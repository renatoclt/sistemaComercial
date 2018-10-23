using Shalong.Clases;
using Shalong.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shalong.Formularios
{
    public partial class Producto_Precio : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Producto_Precio()
        {
            InitializeComponent();
            CargarComboBox();
            CargarDataGridView();
        }

        public Producto_Precio(I_Parametros _interfazParametros)
        {
            InitializeComponent();
            CargarComboBox();
            CargarDataGridView();
        }
        public Producto_Precio(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void Cmb_Producto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarDataGridView();
            ComprobarPrecioProducto();

        }
        private void EliminarBaseDatos()
        {
            string codigoBarras = cmb_Producto.SelectedValue.ToString();
            _shalong.ProductoPrecio(3, 1, codigoBarras, 1);
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_Producto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Producto Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                return;
            }
            else
            {
                EliminarBaseDatos();
                GuardarBaseDatos();
            }
        }
        private void Cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtg_ProductoPrecio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CargarComboBox()
        {
            cmb_Producto.DisplayMember = "Nombre";
            cmb_Producto.ValueMember = "CodigoBarras";
            cmb_Producto.DataSource = _shalong.ProductoMostrar();
            cmb_Producto.SelectedIndex = -1;
        }
        private void CargarDataGridView()
        {
            dtg_ProductoPrecio.AutoGenerateColumns = false;
            dtg_ProductoPrecio.DataSource = _shalong.TipoPrecioMostrar();
        }

        
        private void ComprobarPrecioProducto()
        {
            List<C_ProductoPrecio> lista = _shalong.ProductoPrecioMostrar(cmb_Producto.SelectedValue.ToString());
            if (lista.Count > 0)
            {
                foreach (DataGridViewRow row in dtg_ProductoPrecio.Rows)
                {
                    foreach (C_ProductoPrecio obj in lista)
                    {
                        if (Int32.Parse(row.Cells["Codigo"].Value.ToString()) == obj.CodigoTipoPrecio)
                        {
                            row.Cells["Precio"].Value = obj.Precio;
                            break;
                        }
                    }
                }
            }
        }
       
       
        private void GuardarBaseDatos()
        {
            string codigoBarras;
            int codigoTipoPrecio;
            double precio;
            bool isCorrecto = true;
            if (cmb_Producto.SelectedIndex > -1)
            {
                List<C_ProductoPrecio> lista = _shalong.ProductoPrecioMostrar(cmb_Producto.SelectedValue.ToString());
                foreach (DataGridViewRow row in dtg_ProductoPrecio.Rows)
                {
                    if (row.Cells["Precio"].Value.ToString() != String.Empty)
                    {
                        codigoBarras = cmb_Producto.SelectedValue.ToString();
                        codigoTipoPrecio = Int32.Parse(row.Cells["Codigo"].Value.ToString());
                        precio = Double.Parse(row.Cells["Precio"].Value.ToString());
                        if (!_shalong.ProductoPrecio(1, codigoTipoPrecio, codigoBarras, precio))
                        {
                            MessageBox.Show("Error al ingresar en la fila" + (row.Index + 1), "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isCorrecto = false;
                        }
                    }
                }
            }
            if (isCorrecto)
            {
                MessageBox.Show("Ingreso Correcto","Gestion Ventas",MessageBoxButtons.OK);
                CargarDataGridView();
                CargarComboBox();
            }
        }

        private void Producto_Precio_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }                         
    }
}
