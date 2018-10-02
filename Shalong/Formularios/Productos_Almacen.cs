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
    public partial class Productos_Almacen : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoAlmacen;
        int _codigoTipoAlmacen;
        int _codigoAdministrador;
        string _observacion;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Productos_Almacen(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
        }
        public Productos_Almacen(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {

            _codigoAlmacen = objetoParametros.CodigoAlmacen;
        }

        public Productos_Almacen(C_Parametros objetoParametros, int producto)
        {
            _codigoAlmacen = objetoParametros.CodigoAlmacen;
            InitializeComponent();
            CargarCombobox();
            cmb_Producto.SelectedValue = producto;

        }

        private void CargarCombobox()
        {
            CargarComboboxProducto();
            CargarComboBoxAlmacen();
        }

        private void CargarComboboxProducto()
        {
            cmb_Producto.DisplayMember = "Nombre";
            cmb_Producto.ValueMember = "CodigoBarras";
            cmb_Producto.DataSource = _shalong.ProductoMostrar();
        }

        private void CargarComboBoxAlmacen()
        {
            cmb_almacen.DisplayMember = "Nombre";
            cmb_almacen.ValueMember = "Codigo";
            cmb_almacen.DataSource = _shalong.AlmacenMostrar();
        }

        private void CargarDataGridView(int codigoProducto, int codigoAlmacen)
        {
            dtg_Productos.AutoGenerateColumns = false;
            dtg_Productos.DataSource = _shalong.ProductoAlmacenMostar(codigoProducto, codigoAlmacen);
        }

        private void cmb_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDataGridView(Int32.Parse(cmb_Producto.SelectedValue.ToString()), _codigoAlmacen);
        }

        private void btn_Transferir_Click(object sender, EventArgs e)
        {
            TransferirProductos();
        }

        private void TransferirProductos()
        {
            C_Almacen_Producto obj = new C_Almacen_Producto();
            if (cmb_Producto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Producto Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                return;
            }
            else
            {
                obj.CodigoProducto = Int32.Parse(cmb_Producto.SelectedValue.ToString());
            }
            if (cmb_almacen.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                return;
            }
            else
            {
                obj.CodigoAlmacen = Int32.Parse(cmb_almacen.SelectedValue.ToString());
            }
            obj.Cantidad = _shalong.StockPorAlmancen(obj);
            int codigoAlmacen = _shalong.CodigoTipoAlmacen(_codigoAlmacen);
            int codigoAlmacen2 = _shalong.CodigoTipoAlmacen(Int32.Parse(cmb_almacen.SelectedValue.ToString()));

            if (codigoAlmacen == codigoAlmacen2)
            {
                if (obj.Cantidad != 0)
                {

                    if (_shalong.AlmacenProducto(1, Int32.Parse(cmb_almacen.SelectedValue.ToString()), Int32.Parse(cmb_Producto.SelectedValue.ToString()), Double.Parse(txt_cantidad.Text) * -1))
                    {
                        MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);
                        CargarCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("no hay stock", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                AbrirContraseña();
                if (obj.Cantidad != 0)
                {

                    if (_shalong.AlmacenProducto(1, Int32.Parse(cmb_almacen.SelectedValue.ToString()), Int32.Parse(cmb_Producto.SelectedValue.ToString()), Double.Parse(txt_cantidad.Text) * -1))
                    {

                        MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);
                        CargarCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("no hay stock", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AbrirContraseña()
        {
            C_Parametros objetoParametros = new C_Parametros();
            Contraseña obj = new Contraseña(objetoParametros);
            DialogResult dg = obj.ShowDialog();                  
        }

        private void Productos_Almacen_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
