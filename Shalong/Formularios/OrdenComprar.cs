using System;
using Shalong.Conexion;
using Shalong.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shalong.Formularios
{

    public partial class OrdenComprar : Form
    {
        int _codigoDniUsuario;
        bool _isValido;

        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public OrdenComprar(I_Parametros parametros)
        {

            InitializeComponent();
            CargarComboBox();
            CargarDataGridView();
            _isValido = true;
        }

        private void CargarDataGridViewProductosDetalle()
        {
            dtg_I_Productos.AutoGenerateColumns = false;
            if (Cmb_Documento.SelectedValue == null)
            {
                MessageBox.Show("No hay ningun documento en esa fecha", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                var list = _shalong.OrdenCompraProducto(Int32.Parse(Cmb_Documento.SelectedValue.ToString()));
                var Databinding = new BindingList<C_OrdenCompraDetalle>(list);
                dtg_I_Productos.DataSource = Databinding;
                //dtg_I_Productos.DataSource = _shalong.OrdenCompraProducto(Int32.Parse(Cmb_Documento.SelectedValue.ToString()));
            }
        }
        private void CargarDataGridviewEliminar()
        {
            dtg_I_Productos.AutoGenerateColumns = false;
            if (Cmb_EliminarO.SelectedValue == null)
            {
                MessageBox.Show("No hay ninguna orden de compra", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
                dtg_I_Productos.DataSource = _shalong.OrdenCompraProducto(Int32.Parse(Cmb_EliminarO.SelectedValue.ToString()));
        }
        public OrdenComprar(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _codigoDniUsuario = objetoParametros.DniUsuario;
        }
        public OrdenComprar(int codigoDniUsuario)
        {
            _codigoDniUsuario = codigoDniUsuario;
            InitializeComponent();
            CargarComboBox();
            CargarDataGridView();
            _isValido = true;
        }

        public void CargarComboBox()
        {
            CargarComboBoxRuc();
            CargarComboboxEliminar();
            CargarComboBoxDocumento();
        }

        public void CargarComboBoxRuc()
        {
            Cmb_I_Ruc.DisplayMember = "Ruc";
            Cmb_I_Ruc.ValueMember = "CodigoProveedor";
            Cmb_I_Ruc.DataSource = _shalong.OrdenCompraMostrar();
            Cmb_I_Ruc.SelectedIndex = -1;

        }

        public void CargarComboboxEliminar()
        {
            Cmb_EliminarO.DisplayMember = "NumeroDocumento";
            Cmb_EliminarO.ValueMember = "Codigo";
            Cmb_EliminarO.DataSource = _shalong.OrdenCompraDocumento();
        }

        private void CargarComboBoxDocumento()
        {
            Cmb_Documento.ValueMember = "Codigo";
            Cmb_Documento.DisplayMember = "NumeroDocumento";
            Cmb_Documento.DataSource = _shalong.OrdenDocumentoPorFecha(dateTimePicker2.Value);
        }
        public void CargarDataGridView()
        {
            CargarDataGridViewProductos();

        }

        public void CargarDataGridViewProductos()
        {
            DataGridViewComboBoxColumn columnProducto = dtg_I_Productos.Columns["Nombre"] as DataGridViewComboBoxColumn;
            columnProducto.DisplayMember = "Nombre";
            columnProducto.ValueMember = "CodigoBarras";
            columnProducto.DataSource = _shalong.OrdenCompraMostrarNombreProducto();
        }
        private void GuardarOrdenCompra()
        {
            int accion = 1;
            C_OrdenCompra objetoOrdenCompra = new C_OrdenCompra();
            objetoOrdenCompra.Codigo = 1;
            objetoOrdenCompra.CodigoDniUsuario = _codigoDniUsuario;


            if (Cmb_I_Ruc.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Proveedor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoOrdenCompra.CodigoProveedor = Int32.Parse(Cmb_I_Ruc.SelectedValue.ToString());
            }



            if (date_I_Fecha.Value == null)
            {
                MessageBox.Show("Ingrese una fecha", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                objetoOrdenCompra.Fecha = date_I_Fecha.Value;
            }

            if (Txt_I_NDocumento.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un Numero de Documento", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoOrdenCompra.NumeroDocumento = Txt_I_NDocumento.Text;
            }
            if (Txt_I_Observacion.Text == String.Empty)
            {
                Txt_I_Observacion.Text = "N/E";
                objetoOrdenCompra.ReferenciaOrdenCompra = Txt_I_Observacion.Text;
            }
            else
            {
                objetoOrdenCompra.ReferenciaOrdenCompra = Txt_I_Observacion.Text;
            }

            if (Txt_I_NDocumento.Text == Cmb_Documento.Text)
            {
                accion = 2;
                objetoOrdenCompra.Codigo = Int32.Parse(Cmb_Documento.SelectedValue.ToString());
            }


            if (_shalong.OrdenCompra(accion, objetoOrdenCompra))
            {

                if (GuardarOrdenCompraDetalle(accion))
                {
                    MessageBox.Show("Se Ingreso la orden de compra correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    dtg_I_Productos.DataSource = null;
                    dtg_I_Productos.Refresh();
                }
                else
                {
                    MessageBox.Show("Revise los Datos del del detalle de la orden de compra", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Revise los Datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        private bool GuardarOrdenCompraDetalle(int accion)
        {
            C_OrdenCompraDetalle objetoOrdenCompraDetalle = new C_OrdenCompraDetalle();
            C_OrdenCompra objetoOrdenCompra = new C_OrdenCompra();
            objetoOrdenCompra.CodigoProveedor = Int32.Parse(Cmb_I_Ruc.SelectedValue.ToString());
            objetoOrdenCompra.NumeroDocumento = Txt_I_NDocumento.Text;
            objetoOrdenCompraDetalle.CodigoOrdenCompra = _shalong.OrdenCompraCodigo(objetoOrdenCompra);
            if (accion == 2)
            {
                if (!_shalong.OrdenCompraDetalle(2, objetoOrdenCompraDetalle))
                    MessageBox.Show("Error al modificar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach (DataGridViewRow row in dtg_I_Productos.Rows)
            {
                if (row.Cells["Codigo"].Value != null)
                {
                    objetoOrdenCompraDetalle.CodigoBarras = row.Cells["Codigo"].Value.ToString();
                    objetoOrdenCompraDetalle.Cantidad = row.Cells["Cantidad"].Value.ToString();
                    if (_shalong.OrdenCompraDetalle(1, objetoOrdenCompraDetalle))
                    {
                        MessageBox.Show("Ingreso Detalle Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                        CargarComboBox();
                    }
                    else
                    {
                        MessageBox.Show("No Ingreso Detalle Correctamente", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            return true;
        }

        private void Dtg_OrdenCompraCodigoProducto(int rowActual)
        {
            string codigoFilaActual;

            try
            {
                codigoFilaActual = dtg_I_Productos.Rows[rowActual].Cells["Codigo"].Value.ToString();
            }
            catch (Exception)
            {
                codigoFilaActual = "-999";
            }
            if (_shalong.ProductoExistente(codigoFilaActual))
            {
                dtg_I_Productos.Rows[rowActual].Cells["Nombre"].Value = codigoFilaActual;
                Dtg_Cantidad(rowActual);
            }
            else
            {
                dtg_I_Productos.Rows.RemoveAt(rowActual);
            }
        }
        private void Dtg_OrdenCompraNombreProducto(int rowActual)
        {
            dtg_I_Productos.Rows[rowActual].Cells["Codigo"].Value = dtg_I_Productos.Rows[rowActual].Cells["Nombre"].Value;
            Dtg_Cantidad(rowActual);

        }
        private void Dtg_Cantidad(int rowActual)
        {
            if (dtg_I_Productos.Rows[rowActual].Cells["Cantidad"].Value == null)
            {
                dtg_I_Productos.Rows[rowActual].Cells["Cantidad"].Value = 1;
            }
            else
            {
                try
                {
                    Int32.Parse(dtg_I_Productos.Rows[rowActual].Cells["Cantidad"].Value.ToString());
                }
                catch
                {
                    dtg_I_Productos.Rows.RemoveAt(rowActual);
                }
            }
            foreach (DataGridViewRow row in dtg_I_Productos.Rows)
            {
                if (dtg_I_Productos.Rows[rowActual].Cells["Codigo"].Value != null && row.Cells["Codigo"].Value != null)
                {
                    if (dtg_I_Productos.Rows[rowActual].Cells["Codigo"].Value.ToString() == row.Cells["Codigo"].Value.ToString() && rowActual != row.Index)
                    {
                        dtg_I_Productos.Rows[row.Index].Cells["Cantidad"].Value = Int32.Parse(dtg_I_Productos.Rows[row.Index].Cells["Cantidad"].Value.ToString()) + 1;
                        dtg_I_Productos.Rows.RemoveAt(rowActual);
                        break;
                    }
                }
                else
                {
                    if (row.Index != dtg_I_Productos.RowCount - 1)
                        dtg_I_Productos.Rows.RemoveAt(row.Index);
                }

            }
        }
        private void EliminarOrdenDeCompra()
        {
            C_OrdenCompra objetoOrdenCompra = new C_OrdenCompra();
            objetoOrdenCompra.Codigo = Int32.Parse(Cmb_EliminarO.SelectedValue.ToString());
            objetoOrdenCompra.CodigoProveedor = Int32.Parse(Cmb_I_Ruc.SelectedValue.ToString());
            objetoOrdenCompra.NumeroDocumento = Txt_I_NDocumento.Text;
            objetoOrdenCompra.ReferenciaOrdenCompra = Txt_I_Observacion.Text;
            if (_shalong.OrdenCompra(3, objetoOrdenCompra))
            {
                MessageBox.Show("Se elimino la orden de compra", "Gestion Ventas", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Error al eliminar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            CargarComboboxEliminar();
            CargarDataGridviewEliminar();
        }

        //EVENTOS DEL FORMULARIO

        private void OrdenComprar_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
        private void Cmb_I_Ruc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void Cmb_I_Ruc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (Cmb_I_Ruc.SelectedIndex == -1)
            //{
            //    Txt_I_Nombre.Clear();
            //}
            if (Cmb_I_Ruc.SelectedIndex != -1)
            {
                // Cmb_I_Ruc.SelectedIndex = -1;
                C_Proveedor obj = _shalong.ProveedorMostrar1(Int32.Parse(Cmb_I_Ruc.SelectedValue.ToString()));
                Txt_I_Nombre.Text = " " + obj.Nombre;
            }
        }
        private void dtg_I_Productos_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            int columnaActual = e.ColumnIndex;
            int rowActual = e.RowIndex;
            //la primera vez que se crea el dtg no ingresa al if, 
            //la segunda condicion 
            if (rowActual > -1 && _isValido)
            {
                _isValido = false;
                ////se modifica la columna de codigo 
                if (columnaActual == 0)
                {
                    Dtg_OrdenCompraCodigoProducto(rowActual);

                }
                //se modifica la columna de nombre
                if (columnaActual == 1)
                {
                    Dtg_OrdenCompraNombreProducto(rowActual);
                }
                //si modifica la columna de cantidad
                if (columnaActual == 2)
                {

                }
                _isValido = true;
            }
        }
        private void Btn_Guardar_Click_1(object sender, EventArgs e)
        {
            GuardarOrdenCompra();
        }
        private void Cmb_Documento_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            C_OrdenCompra obj = _shalong.OrdenDocumentoPorFecha1(Int32.Parse(Cmb_Documento.SelectedValue.ToString()));
            textBox3.Text = "" + obj.ReferenciaOrdenCompra;
            Txt_I_NDocumento.Text = "" + obj.NumeroDocumento;
            Cmb_I_Ruc.SelectedValue = obj.CodigoProveedor;
            Txt_I_Observacion.Text = "" + obj.ReferenciaOrdenCompra;
            CargarDataGridViewProductosDetalle();
            dtg_I_Productos.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            Cmb_Documento.ValueMember = "Codigo";
            Cmb_Documento.DisplayMember = "NumeroDocumento";
            Cmb_Documento.DataSource = _shalong.OrdenDocumentoPorFecha(dateTimePicker2.Value);
            CargarComboBox();
            CargarDataGridViewProductosDetalle();
        }
        private void Cmb_EliminarO_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            C_OrdenCompra obj = _shalong.OrdenCompraDocumento1(Int32.Parse(Cmb_EliminarO.SelectedValue.ToString()));
            textBox3.Text = "" + obj.ReferenciaOrdenCompra;
            Txt_I_NDocumento.Text = "" + obj.NumeroDocumento;
            Cmb_I_Ruc.SelectedValue = obj.CodigoProveedor;
            Txt_I_Observacion.Text = "" + obj.ReferenciaOrdenCompra;
            dtg_I_Productos.DataSource = _shalong.OrdenCompraProducto(Int32.Parse(Cmb_EliminarO.SelectedValue.ToString()));
        }
        private void Btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            EliminarOrdenDeCompra();
        }

        private void dtg_I_Productos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

 


    }
}