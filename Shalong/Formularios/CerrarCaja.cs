using Shalong.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Clases;
using Shalong.Formularios;

namespace Shalong.Formularios
{
    public partial class CerrarCaja : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        double _valorDolar;
        int _codigoDolar;
        double _total;
        int _codigoCaja;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public CerrarCaja(I_Parametros parametros)
        {
            InitializeComponent();

            //this.AutoScaleMode = AutoScaleMode.None;  
            _interfazParametros = parametros;
        }
        public CerrarCaja(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _objetoParametros = objetoParametros;
            _codigoCaja = objetoParametros.CodigoCaja;
            CargarValorDolar();
            CargarDataGridView();
            CargarMontos();
            Total();
        }

        private void CargarMontos()
        {
            Txt_Egresos.Text = String.Format("{0:0.00}", _shalong.CajaEgresos(_codigoCaja));
            Txt_Ingresos.Text = String.Format("{0:0.00}", _shalong.CajaIngresos(_codigoCaja));
            Txt_TotalDia.Text = String.Format("{0:0.00}", Double.Parse(Txt_Ingresos.Text) - Double.Parse(Txt_Egresos.Text));
            Txt_Efectivo.Text = String.Format("{0:0.00}", _shalong.CajaEfectivo(_codigoCaja));
        }
        //cargamos el gridview con las denominaciones de la moneda
        private void CargarDataGridView()
        {
            CargarDataGridViewBilletaje();
            CargarDataGridViewIngresos();
            CargarDataGridViewEgresos();
        }

        private void CargarDataGridViewIngresos()
        {
            dtg_Ingresos.AutoGenerateColumns = false;
            dtg_Ingresos.DataSource = _shalong.CajaIngresosTipoPago(_codigoCaja);
        }

        private void CargarDataGridViewEgresos()
        {
            dtg_Egresos.AutoGenerateColumns = false;
            dtg_Egresos.DataSource = _shalong.CajaEgresosTipoPago(_codigoCaja);
        }

        private void CargarDataGridViewBilletaje()
        {
            dtg_Billetaje.AutoGenerateColumns = false;
            dtg_Billetaje.DataSource = _shalong.BilletajeMostrar();
        }

        private void CargarValorDolar()
        {
            _valorDolar = _shalong.TipoCambioDiario();
            _codigoDolar = _shalong.TipoCambioCodigo();
            Txt_Dolar.Text = "" + _valorDolar;
        }

        private void Total()
        {
            //almacenaremos el valor de todo el gridview
            _total = 0;
            //si el dolar no tiene valor
            try
            {
                _valorDolar = Double.Parse(Txt_Dolar.Text);
            }
            catch
            {
                _valorDolar = 0.0;
            }
            //recorremos el gridview y sumamos el valor
            foreach (DataGridViewRow row in dtg_Billetaje.Rows)
            {
                if (row.Cells["Moneda"].Value.ToString().Contains("S/."))
                {
                    _total = _total + (Double.Parse(row.Cells["Valor"].Value.ToString()) * Double.Parse(row.Cells["Cantidad"].Value.ToString()));
                }
                else
                {
                    _total = _total + ((Double.Parse(row.Cells["Valor"].Value.ToString()) * Double.Parse(row.Cells["Cantidad"].Value.ToString())) * _valorDolar);
                }
            }
            Txt_Total.Text = String.Format("{0:0.00}", _total);
            if (Txt_Total.Text == Txt_Efectivo.Text)
            {
                Btn_CerrarCaja.Enabled = true;
            }
            else
            {
                Btn_CerrarCaja.Enabled = false;
            }
        }

        private void dtg_Billetaje_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Billetaje.CurrentRow.Cells[e.ColumnIndex].ReadOnly)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void dtg_Billetaje_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Total();
        }

        private void dtg_Billetaje_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ingrese solo numeros");
        }

        private void Btn_Cuadrar_Click(object sender, EventArgs e)
        {
            double monto = 0;
            monto = Double.Parse(Txt_Efectivo.Text) - Double.Parse(Txt_Total.Text);
            CreditoTrabajador objetoCreditoTrabajador = new CreditoTrabajador(_objetoParametros,monto);
            objetoCreditoTrabajador.Show();
            CargarDataGridView();
            CargarMontos();
            Total();
        }

        private void Btn_CerrarCaja_Click(object sender, EventArgs e)
        {
            C_Caja objetoCaja = new C_Caja();
            objetoCaja.CodigoCaja = _codigoCaja;
            objetoCaja.SaldoFinal = Double.Parse(Txt_Total.Text);
            if (_shalong.CajaCerrar(objetoCaja))
            {
                C_BilletajeCaja objetoBilletajeCaja = new C_BilletajeCaja();
                objetoBilletajeCaja.CodigoCaja = _codigoCaja;
                objetoBilletajeCaja.Accion = 2;
                _shalong.BilletajeCajaBorrar(_codigoCaja, 2);
                foreach (DataGridViewRow row in dtg_Billetaje.Rows)
                {
                    objetoBilletajeCaja.CodigoBilletaje = Int32.Parse(row.Cells["Codigo"].Value.ToString());
                    objetoBilletajeCaja.Cantidad = Int32.Parse(row.Cells["Cantidad"].Value.ToString());
                    if (!_shalong.BilletajeCajaGuardar(objetoBilletajeCaja))
                    {
                        MessageBox.Show("Error al ingresar el billetaje intenlo de nuevo","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                if (MessageBox.Show("Cerro caja", "Gestion Ventas", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    this.Close();
                }
                _objetoParametros.CodigoCaja = 0;
                _objetoParametros.CodigoAlmacen = 0;
                _objetoParametros.NombreAlmacen = " ";
                _objetoParametros.EstadoCaja = false;
                _interfazParametros.SetParametros(_objetoParametros);
            }
            else
            {
                MessageBox.Show("Error al Cerrar Caja","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void CerrarCaja_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

    }
}
