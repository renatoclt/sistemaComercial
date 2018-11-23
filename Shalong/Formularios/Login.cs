using Shalong.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Clases;

namespace Shalong.Formularios
{
    public partial class Login : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        private void Ingresar()
        {
            if (Txt_Usuario.Text != String.Empty && Txt_Contraseña.Text != String.Empty)
            {
                if (_shalong.Login(Int32.Parse(Txt_Usuario.Text), Txt_Contraseña.Text))
                {
                    MessageBox.Show("Ingreso Correcto","Gestion Ventas");                    
                    C_Parametros objetoParametros = new C_Parametros();
                    objetoParametros.DniUsuario = Int32.Parse(Txt_Usuario.Text);
                    objetoParametros.CodigoCaja = 0;
                    objetoParametros.EstadoCaja = false;
                    objetoParametros.ValorDolar = _shalong.TipoCambioDiario();
                    C_Usuario objetoUsuario = _shalong.UsuarioMostrar1(objetoParametros.DniUsuario);
                    /*if (!_shalong.Compañia(objetoUsuario.Compañia))
                    {
                        MessageBox.Show("El tiempo del software ha caducado, contacte a su proveedor","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }*/
                    this.Hide();
                    C_TipoTrabajador objetoTrabajador = _shalong.TipoTrabajadorMostrar1( objetoUsuario.CodigoTipoTrabajador);
                    objetoParametros.TipoTrabajador = "" + objetoTrabajador.Puesto;
                    Principal objetoPrincipal = new Principal(objetoParametros);
                    objetoPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No deje los campos vacios", "Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void Txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                Ingresar();
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        
    }
}
