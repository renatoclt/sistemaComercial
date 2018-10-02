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
    public partial class TipoPrecio : Form
    {
        Shalong_Service _Shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public TipoPrecio(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBoxNombre();
        }
        public TipoPrecio(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarComboBoxNombre()
        {
            cmb_M_Nombre.DisplayMember = "Nombre";
            cmb_M_Nombre.ValueMember = "Codigo";
            cmb_M_Nombre.DataSource = _Shalong.TipoPrecioMostrar();
            cmb_E_Nombre.DisplayMember = "Nombre";
            cmb_E_Nombre.ValueMember = "Codigo";
            cmb_E_Nombre.DataSource = _Shalong.TipoPrecioMostrar();   
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarTipoPrecio();
        }
        private void GuardarTipoPrecio()
        {
            C_TipoPrecio objetoTipoPrecio = new C_TipoPrecio();
            objetoTipoPrecio.Codigo = 1;
            objetoTipoPrecio.Nombre = txt_I_Nombre.Text;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (_Shalong.TipoPrecio(1, objetoTipoPrecio))
                {
                    MessageBox.Show("Ingreso correctamente","Gestion Ventas",MessageBoxButtons.OK);
                    CargarComboBoxNombre();
                    txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese los datos Correctamente","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Precio Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarComboBoxNombre();
                return;
            }
            else
            {
                ModificarTipoPrecio();
            }        
        }
        private void ModificarTipoPrecio()
        {
            C_TipoPrecio objetoTipoPrecio = new C_TipoPrecio();
            objetoTipoPrecio.Codigo =  Int32.Parse(cmb_M_Nombre.SelectedValue.ToString());
            objetoTipoPrecio.Nombre = txt_M_Nombre.Text;
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (_Shalong.TipoPrecio(2, objetoTipoPrecio))
                {
                    MessageBox.Show("Se Modifico correctamente","Gestion Ventas",MessageBoxButtons.OK);
                    CargarComboBoxNombre();
                    txt_M_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Ingrese los datos Correctamente","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en Blanco al modificar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Precio Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarComboBoxNombre();
                return;
            }
            else
            {
                EliminarTipoPrecio();
            }
        }
        private void EliminarTipoPrecio()
        {
            C_TipoPrecio objetoTipoPrecio = new C_TipoPrecio();
            objetoTipoPrecio.Codigo = Int32.Parse(cmb_E_Nombre.SelectedValue.ToString());
            objetoTipoPrecio.Nombre = " ";
            if (_Shalong.TipoPrecio(3, objetoTipoPrecio ))
            {
                MessageBox.Show("Se Elimino correctamente","Gestion Ventas",MessageBoxButtons.OK);
                CargarComboBoxNombre();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {               
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {               
                e.Handled = true;
                return;
            }
        }

        private void TipoPrecio_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
