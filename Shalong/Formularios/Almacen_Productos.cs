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
            Cmb_Almacen.DisplayMember = "Nombre";
            Cmb_Almacen.ValueMember = "Codigo";
            Cmb_Almacen.DataSource = _Shalong.AlmacenMostrar();
        }
        private void CargarComboBoxProducto()
        {
            Cmb_Producto.DisplayMember = "Nombre";
            Cmb_Producto.ValueMember = "CodigoBarras";
            Cmb_Producto.DataSource = _Shalong.ProductoMostrar();
        }
        private void Cmb_Almacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGridView(Int32.Parse(Cmb_Almacen.SelectedValue.ToString()));
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cmb_Almacen.SelectedIndex != -1)
            {
                if (Cmb_Producto.SelectedIndex != -1)
                {
                    GuardarProductoAlmacen();
                }
                else
                {
                    MessageBox.Show("Ingrese un Producto Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                    Cmb_Producto.ResetText();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                Cmb_Almacen.ResetText();
                return;
            }
        }
        private void GuardarProductoAlmacen()
        {

            string yield = Cmb_Producto.SelectedValue.ToString();
            string g = Cmb_Almacen.SelectedValue.ToString();
            if (Txt_Cantidad.Text != String.Empty)
            {
                if (_Shalong.AlmacenProducto(1, Int32.Parse(Cmb_Almacen.SelectedValue.ToString()), Cmb_Producto.SelectedValue.ToString(), Double.Parse(Txt_Cantidad.Text)))
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

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Producto obj = _Shalong.MostrarUnidadProducto(Cmb_Producto.SelectedValue.ToString());
            TxtUnidad.Text = obj.NombreUnidad;
        }

        private void Almacen_Productos_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
