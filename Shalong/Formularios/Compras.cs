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
    public partial class Compras : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoTipoCambio;
        int _codigoUsuario;
        int _codigoCaja;
        int _codigoAlmacen;
        bool isvalido;
        public Compras(I_Parametros parametros)
        {
            InitializeComponent();
            _codigoTipoCambio = 1;
            CargarComboBox();
            CargarValorDolar();
            CargarDataGridViewProductos();
            CargarDataGridViewUnidad();
            isvalido = true;
        }
        public Compras(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _codigoUsuario = objetoParametros.CodigoUsuario;
            _codigoCaja = objetoParametros.CodigoCaja;
            _codigoAlmacen = objetoParametros.CodigoAlmacen;
        }

        //FUNCIONES

        private void LimpiarCompras()
        {
            txt_I_NroDocumento.Clear();
            dtp_I_Fecha.ResetText();
            cmb_I_TipoDocumento.SelectedIndex = -1;
            chk_Credito.Checked = false;
            cmb_I_TipoMoneda.SelectedIndex = -1;
            txt_I_Total.Clear();
            CargarValorDolar();

            //cmb_I_Proveedor.SelectedIndex = -1;
        }

        private void CargarValorDolar()
        {
            _codigoTipoCambio = _shalong.TipoCambioCodigo();
            txt_I_TipoCambio.Text = "" + _shalong.TipoCambioDiario();

        }

        //CARGAR DATAGRIDVIEW
        private void CargarDataGridViewProductos()
        {
            DataGridViewComboBoxColumn columnSGProducto = dtg_SG_Compras.Columns["Nombre"] as DataGridViewComboBoxColumn;
            columnSGProducto.DisplayMember = "Nombre";
            columnSGProducto.ValueMember = "CodigoBarras";
            columnSGProducto.DataSource = _shalong.ProductoMostrar();
            DataGridViewComboBoxColumn columnCGProducto = dtg_CG_Compras.Columns["Cg_Nombre"] as DataGridViewComboBoxColumn;
            columnCGProducto.DisplayMember = "Nombre";
            columnCGProducto.ValueMember = "CodigoBarras";
            columnCGProducto.DataSource = _shalong.ProductoMostrar();

        }
        private void CargarDataGridViewUnidad()
        {
            DataGridViewComboBoxColumn columnSGUnidad = dtg_SG_Compras.Columns["Unidad"] as DataGridViewComboBoxColumn;
            columnSGUnidad.DisplayMember = "Nombre";
            columnSGUnidad.ValueMember = "Codigo";
            columnSGUnidad.DataSource = _shalong.UnidadMostrar();
        }


        //CARGAR COMBO BOX

        private void CargarComboBoxDocumento()
        {
            cmb_M_NroDocumento.ValueMember = "Codigo";
            cmb_M_NroDocumento.DisplayMember = "NumeroDocumento";
            cmb_M_NroDocumento.DataSource = _shalong.DocumentoPorFecha(dateTimePicker2.Value);
        }
        private void CargarComboBoxMoneda()
        {
            cmb_I_TipoMoneda.ValueMember = "Nombre";
            cmb_I_TipoMoneda.ValueMember = "Codigo";
            cmb_I_TipoMoneda.DataSource = _shalong.MonedaMostrar();
        }
        private void CargarComboBoxTipoDocumento()
        {
            cmb_I_TipoDocumento.ValueMember = "Codigo";
            cmb_I_TipoDocumento.DisplayMember = "Nombre";
            cmb_I_TipoDocumento.DataSource = _shalong.TipoDocumentoMostrar();
        }
        private void CargarComboBoxProveedor()
        {
            cmb_M_NroDocumento.ValueMember = "Codigo";
            cmb_M_NroDocumento.DisplayMember = "NumeroDocumento";
            cmb_M_NroDocumento.DataSource = _shalong.DocumentoPorFecha(dateTimePicker2.Value);

            cmb_I_Proveedor.ValueMember = "Codigo";
            cmb_I_Proveedor.DisplayMember = "RUC";
            cmb_I_Proveedor.DataSource = _shalong.ProveedorMostrar();
        }
        private void CargarComboboxOrdendeCompra()
        {
            cmb_Documentos.ValueMember = "Codigo";
            cmb_Documentos.DisplayMember = "NumeroDocumento";
            cmb_Documentos.DataSource = _shalong.OrdenCompraDocumento();
        }
        private void CargarComboBox()
        {
            CargarComboBoxTipoDocumento();
            CargarComboBoxProveedor();
            CargarComboBoxMoneda();
            CargarComboboxOrdendeCompra();
        }

        //BOTONES

        // GUARDA EN CREDITO COMO COMPRA
        private void GuardarCreditoCompra()
        {
            C_Credito objetoCredito = new C_Credito();
            // Datos para SumaFecha
            if (cmb_I_Proveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Proveedor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                objetoCredito.CodigoProveedor = Int32.Parse(cmb_I_Proveedor.SelectedValue.ToString());
            }
            objetoCredito.Fecha = dtp_I_Fecha.Value;
            // ----------
            // Datos para CompraCodigo
            C_Compra objetoCompra = new C_Compra();
            if (txt_I_NroDocumento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Nro de Documento", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoCompra.NumeroDocumento = txt_I_NroDocumento.Text;
            }
            objetoCompra.CodigoProveedor = Int32.Parse(cmb_I_Proveedor.SelectedValue.ToString());
            // -------------
            objetoCredito.CodigoCompra = _shalong.CompraCodigo(objetoCompra);
            objetoCredito.CodigoVenta = -1;
            objetoCredito.CodigoTrabajador = -1;
            objetoCredito.FechaProxPago = _shalong.SumaFecha(objetoCredito);
            if (chk_Credito.Checked == true)
            {
                if (txt_I_Total.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un Producto", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    objetoCredito.TotalDeuda = double.Parse(txt_I_Total.Text);
                    objetoCredito.Monto = 0;
                }
            }
            else
            {
                if (txt_I_Total.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un Producto", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    objetoCredito.TotalDeuda = 0.0;
                    objetoCredito.Monto = double.Parse(txt_I_Total.Text);
                }
            }

            if (_codigoCaja == null)
            {
                MessageBox.Show("No se ingreso desde una caja", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoCredito.CodigoCaja = _codigoCaja;
            }
            objetoCredito.CodigoTipoPago = 10;
            if (_shalong.CreditoCompraVenta(1, objetoCredito))
            {

            }
            else
            {
                MessageBox.Show("No se pudo guardar la Compra", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }


        //FUNCION GUARDAR
        private void GuardarOrdenDeCompra()
        {

            C_OrdenCompra objetoOrdenCompra = new C_OrdenCompra();
            objetoOrdenCompra.CodigoDniUsuario = _codigoUsuario;
            objetoOrdenCompra.CodigoProveedor = 0;
            objetoOrdenCompra.ReferenciaOrdenCompra = "";
            objetoOrdenCompra.NumeroDocumento = txt_I_NroDocumento.Text;
            objetoOrdenCompra.Codigo = Int32.Parse(cmb_Documentos.SelectedValue.ToString());
            if (_shalong.OrdenCompra(3, objetoOrdenCompra))
            {
                MessageBox.Show("La orden de compra se cancelo correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboboxOrdendeCompra();
            }
            else
            {
                MessageBox.Show("No se pudo completar la Orden de Compra", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void GuardarCompraCabezera()
        {
            int accion = 1;
            C_Compra objetoCliente = new C_Compra();
            //PROVEEDOR
            if (cmb_I_Proveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Proveedor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoCliente.CodigoProveedor = Int32.Parse(cmb_I_Proveedor.SelectedValue.ToString());
            }
            //TIPO DE CAMBIO
            objetoCliente.CodigoTipoCambio = _codigoTipoCambio;
            // MONEDA
            if (cmb_I_TipoMoneda.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Moneda", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoCliente.CodigoMoneda = Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString());
            }
            // TIPO DE DOCUMENTO
            if (cmb_I_TipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un tipo de documento", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoCliente.CodigoTipoDocumento = Int32.Parse(cmb_I_TipoDocumento.SelectedValue.ToString());
            }
            // FECHA COMPRA
            if (dtp_I_Fecha.Value == null)
            {
                MessageBox.Show("Ingrese una fecha", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                objetoCliente.FechaCompra = dtp_I_Fecha.Value;
            }
            //MONTO TOTAL
            if (txt_I_Total.Text == String.Empty)
            {
                MessageBox.Show("No existe un Monto Total de Compra, Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                //objetoCliente.MontoTotal = 0.0;
            }
            else
            {
                if (Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString()) == 2)
                {
                    objetoCliente.MontoTotal = (Double.Parse(txt_I_Total.Text) * Double.Parse(txt_I_TipoCambio.Text));

                }
                else
                {
                    objetoCliente.MontoTotal = Double.Parse(txt_I_Total.Text);

                }
            }
            //NUMERO DE DOCUMENTO
            if (txt_I_NroDocumento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Numero de Documento", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoCliente.NumeroDocumento = txt_I_NroDocumento.Text;
            }
            // SELECCIONAR PESTAÑA MODIFICAR
            if (txt_I_NroDocumento.Text == cmb_M_NroDocumento.Text)
            {
                accion = 2;
                objetoCliente.Codigo = Int32.Parse(cmb_M_NroDocumento.SelectedValue.ToString());
            }
            // INGRESAR COMO CREDITO
            if (_shalong.Compra(accion, objetoCliente))
            {
                if (GuardarAlmacen())
                {
                    if (GuardarCompraSerial(accion))
                    {
                        if (GuardarCompraDetalle(accion))
                        {
                            GuardarCreditoCompra();
                            MessageBox.Show("Se Ingreso la compra correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                            if (accion == 1)
                            {
                                CargarComboBoxDocumento();
                                cmb_M_NroDocumento.SelectedIndex = -1;
                                cmb_M_NroDocumento.ResetText();
                            }
                            if (accion == 2)
                            {

                            }

                        }
                        else
                        {
                            MessageBox.Show("Revisar los Datos del Detalle", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Revisar los Datos del Serial", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No se puedo guardar en Almacen, Revise los Datos Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
        private bool GuardarCompraDetalle(int accion)
        {

            C_Compra objetoCompra = new C_Compra();
            objetoCompra.NumeroDocumento = txt_I_NroDocumento.Text;
            objetoCompra.CodigoProveedor = Int32.Parse(cmb_I_Proveedor.SelectedValue.ToString());
            C_CompraDetalle objetoCompraDetalle = new C_CompraDetalle();
            //objetoCompraDetalle.CodigoCompraDetalle = 1;
            objetoCompraDetalle.CodigoCompra = _shalong.CompraCodigo(objetoCompra);
            objetoCompraDetalle.CodigoProducto = "0";
            objetoCompraDetalle.CostoUnitario = 0.0;
            objetoCompraDetalle.CostoTotal = 0.0;
            objetoCompraDetalle.Cantidad = 0.0;
            objetoCompraDetalle.CodigoUnidad = 1;
            if (accion == 2)
            {
                if (_shalong.CompraDetalle(2, objetoCompraDetalle))
                {
                    foreach (DataGridViewRow row in dtg_SG_Compras.Rows)
                    {
                        if (row.Cells["Codigo"].Value != null)
                        {
                            objetoCompraDetalle.CodigoProducto = row.Cells["Codigo"].Value.ToString();
                            objetoCompraDetalle.CostoUnitario = Double.Parse(row.Cells["Costo_Unitario"].Value.ToString());
                            objetoCompraDetalle.CostoTotal = Double.Parse(row.Cells["Costo_Total"].Value.ToString());
                            objetoCompraDetalle.CodigoUnidad = Int32.Parse(row.Cells["Unidad"].Value.ToString());
                            C_Producto obj = _shalong.ProductoMostrar1(objetoCompraDetalle.CodigoProducto);
                            double valorUnidad = _shalong.UnidadesEquivalencia(obj.CodigoUnidad, Int32.Parse(row.Cells["Unidad"].Value.ToString()));
                            if (valorUnidad == 0.0)
                            {
                                MessageBox.Show("No existe la equivalencia con la Unidad del Producto", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }
                            else
                            {
                                objetoCompraDetalle.Cantidad = Double.Parse(row.Cells["Cantidad"].Value.ToString());
                                objetoCompraDetalle.Cantidad = objetoCompraDetalle.Cantidad * valorUnidad;
                            }

                            if (_shalong.CompraDetalle(1, objetoCompraDetalle))
                            {
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar Detalle de la Compra", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return false;
                            }
                        }
                    }
                }

            }
            else if (accion == 1)
            {
                foreach (DataGridViewRow row in dtg_SG_Compras.Rows)
                {
                    if (row.Cells["Codigo"].Value != null)
                    {
                        objetoCompraDetalle.CodigoProducto = row.Cells["Codigo"].Value.ToString();
                        objetoCompraDetalle.CostoUnitario = Double.Parse(row.Cells["Costo_Unitario"].Value.ToString());
                        objetoCompraDetalle.CostoTotal = Double.Parse(row.Cells["Costo_Total"].Value.ToString());
                        objetoCompraDetalle.Cantidad = Double.Parse(row.Cells["Cantidad"].Value.ToString());
                        objetoCompraDetalle.CodigoUnidad = Int32.Parse(row.Cells["Unidad"].Value.ToString());
                        if (!_shalong.CompraDetalle(1, objetoCompraDetalle))
                        {
                            MessageBox.Show("Error al ingresar el Detalle de la Compra", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return false;
                        }
                    }

                }
            }
            return true;
        }
        private bool GuardarCompraSerial(int accion)
        {
            C_Compra objetoCompra = new C_Compra();
            objetoCompra.NumeroDocumento = txt_I_NroDocumento.Text;
            objetoCompra.CodigoProveedor = Int32.Parse(cmb_I_Proveedor.SelectedValue.ToString());
            C_SerialProducto objetoSerialProducto = new C_SerialProducto();
            objetoSerialProducto.CodigoCompra = _shalong.CompraCodigo(objetoCompra);
            if (accion == 2)
            {
                objetoSerialProducto.CodigoSerie = 0;
                objetoSerialProducto.CodigoBarras = 0;
                if (_shalong.CompraSerial(2, objetoSerialProducto))
                {
                    foreach (DataGridViewRow row in dtg_CG_Compras.Rows)
                    {
                        if (row.Cells["Cg_Codigo"].Value != null && row.Cells["Cg_Serial"].Value != null)
                        {
                            objetoSerialProducto.Serial = row.Cells["Cg_Serial"].Value.ToString();
                            objetoSerialProducto.CodigoBarras = Int32.Parse(row.Cells["Cg_Codigo"].Value.ToString());

                            if (_shalong.CompraSerial(1, objetoSerialProducto))
                            {
                            }
                            else
                            {
                                MessageBox.Show("Error al Guardar el Serial");

                            }

                        }
                    }
                }
            }
            else if (accion == 1)
            {
                foreach (DataGridViewRow row in dtg_CG_Compras.Rows)
                {
                    if (row.Cells["Cg_Codigo"].Value != null && row.Cells["Cg_Serial"].Value != null)
                    {
                        objetoSerialProducto.Serial = row.Cells["Cg_Serial"].Value.ToString();
                        objetoSerialProducto.CodigoBarras = Int32.Parse(row.Cells["Cg_Codigo"].Value.ToString());
                        if (!_shalong.CompraSerial(1, objetoSerialProducto))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private bool GuardarAlmacen()
        {
            int accion;
            string codigoProducto;
            int codigoAlmacen;
            double cantidad;
            foreach (DataGridViewRow row in dtg_SG_Compras.Rows)
            {
                if (row.Index != dtg_SG_Compras.RowCount && row.Cells["Codigo"].Value != null)
                {
                    accion = 1;
                    codigoProducto = row.Cells["Codigo"].Value.ToString();
                    codigoAlmacen = _codigoAlmacen;
                    cantidad = Double.Parse(row.Cells["Cantidad"].Value.ToString());
                    if (!_shalong.AlmacenProducto(accion, codigoAlmacen, codigoProducto, cantidad))
                    {
                        MessageBox.Show("Error al Guardar en Almacen", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            return true;
        }

        //CAMBIAR DE ITEM EN EL COMBOBOX


        // DTG_SG
        private void Dtg_SG_ComprasCodigo(int rowActual)
        {
            if (dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value == null)
            {
                dtg_SG_Compras.Rows.RemoveAt(rowActual);
                return;
            }
            if (dtg_SG_Compras.Rows[rowActual].Cells["Nombre"].Value == null)
            {
                string codigo = dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value.ToString();
                if (MostrarDatosProducto(codigo, rowActual))
                {
                    Dtg_SG_ComprasCantidad(rowActual);
                }
            }
        }
        private void Dtg_SG_ComprasNombre(int rowActual)
        {
            if (dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value == null)
            {
                dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value = dtg_SG_Compras.Rows[rowActual].Cells["Nombre"].Value;
                MostrarDatosProducto(dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value.ToString(), rowActual);
                Dtg_SG_ComprasCantidad(rowActual);
                Dtg_SG_AgregarCosto(rowActual);
            }
        }
        private void Dtg_SG_ComprasCantidad(int rowActual)
        {
            if (dtg_SG_Compras.Rows[rowActual].Cells["Cantidad"].Value == null)
            {
                dtg_SG_Compras.Rows[rowActual].Cells["Cantidad"].Value = 0.0;
            }
            //si el codigo existe borrare la fila y aumentare la cantidad            
            foreach (DataGridViewRow row in dtg_SG_Compras.Rows)
            {
                if (rowActual != row.Index && row.Cells["Codigo"].Value != null && dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value != null)
                {
                    if (row.Cells["Codigo"].Value.ToString() == dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value.ToString())
                    {
                        dtg_SG_Compras.Rows[row.Index].Cells["Cantidad"].Value = "" + (Double.Parse(dtg_SG_Compras.Rows[row.Index].Cells["Cantidad"].Value.ToString()) + 1.0);
                        dtg_SG_Compras.Rows.RemoveAt(rowActual);
                        break;
                    }
                }
                //enviar el puntero a la ultima fila
                dtg_SG_Compras.CurrentCell = dtg_SG_Compras[0, dtg_SG_Compras.RowCount - 1];
            }
        }
        private void Dtg_SG_AgregarCosto(int row)
        {
            if (dtg_SG_Compras.Rows[row].Cells["Costo_Unitario"].Value == null)
            {
                dtg_SG_Compras.Rows[row].Cells["Costo_Unitario"].Value = 0;
            }
            else
            {

            }
            if (dtg_SG_Compras.Rows[row].Cells["Costo_Total"].Value == null)
            {
                dtg_SG_Compras.Rows[row].Cells["Costo_Total"].Value = 0;
            }
        }
        private bool Dtg_SG_ComprasComprobarCodigo(int rowActual)
        {
            if (dtg_SG_Compras.Rows[rowActual].Cells["Codigo"].Value == null)
            {
                if (rowActual < dtg_SG_Compras.Rows.Count)
                {
                    dtg_SG_Compras.Rows.RemoveAt(rowActual);
                    return false;
                }
            }
            return true;
        }


        private bool MostrarDatosProducto(string codigo, int row)
        {
            if (_shalong.ProductoExistente(codigo))
            {
                C_Producto obj = _shalong.ProductoMostrar1(codigo);
                dtg_SG_Compras.Rows[row].Cells["Nombre"].Value = obj.CodigoBarras;
                dtg_SG_Compras.Rows[row].Cells["Unidad"].Value = obj.CodigoUnidad;
                Dtg_SG_AgregarCosto(row);
                return true;
            }
            else
            {
                dtg_SG_Compras.Rows.RemoveAt(row);
                return false;
            }
        }
        private void CalcularTotal()
        {
            double sumatoria = 0.0;
            double parcial = 0.0;
            double total = 0.0;
            int tipoCambio = _codigoTipoCambio;
            foreach (DataGridViewRow row in dtg_SG_Compras.Rows)
            {
                parcial += (Convert.ToDouble(row.Cells["Cantidad"].Value)) * (Convert.ToDouble(row.Cells["Costo_Unitario"].Value));
                sumatoria += Convert.ToDouble(row.Cells["Costo_Unitario"].Value);
                total = (parcial * double.Parse(txt_I_TipoCambio.Text));
                // (Convert.ToDouble(row.Cells["Costo_Total"].Value)) = parcial ;
            }
            if (Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString()) == 2)
            {
                txt_I_Total.Text = String.Format("{0:0.00}", total);
            }
            if (Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString()) == 1)
            {
                txt_I_Total.Text = String.Format("{0:0.00}", parcial);
            }
        }
        // Cuando el combo box Moneda es cambiado llama a esta funcion
        private void CalcularTotalCambioDeMoneda()
        {
            if (txt_I_Total.Text == string.Empty)
            { }
            else
            {
                double sumatoria = 0.0;
                double parcial = 0.0;
                double total = 0.0;
                int tipoCambio = _codigoTipoCambio;
                foreach (DataGridViewRow row in dtg_SG_Compras.Rows)
                {
                    parcial += (Convert.ToDouble(row.Cells["Cantidad"].Value)) * (Convert.ToDouble(row.Cells["Costo_Unitario"].Value));
                    sumatoria += Convert.ToDouble(row.Cells["Costo_Unitario"].Value);
                    total = (parcial * double.Parse(txt_I_TipoCambio.Text));
                    // (Convert.ToDouble(row.Cells["Costo_Total"].Value)) = parcial ;
                }
                if (Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString()) == 2)
                {
                    txt_I_Total.Text = String.Format("{0:0.00}", total);
                }
                if (Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString()) == 1)
                {
                    txt_I_Total.Text = String.Format("{0:0.00}", parcial);
                }
            }
        }
        private void AsignarCostoTotal(int rowActual)
        {
            dtg_SG_Compras.Rows[rowActual].Cells["Costo_Total"].Value = (Convert.ToDouble(dtg_SG_Compras.Rows[rowActual].Cells["Cantidad"].Value)) * (Convert.ToDouble(dtg_SG_Compras.Rows[rowActual].Cells["Costo_Unitario"].Value));
        }

        // DTG_CG

        private void Dtg_CG_ComprasCodigo(int rowActual)
        {
            if (dtg_CG_Compras.Rows[rowActual].Cells["Cg_Codigo"].Value == null)
            {
                dtg_CG_Compras.Rows.RemoveAt(rowActual);
                return;
            }
            if (dtg_CG_Compras.Rows[rowActual].Cells["Cg_Nombre"].Value == null)
            {
                string codigo = dtg_CG_Compras.Rows[rowActual].Cells["Cg_Codigo"].Value.ToString();
                MostrarDatosProductoConGarantia(codigo, rowActual);
            }

        }
        private void Dtg_CG_ComprasComprobarCodigo(int rowActual)
        {
            if (dtg_CG_Compras.Rows[rowActual].Cells["Cg_Codigo"].Value == null)
            {
                if (rowActual < dtg_CG_Compras.Rows.Count)
                {
                    dtg_CG_Compras.Rows.RemoveAt(rowActual);
                }
            }
        }
        private void Dtg_CG_ComprasNombre(int rowActual)
        {
            if (dtg_CG_Compras.Rows[rowActual].Cells["Cg_Codigo"].Value == null)
            {
                dtg_CG_Compras.Rows[rowActual].Cells["Cg_Codigo"].Value = dtg_CG_Compras.Rows[rowActual].Cells["Cg_Nombre"].Value;
            }
        }

        private void MostrarDatosProductoConGarantia(string codigo, int row)
        {
            if (_shalong.ProductoExistente(codigo))
            {
                C_Producto obj = _shalong.ProductoMostrar1(codigo);
                dtg_CG_Compras.Rows[row].Cells["Cg_Nombre"].Value = obj.CodigoBarras;
            }
            else
            {
                dtg_CG_Compras.Rows.RemoveAt(row);
            }
        }

        //CARGAR FORMULARIO COMPRA

        private void CargarDataGridView()
        {
            dtg_SG_Compras.DataSource = null;
            dtg_SG_Compras.AutoGenerateColumns = false;
            var list = _shalong.CompraProducto(Int32.Parse(cmb_M_NroDocumento.SelectedValue.ToString()));
            var databinding = new BindingList<C_CompraDetalle>(list);
            dtg_SG_Compras.DataSource = databinding;
            //dtg_SG_Compras.AllowUserToAddRows = true;
        }



        //EVENTOS DEL FORMULARIO

        private void Compras_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
        private void cmb_I_TipoMoneda_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (cmb_I_TipoMoneda.SelectedIndex == -1)
            {

            }
            else if (Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString()) == 1)
            {
                CalcularTotalCambioDeMoneda();
            }
            else if (Int32.Parse(cmb_I_TipoMoneda.SelectedValue.ToString()) == 2)
            {
                CalcularTotalCambioDeMoneda();
            }
        }
        private void btn_I_TipoCambio_Click_1(object sender, EventArgs e)
        {
            Dolar objetoDolar = new Dolar(_codigoUsuario, "observacion", false);
            objetoDolar.ShowDialog();
            CargarValorDolar();
        }
        private void cmb_I_Proveedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_I_Proveedor.SelectedIndex == -1)
            { }
            else
            {
                C_Proveedor objetoProveedor = _shalong.ProveedorMostrar1(Int32.Parse(cmb_I_Proveedor.SelectedValue.ToString()));
                txt_I_Proveedor.Text = objetoProveedor.Nombre;
            }
        }
        private void dtg_SG_Compras_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText = dtg_SG_Compras.Columns[e.ColumnIndex].HeaderText;

            // Abort validation if cell is not in the CompanyName column.
            if (!headerText.Equals("Nombre")) return;

            // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dtg_SG_Compras.Rows[e.RowIndex].ErrorText =
                    "Nombre no debe estar en blanco";
                e.Cancel = true;
            }
        }
        private void dtg_SG_Compras_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            int columnActual = e.ColumnIndex;
            //obtengo la fila actual
            int rowActual = e.RowIndex;
            //si columna es 0 == codigo y que no ingrese al crear el grid
            if (rowActual > -1 && isvalido)
            {
                isvalido = false;
                //codigo
                if (columnActual == 0)
                {
                    Dtg_SG_ComprasCodigo(rowActual);
                }
                //nombre
                if (columnActual == 1)
                {
                    Dtg_SG_ComprasNombre(rowActual);
                }
                //cantidad
                if (columnActual > 1)
                {
                    try
                    {
                        Double.Parse(dtg_SG_Compras.Rows[rowActual].Cells[columnActual].Value.ToString());
                        if (Dtg_SG_ComprasComprobarCodigo(rowActual))
                            AsignarCostoTotal(rowActual);
                        CalcularTotal();
                    }
                    catch
                    {
                        dtg_SG_Compras.Rows[rowActual].Cells[columnActual].Value = "0";

                    }
                }
                isvalido = true;
            }


        }
        private void dtg_SG_Compras_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            Dtg_SG_ComprasCodigo(e.RowIndex);
            //MessageBox.Show("El producto de la fila "+ (e.RowIndex + 1)+" ya no existe");
        }
        private void dtg_CG_Compras_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            int columnActual = e.ColumnIndex;
            //obtengo la fila actual
            int rowActual = e.RowIndex;
            //si columna es 0 == codigo y que no ingrese al crear el grid
            if (rowActual > -1)
            {
                //codigo
                if (columnActual == 0)
                {
                    Dtg_CG_ComprasCodigo(rowActual);
                }
                //nombre
                if (columnActual == 1)
                {
                    Dtg_CG_ComprasNombre(rowActual);
                }
                if (columnActual > 1)
                {
                    Dtg_CG_ComprasComprobarCodigo(rowActual);
                }
            }
        }
        private void btn_Otra_Click_1(object sender, EventArgs e)
        {
            LimpiarCompras();
            dtg_SG_Compras.DataSource = null;
            dtg_SG_Compras.Refresh();
            dtg_CG_Compras.Refresh();
            cmb_I_Proveedor.SelectedIndex = -1;
            cmb_I_Proveedor.ResetText();
            txt_I_Proveedor.Clear();
        }
        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
            if (tab_Compras.SelectedIndex == 2)
            {
                GuardarOrdenDeCompra();
            }
            else
            {
                GuardarCompraCabezera();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            cmb_M_NroDocumento.ValueMember = "Codigo";
            cmb_M_NroDocumento.DisplayMember = "NumeroDocumento";
            cmb_M_NroDocumento.DataSource = _shalong.DocumentoPorFecha(dateTimePicker2.Value);
            //CargarComboBox();
            //CargarDataGridView();
        }
        private void cmb_Documentos_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            C_OrdenCompra obj = _shalong.OrdenCompraDocumento1(Int32.Parse(cmb_Documentos.SelectedValue.ToString()));
            cmb_I_Proveedor.SelectedValue = obj.CodigoProveedor;
            dtg_SG_Compras.AutoGenerateColumns = false;
            var yourList = _shalong.OrdenCompraProducto(Int32.Parse(cmb_Documentos.SelectedValue.ToString()));
            var listBinding = new BindingList<C_OrdenCompraDetalle>(yourList);
            dtg_SG_Compras.DataSource = listBinding;
            LimpiarCompras();
            dtg_SG_Compras.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }
        private void tab_Compras_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tab_Compras.SelectedIndex == 1)
            {
                cmb_M_NroDocumento.SelectedIndex = -1;

            }
            if (tab_Compras.SelectedIndex == 2)
            {
                cmb_Documentos.SelectedIndex = -1;
                if (cmb_Documentos.SelectedIndex == -1)
                {
                    LimpiarCompras();
                    cmb_I_Proveedor.SelectedIndex = -1;
                    txt_I_Proveedor.Clear();
                    dtg_SG_Compras.DataSource = null;
                    dtg_SG_Compras.Refresh();
                    dtg_CG_Compras.DataSource = null;
                    dtg_CG_Compras.Refresh();
                }

            }
        }

        private void cmb_M_NroDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_M_NroDocumento.SelectedIndex != -1)
            {
                C_Compra obj = _shalong.DocumentoPorFecha1(Int32.Parse(cmb_M_NroDocumento.SelectedValue.ToString()));
                txt_I_NroDocumento.Text = obj.NumeroDocumento;
                dtp_I_Fecha.Value = obj.FechaCompra;
                cmb_I_TipoDocumento.SelectedValue = obj.CodigoTipoDocumento;
                cmb_I_TipoMoneda.SelectedValue = obj.CodigoMoneda;
                txt_I_TipoCambio.Text = "" + obj.ValorTipoCambio;
                cmb_I_Proveedor.SelectedValue = obj.CodigoProveedor;
                txt_I_Total.Text = "" + obj.MontoTotal;
                CargarDataGridView();
                
            }
            dtg_SG_Compras.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }
}
