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
            if (Cmb_I_TipoTrabajador.SelectedIndex == -1)
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
            if (Txt_I_Dni.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un DNI", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoUsuario.Dni = Int32.Parse(Txt_I_Dni.Text);
            }
            objetoUsuario.CodigoTipoTrabajador = Int32.Parse(Cmb_I_TipoTrabajador.SelectedValue.ToString());
            objetoUsuario.Password = Txt_I_Password.Text;
            objetoUsuario.Email = Txt_I_CorreoElectronico.Text;
            objetoUsuario.Nombre = Txt_I_Nombre.Text;
            objetoUsuario.ApellidoPaterno = Txt_I_ApellidoPaterno.Text;
            objetoUsuario.ApellidoMaterno = Txt_I_ApellidoMaterno.Text;
            objetoUsuario.FechaNacimiento = dtp_I_FechaNacimiento.Value;
            objetoUsuario.LugarNacimiento = Txt_I_LugarNacimiento.Text;
            objetoUsuario.Direccion = Txt_I_Direccion.Text;
            objetoUsuario.Telefono = Txt_I_Telefono.Text;
            objetoUsuario.FechaInicio = dtp_I_FechaInicio.Value;
            if (_shalong.Usuario(1, objetoUsuario))
            {
                MessageBox.Show("Ingreso correcto", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarComboBox();
                if (MessageBox.Show("¿Usted desea asignar permisos al usuario" + Txt_I_Dni.Text + "que acaba de crear?", "PERMISOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            if (Cmb_M_Dni.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Usuario Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoUsuario.Dni = Int32.Parse(Cmb_M_Dni.SelectedValue.ToString());
            }
            if (Cmb_M_TipoTrabajador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Trabajador Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoUsuario.CodigoTipoTrabajador = Int32.Parse(Cmb_M_TipoTrabajador.SelectedValue.ToString());
            }
            objetoUsuario.Password = Txt_M_Password.Text;
            objetoUsuario.Email = Txt_M_CorreoElectronico.Text;
            objetoUsuario.Nombre = Txt_M_Nombre.Text;
            objetoUsuario.ApellidoPaterno = Txt_M_ApellidoPaterno.Text;
            objetoUsuario.ApellidoMaterno = Txt_M_ApellidoMaterno.Text;
            objetoUsuario.FechaNacimiento = dtp_M_FechaNacimiento.Value;
            objetoUsuario.LugarNacimiento = Txt_M_LugarNacimiento.Text;
            objetoUsuario.Direccion = Txt_M_Direccion.Text;
            objetoUsuario.Telefono = Txt_M_Telefono.Text;
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
            if (Cmb_E_Dni.SelectedIndex == -1)
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
            objetoUsuario.Dni = Int32.Parse(Cmb_E_Dni.SelectedValue.ToString());
            objetoUsuario.CodigoTipoTrabajador = Int32.Parse(Cmb_E_TipoTrabajador.SelectedValue.ToString());
            objetoUsuario.Password = Txt_E_Password.Text;
            objetoUsuario.Email = Txt_E_CorreoElectronico.Text;
            objetoUsuario.Nombre = Txt_E_Nombre.Text;
            objetoUsuario.ApellidoPaterno = Txt_E_ApellidoPaterno.Text;
            objetoUsuario.ApellidoMaterno = Txt_E_ApellidoMaterno.Text;
            objetoUsuario.FechaNacimiento = dtp_E_FechaNacimiento.Value;
            objetoUsuario.LugarNacimiento = Txt_E_LugarNacimiento.Text;
            objetoUsuario.Direccion = Txt_E_Direccion.Text;
            objetoUsuario.Telefono = Txt_E_Telefono.Text;
            objetoUsuario.FechaInicio = dtp_E_FechaInicio.Value;
            if (_shalong.Usuario(3, objetoUsuario))
            {
                MessageBox.Show("Se elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar al usuario", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Limpiar()
        {
            this.Txt_E_ApellidoMaterno.Clear();
            this.Txt_E_ApellidoPaterno.Clear();
            this.Txt_E_CorreoElectronico.Clear();
            this.Txt_E_Direccion.Clear();
            this.Txt_E_LugarNacimiento.Clear();
            this.Txt_E_Nombre.Clear();
            this.Txt_E_Password.Clear();
            this.Txt_E_Telefono.Clear();
            this.Txt_E_CorreoElectronico.Clear();
            this.Cmb_E_TipoTrabajador.ResetText();
            this.Cmb_E_Dni.ResetText();
            this.Txt_M_ApellidoMaterno.Clear();
            this.Txt_M_ApellidoPaterno.Clear();
            this.Txt_M_CorreoElectronico.Clear();
            this.Txt_M_Direccion.Clear();
            this.Txt_M_LugarNacimiento.Clear();
            this.Txt_M_Nombre.Clear();
            this.Txt_M_Password.Clear();
            this.Txt_M_Telefono.Clear();
            this.Txt_M_CorreoElectronico.Clear();
            this.Cmb_M_TipoTrabajador.ResetText();
            this.Cmb_M_Dni.ResetText();
        }


        private void Cmb_M_Dni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Cmb_M_Dni.SelectedValue != null)
                MostrarUnUsuario(Int32.Parse(Cmb_M_Dni.SelectedValue.ToString()));
        }

        private void Cmb_E_Dni_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarUnUsuario(Int32.Parse(Cmb_E_Dni.SelectedValue.ToString()));
        }

        private void CargarComboBox()
        {
            CargarComboBoxUsuario();
            CargarComboBoxTipoUsuario();
        }

        private void CargarComboBoxUsuario()
        {
            Cmb_M_Dni.DisplayMember = "Nombre";
            Cmb_M_Dni.ValueMember = "Dni";
            Cmb_M_Dni.DataSource = _shalong.UsuarioMostrar();
            Cmb_E_Dni.DisplayMember = "Nombre";
            Cmb_E_Dni.ValueMember = "Dni";
            Cmb_E_Dni.DataSource = _shalong.UsuarioMostrar();
        }

        private void CargarComboBoxTipoUsuario()
        {
            Cmb_E_TipoTrabajador.DisplayMember = "Puesto";
            Cmb_E_TipoTrabajador.ValueMember = "Codigo";
            Cmb_E_TipoTrabajador.DataSource = _shalong.TipoTrabajadorMostrar();
            Cmb_I_TipoTrabajador.DisplayMember = "Puesto";
            Cmb_I_TipoTrabajador.ValueMember = "Codigo";
            Cmb_I_TipoTrabajador.DataSource = _shalong.TipoTrabajadorMostrar();
            Cmb_M_TipoTrabajador.DisplayMember = "Puesto";
            Cmb_M_TipoTrabajador.ValueMember = "Codigo";
            Cmb_M_TipoTrabajador.DataSource = _shalong.TipoTrabajadorMostrar();
        }
        

        

        
        private void MostrarUnUsuario(int dni)
        {
            C_Usuario ObjetoUsuario = _shalong.UsuarioMostrar1(dni);
            Cmb_M_TipoTrabajador.SelectedValue = ObjetoUsuario.CodigoTipoTrabajador;
            Txt_M_Nombre.Text = ObjetoUsuario.Nombre;
            Txt_M_ApellidoPaterno.Text = ObjetoUsuario.ApellidoPaterno;
            Txt_M_ApellidoMaterno.Text = ObjetoUsuario.ApellidoMaterno;
            dtp_M_FechaNacimiento.Value = ObjetoUsuario.FechaNacimiento;
            Txt_M_LugarNacimiento.Text = ObjetoUsuario.LugarNacimiento;
            Txt_M_Direccion.Text = ObjetoUsuario.Direccion;
            Txt_M_Telefono.Text = ObjetoUsuario.Telefono;
            dtp_M_FechaInicio.Value = ObjetoUsuario.FechaInicio;
            Txt_M_CorreoElectronico.Text = ObjetoUsuario.Email;
            Txt_M_Password.Text = ObjetoUsuario.Password;
            ///////////////////////////////////////////////////////
            Cmb_E_TipoTrabajador.SelectedValue = ObjetoUsuario.CodigoTipoTrabajador;
            Txt_E_Nombre.Text = ObjetoUsuario.Nombre;
            Txt_E_ApellidoPaterno.Text = ObjetoUsuario.ApellidoPaterno;
            Txt_E_ApellidoMaterno.Text = ObjetoUsuario.ApellidoMaterno;
            dtp_E_FechaNacimiento.Value = ObjetoUsuario.FechaNacimiento;
            Txt_E_LugarNacimiento.Text = ObjetoUsuario.LugarNacimiento;
            Txt_E_Direccion.Text = ObjetoUsuario.Direccion;
            Txt_E_Telefono.Text = ObjetoUsuario.Telefono;
            dtp_E_FechaInicio.Value = ObjetoUsuario.FechaInicio;
            Txt_E_CorreoElectronico.Text = ObjetoUsuario.Email;
            Txt_E_Password.Text = ObjetoUsuario.Password;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void Txt_I_Dni_KeyPress(object sender, KeyPressEventArgs e)
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
