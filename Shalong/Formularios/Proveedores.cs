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
    public partial class Proveedores : Form
    {
        Shalong_Service _Shalong = new Shalong_Service();
        int _codigoProveedor;
        int _flag;

        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Proveedores(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Proveedores()
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Proveedores(int codigo)
        {
            InitializeComponent();
            CargarComboBox();
            _codigoProveedor = codigo;
            CargarDataGridViewExternoModificar(_codigoProveedor);
        }
        public Proveedores(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }

        //CARGAR COMBOBOX
        private void CargarComboBox()
        {
            CargarComboBoxLineaCredito();
            CargarComboBoxProveedores();
        }
        private void CargarComboBoxProveedores()
        {
            Cmb_M_Proveedores.DisplayMember = "Nombre";
            Cmb_M_Proveedores.ValueMember = "Codigo";
            Cmb_M_Proveedores.DataSource = _Shalong.ProveedorMostrar();
            Cmb_E_Proveedores.DisplayMember = "Nombre";
            Cmb_E_Proveedores.ValueMember = "Codigo";
            Cmb_E_Proveedores.DataSource = _Shalong.ProveedorMostrar();

        }
        private void CargarComboBoxLineaCredito()
        {
            CargarLineaCreditoIngresar();
            CargarLineaCreditoModificar();
            CargarLineaCreditoEliminar();
        }
        private void CargarLineaCreditoModificar()
        {
            Cmb_M_TipoProveedor.DisplayMember = "NombreCompleto";
            Cmb_M_TipoProveedor.ValueMember = "Codigo";
            Cmb_M_TipoProveedor.DataSource = _Shalong.TipoLineaCreditoMostrar();
        }
        private void CargarLineaCreditoEliminar()
        {
            Cmb_E_TipoProveedor.DisplayMember = "NombreCompleto";
            Cmb_E_TipoProveedor.ValueMember = "Codigo";
            Cmb_E_TipoProveedor.DataSource = _Shalong.TipoLineaCreditoMostrar();
        }
        private void CargarLineaCreditoIngresar()
        {
            Cmb_I_TipoProveedor.DisplayMember = "NombreCompleto";
            Cmb_I_TipoProveedor.ValueMember = "Codigo";
            Cmb_I_TipoProveedor.DataSource = _Shalong.TipoLineaCreditoMostrar();
        }

        //CARGAR DATAGRIDVIEW
        private void CargarDataGridViewExternoModificar(int codigo)
        {
            Gv_M_Contactos.AutoGenerateColumns = false;
            Gv_M_Contactos.DataSource = _Shalong.TrabajadorProveedorDGV(codigo);
        }

        private void CargarDataGridViewModificar()
        {
            Gv_M_Contactos.AutoGenerateColumns = false;
            Gv_M_Contactos.DataSource = _Shalong.TrabajadorProveedorDGV(Int32.Parse(Cmb_M_Proveedores.SelectedValue.ToString()));
        }
        private void CargarDataGridViewElimnar()
        {
            Gv_E_Contactos.AutoGenerateColumns = false;
            Gv_E_Contactos.DataSource = _Shalong.TrabajadorProveedorDGV(Int32.Parse(Cmb_E_Proveedores.SelectedValue.ToString()));
        }

        // BOTONES 
        private void Btn_I_Guardar_Click(object sender, EventArgs e)
        {
            Guardar_Proveedor();
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarProveedor();
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor();
        }
        private void Btn_AgregarLineaCredito_Click(object sender, EventArgs e)
        {
            TipoLineaCredito obj = new TipoLineaCredito();
            obj.ShowDialog();
            CargarComboBoxLineaCredito();
        }

        //FUNCIONES
        private void Guardar_Proveedor()
        {
            C_Proveedor oProveedor = new C_Proveedor();
            //INGRESO DE LINEA DE CREDITO
            if (Cmb_I_TipoProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una Linea de Credito", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                oProveedor.CodigoTipoLineaCredito = Int32.Parse(Cmb_I_TipoProveedor.SelectedValue.ToString());
            }
            //INGRESO DE RUC
            if (Txt_I_RUC.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Ruc Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                oProveedor.RUC = Txt_I_RUC.Text;
            }
            //MONTO MAXIMO PRESTAMO
            if (Txt_I_Monto.Text == string.Empty)
            {
                Txt_I_Monto.Text = "0.0";
                oProveedor.MontoPrestamo = Double.Parse(Txt_I_Monto.Text);
            }
            else
            {
                oProveedor.MontoPrestamo = Double.Parse(Txt_I_Monto.Text);
            }
            //CUENTA AHORROS EN SOLES
            if (Txt_I_CuentasSoles.Text == string.Empty)
            {
                oProveedor.CuentasSoles = " ";
            }
            else
            {
                oProveedor.CuentasSoles = Txt_I_CuentasSoles.Text;
            }
            //CUENTA AHORROS EN DOLARES
            if (Txt_I_CuentasDolares.Text == string.Empty)
            {
                oProveedor.CuentaDolares = " ";
            }
            else
            {
                oProveedor.CuentaDolares = Txt_I_CuentasDolares.Text;
            }
            //PAGINA WEB
            if (Txt_I_PaginaWeb.Text == string.Empty)
            {
                oProveedor.PaginaWeb = " ";
            }
            else
            {
                oProveedor.PaginaWeb = Txt_I_PaginaWeb.Text;
            }
            //TELEFONO
            if (Txt_I_Telefono.Text == string.Empty)
            {
                Txt_I_Telefono.Text = "0";
                oProveedor.Telefono = Int32.Parse(Txt_I_Telefono.Text);
            }
            else
            {
                oProveedor.Telefono = Int32.Parse(Txt_I_Telefono.Text);
            }
            //DIRECCION
            if (Txt_I_Direccion.Text == string.Empty)
            {
                oProveedor.Direccion = " ";
            }
            else
            {
                oProveedor.Direccion = Txt_I_Direccion.Text;
            }
            //NOMBRE
            if (Txt_I_Nombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Nombre Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                oProveedor.Nombre = Txt_I_Nombre.Text;
            }
            //LLAMAR AL SERVICE
            if (_Shalong.Proveedor(1, oProveedor))
            {

                if (MessageBox.Show("¿Usted desea ingresar trabajadores del Proveedor " + Txt_I_Nombre.Text + "?", "Trabajadores del Proveedor", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Trabajador_Proveedor obj = new Trabajador_Proveedor();
                    obj.ShowDialog();
                    LimpiarProveedores();
                    CargarComboBox();
                }
                else
                {
                    MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);
                    LimpiarProveedores();
                    CargarComboBox();
                }

            }
            else
            {
                MessageBox.Show("Error al ingresar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void ModificarProveedor()
        {
            C_Proveedor oProveedor = new C_Proveedor();
            if (Cmb_M_Proveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Proveedor a Modificar Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                oProveedor.Codigo = Int32.Parse(Cmb_M_Proveedores.SelectedValue.ToString());
            }
            if (Txt_M_Nombre.Text == string.Empty)
            {
                oProveedor.Nombre = " ";
            }
            else
            {
                oProveedor.Nombre = Txt_M_Nombre.Text;
            }
            if (Cmb_M_TipoProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese una Linea de Credito", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                oProveedor.CodigoTipoLineaCredito = Int32.Parse(Cmb_M_TipoProveedor.SelectedValue.ToString());
            }
            //CUENTA AHORROS EN SOLES
            if (Txt_I_CuentasSoles.Text == string.Empty)
            {
                oProveedor.CuentasSoles = " ";
            }
            else
            {
                oProveedor.CuentasSoles = Txt_I_CuentasSoles.Text;
            }
            //CUENTA AHORROS EN DOLARES
            if (Txt_I_CuentasDolares.Text == string.Empty)
            {
                oProveedor.CuentaDolares = " ";
            }
            else
            {
                oProveedor.CuentaDolares = Txt_I_CuentasDolares.Text;
            }
            //DIRECCION
            if (Txt_I_Direccion.Text == string.Empty)
            {
                oProveedor.Direccion = " ";
            }
            else
            {
                oProveedor.Direccion = Txt_I_Direccion.Text;
            }
            //TELEFONO
            if (Txt_I_Telefono.Text == string.Empty)
            {
                Txt_I_Telefono.Text = "0";
                oProveedor.Telefono = Int32.Parse(Txt_I_Telefono.Text);
            }
            else
            {
                oProveedor.Telefono = Int32.Parse(Txt_I_Telefono.Text);
            }
            //INGRESO DE RUC
            if (Txt_I_RUC.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Ruc Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                oProveedor.RUC = Txt_I_RUC.Text;
            }
            //PAGINA WEB
            if (Txt_I_PaginaWeb.Text == string.Empty)
            {
                oProveedor.PaginaWeb = " ";
            }
            else
            {
                oProveedor.PaginaWeb = Txt_I_PaginaWeb.Text;
            }
            //MONTO MAXIMO PRESTAMO
            if (Txt_I_Monto.Text == string.Empty)
            {
                Txt_I_Monto.Text = "0.0";
                oProveedor.MontoPrestamo = Double.Parse(Txt_I_Monto.Text);
            }
            else
            {
                oProveedor.MontoPrestamo = Double.Parse(Txt_I_Monto.Text);
            }
            if (_Shalong.Proveedor(2, oProveedor))
            {
                MessageBox.Show("Modificacion Correcta", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("Error al modificar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EliminarProveedor()
        {
            C_Proveedor oProveedor = new C_Proveedor();
            if (Cmb_E_Proveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Proveedor para Elimnar Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                oProveedor.Codigo = Int32.Parse(Cmb_E_Proveedores.SelectedValue.ToString());
            }
            oProveedor.Nombre = Txt_E_Nombre.Text;
            oProveedor.CodigoTipoLineaCredito = Int32.Parse(Cmb_E_TipoProveedor.SelectedValue.ToString());
            oProveedor.CuentaDolares = Txt_E_CuentasDolares.Text;
            oProveedor.CuentasSoles = Txt_E_CuentasSoles.Text;
            oProveedor.Direccion = Txt_E_Direccion.Text;
            oProveedor.Telefono = Int32.Parse(Txt_E_Telefono.Text);
            oProveedor.RUC = Txt_E_RUC.Text;
            oProveedor.PaginaWeb = Txt_E_PaginaWeb.Text;
            oProveedor.MontoPrestamo = Double.Parse(Txt_E_Monto.Text);
            if (_Shalong.Proveedor(3, oProveedor))
            {
                MessageBox.Show("Se elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                this.LimpiarProveedoresEliminados();
            }
            else
            {
                MessageBox.Show("Error al eliminar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LimpiarProveedores()
        {
            
            Txt_I_Nombre.Clear();
            Txt_I_RUC.Clear();
            Txt_I_Direccion.Clear();
            Txt_I_Telefono.Text = "0";
            Txt_I_PaginaWeb.Clear();
            Txt_I_CuentasSoles.Clear();
            Txt_I_CuentasDolares.Clear();
            Cmb_I_TipoProveedor.SelectedIndex = -1;
            Cmb_I_TipoProveedor.ResetText();
            Txt_I_Monto.Text = "0.0";
        }
        public void LimpiarProveedoresEliminados()
        {
            Txt_E_Nombre.Clear();
            Txt_E_RUC.Clear();
            Txt_E_Direccion.Clear();
            Txt_E_Telefono.Text = "0";
            Txt_E_PaginaWeb.Clear();
            Txt_E_CuentasSoles.Clear();
            Txt_E_CuentasDolares.Clear();
            Cmb_E_TipoProveedor.SelectedIndex = -1;
            Cmb_E_TipoProveedor.ResetText();
            Cmb_E_Proveedores.SelectedIndex = -1;
            Cmb_E_Proveedores.ResetText();
            Txt_E_Monto.Clear();
            Txt_M_Nombre.Clear();
            Txt_M_RUC.Clear();
            Txt_M_Direccion.Clear();
            Txt_M_Telefono.Text = "0";
            Txt_M_PaginaWeb.Clear();
            Txt_M_CuentasSoles.Clear();
            Txt_M_CuentasDolares.Clear();
            Cmb_M_TipoProveedor.SelectedIndex = -1;
            Cmb_M_TipoProveedor.ResetText();
            Cmb_M_Proveedores.SelectedIndex = -1;
            Cmb_M_Proveedores.ResetText();
            Txt_M_Monto.Clear();
            Gv_E_Contactos.DataSource = null;
            Gv_M_Contactos.DataSource = null;
        }


        //COMBOBOX MODIFICAR Y ELIMINAR
        private void Cmb_E_Proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_E_Proveedores.SelectedValue != null){
                C_Proveedor obj = _Shalong.ProveedorMostrar1(Int32.Parse(Cmb_E_Proveedores.SelectedValue.ToString()));
                Txt_E_CuentasDolares.Text = obj.CuentaDolares;
                Txt_E_CuentasSoles.Text = obj.CuentasSoles;
                Txt_E_Direccion.Text = obj.Direccion;
                Txt_E_Nombre.Text = obj.Nombre;
                Txt_E_PaginaWeb.Text = obj.PaginaWeb;
                Txt_E_RUC.Text = obj.RUC;
                Txt_E_Telefono.Text = "" + obj.Telefono;
                Txt_E_Monto.Text = "" + obj.MontoPrestamo;
                Cmb_E_TipoProveedor.SelectedValue = obj.CodigoTipoLineaCredito;
                CargarDataGridViewElimnar();
            }
            
        }
        private void Cmb_M_Proveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_M_Proveedores.SelectedValue != null)
            {
                C_Proveedor obj = _Shalong.ProveedorMostrar1(Int32.Parse(Cmb_M_Proveedores.SelectedValue.ToString()));
                Txt_M_CuentasDolares.Text = obj.CuentaDolares;
                Txt_M_CuentasSoles.Text = obj.CuentasSoles;
                Txt_M_Direccion.Text = obj.Direccion;
                Txt_M_Nombre.Text = obj.Nombre;
                Txt_M_PaginaWeb.Text = obj.PaginaWeb;
                Txt_M_RUC.Text = obj.RUC;
                Txt_M_Telefono.Text = "" + obj.Telefono;
                Txt_M_Monto.Text = "" + obj.MontoPrestamo;
                Cmb_M_TipoProveedor.SelectedValue = obj.CodigoTipoLineaCredito;
                CargarDataGridViewModificar();
            }
        }

        // OTROS
        private void Txt_I_RUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
        private void Txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void Txt_M_RUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
        private void Txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        private void Txt_I_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
        private void Txt_I_PaginaWeb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || e.KeyChar == '.') && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten número, letras y puntos", "Gestion Ventas", MessageBoxButtons.OK);

                e.Handled = true;
                return;
            }
        }


        private void Proveedores_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void Btn_M_Trabajadores_Click(object sender, EventArgs e)
        {
            if (Cmb_M_Proveedores.SelectedIndex != -1)
            {
                _flag = 1;
                _codigoProveedor = Int32.Parse(Cmb_M_Proveedores.SelectedValue.ToString());
                Trabajador_Proveedor obj = new Trabajador_Proveedor(_codigoProveedor, _flag);
                obj.ShowDialog();

            }
        }

        private void Btn_E_Trabajadores_Click(object sender, EventArgs e)
        {
            if (Cmb_E_Proveedores.SelectedIndex != -1)
            {
                _flag = 2;
                _codigoProveedor = Int32.Parse(Cmb_E_Proveedores.SelectedValue.ToString());
                Trabajador_Proveedor obj = new Trabajador_Proveedor(_codigoProveedor, _flag);
                obj.ShowDialog();
            }
        }

        private void Btn_M_LineaCredito_Click(object sender, EventArgs e)
        {
            TipoLineaCredito obj = new TipoLineaCredito();
            obj.ShowDialog();
            CargarComboBoxLineaCredito();
        }




    }
}
