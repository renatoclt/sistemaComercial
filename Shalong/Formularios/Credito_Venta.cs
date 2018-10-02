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
    public partial class Credito_Venta : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoCaja;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Credito_Venta(I_Parametros parametros)
        {
            InitializeComponent();


        }
        public Credito_Venta(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _objetoParametros = objetoParametros;
            CargarDataGridView();
            CargarComboBox();
            _codigoCaja = _objetoParametros.CodigoCaja;
        }
        private void CargarComboBox()
        {
            CargarComboBoxCodigoCredito();
            CargarComboBoxTipoPago();
        }
        private void CargarComboBoxTipoPago()
        {
            cmb_TipoPago.DisplayMember = "Nombre";
            cmb_TipoPago.ValueMember = "Codigo";
            cmb_TipoPago.DataSource = _shalong.TipoPagoMostrar();
        }
        private void CargarComboBoxCodigoCredito()
        {
            cmb_CodigoCredito.DisplayMember = "CodigoCredito";
            cmb_CodigoCredito.ValueMember = "CodigoCredito";
            cmb_CodigoCredito.DataSource = _shalong.CreditoVentaMostrar();
        }
        private void CargarDataGridView()
        {
            dtg_CreditoVenta.AutoGenerateColumns = false;
            dtg_CreditoVenta.DataSource = _shalong.CreditoVentaMostrar();
        }

        private void dtg_CreditoVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtg_CreditoVenta.ClearSelection();
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            C_Pago objetoPago = new C_Pago();
            if (cmb_TipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Pago Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoPago.CodigoTipoPago = Int32.Parse(cmb_TipoPago.SelectedValue.ToString());
            }
            objetoPago.CodigoCaja = _codigoCaja;
            if (cmb_CodigoCredito.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Codigo de Credito Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoPago.CodigoCredito = Int32.Parse(cmb_CodigoCredito.SelectedValue.ToString());
            }
            //
            objetoPago.NumCuenta = " ";
            objetoPago.EntidadBancaria = " ";
            objetoPago.NumVoucher = " ";
            objetoPago.FechaPago = dtp_Fecha.Value;
            if (txt_Monto.Text == String.Empty)
            {
                MessageBox.Show("No deje el monto en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                objetoPago.MontoPagar = 0.0;
            }
            else
            {
                objetoPago.MontoPagar = Double.Parse(txt_Monto.Text);
                if (_shalong.Pago(1, objetoPago))
                {
                    MessageBox.Show("Pago Realizado satisfactoriamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarComboBox();
                    CargarDataGridView();
                }
                else
                {
                    MessageBox.Show("Revise los Datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
           
        }

        private void Credito_Venta_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '.' ) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se Aceptan Números y Puntos", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }


    }
}
