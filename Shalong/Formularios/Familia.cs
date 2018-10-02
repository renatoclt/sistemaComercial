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
    public partial class Familia : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Familia()
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Familia(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Familia(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarComboBox()
        {
            cmb_M_Nombre.DisplayMember = "Nombre";
            cmb_M_Nombre.ValueMember = "Codigo";
            cmb_M_Nombre.DataSource = _shalong.FamiliaMostrar();
            cmb_E_Nombre.DisplayMember = "Nombre";
            cmb_E_Nombre.ValueMember = "Codigo";
            cmb_E_Nombre.DataSource = _shalong.FamiliaMostrar();
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarFamilia();
        }
        private void GuardarFamilia()
        {
            C_Familia objetoFamilia = new C_Familia();
            objetoFamilia.Nombre = txt_I_Nombre.Text;
            objetoFamilia.Codigo = 1;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.Familia(1, objetoFamilia))
                {
                    MessageBox.Show("Ingreso correctamente","Gestion Ventas",MessageBoxButtons.OK);
                    CargarComboBox();
                    txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Error al ingresar Familia", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Familia Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                return;
            }
            else
            {
                ModificarFamilia();
            }
        }
        private void ModificarFamilia()
        {
            C_Familia objetoFamilia = new C_Familia();
            objetoFamilia.Codigo = Int32.Parse(cmb_M_Nombre.SelectedValue.ToString());
            objetoFamilia.Nombre = txt_M_Nombre.Text;
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (_shalong.Familia(2, objetoFamilia))
                {
                    MessageBox.Show("Se modifico correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarComboBox();
                }
                else
                {
                    MessageBox.Show("Error al modificar familia","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre al modificar en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Familia a Eliminar", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                return;
            }
            else
            {
                EliminarFamilia();
            }
            
        }

        private void EliminarFamilia()
        {
            C_Familia objetoFamilia = new C_Familia();
            objetoFamilia.Codigo = Int32.Parse(cmb_E_Nombre.SelectedValue.ToString());
            objetoFamilia.Nombre = " ";
            if (_shalong.Familia(3, objetoFamilia))
            {
                MessageBox.Show("Se elimino correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                txt_M_Nombre.Clear();
            }
            else
            {
                MessageBox.Show("Error al eliminar familia", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }
        private void Cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Familia obj = _shalong.FamiliaMostrar1(Int32.Parse(cmb_M_Nombre.SelectedValue.ToString()));
            txt_M_Nombre.Text = obj.Nombre;
        }

        private void txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {              
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Familia_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
