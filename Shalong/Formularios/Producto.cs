using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Conexion;
using Shalong.Clases;

namespace Shalong.Formularios
{
    public partial class Producto : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoAdministrador;
        string _observacion;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Producto()
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Producto(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Producto(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _objetoParametros = objetoParametros;
        }
        private void Btn_I_Marca_Click(object sender, EventArgs e)
        {
            OpenMarca();
        }
        private void Btn_I_Familia_Click(object sender, EventArgs e)
        {
            OpenFamilia();
        }

        private void Btn_I_Categoria_Click(object sender, EventArgs e)
        {
            OpenCategoria();
        }

        private void Btn_I_Unidad_Click(object sender, EventArgs e)
        {
            OpenUnidad();
        }
        private void Btn_M_Marca_Click(object sender, EventArgs e)
        {
            OpenMarca();
        }

        private void Btn_M_Familia_Click(object sender, EventArgs e)
        {
            OpenFamilia();
        }

        private void Btn_M_Categoria_Click(object sender, EventArgs e)
        {
            OpenCategoria();
        }

        private void Btn_M_Unidad_Click(object sender, EventArgs e)
        {
            OpenUnidad();
        }

        private bool ComprobarTabSeleccionado(int tabSeleccionado)
        {
            bool isValido = false;
            if (tabSeleccionado == 1 || tabSeleccionado == 2)
            {
                isValido = AbrirContraseña();
            }
            return isValido;
        }
        private void Tab_Producto_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!ComprobarTabSeleccionado(e.TabPageIndex))
            {
                Tab_Producto.SelectedIndex = 0;
            }
        }

        private void Btn_I_Guardar_Click(object sender, EventArgs e)
        {
            IngresarProducto();
        }


        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarProductos();
        }
        private void Cmb_M_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Producto obj = _shalong.ProductoMostrar1(Int32.Parse(cmb_M_Producto.SelectedValue.ToString()));
            txt_M_Codigo.Text = "" + obj.CodigoBarras;
            txt_M_Nombre.Text = "" + obj.Nombre;
            txt_M_TiempoGarantia.Text = "" + obj.TiempoGarantia;
            cmb_M_Categoria.SelectedValue = obj.CodigoCategoria;
            cmb_M_Familia.SelectedValue = obj.CodigoFamilia;
            cmb_M_Marca.SelectedValue = obj.CodigoMarca;
            cmb_M_Unidad.SelectedValue = obj.CodigoUnidad;
        }

        private void Cmb_E_Producto_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Producto obj = _shalong.ProductoMostrar1(Int32.Parse(cmb_E_Producto.SelectedValue.ToString()));
            txt_E_Codigo.Text = "" + obj.CodigoBarras;
            txt_E_Nombre.Text = "" + obj.Nombre;
            txt_E_TiempoGarantia.Text = "" + obj.TiempoGarantia;
            cmb_E_Categoria.SelectedValue = obj.CodigoCategoria;
            cmb_E_Familia.SelectedValue = obj.CodigoFamilia;
            cmb_E_Marca.SelectedValue = obj.CodigoMarca;
            cmb_E_Unidad.SelectedValue = obj.CodigoUnidad;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void Txt_I_TiempoGarantia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_I_Familia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarComboBox()
        {
            CargarComboBoxUnidad();
            CargarComboBoxCategoria();
            CargarComboBoxFamilia();
            CargarComboBoxMarca();
            CargarComboBoxProducto();
        }

        private void CargarComboBoxProducto()
        {
            cmb_M_Producto.DisplayMember = "Nombre";
            cmb_M_Producto.ValueMember = "CodigoBarras";
            cmb_M_Producto.DataSource = _shalong.ProductoMostrar();
            cmb_E_Producto.DisplayMember = "Nombre";
            cmb_E_Producto.ValueMember = "CodigoBarras";
            cmb_E_Producto.DataSource = _shalong.ProductoMostrar();
        }

        private void CargarComboBoxUnidad()
        {
            cmb_I_Unidad.DisplayMember = "Nombre";
            cmb_I_Unidad.ValueMember = "Codigo";
            cmb_I_Unidad.DataSource = _shalong.UnidadMostrar();

            cmb_M_Unidad.DisplayMember = "Nombre";
            cmb_M_Unidad.ValueMember = "Codigo";
            cmb_M_Unidad.DataSource = _shalong.UnidadMostrar();

            cmb_E_Unidad.DisplayMember = "Nombre";
            cmb_E_Unidad.ValueMember = "Codigo";
            cmb_E_Unidad.DataSource = _shalong.UnidadMostrar();
        }

        private void CargarComboBoxCategoria()
        {
            cmb_I_Categoria.DisplayMember = "Nombre";
            cmb_I_Categoria.ValueMember = "Codigo";
            cmb_I_Categoria.DataSource = _shalong.CategoriaMostrar();
            cmb_M_Categoria.DisplayMember = "Nombre";
            cmb_M_Categoria.ValueMember = "Codigo";
            cmb_M_Categoria.DataSource = _shalong.CategoriaMostrar();
            cmb_E_Categoria.DisplayMember = "Nombre";
            cmb_E_Categoria.ValueMember = "Codigo";
            cmb_E_Categoria.DataSource = _shalong.CategoriaMostrar();
        }

        private void CargarComboBoxFamilia()
        {
            cmb_I_Familia.DisplayMember = "Nombre";
            cmb_I_Familia.ValueMember = "Codigo";
            cmb_I_Familia.DataSource = _shalong.FamiliaMostrar();
            cmb_M_Familia.DisplayMember = "Nombre";
            cmb_M_Familia.ValueMember = "Codigo";
            cmb_M_Familia.DataSource = _shalong.FamiliaMostrar();
            cmb_E_Familia.DisplayMember = "Nombre";
            cmb_E_Familia.ValueMember = "Codigo";
            cmb_E_Familia.DataSource = _shalong.FamiliaMostrar();
        }

        private void CargarComboBoxMarca()
        {
            cmb_I_Marca.DisplayMember = "Nombre";
            cmb_I_Marca.ValueMember = "Codigo";
            cmb_I_Marca.DataSource = _shalong.MarcaMostrar();
            cmb_M_Marca.DisplayMember = "Nombre";
            cmb_M_Marca.ValueMember = "Codigo";
            cmb_M_Marca.DataSource = _shalong.MarcaMostrar();
            cmb_E_Marca.DisplayMember = "Nombre";
            cmb_E_Marca.ValueMember = "Codigo";
            cmb_E_Marca.DataSource = _shalong.MarcaMostrar();
        }

        private void OpenMarca()
        {
            Marca obj = new Marca();
            obj.ShowDialog();
            CargarComboBox();
        }

        private void OpenFamilia()
        {
            Familia obj = new Familia();
            obj.ShowDialog();
            CargarComboBox();
        }

        private void OpenUnidad()
        {
            Unidad obj = new Unidad();
            obj.ShowDialog();
            CargarComboBox();
        }

        private void OpenCategoria()
        {
            C_Parametros objetoParametros = new C_Parametros();
            Categoria obj = new Categoria();
            obj.ShowDialog();
            CargarComboBox();
        }

        private bool AbrirContraseña()
        {

            Contraseña obj = new Contraseña(_objetoParametros);
            DialogResult dg = obj.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK)
            {
                _codigoAdministrador = obj.CodigoAdministrador;
                _observacion = obj.Observacion;
                CargarComboBox();
                return true;
            }
            return false;
        }

        private void IngresarProducto()
        {
            C_Producto objetoProducto = new C_Producto();
            //Envio de validación para usar la pestaña modificar, se envia valores nulos.
            objetoProducto.CodigoAdministrador = 1;
            objetoProducto.Observacion = "";
            //
            // CODIGO DE BARRAS
            if (txt_I_Codigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo del Producto, Por Favor","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else if (_shalong.ProductoExistente(Int32.Parse(txt_I_Codigo.Text)))
            {
                MessageBox.Show("El Codigo del Producto ya existe, Ingrese otro ó Modifiquelo","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoProducto.CodigoBarras = Int32.Parse(txt_I_Codigo.Text);
            }
            //
            if (cmb_I_Marca.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una Marca Por Favor","Gestion Ventas",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoProducto.CodigoMarca = Int32.Parse(cmb_I_Marca.SelectedValue.ToString());
            }
            if (cmb_I_Familia.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una Familia del Producto Por Favor","Gestion Ventas",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoProducto.CodigoFamilia = Int32.Parse(cmb_I_Familia.SelectedValue.ToString());
            }
            if (cmb_I_Categoria.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una Categoria del Producto Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoProducto.CodigoCategoria = Int32.Parse(cmb_I_Categoria.SelectedValue.ToString());
            }
            if (cmb_I_Unidad.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una Unidad del Producto Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoProducto.CodigoUnidad = Int32.Parse(cmb_I_Unidad.SelectedValue.ToString());
            }
            if (txt_I_TiempoGarantia.Text == string.Empty)
            {
                objetoProducto.TiempoGarantia = "-";
            }
            else
            {
                objetoProducto.TiempoGarantia = txt_I_TiempoGarantia.Text;
            }
            if (txt_I_Nombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Nombre del Producto", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoProducto.Nombre = txt_I_Nombre.Text;
            }
            if (_shalong.Producto(1, objetoProducto))
            {
                if (MessageBox.Show("¿Usted desea ingresar la cantidad del Producto " + txt_I_Nombre.Text + "?", "ALMACEN", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Almacen_Productos obj = new Almacen_Productos();
                    obj.ShowDialog();
                }
                if (MessageBox.Show("¿Usted desea ingresar el precio del Producto " + txt_I_Nombre.Text + "?", "PRECIO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Producto_Precio objPrecio = new Producto_Precio();
                    objPrecio.ShowDialog();
                }
                MessageBox.Show("Producto ingreso correctamente","Gestion Ventas",MessageBoxButtons.OK);
                CargarComboBox();
                txt_I_Codigo.Clear();
                txt_I_Nombre.Clear();
                txt_I_TiempoGarantia.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese los datos Correctamente","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ModificarProductos()
        {
            C_Producto objetoProducto = new C_Producto();
            objetoProducto.CodigoBarras = Int32.Parse(txt_M_Codigo.Text);
            objetoProducto.CodigoMarca = Int32.Parse(cmb_M_Marca.SelectedValue.ToString());
            objetoProducto.CodigoFamilia = Int32.Parse(cmb_M_Familia.SelectedValue.ToString());
            objetoProducto.CodigoCategoria = Int32.Parse(cmb_M_Categoria.SelectedValue.ToString());
            objetoProducto.CodigoUnidad = Int32.Parse(cmb_M_Unidad.SelectedValue.ToString());
            objetoProducto.TiempoGarantia = txt_M_TiempoGarantia.Text;
            objetoProducto.Nombre = txt_M_Nombre.Text;
            objetoProducto.CodigoAdministrador = _codigoAdministrador;
            objetoProducto.Observacion = _observacion;
            if (_shalong.Producto(2, objetoProducto))
            {
                MessageBox.Show("Se Modifico correctamente","Gestion Ventas",MessageBoxButtons.OK);
                CargarComboBox();
                txt_E_Nombre.Clear();
                txt_E_Codigo.Clear();
                txt_E_TiempoGarantia.Clear();
            }
            else
            {
                MessageBox.Show("No se modifico Correctamente","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void EliminarProducto()
        {
            C_Producto objetoProducto = new C_Producto();
            objetoProducto.CodigoBarras = Int32.Parse(txt_M_Codigo.Text);
            objetoProducto.CodigoMarca = Int32.Parse(cmb_M_Marca.SelectedValue.ToString());
            objetoProducto.CodigoFamilia = Int32.Parse(cmb_M_Familia.SelectedValue.ToString());
            objetoProducto.CodigoCategoria = Int32.Parse(cmb_M_Categoria.SelectedValue.ToString());
            objetoProducto.CodigoUnidad = Int32.Parse(cmb_M_Unidad.SelectedValue.ToString());
            objetoProducto.TiempoGarantia = txt_M_TiempoGarantia.Text;
            objetoProducto.Nombre = txt_M_Nombre.Text;
            objetoProducto.CodigoAdministrador = _codigoAdministrador;
            objetoProducto.Observacion = _observacion;
            if (_shalong.Producto(3, objetoProducto))
            {
                MessageBox.Show("Se Elimino correctamente","Gestion Ventas",MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("No se elimino Correctamente","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private bool Validar(Control objeto, string nombre, int accion = 0)
        {
            if (!ValidarVacio(objeto, nombre))
                return false;
            switch (accion)
            {
                case 1:
                    {
                        if (!ValidarNumero(objeto, nombre))
                            return false;
                        break;
                    }
                case 2:
                    {
                        if (!ValidarLetra(objeto, nombre))
                            return false;
                        break;
                    }
                case 3:
                    {
                        if (!ValidarLetraNumero(objeto, nombre))
                            return false;
                        break;
                    }

                default:
                    return false;
            }
            return true;
        }
        private bool ValidarVacio(Control objeto, string nombre)
        {
            if (objeto.Text == String.Empty)
            {
                MessageBox.Show("No puede dejar el " + nombre + " vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarNumero(Control objeto, string nombre)
        {
            if (objeto.Text == String.Empty)
            {
                MessageBox.Show("No puede dejar el " + nombre + " vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarLetra(Control objeto, string nombre)
        {
            if (objeto.Text == String.Empty)
            {
                MessageBox.Show("No puede dejar el " + nombre + " vacio");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ValidarLetraNumero(Control objeto, string nombre)
        {
            if (objeto.Text == String.Empty)
            {
                MessageBox.Show("No puede dejar el " + nombre + " vacio");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void txt_I_Codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros");
                e.Handled = true;
                return;
            }
        }
        private void txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (char.IsNumber(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void txt_I_TiempoGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsLetter(e.KeyChar)) || e.KeyChar == '-' || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

    }
}