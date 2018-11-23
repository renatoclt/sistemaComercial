using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Clases;
using Shalong.Conexion;

namespace Shalong.Formularios
{
    public partial class Venta : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        bool _isValido;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Venta()
        {
            InitializeComponent();
        }

        public Venta(I_Parametros parametros)
        {
            InitializeComponent();
            CargarDataGridViewProductos();
            CargarComboBox();
            CargarDataGridView();
            _isValido = true;
            _objetoParametros = new C_Parametros();
            _objetoParametros.CodigoCaja = _objetoParametros.CodigoCaja;
            Atajo();
        }

        public Venta(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _objetoParametros = objetoParametros;
        }


        // VALIDACIONES

        private bool ValidarCantidad()
        {
            double cantidad;
            string codigo_barras;
            double diferencia;
            double conversionValor;
            foreach (DataGridViewRow row in dtg_Factura.Rows)
            {
                if (row.Index != dtg_Factura.RowCount - 1)
                {
                    codigo_barras = row.Cells["Codigo"].Value.ToString();
                    cantidad = Int32.Parse(row.Cells["Cantidad"].Value.ToString());
                    C_Producto objetoProducto = _shalong.ProductoMostrar1(codigo_barras);
                    conversionValor = _shalong.UnidadesEquivalencia(objetoProducto.CodigoUnidad, Int32.Parse(row.Cells["Unidad"].Value.ToString()));
                    cantidad = cantidad * conversionValor;
                    if (cantidad == 0)
                    {
                        MessageBox.Show("El producto " + objetoProducto.Nombre + " no se puede vender en esa unidad o agrege la equivalencia");
                        return false;
                    }
                    diferencia = _shalong.VerificarCantidad(codigo_barras, _objetoParametros.CodigoAlmacen, cantidad);
                    if (diferencia < 0)
                    {
                        string unidad = Convert.ToString((row.Cells["Unidad"] as DataGridViewComboBoxCell).FormattedValue.ToString());
                        if (MessageBox.Show("El producto " + objetoProducto.Nombre + " no tiene suficiente stock para realizar esta venta ¿Desea cambiar la cantidad?\n le falta " + Math.Abs(diferencia / conversionValor) + "  " + unidad, "Gestion Ventas",
                        MessageBoxButtons.YesNo) == DialogResult.No)
                        {
                            return false;
                        }
                        else
                        {
                            Productos_Almacen objeto = new Productos_Almacen(_objetoParametros, Int32.Parse(row.Cells["Nombre"].Value.ToString()));
                            objeto.ShowDialog();
                            return false;
                        }
                        ;

                    }
                }
            }

            return true;
        }
        private bool Validar()
        {
            if (Cmb_I_TipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleecione un tipo de documento");
                return false;
            }
            if (Cmb_I_Cliente.SelectedIndex == -1 && Cmb_I_Empresa.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cliente o una empresa");
                return false;
            }
            if (Txt_I_NDocumento.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un numero de documento");
                return false;
            }
            if (dtg_Factura.Rows.Count < 2)
            {
                MessageBox.Show("Ingrese un producto");
                return false;
            }
            return true;
        }
        private void ComprobarGarantia()
        {
            bool isCellChecked;
            foreach (DataGridViewRow row in dtg_Factura.Rows)
            {
                try
                {
                    isCellChecked = (bool)row.Cells["GarantiaCheck"].Value;
                }
                catch (Exception)
                {
                    isCellChecked = false;
                }
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["GarantiaCheck"];
                if (isCellChecked)
                {
                    C_Venta objetoVenta = new C_Venta();
                    objetoVenta.NumeroDocumentoVenta = Txt_I_NDocumento.Text;
                    int codigoVenta = _shalong.VentasCodigo(objetoVenta);
                    string garantia;
                    if (row.Cells["Garantia"].Value != null)
                    {
                        garantia = row.Cells["Garantia"].Value.ToString();
                    }
                    else
                    {
                        garantia = "Garantia Vacia";
                    }
                    Serial_Producto obj = new Serial_Producto(Int32.Parse(row.Cells["Codigo"].Value.ToString()), codigoVenta, garantia);
                    obj.ShowDialog();
                }
            }
        }

        //CALCULOS

        private void TotalVenta()
        {
            SubTotal();
            double total;
            double igv;
            double subTotal;
            subTotal = Double.Parse(Txt_SubTotal.Text);
            igv = Double.Parse(Txt_IGV.Text);
            total = subTotal + igv;
            Txt_Total.Text = String.Format("{0:0.00}", total);
            CalcularDevolucion();
        }
        private void SubTotal()
        {
            double subTotal = 0;
            double igv;
            foreach (DataGridViewRow row in dtg_Factura.Rows)
            {
                if (dtg_Factura.Rows[row.Index].Cells["PrecioTotalSinRedondear"].Value != null)
                    subTotal += Double.Parse(dtg_Factura.Rows[row.Index].Cells["PrecioTotalSinRedondear"].Value.ToString());
            }
            Txt_SubTotal.Text = String.Format("{0:0.00}", subTotal);
            if (chk_Igv.Checked)
            {
                igv = subTotal * 0.18;
                Txt_IGV.Text = String.Format("{0:0.00}", igv);
            }
            else
            {
                Txt_IGV.Text = "0.00";
            }
        }
        private void ActualizarTipoPrecio()
        {
            foreach (DataGridViewRow row in dtg_Factura.Rows)
            {
                row.Cells["Tipo_Precio"].Value = Cmb_TipoPrecio.SelectedValue;
            }
        }
        private void CalcularDevolucion()
        {
            double total;
            double cantidad;
            double devolucion;
            if (!chk_VariosPagos.Checked)
            {
                if (Txt_Total.Text != String.Empty && Txt_Cantidad.Text != String.Empty)
                {
                    total = Double.Parse(Txt_Total.Text);
                    try
                    {
                        cantidad = Double.Parse(Txt_Cantidad.Text);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("El Número de Cantidad no es Válido, Revise La Cantidad Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Txt_Cantidad.Clear();
                        Txt_SubTotal.Clear();
                        Txt_IGV.Clear();
                        Txt_Total.Clear();
                        return;
                        //cantidad = double.Parse(Txt_Cantidad.Text);
                    }
                    devolucion = cantidad - total;
                    if (devolucion > 0)
                        Txt_Devolucion.Text = String.Format("{0:0.00}", devolucion);
                    else
                        Txt_Devolucion.Clear();

                }
            }
            else
            {
                try
                {
                    total = Double.Parse(Txt_Total.Text);
                }
                catch (Exception)
                {
                    total = 0;
                }
                cantidad = 0;
                foreach (DataGridViewRow row in dgv_TipoPago.Rows)
                {
                    if (row.Cells["CantidadPago"].Value != null)
                    {
                        try
                        {
                            cantidad += Double.Parse(row.Cells["CantidadPago"].Value.ToString());
                        }
                        catch (Exception e)
                        {
                            row.Cells["CantidadPago"].Value = 0;
                        }
                    }
                }
                Txt_Devolucion.Text = String.Format("{0:0.00}", cantidad);

            }
        }
        
       // GUARDAR

        private void GuardarVenta()
        {
            if (!Validar())
            {
                return;
            }
            else
            {
                C_Venta objetoVenta = new C_Venta();
                try
                {
                    objetoVenta.TotalVenta = Double.Parse(Txt_Total.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al mostrar el total de la venta", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int[] totalPago = new int[dgv_TipoPago.RowCount];
                int[] tipoPago = new int[dgv_TipoPago.RowCount];
                objetoVenta.CodigoTipoDocumento = Int32.Parse(Cmb_I_TipoDocumento.SelectedValue.ToString());
                objetoVenta.Codigo = 1;
                objetoVenta.CodigoCaja = _objetoParametros.CodigoCaja;
                if (Cmb_I_Cliente.SelectedValue == null)
                {
                    objetoVenta.CodigoCliente = -1;
                }
                else
                {
                    objetoVenta.CodigoCliente = Int32.Parse(Cmb_I_Cliente.SelectedValue.ToString());
                }
                objetoVenta.NumeroDocumentoVenta = Txt_I_NDocumento.Text;
                if (Cmb_I_Empresa.SelectedValue == null)
                {
                    objetoVenta.CodigoEmpresa = -1;
                }
                else
                {
                    objetoVenta.CodigoEmpresa = Int32.Parse(Cmb_I_Empresa.SelectedValue.ToString());
                }

                if (chk_VariosPagos.Checked)
                {
                    if (Txt_Devolucion.Text != Txt_Total.Text)
                    {
                        MessageBox.Show("El pago no es igual al total de la venta", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    bool validar = false;
                    foreach (DataGridViewRow row in dgv_TipoPago.Rows)
                    {
                        if (row.Index != dgv_TipoPago.RowCount - 1)
                        {
                            try
                            {
                                tipoPago[row.Index] = Int32.Parse(row.Cells["CodigoTipoPago"].Value.ToString());
                                objetoVenta.CodigoTipoPago = Int32.Parse(row.Cells["CodigoTipoPago"].Value.ToString());
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Seleccione un tipo de pago en la fila" + (row.Index + 1), "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            try
                            {
                                totalPago[row.Index] = Int32.Parse(row.Cells["CantidadPago"].Value.ToString());
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show("Ingrese un monto en la fila" + (row.Index + 1)  ,"Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }

                        }
                    }
                    for (int i = 0; i < totalPago.Length - 1; i++)
                    {
                        objetoVenta.CodigoTipoPago = tipoPago[i];
                        if (objetoVenta.CodigoTipoPago == 10)
                        {
                            int cliente = -1;
                            string empresa = "-1";
                            if (Cmb_I_Cliente.SelectedIndex != -1)
                            {
                                cliente = Int32.Parse(Cmb_I_Cliente.SelectedValue.ToString());
                            }
                            if (Cmb_I_Empresa.SelectedIndex != -1)
                            {
                                empresa = Cmb_I_Empresa.SelectedValue.ToString();
                            }
                            int codigoVenta = _shalong.VentasCodigo(objetoVenta);
                            Credito objeto = new Credito(objetoVenta.NumeroDocumentoVenta, Double.Parse(Txt_Total.Text), cliente, empresa, codigoVenta, _objetoParametros.CodigoCaja);
                            objeto.ShowDialog();
                        }
                        objetoVenta.TotalVenta = totalPago[i];
                        if (_shalong.Ventas(1, objetoVenta))
                        {
                            validar = true;
                            //MessageBox.Show("Ingreso Correctamente la Venta");
                        }
                        else
                        {
                            MessageBox.Show("Error Ingrese los Datos Correctamente de la cabezera", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (validar)
                    {
                        GuardarVentaDetalle();

                    }
                }
                else
                {

                    objetoVenta.CodigoTipoPago = Int32.Parse(Cmb_TipoPago.SelectedValue.ToString());
                    if (_shalong.Ventas(1, objetoVenta))
                    {
                        //MessageBox.Show("Ingreso Correctamente la Venta");
                        GuardarVentaDetalle();
                        if (objetoVenta.CodigoTipoPago == 10)
                        {
                            int cliente = -1;
                            string empresa = "-1";
                            if (Cmb_I_Cliente.SelectedIndex != -1)
                            {
                                cliente = Int32.Parse(Cmb_I_Cliente.SelectedValue.ToString());
                            }
                            if (Cmb_I_Empresa.SelectedIndex != -1)
                            {
                                empresa = Cmb_I_Empresa.SelectedValue.ToString();
                            }
                            int codigoVenta = _shalong.VentasCodigo(objetoVenta);
                            Credito objeto = new Credito(objetoVenta.NumeroDocumentoVenta, Double.Parse(Txt_Total.Text), cliente, empresa, codigoVenta, _objetoParametros.CodigoCaja);
                            objeto.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("error Ingrese los Datos Correctamente", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private bool GuardarVentaDetalle()
        {
            bool bandera = true;
            C_VentaDetalle objetoVentaDetalle = new C_VentaDetalle();
            C_Venta objetoVenta = new C_Venta();
            //objetoVenta.CodigoCaja = _codigoCaja;
            objetoVenta.NumeroDocumentoVenta = Txt_I_NDocumento.Text;
            objetoVentaDetalle.CodigoVenta = _shalong.VentasCodigo(objetoVenta);
            foreach (DataGridViewRow row in dtg_Factura.Rows)
            {
                if (row.Cells["Codigo"].Value != null)
                {
                    objetoVentaDetalle.CodigoBarras = Int32.Parse(row.Cells["Codigo"].Value.ToString());
                    objetoVentaDetalle.Cantidad = Double.Parse(row.Cells["Cantidad"].Value.ToString());
                    objetoVentaDetalle.CodigoTipoPrecio = Int32.Parse(row.Cells["Tipo_Precio"].Value.ToString());
                    objetoVentaDetalle.Precio = Double.Parse(row.Cells["Precio"].Value.ToString());
                    objetoVentaDetalle.PrecioTotal = Double.Parse(row.Cells["Precio_Total"].Value.ToString());
                    objetoVentaDetalle.Descuento = Double.Parse(row.Cells["Descuento"].Value.ToString());
                    objetoVentaDetalle.Garantia = row.Cells["Garantia"].Value.ToString();
                    if (!_shalong.VentaDetalle(1, objetoVentaDetalle))
                    {
                        MessageBox.Show("Ingreso Incorrectamente los Productos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        bandera = false;
                    }
                }
            }
            if (bandera)
            {
                MessageBox.Show("Venta  Ingresada correctamente", "Gestion Ventas", MessageBoxButtons.OK);

            }
            return true;
        }

        //LIMPIAR

        private void Limpiar()
        {
            Cmb_I_Cliente.SelectedIndex = -1;
            Cmb_I_Empresa.SelectedIndex = -1;
            Cmb_TipoPago.SelectedIndex = -1;
            Cmb_I_TipoDocumento.SelectedIndex = -1;
            Txt_I_NDocumento.Text = "";
            dtg_Factura.Rows.Clear();
            dgv_TipoPago.Rows.Clear();
            Txt_Cantidad.Text = "";
            Txt_Devolucion.Text = "";
        }

        // CARGAR

        private void CargarDataGridViewTipoPago()
        {
            DataGridViewComboBoxColumn columnTipoPago = dgv_TipoPago.Columns["TipoDePago"] as DataGridViewComboBoxColumn;
            columnTipoPago.DisplayMember = "Nombre";
            columnTipoPago.ValueMember = "Codigo";
            columnTipoPago.DataSource = _shalong.TipoPagoMostrar();
        }
        private void CargarDataGridView()
        {
            CargarDataGridViewProductos();
            CargarDataGridViewTipoPago();
        }
        private void CargarComboBox()
        {
            CargarComboBoxTipoDocumento();
            CargarComboBoxCliente();
            CargarComboBoxEmpresa();
            CargarComboBoxTipoPrecio();
            CargarComboBoxTipoPago();
        }
        private void CargarComboBoxTipoPago()
        {
            Cmb_TipoPago.DisplayMember = "Nombre";
            Cmb_TipoPago.ValueMember = "Codigo";
            Cmb_TipoPago.DataSource = _shalong.TipoPagoMostrar();
            //Cmb_TipoPago.AutoCompleteCustomSource = DataHelper.LoadAutoComplete();   
        }
        private void CargarComboBoxCliente()
        {
            Cmb_I_Cliente.DisplayMember = "Nombre";
            Cmb_I_Cliente.ValueMember = "Codigo";
            Cmb_I_Cliente.DataSource = _shalong.ClienteMostrar();
            Cmb_I_Cliente.SelectedIndex = -1;
        }
        private void CargarComboBoxEmpresa()
        {
            Cmb_I_Empresa.DisplayMember = "Nombre";
            Cmb_I_Empresa.ValueMember = "Codigo";
            Cmb_I_Empresa.DataSource = _shalong.EmpresaMostrar();
            Cmb_I_Empresa.SelectedIndex = -1;
        }
        private void CargarComboBoxTipoPrecio()
        {
            Cmb_TipoPrecio.DisplayMember = "Nombre";
            Cmb_TipoPrecio.ValueMember = "Codigo";
            Cmb_TipoPrecio.DataSource = _shalong.TipoPrecioMostrar();
            //Cmb_TipoPrecio.SelectedIndex = -1;

        }
        private void CargarComboBoxTipoDocumento()
        {
            Cmb_I_TipoDocumento.DisplayMember = "Nombre";
            Cmb_I_TipoDocumento.ValueMember = "Codigo";
            Cmb_I_TipoDocumento.DataSource = _shalong.TipoDocumentoMostrar();
            Cmb_I_TipoDocumento.SelectedIndex = -1;

        }
        private void CargarDataGridViewProductos()
        {
            DataGridViewComboBoxColumn columnTipoPrecio = dtg_Factura.Columns["Tipo_Precio"] as DataGridViewComboBoxColumn;
            columnTipoPrecio.DisplayMember = "Nombre";
            columnTipoPrecio.ValueMember = "Codigo";
            columnTipoPrecio.DataSource = _shalong.TipoPrecioMostrar();
            DataGridViewComboBoxColumn columnProducto = dtg_Factura.Columns["Nombre"] as DataGridViewComboBoxColumn;
            columnProducto.DisplayMember = "Nombre";
            columnProducto.ValueMember = "CodigoBarras";
            columnProducto.DataSource = _shalong.ProductoMostrar();
            DataGridViewComboBoxColumn columnUnidad = dtg_Factura.Columns["Unidad"] as DataGridViewComboBoxColumn;
            columnUnidad.DisplayMember = "Nombre";
            columnUnidad.ValueMember = "Codigo";
            columnUnidad.DataSource = _shalong.UnidadMostrar();
            DataGridViewComboBoxColumn columnDescuento = dtg_Factura.Columns["Descuento"] as DataGridViewComboBoxColumn;
            columnDescuento.DisplayMember = "Nombre";
            columnDescuento.ValueMember = "Valor";
            columnDescuento.DataSource = _shalong.DescuentoMostrar();
        }

        // DATA GRIDVIEW

        private void Dtg_FacturaPrecioTotal(int rowActual)
        {
            double cantidad;
            if (dtg_Factura.Rows[rowActual].Cells["PrecioSinRedondear"].Value != null && dtg_Factura.Rows[rowActual].Cells["Cantidad"].Value != null)
            {
                try
                {
                    cantidad = Double.Parse(dtg_Factura.Rows[rowActual].Cells["Cantidad"].Value.ToString());
                }
                catch (Exception)
                {
                    cantidad = 0;
                    dtg_Factura.Rows[rowActual].Cells["Cantidad"].Value = 0;
                }
                double precioSinRedondear = Double.Parse(dtg_Factura.Rows[rowActual].Cells["PrecioSinRedondear"].Value.ToString());
                double total = cantidad * precioSinRedondear;
                dtg_Factura.Rows[rowActual].Cells["PrecioTotalSinRedondear"].Value = total;
                dtg_Factura.Rows[rowActual].Cells["Precio_Total"].Value = String.Format("{0:0.00}", total);
                TotalVenta();
            }
        }
        private void Dtg_FacturaCodigo(int rowActual)
        {
            if (Cmb_TipoPrecio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Precio Valido Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtg_Factura.Rows.Clear();
                CargarComboBoxTipoPago();
                return;
            }
            else
            {
                string codigoFilaActual;
                try
                {
                    codigoFilaActual = dtg_Factura.Rows[rowActual].Cells["Codigo"].Value.ToString();
                }
                catch (Exception)
                {
                    codigoFilaActual = "0";
                }
                if (_shalong.ProductoExistente(codigoFilaActual))
                {
                    dtg_Factura.Rows[rowActual].Cells["Nombre"].Value = codigoFilaActual;
                    Dtg_FacturaCantidad(rowActual);
                    Dtg_FacturaMostrarProducto(rowActual);
                    Dtg_FacturaPrecioTotal(rowActual);
                }
                else
                {
                    dtg_Factura.Rows.RemoveAt(rowActual);
                }
            }

        }
        private void Dtg_FacturaNombre(int rowActual)
        {
            if (Cmb_TipoPrecio.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Precio Valido Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtg_Factura.Rows.Clear();
                CargarComboBoxTipoPago();
                return;
            }
            else
            {

                dtg_Factura.Rows[rowActual].Cells["Codigo"].Value = dtg_Factura.Rows[rowActual].Cells["Nombre"].Value;
                Dtg_FacturaCantidad(rowActual);
                Dtg_FacturaMostrarProducto(rowActual);
                dtg_Factura.Rows[rowActual].Cells["Descuento"].Value = 0;
                Dtg_FacturaPrecioTotal(rowActual);
            }
        }
        private void Dtg_FacturaCantidad(int rowActual)
        {
            if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value == null)
            {
                dtg_Factura.Rows.RemoveAt(rowActual);
                return;
            }
            if (dtg_Factura.Rows[rowActual].Cells["Cantidad"].Value == null)
            {
                dtg_Factura.Rows[rowActual].Cells["Cantidad"].Value = 1;
            }
            foreach (DataGridViewRow row in dtg_Factura.Rows)
            {
                if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value != null && row.Cells["Codigo"].Value != null)
                {
                    if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value.ToString() == row.Cells["Codigo"].Value.ToString() && rowActual != row.Index)
                    {
                        try
                        {
                            dtg_Factura.Rows[row.Index].Cells["Cantidad"].Value = Int32.Parse(dtg_Factura.Rows[row.Index].Cells["Cantidad"].Value.ToString()) + 1;
                        }
                        catch (Exception)
                        {
                            dtg_Factura.Rows[row.Index].Cells["Cantidad"].Value = 0;
                        }
                        dtg_Factura.Rows.RemoveAt(rowActual);

                    }
                    Dtg_FacturaPrecioTotal(row.Index);
                }
            }
        }
        private void Dtg_FacturaValidarCodigoVacio(int rowActual)
        {
            if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value == null)
            {
                if (dtg_Factura.RowCount - 1 != rowActual)
                    dtg_Factura.Rows.RemoveAt(rowActual);
                return;
            }
            Dtg_FacturaPrecio(rowActual);
        }
        private void Dtg_FacturaUnidad(int rowActual)
        {
            if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value == null)
            {
                if (dtg_Factura.RowCount - 1 != rowActual)
                    dtg_Factura.Rows.RemoveAt(rowActual);
                return;
            }
            Dtg_FacturaPrecio(rowActual);
        }
        private void Dtg_FacturaPrecio(int rowActual)
        {
            if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value != null && dtg_Factura.Rows[rowActual].Cells["Descuento"].Value != null)
            {
                string codigo = dtg_Factura.Rows[rowActual].Cells["Codigo"].Value.ToString();
                C_Producto objetoProducto = _shalong.ProductoMostrar1(codigo);

                int tipoPrecio = Int32.Parse(dtg_Factura.Rows[rowActual].Cells["Tipo_Precio"].Value.ToString());
                double precio = _shalong.ProductoPrecioValor(tipoPrecio, codigo);
                if (objetoProducto.CodigoUnidad != Int32.Parse(dtg_Factura.Rows[rowActual].Cells["Unidad"].Value.ToString()))
                {
                    double unidad = _shalong.UnidadesEquivalencia(objetoProducto.CodigoUnidad, Int32.Parse(dtg_Factura.Rows[rowActual].Cells["Unidad"].Value.ToString()));
                    if (unidad == 0)
                    {
                        MessageBox.Show("El producto " + objetoProducto.Nombre + " no se puede vender en esa unidad o agrege la equivalencia");
                    }
                    precio = precio * unidad;
                }
                int descuento = Int32.Parse(dtg_Factura.Rows[rowActual].Cells["Descuento"].Value.ToString());
                precio = precio - ((descuento * precio) / 100);
                if (chk_Igv.Checked)
                {
                    precio = precio / 1.18;
                }
                dtg_Factura.Rows[rowActual].Cells["PrecioSinRedondear"].Value = precio;
                dtg_Factura.Rows[rowActual].Cells["Precio"].Value = String.Format("{0:0.00}", precio);
                Dtg_FacturaPrecioTotal(rowActual);
            }
        }
        private void Dtg_FacturaMostrarProducto(int rowActual)
        {
            if (Cmb_TipoPrecio.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Precio Valido Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtg_Factura.Rows.Clear();
                CargarComboBoxTipoPago();
                return;
            }
            else
            {
                if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value != null)
                {

                    double precio;
                    string codigo = dtg_Factura.Rows[rowActual].Cells["Codigo"].Value.ToString();
                    C_Producto objetoProducto = _shalong.ProductoMostrar1(codigo);

                    int tipoPrecio = Int32.Parse(Cmb_TipoPrecio.SelectedValue.ToString());
                    dtg_Factura.Rows[rowActual].Cells["Garantia"].Value = objetoProducto.TiempoGarantia;
                    dtg_Factura.Rows[rowActual].Cells["Descuento"].Value = 0;
                    dtg_Factura.Rows[rowActual].Cells["Tipo_Precio"].Value = tipoPrecio;
                    dtg_Factura.Rows[rowActual].Cells["Unidad"].Value = objetoProducto.CodigoUnidad;
                    precio = _shalong.ProductoPrecioValor(tipoPrecio, codigo);
                    if (chk_Igv.Checked)
                    {
                        precio = precio / 1.18;
                    }
                    dtg_Factura.Rows[rowActual].Cells["PrecioSinRedondear"].Value = precio;
                    dtg_Factura.Rows[rowActual].Cells["Precio"].Value = String.Format("{0:0.00}", precio);

                }
            }
        }
        private void Dtg_TipoPagoNombre(int rowActual)
        {
            dgv_TipoPago.Rows[rowActual].Cells["CodigoTipoPago"].Value = dgv_TipoPago.Rows[rowActual].Cells["TipoDePago"].Value;
        }

        //EVENTOS

        private void Btn_I_Cliente_Click(object sender, EventArgs e)
        {
            Cliente objeto = new Cliente();
            objeto.ShowDialog();
        }
        private void Btn_I_Empresa_Click(object sender, EventArgs e)
        {
            Empresa objeto = new Empresa();
            objeto.ShowDialog();

        }
        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se Permiten Números y Puntos");
                e.Handled = true;
                return;
            }
        }
        private void Txt_Cantidad_TextChanged_1(object sender, EventArgs e)
        {
            int rowActual;
            rowActual = 0;
            if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value != null)
            {
                CalcularDevolucion();
            }
            else
            {
                //MessageBox.Show("Ingrese un Producto Antes de Ingresar una Cantidad de Ingreso");
                Txt_Cantidad.Clear();
                return;
            }
        }
        private void Cmb_I_TipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cmb_I_TipoDocumento.SelectedIndex != -1)
            {
                if (Int32.Parse(Cmb_I_TipoDocumento.SelectedValue.ToString()) == 3)
                {
                    chk_Igv.Enabled = false;
                    chk_Igv.Checked = false;
                }
                if (Int32.Parse(Cmb_I_TipoDocumento.SelectedValue.ToString()) == 5)
                {
                    chk_Igv.Enabled = false;
                    chk_Igv.Checked = false;
                }
                if (Int32.Parse(Cmb_I_TipoDocumento.SelectedValue.ToString()) == 4)
                {
                    chk_Igv.Enabled = true;
                    chk_Igv.Checked = true;
                              
                }
            }
            else
            {
                chk_Igv.Enabled = false;
            }
            

        }
        private void Cmb_TipoPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Cmb_TipoPago.SelectedIndex != -1)
            {
                if (Int32.Parse(Cmb_TipoPago.SelectedValue.ToString()) == 1)
                {
                    Txt_Cantidad.Enabled = true;
                    Txt_Cantidad.Clear();
                    Txt_Devolucion.Text = "0.0";

                }
                else
                {
                    Txt_Cantidad.Enabled = false;
                    Txt_Cantidad.Clear();
                    Txt_Devolucion.Text = "0.0";
                    Txt_Cantidad.Text = Txt_Total.Text;
                }
            }

        }
        private void Txt_Total_TextChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(Cmb_TipoPago.SelectedValue.ToString()) == 1)
            {
            }
            else
            {
                Txt_Cantidad.Enabled = false;
                Txt_Cantidad.Text = Txt_Total.Text;
                Txt_Devolucion.Text = "0.0";
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
        private void Venta_Load(object sender, EventArgs e)
        {

        }
        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularDevolucion();
        }
        private void Cmb_I_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_I_Cliente.SelectedIndex == -1)
            {
                Txt_P_Nombre.Clear();
            }

            if (Cmb_I_Cliente.SelectedIndex != -1)
            {
                Cmb_I_Empresa.SelectedIndex = -1;
                C_Cliente obj = _shalong.ClienteMostrar1(Int32.Parse(Cmb_I_Cliente.SelectedValue.ToString()));
                Txt_P_Nombre.Text = " " + obj.Nombre + "  " + "" + obj.Apellido_paterno + "  " + "" + obj.Apellido_materno;
                Txt_P_Telefono.Enabled = false;
                Txt_P_Direccion.Enabled = false;
            }
        }
        private void dtg_TipoPago_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int fila = e.RowIndex;
            if (fila > -1 && _isValido)
            {
                switch (column)
                {
                    case 1:
                        Dtg_TipoPagoNombre(fila);
                        break;
                    case 2:
                        CalcularDevolucion();
                        break;

                }
            }
        }
        private void dtg_Factura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int fila = e.RowIndex;
            if (fila > -1 && _isValido)
            {
                _isValido = false;
                switch (column)
                {
                    case 0:
                        Dtg_FacturaCodigo(fila);
                        break;
                    case 1:
                        Dtg_FacturaNombre(fila);
                        break;
                    case 2:
                        Dtg_FacturaCantidad(fila);
                        break;
                    case 3:
                        Dtg_FacturaUnidad(fila);
                        break;
                    case 4:
                        Dtg_FacturaValidarCodigoVacio(fila);
                        break;
                    case 9:
                        Dtg_FacturaValidarCodigoVacio(fila);
                        break;
                    case 10:
                        Dtg_FacturaValidarCodigoVacio(fila);
                        break;
                    case 11:
                        Dtg_FacturaValidarCodigoVacio(fila);
                        break;
                }
                _isValido = true;
            }
            /*
            Dtg_FacturaMostrarProducto(fila);*/
        }
        private void Cmb_I_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_I_Empresa.SelectedIndex == -1)
            {
                Txt_P_Nombre.Clear();
                Txt_P_Direccion.Clear();
                Txt_P_Telefono.Clear();
            }
            if (Cmb_I_Empresa.SelectedIndex != -1)
            {
                Cmb_I_Cliente.SelectedIndex = -1;
                C_Empresa obj = _shalong.EmpresaMostrar1(Int32.Parse(Cmb_I_Empresa.SelectedValue.ToString()));
                Txt_P_Nombre.Text = "" + obj.Nombre;
                Txt_P_Direccion.Text = "" + obj.Direccion;
                Txt_P_Telefono.Text = "" + obj.Telefono;
                Txt_P_Direccion.Enabled = true;
                Txt_P_Telefono.Enabled = true;
            }
        }
        private void chk_VariosPagos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_VariosPagos.Checked)
            {
                Cmb_TipoPago.Visible = false;
                lbl_TipoPago.Visible = false;
                Txt_Cantidad.Visible = false;
                lbl_Cantidad.Visible = false;
                dgv_TipoPago.Visible = true;
                lbl_TotalDevolucion.Text = "Total";
            }
            else
            {
                Txt_Cantidad.Visible = true;
                lbl_Cantidad.Visible = true;
                Cmb_TipoPago.Visible = true;
                lbl_TipoPago.Visible = true;
                dgv_TipoPago.Visible = false;
                lbl_TotalDevolucion.Text = "Devolucion";
            }
        }
        private void Cmb_TipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarTipoPrecio();
        }
        private void chk_Igv_CheckedChanged(object sender, EventArgs e)
        {
            if (dtg_Factura.Rows.Count == 1)
            {
                chk_Igv.Checked = true;
                return;
            }
            if (Cmb_I_TipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Documento", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                int rowActual;
                rowActual = 0;
                if (dtg_Factura.Rows[rowActual].Cells["Codigo"].Value != null)
                {
                    foreach (DataGridViewRow row in dtg_Factura.Rows)
                    {
                        Dtg_FacturaPrecio(row.Index);
                        Dtg_FacturaPrecioTotal(row.Index);
                    }
                    TotalVenta();
                }
                else
                {
                    MessageBox.Show("Ingrese un Producto Antes de Seleccionar un IGV", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

        }
        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            Aceptar();
        }
        private void Aceptar()
        {
            if (ValidarCantidad())
            {
                GuardarVenta();
                if (!Validar())
                {
                    return;
                }
                else
                {
                    ComprobarGarantia();
                    Limpiar();
                }
            }
        }
        public void Atajo()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(this.CrearModificar_KeyDown);
        }

        private void CrearModificar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.B)
            {
                AbrirBusqueda();
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                Aceptar();
            }
        }
        private void AbrirBusqueda()
        {
            ProductoBusqueda obj = new ProductoBusqueda();
            obj.ShowDialog();
            if (obj.CodigoNuevo != string.Empty)
            {
                int cont = dtg_Factura.Rows.Count - 1;
                dtg_Factura.Rows.Add();
                dtg_Factura.Rows[cont].Cells[0].Value = obj.CodigoNuevo;
            }
        }
    }
}
