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
    public partial class ReporteGarantia : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

          public ReporteGarantia(I_Parametros parametros)
        {
            InitializeComponent();
            _interfazParametros = parametros;
;
        }

          public ReporteGarantia(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _interfazParametros = parametros;
            _objetoParametros = objetoParametros;
 
        }
        public ReporteGarantia()
        {
            InitializeComponent();
        }


        private void CargarDatagridview()
        {
            dtg_Garantia.AutoGenerateColumns = false;
            //C_CodigoSerial objetoCodigoSerial = _shalong.GarantiaCodigoSerial(txt_Codigo_serial.Text.ToString());
            //dtg_Garantia.Rows.Add(objetoCodigoSerial.CodigoSerial, objetoCodigoSerial.Factura1, objetoCodigoSerial.Garantia,objetoCodigoSerial.Proveedor1);
            dtg_Garantia.DataSource = _shalong.GarantiaCodigoSerial(txt_Codigo_serial.Text.ToString());
        }
        private void CargarDatagridview2()
        {
            dtg_Garantia.AutoGenerateColumns = false;
            //C_CodigoSerial objetoCodigoSerial = _shalong.GarantiaCodigoVenta(txt_Codigo_Venta.Text.ToString());
            //dtg_Garantia.Rows.Add(objetoCodigoSerial.CodigoSerial, objetoCodigoSerial.Factura1, objetoCodigoSerial.Garantia);
            dtg_Garantia.DataSource = _shalong.GarantiaCodigoVenta(txt_Codigo_Venta.Text.ToString());
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_Venta.Text != String.Empty)
            {
                CargarDatagridview2();
                txt_Codigo_Venta.Clear();
            }

        }

        private void ReporteGarantia_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void btn_Codigo_Click(object sender, EventArgs e)
        {
            if (txt_Codigo_serial.Text != String.Empty)
            {
                C_CodigoSerial objetoSerial = new C_CodigoSerial();
                objetoSerial.CodigoSerial = txt_Codigo_serial.Text;
                if (_shalong.SerialExiste(objetoSerial) == true)
                {
                    CargarDatagridview();
                    txt_Codigo_serial.Clear();
                }
                else
                {
                    MessageBox.Show("El serial no existe");
                    txt_Codigo_serial.Clear();
                    return;
                }
            }
        }
    }
}
