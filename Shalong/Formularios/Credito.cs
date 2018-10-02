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
    public partial class Credito : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoVenta;
        C_Parametros _objetoParametros;
        public Credito(C_Parametros objetoParametros)
        {
            InitializeComponent();
            CargarComboBox();
            _objetoParametros = objetoParametros;
        }
        public Credito(string numDocumento, Double totalVenta, int codigoCliente, string empresa,int codigoVenta, int codigoCaja)
        {
            InitializeComponent();
            CargarComboBox();
            cmb_SelectCredito.SelectedIndex = 0;
            txt_I_NumDocumento.Text = numDocumento;
            txt_I_TotalDeuda.Text = String.Format("{0:0.00}", totalVenta);
            cmb_I_Proveedor.SelectedValue = codigoCliente;
            cmb_SelectCredito.SelectedIndex = 1;
            _codigoVenta = codigoVenta;
            _objetoParametros = new C_Parametros();
            _objetoParametros.CodigoCaja = codigoCaja;
        }
        public Credito(string numDocumento, Double totalVenta)
        {
            InitializeComponent();
            CargarComboBox();
            cmb_SelectCredito.SelectedIndex = 1;
            txt_I_NumDocumento.Text = numDocumento;
            txt_I_TotalDeuda.Text = String.Format("{0:0.00}", totalVenta);
        }
        public Credito()
        {
            InitializeComponent();
            CargarComboBox();
        }


        public void CargarComboBox()
        {
            CargarComboBoxProveedor();
            cmb_SelectCredito.SelectedIndex = 0;
        }
        public void CargarComboBoxProveedor()
        {
            cmb_I_Proveedor.DisplayMember = "Nombre";
            cmb_I_Proveedor.ValueMember = "Codigo";
            cmb_I_Proveedor.DataSource = _shalong.ProveedorMostrar();
        }
        private void cmb_SelectCredito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_SelectCredito.Text == "Credito de Venta")
            {
                cmb_I_Proveedor.Visible = false;
                lbl_Proveedor.Visible = false;

            }
            else if(cmb_SelectCredito.Text == "Credito de Compra")
            {
                cmb_I_Proveedor.Visible = true;
                lbl_Proveedor.Visible = true;

            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_SelectCredito.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Credito Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                C_Credito objetoCredito = new C_Credito();
                C_Compra objetoCompra = new C_Compra();
                C_Venta objetoVenta = new C_Venta();
                if (cmb_SelectCredito.Text == "Credito de Compra")
                {
                    if (cmb_I_Proveedor.SelectedIndex == -1)
                    {
                        MessageBox.Show("Ingrese un Proveedor Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        objetoCompra.CodigoProveedor = Int32.Parse(cmb_I_Proveedor.SelectedValue.ToString());
                    }
                    objetoCompra.NumeroDocumento = txt_I_NumDocumento.Text;
                    objetoCredito.CodigoCompra = _shalong.CompraCodigo(objetoCompra);
                    objetoCredito.CodigoVenta = -1;
                    MessageBox.Show("Se Ingreso Correctamente el Credito de Compra", "Gestion Ventas", MessageBoxButtons.OK);
                }
                else if (cmb_SelectCredito.Text == "Credito de Venta")
                {
                    objetoVenta.NumeroDocumentoVenta = txt_I_NumDocumento.Text;
                    objetoCredito.CodigoVenta = _codigoVenta;
                    objetoCredito.CodigoCompra = -1;
                    objetoCredito.CodigoTrabajador = -1;
                    objetoCredito.FechaProxPago = dtp_proximoPago.Value;
                    objetoCredito.TotalDeuda = Double.Parse(txt_I_TotalDeuda.Text);
                    objetoCredito.Monto = Double.Parse(txt_I_MontoPagado.Text);
                    objetoCredito.CodigoCaja = _objetoParametros.CodigoCaja;
                    objetoCredito.CodigoTipoPago = 10;
                    _shalong.CreditoCompraVenta(1, objetoCredito);
                    MessageBox.Show("Se Ingreso Correctamente el Credito de Venta", "Gestion Ventas", MessageBoxButtons.OK);
                    this.Hide();
                }
            }
        }

        private void Credito_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

  
    }
}
