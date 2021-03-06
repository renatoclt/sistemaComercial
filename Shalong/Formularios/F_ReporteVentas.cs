﻿
using System;
using Shalong.Clases;
using Shalong.Conexion;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shalong.Formularios
{
    public partial class F_ReporteVentas : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public F_ReporteVentas(I_Parametros parametros)
        {
            InitializeComponent();
            _interfazParametros = parametros;
            CargarComboBox();
            CargarDataGridView();
        }

        public F_ReporteVentas(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _interfazParametros = parametros;
            _objetoParametros = objetoParametros;
            CargarComboBox();
            CargarDataGridView();
        }
        public F_ReporteVentas()
        {
            InitializeComponent();
            CargarComboBox();
            CargarDataGridView();
        }
        public void CargarDataGridView()
        {
            this.dgv_Ventas.Columns["TotalVenta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgv_Ventas.Columns["TotalVenta"].DefaultCellStyle.Format = "0.00##";
        }
        private void Cmb_TipoDeVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_TipoDeVenta.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Venta a Buscar Por Favor");
                return;
            }
            else if (Cmb_TipoDeVenta.SelectedIndex == 0)
            {
                dgv_Ventas.AutoGenerateColumns = false;
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentaTodo(0);
            }
            else if (Cmb_TipoDeVenta.SelectedIndex == 1)
            {
                dgv_Ventas.AutoGenerateColumns = false;
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentaTodo(1);
            }
        }
        public void CargarComboBox()
        {
            CargarComboBoxCaja();
            CargarComboBoxTipoPago();
            CargarComboBoxCliente();
            CargarComboBoxEmpresa();
        }
        public void CargarComboBoxCaja()
        {
            Cmb_Caja.DisplayMember = "NombreCaja";
            Cmb_Caja.ValueMember = "CodigoCaja";
            Cmb_Caja.DataSource = _shalong.CajaMostrar();
        }
        public void CargarComboBoxTipoPago()
        {
            Cmb_TipoPago.DisplayMember = "Nombre";
            Cmb_TipoPago.ValueMember = "Codigo";
            Cmb_TipoPago.DataSource = _shalong.TipoPagoMostrar();
        }
        public void CargarComboBoxCliente()
        {
            Cmb_Cliente.DisplayMember = "NombreCompleto";
            Cmb_Cliente.ValueMember = "Codigo";
            Cmb_Cliente.DataSource = _shalong.ClienteMostrar();
        }
        public void CargarComboBoxEmpresa()
        {
            Cmb_Empresa.DisplayMember = "Nombre";
            Cmb_Empresa.ValueMember = "Codigo";
            Cmb_Empresa.DataSource = _shalong.EmpresaMostrar();
        }

        private void Btn_Caja_Click(object sender, EventArgs e)
        {
            if (Cmb_TipoDeVenta.SelectedIndex == 0)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorCaja(0, Int32.Parse(Cmb_Caja.SelectedValue.ToString()));
            }
            else if (Cmb_TipoDeVenta.SelectedIndex == 1)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorCaja(1, Int32.Parse(Cmb_Caja.SelectedValue.ToString()));
            }
        }

        private void Btn_TipoPago_Click(object sender, EventArgs e)
        {
            if (Cmb_TipoDeVenta.SelectedIndex == 0)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorTipoPago(0, Int32.Parse(Cmb_TipoPago.SelectedValue.ToString()));
            }
            else if (Cmb_TipoDeVenta.SelectedIndex == 1)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorTipoPago(1, Int32.Parse(Cmb_TipoPago.SelectedValue.ToString()));
            }
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            if (Cmb_TipoDeVenta.SelectedIndex == 0)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorCliente(0, Int32.Parse(Cmb_Cliente.SelectedValue.ToString()));
            }
            else if (Cmb_TipoDeVenta.SelectedIndex == 1)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorCliente(1, Int32.Parse(Cmb_Cliente.SelectedValue.ToString()));
            }
        }

        private void Btn_Empresa_Click(object sender, EventArgs e)
        {
            if (Cmb_TipoDeVenta.SelectedIndex == 0)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorEmpresa(0, Int32.Parse(Cmb_Empresa.SelectedValue.ToString()));
            }
            else if (Cmb_TipoDeVenta.SelectedIndex == 1)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorEmpresa(1, Int32.Parse(Cmb_Empresa.SelectedValue.ToString()));
            }
        }

        private void Btn_Fecha_Click(object sender, EventArgs e)
        {
            if (Cmb_TipoDeVenta.SelectedIndex == 0)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorFecha(0, dtp_de.Value, dtp_hasta.Value);
            }
            else if (Cmb_TipoDeVenta.SelectedIndex == 1)
            {
                dgv_Ventas.DataSource = null;
                dgv_Ventas.DataSource = _shalong.ReporteVentasPorFecha(1, dtp_de.Value, dtp_hasta.Value);
            }

        }

        private void Btn_Exportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
        private void CargarTodoDataGridView()
        {
            dgv_Ventas.SelectAll();
            DataObject dataObj = dgv_Ventas.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        public void Exportar()
        {
            if (dgv_Ventas.Rows.Count > 0)
            {
                CargarTodoDataGridView();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Value = "Nombre de Caja";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "11";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 2];
                CR.Value = "Nombre de Documento";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "11";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 3];
                CR.Value = "Tipo de Pago";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "11";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 4];
                CR.Value = "Cliente";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "11";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 5];
                CR.Value = "Empresa";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "11";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 6];
                CR.Value = "Numero de Documento";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 7];
                CR.Value = "Fecha de Venta";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "11";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 8];
                CR.Value = "Total de Venta";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "11";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();

            }
            else
            {
                MessageBox.Show("No hay Registros Para Exportar");
                return;
            }
        }

        private void F_ReporteVentas_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }



    }
}
