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
    public partial class Usuario : Form
    {

        Shalong_Service _shalong = new Shalong_Service();
        public Usuario()
        {
            InitializeComponent();
            CargarComboBox();
        }
         public Usuario(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();

        }
         public Usuario(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void Btn_I_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_I_TipoTrabajador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Trabajador Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                GuardarUsuario();
            }
        }
        private void GuardarUsuario()
        {
            C_Usuario objetoUsuario = new C_Usuario();
            if (txt_I_Dni.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un DNI", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoUsuario.Dni = Int32.Parse(txt_I_Dni.Text);
            }
            objetoUsuario.CodigoTipoTrabajador = Int32.Parse(cmb_I_TipoTrabajador.SelectedValue.ToString());
            objetoUsuario.Password = txt_I_Password.Text;
            objetoUsuario.Email = txt_I_CorreoElectronico.Text;
            objetoUsuario.Nombre = txt_I_Nombre.Text;
            objetoUsuario.ApellidoPaterno = txt_I_ApellidoPaterno.Text;
            objetoUsuario.ApellidoMaterno = txt_I_ApellidoMaterno.Text;
            objetoUsuario.FechaNacimiento = dtp_I_FechaNacimiento.Value;
            objetoUsuario.LugarNacimiento = txt_I_LugarNacimiento.Text;
            objetoUsuario.Direccion = txt_I_Direccion.Text;
            objetoUsuario.Telefono = txt_I_Telefono.Text;
            objetoUsuario.FechaInicio = dtp_I_FechaInicio.Value;
            if (_shalong.Usuario(1, objetoUsuario))
            {
                MessageBox.Show("Ingreso correcto", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarComboBox();
                if (MessageBox.Show("¿Usted desea asignar permisos al usuario" + txt_I_Dni.Text + "que acaba de crear?", "PERMISOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Permisos obj = new Permisos();
                    obj.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No se pudo Guardar el Usuario Revise los Datos Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarUsuario();
        }

        private void ModificarUsuario()
        {
            C_Usuario objetoUsuario = new C_Usuario();
            if (cmb_M_Dni.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Usuario Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoUsuario.Dni = Int32.Parse(cmb_M_Dni.SelectedValue.ToString());
            }
            if (cmb_M_TipoTrabajador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Trabajador Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoUsuario.CodigoTipoTrabajador = Int32.Parse(cmb_M_TipoTrabajador.SelectedValue.ToString());
            }
            objetoUsuario.Password = txt_M_Password.Text;
            objetoUsuario.Email = txt_M_CorreoElectronico.Text;
            objetoUsuario.Nombre = txt_M_Nombre.Text;
            objetoUsuario.ApellidoPaterno = txt_M_ApellidoPaterno.Text;
            objetoUsuario.ApellidoMaterno = txt_M_ApellidoMaterno.Text;
            objetoUsuario.FechaNacimiento = dtp_M_FechaNacimiento.Value;
            objetoUsuario.LugarNacimiento = txt_M_LugarNacimiento.Text;
            objetoUsuario.Direccion = txt_M_Direccion.Text;
            objetoUsuario.Telefono = txt_M_Telefono.Text;
            objetoUsuario.FechaInicio = dtp_M_FechaInicio.Value;
            if (_shalong.Usuario(2, objetoUsuario))
            {
                MessageBox.Show("Se Modifico el usuario correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("No se pudo modificar el usuario", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Dni.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un usuario para eliminar Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                EliminarUsuario();
            }
        }
        private void EliminarUsuario()
        {
            C_Usuario objetoUsuario = new C_Usuario();
            objetoUsuario.Dni = Int32.Parse(cmb_E_Dni.SelectedValue.ToString());
            objetoUsuario.CodigoTipoTrabajador = Int32.Parse(cmb_E_TipoTrabajador.SelectedValue.ToString());
            objetoUsuario.Password = txt_E_Password.Text;
            objetoUsuario.Email = txt_E_CorreoElectronico.Text;
            objetoUsuario.Nombre = txt_E_Nombre.Text;
            objetoUsuario.ApellidoPaterno = txt_E_ApellidoPaterno.Text;
            objetoUsuario.ApellidoMaterno = txt_E_ApellidoMaterno.Text;
            objetoUsuario.FechaNacimiento = dtp_E_FechaNacimiento.Value;
            objetoUsuario.LugarNacimiento = txt_E_LugarNacimiento.Text;
            objetoUsuario.Direccion = txt_E_Direccion.Text;
            objetoUsuario.Telefono = txt_E_Telefono.Text;
            objetoUsuario.FechaInicio = dtp_E_FechaInicio.Value;
            if (_shalong.Usuario(3, objetoUsuario))
            {
                MessageBox.Show("Se elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar al usuario", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }



        private void cmb_M_Dni_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarUnUsuario(Int32.Parse(cmb_M_Dni.SelectedValue.ToString()));
        }

        private void cmb_E_Dni_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarUnUsuario(Int32.Parse(cmb_E_Dni.SelectedValue.ToString()));
        }

        private void CargarComboBox()
        {
            CargarComboBoxUsuario();
            CargarComboBoxTipoUsuario();
        }

        private void CargarComboBoxUsuario()
        {
            cmb_M_Dni.DisplayMember = "Nombre";
            cmb_M_Dni.ValueMember = "Dni";
            cmb_M_Dni.DataSource = _shalong.UsuarioMostrar();
            cmb_E_Dni.DisplayMember = "Nombre";
            cmb_E_Dni.ValueMember = "Dni";
            cmb_E_Dni.DataSource = _shalong.UsuarioMostrar();
        }

        private void CargarComboBoxTipoUsuario()
        {
            cmb_E_TipoTrabajador.DisplayMember = "Puesto";
            cmb_E_TipoTrabajador.ValueMember = "Codigo";
            cmb_E_TipoTrabajador.DataSource = _shalong.TipoTrabajadorMostrar();
            cmb_I_TipoTrabajador.DisplayMember = "Puesto";
            cmb_I_TipoTrabajador.ValueMember = "Codigo";
            cmb_I_TipoTrabajador.DataSource = _shalong.TipoTrabajadorMostrar();
            cmb_M_TipoTrabajador.DisplayMember = "Puesto";
            cmb_M_TipoTrabajador.ValueMember = "Codigo";
            cmb_M_TipoTrabajador.DataSource = _shalong.TipoTrabajadorMostrar();
        }
        

        

        
        private void MostrarUnUsuario(int dni)
        {
            C_Usuario ObjetoUsuario = _shalong.UsuarioMostrar1(dni);
            cmb_M_TipoTrabajador.SelectedValue = ObjetoUsuario.CodigoTipoTrabajador;
            txt_M_Nombre.Text = ObjetoUsuario.Nombre;
            txt_M_ApellidoPaterno.Text = ObjetoUsuario.ApellidoPaterno;
            txt_M_ApellidoMaterno.Text = ObjetoUsuario.ApellidoMaterno;
            dtp_M_FechaNacimiento.Value = ObjetoUsuario.FechaNacimiento;
            txt_M_LugarNacimiento.Text = ObjetoUsuario.LugarNacimiento;
            txt_M_Direccion.Text = ObjetoUsuario.Direccion;
            txt_M_Telefono.Text = ObjetoUsuario.Telefono;
            dtp_M_FechaInicio.Value = ObjetoUsuario.FechaInicio;
            txt_M_CorreoElectronico.Text = ObjetoUsuario.Email;
            txt_M_Password.Text = ObjetoUsuario.Password;
            ///////////////////////////////////////////////////////
            cmb_E_TipoTrabajador.SelectedValue = ObjetoUsuario.CodigoTipoTrabajador;
            txt_E_Nombre.Text = ObjetoUsuario.Nombre;
            txt_E_ApellidoPaterno.Text = ObjetoUsuario.ApellidoPaterno;
            txt_E_ApellidoMaterno.Text = ObjetoUsuario.ApellidoMaterno;
            dtp_E_FechaNacimiento.Value = ObjetoUsuario.FechaNacimiento;
            txt_E_LugarNacimiento.Text = ObjetoUsuario.LugarNacimiento;
            txt_E_Direccion.Text = ObjetoUsuario.Direccion;
            txt_E_Telefono.Text = ObjetoUsuario.Telefono;
            dtp_E_FechaInicio.Value = ObjetoUsuario.FechaInicio;
            txt_E_CorreoElectronico.Text = ObjetoUsuario.Email;
            txt_E_Password.Text = ObjetoUsuario.Password;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void txt_I_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

       


    }
}
