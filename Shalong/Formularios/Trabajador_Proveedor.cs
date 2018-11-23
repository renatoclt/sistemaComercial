using System;
using Shalong.Clases;
using Shalong.Conexion;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shalong.Formularios
{
    public partial class Trabajador_Proveedor : Form
    {
        Shalong_Service _shalong = new Shalong_Service();

        int _codigoProveedor;
        public Trabajador_Proveedor()
        {
            InitializeComponent();
            CargarComboBox();
            Cmb_I_Proveedor.SelectedIndex = -1;
        }

        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Trabajador_Proveedor(int codigo, int flag)
        {
            if (flag == 1)
            {
                InitializeComponent();
                CargarComboBox();
                _codigoProveedor = codigo;
                Cmb_I_Proveedor.SelectedValue = _codigoProveedor;
                tabControl1.SelectedIndex = 1;
            }
            if (flag == 2)
            {
                InitializeComponent();
                CargarComboBox();
                _codigoProveedor = codigo;
                Cmb_I_Proveedor.SelectedValue = _codigoProveedor;
                tabControl1.SelectedIndex = 2;
            }


        }
        public Trabajador_Proveedor(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Trabajador_Proveedor(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {

        }


        //CARGAR COMBO BOX
        public void CargarComboBox()
        {
            CargarComboBoxProveedor();
            // CargarComboBoxModificar();
            // CargarComboBoxEliminar();
        }
        public void CargarComboBoxProveedor()
        {
            Cmb_I_Proveedor.DisplayMember = "Nombre";
            Cmb_I_Proveedor.ValueMember = "Codigo";
            Cmb_I_Proveedor.DataSource = _shalong.ProveedorMostrar();
        }
        public void CargarComboBoxModificar()
        {
            Cmb_M_Trabajador.DisplayMember = "NombreCompletoTrabajador";
            Cmb_M_Trabajador.ValueMember = "CodigoTrabajadorProveedor";
            Cmb_M_Trabajador.DataSource = _shalong.TrabajadorProveedorMostrar();
        }
        public void CargarComboBoxEliminar()
        {
            Cmb_E_Trabajador.DisplayMember = "NombreCompletoTrabajador";
            Cmb_E_Trabajador.ValueMember = "CodigoTrabajadorProveedor";
            Cmb_E_Trabajador.DataSource = _shalong.TrabajadorProveedorMostrar();
        }
        public void CargarComboBoxPorProveedor()
        {
            if (Cmb_I_Proveedor.SelectedIndex != -1)
            {
                Cmb_M_Trabajador.DataSource = null;
                Cmb_M_Trabajador.DisplayMember = "NombreCompletoTrabajador";
                Cmb_M_Trabajador.ValueMember = "CodigoTrabajadorProveedor";
                Cmb_M_Trabajador.DataSource = _shalong.TrabajdorProveedorPorProveedor(Int32.Parse(Cmb_I_Proveedor.SelectedValue.ToString()));
                Cmb_E_Trabajador.DataSource = null;
                Cmb_E_Trabajador.DisplayMember = "NombreCompletoTrabajador";
                Cmb_E_Trabajador.ValueMember = "CodigoTrabajadorProveedor";
                Cmb_E_Trabajador.DataSource = _shalong.TrabajdorProveedorPorProveedor(Int32.Parse(Cmb_I_Proveedor.SelectedValue.ToString()));
            }
        }


        //FUNCIONES
        public void GuardarIngreso()
        {
            C_TrabajadorProveedor objetoTrabajador = new C_TrabajadorProveedor();
            if (Cmb_I_Proveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Proveedor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                objetoTrabajador.CodigoProveedor = Int32.Parse(Cmb_I_Proveedor.SelectedValue.ToString());
            }
            if (Txt_I_Celular.Text == string.Empty)
            {
                objetoTrabajador.Celular = "";
            }
            else
            {
                objetoTrabajador.Celular = Txt_I_Celular.Text;
            }
            if (Txt_I_Nombre.Text == string.Empty)
            {
                objetoTrabajador.Nombre = "";
            }
            else
            {
                objetoTrabajador.Nombre = Txt_I_Nombre.Text;
            }
            if (Txt_I_AP.Text == string.Empty)
            {
                objetoTrabajador.ApellidoPaterno = "";
            }
            else
            {
                objetoTrabajador.ApellidoPaterno = Txt_I_AP.Text;
            }
            if (Txt_I_AM.Text == string.Empty)
            {
                objetoTrabajador.ApellidoMaterno = "";
            }
            else
            {
                objetoTrabajador.ApellidoMaterno = Txt_I_AM.Text;
            }
            if (_shalong.TrabajadorProveedor(1, objetoTrabajador))
            {
                MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Revise Los Datos Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void ModificarTrabajador()
        {
            C_TrabajadorProveedor objetoTrabajador = new C_TrabajadorProveedor();
            if (Cmb_I_Proveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Un Proveedor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                objetoTrabajador.CodigoProveedor = Int32.Parse(Cmb_I_Proveedor.SelectedValue.ToString());
            }
            if (Txt_M_Celular.Text == string.Empty)
            {
                objetoTrabajador.Celular = "";
            }
            else
            {
                objetoTrabajador.Celular = Txt_M_Celular.Text;
            }
            if (Txt_M_Nombre.Text == string.Empty)
            {
                objetoTrabajador.Nombre = "";
            }
            else
            {
                objetoTrabajador.Nombre = Txt_M_Nombre.Text;
            }
            if (Txt_M_AP.Text == string.Empty)
            {
                objetoTrabajador.ApellidoPaterno = "";
            }
            else
            {
                objetoTrabajador.ApellidoPaterno = Txt_M_AP.Text;
            }
            if (Txt_M_AM.Text == string.Empty)
            {
                objetoTrabajador.ApellidoMaterno = "";
            }
            else
            {
                objetoTrabajador.ApellidoMaterno = Txt_M_AM.Text;
            }
            if (Cmb_M_Trabajador.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Trabajador a Modificar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                objetoTrabajador.CodigoTrabajadorProveedor = Int32.Parse(Cmb_M_Trabajador.SelectedValue.ToString());
            }
            if (_shalong.TrabajadorProveedor(2, objetoTrabajador))
            {
                MessageBox.Show("Modificacion Correcta", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("Revise los datos Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        public void Eliminar()
        {
            C_TrabajadorProveedor objetoTrabajador = new C_TrabajadorProveedor();
            objetoTrabajador.CodigoProveedor = 0;
            objetoTrabajador.Celular = "";
            objetoTrabajador.Nombre = "";
            objetoTrabajador.ApellidoPaterno = "";
            objetoTrabajador.ApellidoMaterno = "";
            if (Cmb_E_Trabajador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Trabajador", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                objetoTrabajador.CodigoTrabajadorProveedor = Int32.Parse(Cmb_E_Trabajador.SelectedValue.ToString());
            }
            if (_shalong.TrabajadorProveedor(3, objetoTrabajador))
            {
                MessageBox.Show("Se elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("No se pudo elimnar correctamente", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        public void Limpiar()
        {
            Txt_I_Celular.Clear();
            Txt_I_Nombre.Clear();
            Txt_I_AP.Clear();
            Txt_I_AM.Clear();
        }
        public void LimpiarModificar()
        {
            Txt_M_Celular.Clear();
            Txt_M_Nombre.Clear();
            Txt_M_AP.Clear();
            Txt_M_AM.Clear();
        }


        //EVENTOS DEL FORMULARIO
        private void Cmb_M_Trabajador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_M_Trabajador.SelectedIndex != -1)
            {
                C_TrabajadorProveedor objMod = _shalong.TrabajadorProveedorMostrar1(Int32.Parse(Cmb_M_Trabajador.SelectedValue.ToString()));
                Txt_M_Celular.Text = "" + objMod.Celular;
                Txt_M_Nombre.Text = "" + objMod.Nombre;
                Txt_M_AP.Text = "" + objMod.ApellidoPaterno;
                Txt_M_AM.Text = "" + objMod.ApellidoMaterno;
            }
        }
        private void Btn_I_Guardar_Click(object sender, EventArgs e)
        {
            GuardarIngreso();
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarTrabajador();
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
            this.Limpiar();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && Cmb_I_Proveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Proveedor Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_I_Proveedor.ResetText();
                Cmb_M_Trabajador.ResetText();
                Cmb_E_Trabajador.ResetText();
                LimpiarModificar();
                tabControl1.SelectedIndex = 0;
                return;
            }
            else if (tabControl1.SelectedIndex == 2 && Cmb_I_Proveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Proveedor Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cmb_I_Proveedor.ResetText();
                Cmb_E_Trabajador.ResetText();
                Cmb_M_Trabajador.ResetText();
                tabControl1.SelectedIndex = 0;
                return;
            }
        }

        private void Cmb_I_Proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarModificar();
            CargarComboBoxPorProveedor();
        }

    }
}
