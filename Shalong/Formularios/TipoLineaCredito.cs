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
    public partial class TipoLineaCredito : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public TipoLineaCredito()
        {
            InitializeComponent();
        }
        public TipoLineaCredito(I_Parametros parametros)
        {
            InitializeComponent();
            //CargarComboBox();
        }
        public TipoLineaCredito(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cmb_I_TC.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Dia/Mes/Año Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                GuardarTipoLineaCredito();
            }
        }

        private void GuardarTipoLineaCredito()
        {
            C_TipoLineaCredito objetoLineaCredito = new C_TipoLineaCredito();
            if (Txt_I_Nombre.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Tiempo para la Linea de Credito", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (Cmb_I_TC.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese un Dia/Mes/Año Por Favor","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                if (Cmb_I_TC.SelectedIndex == 0)
                {
                    objetoLineaCredito.Detalle = "Dias";
                    objetoLineaCredito.Nombre = Txt_I_Nombre.Text + " " + "Days";
                    objetoLineaCredito.NombreCompleto = Txt_I_Nombre.Text + " " + "Dias";
                }
                if (Cmb_I_TC.SelectedIndex == 1)
                {
                    objetoLineaCredito.Detalle = "Meses";
                    objetoLineaCredito.Nombre = Txt_I_Nombre.Text + " " + "Months";
                    objetoLineaCredito.NombreCompleto = Txt_I_Nombre.Text + " " + "Meses";
                }
                if (Cmb_I_TC.SelectedIndex == 2)
                {
                    objetoLineaCredito.Detalle = "Años";
                    objetoLineaCredito.Nombre = Txt_I_Nombre.Text + " " + "Years";
                    objetoLineaCredito.NombreCompleto = Txt_I_Nombre.Text + " " + "Años";
                }

                if (_shalong.TipoLineaCredito(1, objetoLineaCredito))
                {
                    MessageBox.Show("Ingreso correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    Txt_I_Nombre.Clear();
                    Cmb_I_TC.ResetText();
                    //CargarComboBox();
                }
                else
                {
                    MessageBox.Show("Error al ingresar Tipo linea credito", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (char.IsNumber(e.KeyChar))) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TipoLineaCredito_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void Txt_I_Nombre_KeyPress_1(object sender, KeyPressEventArgs e)
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
