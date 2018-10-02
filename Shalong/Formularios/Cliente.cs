using Shalong.Conexion;
using Shalong.Clases;
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
    public partial class Cliente : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        public Cliente()
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Cliente(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
         public Cliente(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarComboBox() 
        {
            CargarComboboxCliente();
        }
        private void CargarComboboxCliente()
        {
            cmb_M_Nombre.DisplayMember = "Nombre";
            cmb_M_Nombre.ValueMember = "Codigo";
            cmb_M_Nombre.DataSource = _shalong.ClienteMostrar();
            cmb_E_Nombre.DisplayMember = "Nombre";
            cmb_E_Nombre.ValueMember = "Codigo";
            cmb_E_Nombre.DataSource = _shalong.ClienteMostrar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            IngresarCliente();
        }
 
        private void IngresarCliente()
        {
            C_Cliente objetoCliente = new C_Cliente();
            objetoCliente.Nombre = txt_I_Nombre.Text;
            objetoCliente.Dni = txt_I_Dni.Text;
            objetoCliente.Apellido_paterno = txt_I_APaterno.Text;
            objetoCliente.Apellido_materno = txt_I_AMaterno.Text;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (txt_I_Dni.Text != String.Empty)
                {
                    if (_shalong.Cliente(1, objetoCliente))
                    {
                        MessageBox.Show("Se Ingreso al Cliente Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                        CargarComboBox();
                        txt_I_Nombre.Clear();
                        txt_I_Dni.Clear();
                        txt_I_APaterno.Clear();
                        txt_I_AMaterno.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los datos Correctamente", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campo DNI en blanco", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }          
        }
       

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Cliente Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                return;
            }
            else
            {
                ModificarCliente();
            }
        }
        private void ModificarCliente()
        {
            C_Cliente objetoCliente = new C_Cliente();
            objetoCliente.Codigo = Int32.Parse(cmb_M_Nombre.SelectedValue.ToString());
            objetoCliente.Nombre = txt_M_Nombre.Text;
            objetoCliente.Dni = txt_M_Dni.Text;
            objetoCliente.Apellido_paterno = txt_M_APaterno.Text;
            objetoCliente.Apellido_materno = txt_M_AMaterno.Text;
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (txt_M_Dni.Text != String.Empty)
                {

                    if (_shalong.Cliente(2, objetoCliente))
                    {
                        MessageBox.Show("Se Modifico correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                        CargarComboBox();
                        /*txt_M_Nombre.Clear();
                        txt_M_Dni.Clear();
                        txt_M_APaterno.Clear();
                        txt_M_AMaterno.Clear();*/
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los datos Correctamente", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campo DNI en blanco", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
             
        }
        private void cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
           C_Cliente obj = _shalong.ClienteMostrar1(Int32.Parse(cmb_M_Nombre.SelectedValue.ToString()));
           
           txt_M_Nombre.Text = "" + obj.Nombre;
           txt_M_Dni.Text = "" + obj.Dni;
           txt_M_APaterno.Text = "" + obj.Apellido_paterno;
           txt_M_AMaterno.Text = "" + obj.Apellido_materno;

        }


        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Cliente Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                EliminarCliente();
            }
        }
        private void EliminarCliente()
        {
            C_Cliente objetoCliente = new C_Cliente();
            objetoCliente.Codigo = Int32.Parse(cmb_E_Nombre.SelectedValue.ToString());
            objetoCliente.Dni = txt_E_Dni.Text;
            objetoCliente.Apellido_paterno = txt_E_APaterno.Text;
            objetoCliente.Apellido_materno = txt_E_AMaterno.Text;
            if (_shalong.Cliente(3, objetoCliente))
            {
                MessageBox.Show("Se Elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                /*txt_E_Dni.Clear();
                txt_E_APaterno.Clear();
                txt_E_AMaterno.Clear();*/
            }            
        }

        private void cmb_E_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Cliente obj = _shalong.ClienteMostrar1(Int32.Parse(cmb_E_Nombre.SelectedValue.ToString()));
            txt_E_Dni.Text = "" + obj.Dni;
            txt_E_APaterno.Text = "" + obj.Apellido_paterno;
            txt_E_AMaterno.Text = "" + obj.Apellido_materno;
            
        }

        private void txt_I_Dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros");
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Dni_KeyPress(object sender, KeyPressEventArgs e)
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
            if (!(char.IsLetter(e.KeyChar)|| char.IsPunctuation(e.KeyChar)) &&(e.KeyChar != (char)Keys.Space) && (e.KeyChar !=(char)Keys.Back)) 
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)|| char.IsPunctuation(e.KeyChar)) &&(e.KeyChar != (char)Keys.Space) && (e.KeyChar !=(char)Keys.Back)) 
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_I_APaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_I_AMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back)) 
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_M_APaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back)) 
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_M_AMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back)) 
            {
                e.Handled = true;
                return;
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
