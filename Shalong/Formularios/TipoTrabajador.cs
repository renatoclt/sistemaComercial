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
    public partial class TipoTrabajador : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public TipoTrabajador(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
        }
        public TipoTrabajador(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarCombobox()
        {
            cmb_M_Nombre.ValueMember = "Codigo";
            cmb_M_Nombre.DisplayMember = "Puesto";
            cmb_M_Nombre.DataSource = _shalong.TipoTrabajadorMostrar();
            cmb_E_Nombre.ValueMember = "Codigo";
            cmb_E_Nombre.DisplayMember = "Puesto";
            cmb_E_Nombre.DataSource = _shalong.TipoTrabajadorMostrar();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarTipoTrabajador();
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Trabajador Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarCombobox();
                return;
            }
            else
            {
                ModificarTipoTrabajador();
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Trabajador Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarCombobox();
                return;
            }
            else
            {
                EliminarTipoTrabajador();
            }
        }

        private void GuardarTipoTrabajador()
        {
            C_TipoTrabajador objetoTipoTrabajador = new C_TipoTrabajador();
            objetoTipoTrabajador.Puesto = txt_I_Nombre.Text;
            objetoTipoTrabajador.Codigo = 1;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.TipoTrabajador(1, objetoTipoTrabajador))
                {
                    MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarCombobox();
                    txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo en blaco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModificarTipoTrabajador()
        {
            C_TipoTrabajador objetoTipoTrabajador = new C_TipoTrabajador();
            objetoTipoTrabajador.Codigo = Int32.Parse(cmb_M_Nombre.SelectedValue.ToString());
            objetoTipoTrabajador.Puesto = txt_M_Nombre.Text;
            if (_shalong.TipoTrabajador(2, objetoTipoTrabajador))
            {
                MessageBox.Show("Modifico Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                txt_M_Nombre.Clear();
            }
            else
            {
                MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EliminarTipoTrabajador()
        {
            C_TipoTrabajador objetoTipoTrabajador = new C_TipoTrabajador();
            objetoTipoTrabajador.Codigo = Int32.Parse(cmb_E_Nombre.SelectedValue.ToString());
            objetoTipoTrabajador.Puesto = " ";
            if (_shalong.TipoTrabajador(3, objetoTipoTrabajador ))
            {
                MessageBox.Show("Elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
            }
            else
            {
                MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }     

        private void cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_TipoTrabajador obj = _shalong.TipoTrabajadorMostrar1(Int32.Parse(cmb_M_Nombre.SelectedValue.ToString()));
            txt_M_Nombre.Text = obj.Puesto;

        }
         
        private void txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TipoTrabajador_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }



    }
}
