using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Conexion;
using Shalong.Clases;

namespace Shalong.Formularios
{
    public partial class CreditoTrabajador : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoCaja;
        public CreditoTrabajador(C_Parametros objetoParametros)
        {
            InitializeComponent();
            CargarComboBox();
            //_codigoCaja = codigoCaja;
            _codigoCaja = objetoParametros.CodigoCaja;
        }
        public CreditoTrabajador(I_Parametros parametros)
        {
            InitializeComponent();
        }
        public CreditoTrabajador(C_Parametros objetoParametros, double monto)
            : this(objetoParametros)
        {
            if (objetoParametros.TipoTrabajador == "Administrador")
            {
                Txt_CodigoUsuario.Text = "" + objetoParametros.DniUsuario;
                Txt_Dolar.Text = "" + objetoParametros.ValorDolar;
            }
            Txt_CodigoUsuario.Text = "" + objetoParametros.DniUsuario;
            Txt_Monto.Text = monto.ToString();
            Txt_CodigoUsuario.ReadOnly = true;
            Txt_Dolar.ReadOnly = true;

        }
        private void CargarComboBox()
        {
            CargarComboBoxTipoPago();
            CargarComboBoxTipoDocumento();
        }
        private void CargarComboBoxTipoPago()
        {
            Cmb_TipoPago.DisplayMember = "Nombre";
            Cmb_TipoPago.ValueMember = "Codigo";
            Cmb_TipoPago.DataSource = _shalong.TipoPagoMostrar();
        }
        private void CargarComboBoxTipoDocumento()
        {
            Cmb_TipoDocumento.DisplayMember = "Nombre";
            Cmb_TipoDocumento.ValueMember = "Codigo";
            Cmb_TipoDocumento.DataSource = _shalong.TipoDocumentoMostrar();
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarCreditoTrabajador();


        }
        //GUARDA EN LA TABLA CREDITO
        public void GuardarEnCredito()
        {
            C_CreditoTrabajador objCT = new C_CreditoTrabajador();
            objCT.CodigoUsuario = Int32.Parse(Txt_CodigoUsuario.Text);
            objCT.CodigoTipoPago = Int32.Parse(Cmb_TipoPago.SelectedValue.ToString());
            objCT.MontoPrestamo = Double.Parse(Txt_Monto.Text);
            objCT.NumeroDocumento = Txt_nroDocumento.Text;
            objCT.Observacion = Txt_Observacion.Text;
            objCT.CodigoCaja = _codigoCaja;

            C_Credito objCredito = new C_Credito();
            objCredito.CodigoCompra = -1;
            objCredito.CodigoVenta = -1;
            if (_shalong.CodigoTrabajadorCredito(objCT) == 0)
            {
                MessageBox.Show("El Credito Anterior no existe actualmente", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objCredito.CodigoTrabajador = _shalong.CodigoTrabajadorCredito(objCT);
            }
            objCredito.FechaProxPago = DateTime.Now;
            objCredito.TotalDeuda = Double.Parse(Txt_Monto.Text);
            objCredito.Monto = 0.0;
            objCredito.CodigoCaja = _codigoCaja;
            objCredito.CodigoTipoPago = Int32.Parse(Cmb_TipoPago.SelectedValue.ToString());
            if (!_shalong.CreditoCompraVenta(1, objCredito))
            {
                MessageBox.Show("El Credito al Trabajador No se Guardo en Credito Correctamente", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Hide();

        }
        //GUARDAR EN LA TABLA CREDITO TRABAJADOR
        public void GuardarCreditoTrabajador()
        {
            C_CreditoTrabajador objetoCreditoTrabajador = new C_CreditoTrabajador();
            objetoCreditoTrabajador.Codigo = 1;
            if (Txt_CodigoUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Codigo de Usuario Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoCreditoTrabajador.CodigoUsuario = Int32.Parse(Txt_CodigoUsuario.Text);
            }
            objetoCreditoTrabajador.CodigoCaja = _codigoCaja;
            if (Cmb_TipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Pago Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoCreditoTrabajador.CodigoTipoPago = Int32.Parse(Cmb_TipoPago.SelectedValue.ToString());
            }
            if (Cmb_TipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Documento Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoCreditoTrabajador.CodigoTipoDocumento = Int32.Parse(Cmb_TipoDocumento.SelectedValue.ToString());
            }
            objetoCreditoTrabajador.FechaPrestamo = DateTime.Now;
            objetoCreditoTrabajador.MontoPrestamo = Double.Parse(Txt_Monto.Text);
            objetoCreditoTrabajador.NumeroDocumento = Txt_nroDocumento.Text;
            objetoCreditoTrabajador.Observacion = Txt_Observacion.Text;
            if (_shalong.CreditoTrabajador(1, objetoCreditoTrabajador))
            {
                MessageBox.Show("Ingreso Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                GuardarEnCredito();
            }
            else
            {
                MessageBox.Show("Revise los Datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void CreditoTrabajador_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
        private void Txt_CodigoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se Aceptan Números", "Gestion Ventas", MessageBoxButtons.OK);
                e.Handled = true;
                return;
            }
        }
        private void Txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
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
