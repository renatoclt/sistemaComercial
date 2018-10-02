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
    public partial class Empresa : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Empresa()
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Empresa(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Empresa(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        } 
        public void CargarComboBox()
        {
            CargarComboBoxEmpresa();
        }
        public void CargarComboBoxEmpresa()
        {
            cmb_M_Empresa.DisplayMember = "Nombre";
            cmb_M_Empresa.ValueMember = "Codigo";
            cmb_M_Empresa.DataSource = _shalong.EmpresaMostrar();
            cmb_E_Empresa.DisplayMember = "Nombre";
            cmb_E_Empresa.ValueMember = "Codigo";
            cmb_E_Empresa.DataSource = _shalong.EmpresaMostrar();
 
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            IngresarEmpresa();
        }
        private void IngresarEmpresa()
        {
            C_Empresa objetoEmpresa = new C_Empresa();
            objetoEmpresa.Nombre = txt_I_Nombre.Text;
            objetoEmpresa.Ruc = txt_I_Ruc.Text;
            objetoEmpresa.Direccion = txt_I_Direccion.Text;
            objetoEmpresa.Telefono = txt_I_Telefono.Text;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (txt_I_Ruc.Text != String.Empty)
                {
                    if (_shalong.Empresa(1, objetoEmpresa))
                    {
                        MessageBox.Show("Se Ingreso la Empresa Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                        CargarComboBox();
                        txt_I_Nombre.Clear();
                        txt_I_Ruc.Clear();
                        txt_I_Direccion.Clear();
                        txt_I_Telefono.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los datos Correctamente","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campo RUC en blanco", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
     
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Empresa.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione Una Empresa Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                return;
            }
            else
            {
                ModificarEmpresa();
            }
        }
        private void ModificarEmpresa()
        {
            C_Empresa objetoEmpresa = new C_Empresa();
            objetoEmpresa.Codigo = Int32.Parse(cmb_M_Empresa.SelectedValue.ToString());
            objetoEmpresa.Nombre = txt_M_Nombre.Text;
            objetoEmpresa.Ruc = txt_M_Ruc.Text;
            objetoEmpresa.Direccion = txt_M_Direccion.Text;
            objetoEmpresa.Telefono = txt_M_Telefono.Text;
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (txt_M_Ruc.Text != String.Empty)
                {
                    if (_shalong.Empresa(2, objetoEmpresa))
                    {
                        MessageBox.Show("Se Modifico correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                        CargarComboBox();
                        /*txt_M_Nombre.Clear();
                        txt_M_Ruc.Clear();*/
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los datos Correctamente", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campo RUC en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmb_M_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Empresa obj = _shalong.EmpresaMostrar1(Int32.Parse(cmb_M_Empresa.SelectedValue.ToString()));
            txt_M_Nombre.Text = "" + obj.Nombre;
            txt_M_Ruc.Text = "" + obj.Ruc;
            txt_M_Direccion.Text = "" + obj.Direccion;
            txt_M_Telefono.Text = "" + obj.Telefono;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Empresa.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Empresa Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                return;
            }
            else
            {
                EliminarEmpresa();
            }
        }
        private void EliminarEmpresa()
        {
            C_Empresa objetoEmpresa = new C_Empresa();
            objetoEmpresa.Codigo = Int32.Parse(cmb_E_Empresa.SelectedValue.ToString());
            objetoEmpresa.Nombre = txt_E_Nombre.Text;
            objetoEmpresa.Ruc = txt_E_Ruc.Text;
            objetoEmpresa.Direccion = txt_E_Direccion.Text;
            objetoEmpresa.Telefono = txt_E_Telefono.Text;
            if (_shalong.Empresa(3, objetoEmpresa))
            {
                MessageBox.Show("Se Elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                /*txt_E_Nombre.Clear();
                txt_E_Ruc.Clear();*/
            }
        }

        private void Cmb_E_Empresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Empresa obj = _shalong.EmpresaMostrar1(Int32.Parse(cmb_E_Empresa.SelectedValue.ToString()));
            txt_E_Nombre.Text = "" + obj.Nombre;
            txt_E_Ruc.Text = "" + obj.Ruc;
            txt_E_Direccion.Text = "" + obj.Direccion;
            txt_E_Telefono.Text = "" + obj.Telefono;
        }

        private void txt_I_Ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txt_I_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }

        private void txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }


    }
}
