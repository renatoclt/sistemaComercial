﻿using System;
using Shalong.Clases;
using Shalong.Conexion;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shalong.Formularios
{
    public partial class F_ReporteCreditoVenta : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public F_ReporteCreditoVenta(I_Parametros parametros)
        {
            InitializeComponent();
            _interfazParametros = parametros;
            CargarDataGridView();
            CargarCombobox(); 
        }

        public F_ReporteCreditoVenta(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _interfazParametros = parametros;
            _objetoParametros = objetoParametros;
            CargarDataGridView();
            CargarCombobox();
        }

        public F_ReporteCreditoVenta()
        {
            InitializeComponent();
            CargarDataGridView();
            CargarCombobox();
        }

        //CARGAR COMBOBOX
        public void CargarCombobox()
        {
            CargarComboBoxCaja();
            CargarComboBoxCliente();
        }
        public void CargarComboBoxCaja()
        {
            cmb_Caja.DisplayMember = "NombreCaja";
            cmb_Caja.ValueMember = "CodigoCaja";
            cmb_Caja.DataSource = _shalong.CajaMostrar();
        }
        public void CargarComboBoxCliente()
        {
            cmb_Cliente.DisplayMember = "NombreCompleto";
            cmb_Cliente.ValueMember = "Codigo";
            cmb_Cliente.DataSource = _shalong.ClienteMostrar();
        }

        //CARGAR DATAGRIDVIEW
        public void CargarDataGridView()
        {
            dgv_Pagos.AutoGenerateColumns = false;
            dgv_Pagos.DataSource = _shalong.ReporteVentaTodo();
        }
        private void CargarTodoDataGridView()
        {
            dgv_Pagos.SelectAll();
            DataObject dataObj = dgv_Pagos.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        //BOTONES
        private void button2_Click(object sender, EventArgs e)
        {
            if (cmb_Caja.SelectedIndex == -1)
            {
                CargarTodoDataGridView();
                MessageBox.Show("Ingrese un nombre de caja valido");
                return;

            }
            else
            {
                dgv_Pagos.DataSource = null;
                dgv_Pagos.DataSource = _shalong.ReporteVentaPorCaja(Int32.Parse(cmb_Caja.SelectedValue.ToString()));
            }
        }
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            if (cmb_Cliente.SelectedIndex == -1)
            {
                CargarTodoDataGridView();
                MessageBox.Show("Ingrese un nombre de cliente valido");
                return;

            }
            else
            {
                dgv_Pagos.DataSource = null;
                dgv_Pagos.DataSource = _shalong.ReporteVentaPorCliente(Int32.Parse(cmb_Cliente.SelectedValue.ToString()));
            }
        }
        private void btn_Fecha_Click(object sender, EventArgs e)
        {
            dgv_Pagos.DataSource = null;
            dgv_Pagos.DataSource = _shalong.ReporteVentaPorFechas(dtp_de.Value, dtp_hasta.Value);
        }
        private void btn_Documento_Click(object sender, EventArgs e)
        {
            if (txt_Documento.Text == string.Empty)
            {
                CargarTodoDataGridView();
                MessageBox.Show("Ingrese un Número de Documento");
                return;

            }
            else
            {
                dgv_Pagos.DataSource = null;
                dgv_Pagos.DataSource = _shalong.ReporteVentaPorDocumento(txt_Documento.Text);
            }

        }
        private void btn_Voucher_Click(object sender, EventArgs e)
        {
            if (txt_Voucher.Text == string.Empty)
            {
                CargarTodoDataGridView();
                MessageBox.Show("Ingrese un Número de Voucher ");
                return;

            }
            else
            {
                dgv_Pagos.DataSource = null;
                dgv_Pagos.DataSource = _shalong.ReporteVentaPorVoucher(txt_Voucher.Text);
            }

        }

        //EXPORTAR
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
        public void Exportar()
        {
            if (dgv_Pagos.Rows.Count > 0)
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
                CR.Value = "Número de Documento";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 2];
                CR.Value = "Número de Voucher";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 3];
                CR.Value = "Nombre de Caja";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 4];
                CR.Value = "Tipo de Pago";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 5];
                CR.Value = "Cliente";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 6];
                CR.Value = "Número de Cuenta";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 7];
                CR.Value = "Entidad Bancaria";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 8];
                CR.Value = "Monto Pagado";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 9];
                CR.Value = "Fecha de Pago";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();

            }
            else
            {
                MessageBox.Show("No hay Registros Para Exportar");
                return;
            }
        }

        //EVENTOS
        private void txt_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsLetter(e.KeyChar)) || e.KeyChar == '-' || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("No se Aceptan Espacios");
                e.Handled = true;
                return;
            }
        }
        private void txt_Voucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsLetter(e.KeyChar)) || e.KeyChar == '-' || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("No se Aceptan Espacios");
                e.Handled = true;
                return;
            }
        }


    }
}
