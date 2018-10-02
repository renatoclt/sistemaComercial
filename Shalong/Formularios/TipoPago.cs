using System;
using Shalong.Conexion;
using Shalong.Clases;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shalong.Formularios
{
    public partial class TipoPago : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public TipoPago(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public TipoPago(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        public void CargarComboBox()
        {
            cmb_M_Nombre.DisplayMember = "Nombre";
            cmb_M_Nombre.ValueMember = "Codigo";
            cmb_M_Nombre.DataSource = _shalong.TipoPagoMostrar();
            cmb_E_Nombre.DisplayMember = "Nombre";
            cmb_E_Nombre.ValueMember = "Codigo";
            cmb_E_Nombre.DataSource = _shalong.TipoPagoMostrar();
 
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarTipoPago();
        }
        private void GuardarTipoPago()
        {
            C_TipoPago objetoTipoPago = new C_TipoPago();
            objetoTipoPago.Nombre = txt_I_Nombre.Text;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.TipoPago(1, objetoTipoPago))
                {
                    MessageBox.Show("Ingreso correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarComboBox();
                }
                else
                {
                    MessageBox.Show("Error al ingresar Tipo de Pago", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Pago Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarComboBox();
                return;
            }
            else
            {
                ModificarTipoCambio();
            }         
        }

        private void ModificarTipoCambio()
        {
            C_TipoPago objetoTipoPago = new C_TipoPago();
            objetoTipoPago.Codigo = Int32.Parse(cmb_M_Nombre.SelectedValue.ToString());
            objetoTipoPago.Nombre = txt_M_Nombre.Text;
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (_shalong.TipoPago(2, objetoTipoPago))
                {
                    MessageBox.Show("Se modifico correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarComboBox();
                }
                else
                {
                    MessageBox.Show("Error al modificar Tipo de Pago", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Pago Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CargarComboBox();
                return;
            }
            else
            {
                eliminar();
            }
        }
        public void eliminar()
        {
            C_TipoPago objetoTipoPago = new C_TipoPago();
            objetoTipoPago.Codigo = Int32.Parse(cmb_E_Nombre.SelectedValue.ToString());
            objetoTipoPago.Nombre = "";
            if (_shalong.TipoPago(3, objetoTipoPago))
            {
                MessageBox.Show("Se elimino correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("Error al eliminar TipoPago", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_TipoPago obj = _shalong.TipoPagoMostrar1(Int32.Parse(cmb_M_Nombre.SelectedValue.ToString()));
            txt_M_Nombre.Text =" " + obj.Nombre;
        }

        private void cmb_E_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_TipoPago obj = _shalong.TipoPagoMostrar1(Int32.Parse(cmb_E_Nombre.SelectedValue.ToString()));
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

        private void TipoPago_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }



    }
}
