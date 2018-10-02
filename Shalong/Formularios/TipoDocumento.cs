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
    public partial class TipoDocumento : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public TipoDocumento(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public TipoDocumento(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarComboBox()
        {
            cmb_M_TipoDocumento.DisplayMember = "Nombre";
            cmb_M_TipoDocumento.ValueMember = "Codigo";
            cmb_M_TipoDocumento.DataSource = _shalong.TipoDocumentoMostrar();
            cmb_E_TipoDocumento.DisplayMember = "Nombre";
            cmb_E_TipoDocumento.ValueMember = "Codigo";
            cmb_E_TipoDocumento.DataSource = _shalong.TipoDocumentoMostrar();
 
        }

        private void btn_I_TipoDocumento_Click(object sender, EventArgs e)
        {
            IngresarTipoDocumento();
        }
        private void IngresarTipoDocumento()
        {
            C_TipoDocumento objetoTipoDocumento = new C_TipoDocumento();
            objetoTipoDocumento.Nombre = txt_I_Nombre.Text;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.TipoDocumento(1, objetoTipoDocumento))
                {
                    MessageBox.Show("Ingreso correctamente","Gestion Ventas", MessageBoxButtons.OK);
                    CargarComboBox();
                    //txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Error al ingresar categoria", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmb_M_TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_TipoDocumento obj = _shalong.TipoDocumentoMostrar1(Int32.Parse(cmb_M_TipoDocumento.SelectedValue.ToString()));
            txt_M_Nombre.Text = obj.Nombre;
        }

        private void btn_M_TipoDocumento_Click(object sender, EventArgs e)
        {
            if (cmb_M_TipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Documento Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarComboBox();
                return;
            }
            else
            {
                ModificarTipoDocumento();
            }
        }

        private void ModificarTipoDocumento()
        {
            C_TipoDocumento objetoTipoDocumento = new C_TipoDocumento();
            objetoTipoDocumento.Codigo = Int32.Parse(cmb_M_TipoDocumento.SelectedValue.ToString());
            objetoTipoDocumento.Nombre = txt_M_Nombre.Text;
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (_shalong.TipoDocumento(2, objetoTipoDocumento))
                {
                    MessageBox.Show("Se modifico correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarComboBox();
                }
                else
                {
                    MessageBox.Show("Error al modificar Tipo de Documento","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo en blanco","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void cmb_E_TipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_TipoDocumento obj = _shalong.TipoDocumentoMostrar1(Int32.Parse(cmb_E_TipoDocumento.SelectedValue.ToString()));
        }

        private void btn_E_TipoDocumento_Click(object sender, EventArgs e)
        {
            C_TipoDocumento objetoTipoDocumento = new C_TipoDocumento();
            if (cmb_E_TipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Documento Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarComboBox();
                return;
            }
            else
            {
                objetoTipoDocumento.Codigo = Int32.Parse(cmb_E_TipoDocumento.SelectedValue.ToString());
            }
            if (_shalong.TipoDocumento(3, objetoTipoDocumento))
            {
                MessageBox.Show("Se Elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
                /*txt_E_Nombre.Clear();
                txt_E_Ruc.Clear();*/
            }
            else 
            {
                MessageBox.Show("Error al eliminar", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        private void TipoDocumento_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }




    }
}
