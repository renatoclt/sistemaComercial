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
    public partial class Credito_Trabajador : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoCaja;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Credito_Trabajador(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
            CargarDataGridView();

        }
        public Credito_Trabajador(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _codigoCaja = objetoParametros.CodigoCaja;
            _objetoParametros = objetoParametros;

        }
        public Credito_Trabajador(int codigoCaja)
        {
            InitializeComponent();
            CargarCombobox();
            CargarDataGridView();
            _codigoCaja = codigoCaja;
        }
        private void CargarDataGridView()
        {
            dtg_CreditoCompraTrabajador.AutoGenerateColumns = false;
            dtg_CreditoCompraTrabajador.DataSource = _shalong.CreditoTrabajadorMostrar();
        }
        private void CargarCombobox()
        {
            CargarComboBoxCredito();
            CargarComboBoxTipoPago();
        }
        private void CargarComboBoxCredito()
        {
            cmb_CodigoCreditoTrabajador.DisplayMember = "CodigoCredito";
            cmb_CodigoCreditoTrabajador.ValueMember = "CodigoCredito";
            cmb_CodigoCreditoTrabajador.DataSource = _shalong.CreditoTrabajadorMostrar();

        }
        private void CargarComboBoxTipoPago()
        {
            cmb_TipoPagoTrabajador.DisplayMember = "Nombre";
            cmb_TipoPagoTrabajador.ValueMember = "Codigo";
            cmb_TipoPagoTrabajador.DataSource = _shalong.TipoPagoMostrar();
        }

        private void dtg_CreditoCompraTrabajador_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dtg_CreditoCompraTrabajador.ClearSelection();
        }

        private void btn_I_PagoTrabajador_Click(object sender, EventArgs e)
        {
            if (cmb_CodigoCreditoTrabajador.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Codigo de Trabajador Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                cmb_CodigoCreditoTrabajador.ResetText();
                return;
            }
            else
            {
                if (cmb_TipoPagoTrabajador.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Tipo de Pago Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
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
            objetoPago.CodigoCredito = Int32.Parse(cmb_CodigoCreditoTrabajador.SelectedValue.ToString());
            objetoPago.MontoPagar = Double.Parse(txt_I_MontoPagarTrabajador.Text.ToString());
            objetoPago.CodigoTipoPago = Int32.Parse(cmb_TipoPagoTrabajador.SelectedValue.ToString());
            if (txt_I_NumVoucherTrabajador.Text == String.Empty)
            {
                txt_I_NumVoucherTrabajador.Text = "N/E";
                objetoPago.NumVoucher = txt_I_NumVoucherTrabajador.Text;
            }
            else
            {
                objetoPago.NumVoucher = txt_I_NumVoucherTrabajador.Text;
            }
            if (txt_I_NumCuentaTrabajador.Text == String.Empty)
            {
                txt_I_NumCuentaTrabajador.Text = "N/E";
                objetoPago.NumCuenta = txt_I_NumCuentaTrabajador.Text;
            }
            else
            {
                objetoPago.NumCuenta = txt_I_NumCuentaTrabajador.Text;
            }
            if (txt_I_EntidadBancariaTrabajador.Text == String.Empty)
            {
                txt_I_EntidadBancariaTrabajador.Text = "N/E";
                objetoPago.EntidadBancaria = txt_I_EntidadBancariaTrabajador.Text;
            }
            else
            {
                objetoPago.EntidadBancaria = txt_I_EntidadBancariaTrabajador.Text;
            }
            objetoPago.CodigoCaja = _codigoCaja;
            objetoPago.FechaPago = dtp_ProxPagoTrabajador.Value;
            if (_shalong.Pago(1, objetoPago))
            {
                MessageBox.Show("Ingreso Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                CargarDataGridView();
            }
            else
            {
                MessageBox.Show("Revise Los Datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_IngresoCredito_Click_1(object sender, EventArgs e)
        {
            CreditoTrabajador obj = new CreditoTrabajador(_objetoParametros);
             obj.ShowDialog();
        }

        private void Credito_Trabajador_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void txt_I_MontoPagarTrabajador_KeyPress(object sender, KeyPressEventArgs e)
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
