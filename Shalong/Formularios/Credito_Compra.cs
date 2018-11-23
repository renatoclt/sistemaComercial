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
    public partial class Credito_Compra : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoCaja;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Credito_Compra(I_Parametros parametros)
        {
            InitializeComponent();

        }
        public Credito_Compra(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            CargarDataGridView();
            CargarComboBox();
            _codigoCaja = objetoParametros.CodigoCaja;
        }
        public Credito_Compra(int codigoCaja)
        {
            InitializeComponent();
            CargarDataGridView();
            CargarComboBox();
            _codigoCaja = codigoCaja;
        }
        private void CargarDataGridView()
        {
            dtg_CreditoCompra.AutoGenerateColumns = false;
            dtg_CreditoCompra.DataSource = _shalong.CreditoCompraMostrar();
        }
        private void CargarComboBox()
        {
            CargarComboBoxCredito();
            CargarComboBoxTipoPago();
        }
        private void CargarComboBoxCredito()
        {
            Cmb_CodigoCredito.DisplayMember = "CodigoCredito";
            Cmb_CodigoCredito.ValueMember = "CodigoCredito";
            Cmb_CodigoCredito.DataSource = _shalong.CreditoCompraMostrar();

        }
        private void CargarComboBoxTipoPago()
        {
            Cmb_TipoPago.DisplayMember = "Nombre";
            Cmb_TipoPago.ValueMember = "Codigo";
            Cmb_TipoPago.DataSource = _shalong.TipoPagoMostrar();
        }

        private void dtg_CreditoCompra_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtg_CreditoCompra.ClearSelection();
        }

        private void Btn_I_Pago_Click(object sender, EventArgs e)
        {
            if (Cmb_TipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Pago Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (Cmb_CodigoCredito.SelectedIndex == -1)
                {
                    MessageBox.Show("Ingrese un Codigo de Credito Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    IngresarPago();
                }
            }
        }
        private void IngresarPago()
        {
            C_Pago objetoPago = new C_Pago();
            objetoPago.CodigoPago = 1;
            objetoPago.CodigoCredito = Int32.Parse(Cmb_CodigoCredito.SelectedValue.ToString());

            //objetoPago.MontoPagar = Double.Parse(Txt_I_MontoPagar.Text.ToString());
            objetoPago.CodigoTipoPago = Int32.Parse(Cmb_TipoPago.SelectedValue.ToString());
            objetoPago.NumVoucher = Txt_I_NumVoucher.Text;
            objetoPago.NumCuenta = Txt_I_NumCuenta.Text;
            objetoPago.EntidadBancaria = Txt_I_EntidadBancaria.Text;
            if (Txt_I_MontoPagar.Text == String.Empty)
            {
                MessageBox.Show("No deje el monto en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                objetoPago.MontoPagar = 0.0;
            }
            else 
            {
                objetoPago.MontoPagar = Double.Parse(Txt_I_MontoPagar.Text.ToString());
                if (_shalong.Pago(1, objetoPago))
                {
                    MessageBox.Show("Ingreso Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarComboBox();
                    CargarDataGridView();
                }
                else
                {
                    MessageBox.Show("Revise Los Datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (Txt_I_NumVoucher.Text == String.Empty)
            {
                Txt_I_NumVoucher.Text = "N/E";
                objetoPago.NumVoucher = Txt_I_NumVoucher.Text;
            }
            else
            {
                objetoPago.NumVoucher = Txt_I_NumVoucher.Text;
            }
            if (Txt_I_NumCuenta.Text == String.Empty)
            {
                Txt_I_NumCuenta.Text = "N/E";
                objetoPago.NumCuenta = Txt_I_NumCuenta.Text;
            }
            else
            {
                objetoPago.NumCuenta = Txt_I_NumCuenta.Text;
            }
            if (Txt_I_EntidadBancaria.Text == String.Empty)
            {
                Txt_I_EntidadBancaria.Text = "N/E";
                objetoPago.EntidadBancaria = Txt_I_EntidadBancaria.Text;
            }
            else
            {
                objetoPago.EntidadBancaria = Txt_I_EntidadBancaria.Text;
            }
            objetoPago.CodigoCaja = _codigoCaja;
            objetoPago.FechaPago = dtp_ProxPago.Value;
           
        }

        private void Cmb_CodigoCredito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Credito_Compra_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void Txt_I_MontoPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || e.KeyChar == '.') && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se Aceptan Números y Puntos", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
    }
}
