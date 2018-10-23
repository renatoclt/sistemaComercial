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
    public partial class Almacen_Productos : Form
    {
        Shalong_Service _Shalong = new Shalong_Service();
        public Almacen_Productos()
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Almacen_Productos(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Almacen_Productos(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }

        
        private void CargarGridView(int codigoAlmacen)
        {
            dtg_Productos.AutoGenerateColumns = false;
            dtg_Productos.DataSource = _Shalong.AlmacenProductoMostrar(codigoAlmacen);
        }
        private void CargarComboBox()
        {
            CargarComboBoxAlmacen();
            CargarComboBoxProducto();
        }
        private void CargarComboBoxAlmacen()
        {
            cmb_Almacen.DisplayMember = "Nombre";
            cmb_Almacen.ValueMember = "Codigo";
            cmb_Almacen.DataSource = _Shalong.AlmacenMostrar();
        }
        private void CargarComboBoxProducto()
        {
            cmb_Producto.DisplayMember = "Nombre";
            cmb_Producto.ValueMember = "CodigoBarras";
            cmb_Producto.DataSource = _Shalong.ProductoMostrar();
        }
        private void cmb_Almacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGridView(Int32.Parse(cmb_Almacen.SelectedValue.ToString()));
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_Almacen.SelectedIndex != -1)
            {
                if (cmb_Producto.SelectedIndex != -1)
                {
                    GuardarProductoAlmacen();
                }
                else
                {
                    MessageBox.Show("Ingrese un Producto Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                    cmb_Producto.ResetText();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                cmb_Almacen.ResetText();
                return;
            }
        }
        private void GuardarProductoAlmacen()
        {

            string yield = cmb_Producto.SelectedValue.ToString();
            string g = cmb_Almacen.SelectedValue.ToString();
            if (txt_Cantidad.Text != String.Empty)
            {
                if (_Shalong.AlmacenProducto(1, Int32.Parse(cmb_Almacen.SelectedValue.ToString()), cmb_Producto.SelectedValue.ToString(), Double.Parse(txt_Cantidad.Text)))
                {
                    MessageBox.Show("Ingreso Correcto","Gestion Ventas",MessageBoxButtons.OK);
                    CargarComboBox();
                }
                else
                {
                    MessageBox.Show("Revise los datos","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No deje en blanco el campo Cantidad","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Producto obj = _Shalong.MostrarUnidadProducto(cmb_Producto.SelectedValue.ToString());
            txtUnidad.Text = obj.NombreUnidad;
        }

        private void Almacen_Productos_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
