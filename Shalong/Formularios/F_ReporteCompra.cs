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
    public partial class F_ReporteCompra : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public F_ReporteCompra(I_Parametros parametros) 
        {
            InitializeComponent();
            CargarDataGridView();
            CargarComboBoxProveedor();
            cmb_Proveedor.SelectedIndex = -1;
        }

        public F_ReporteCompra(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros) 
        {
            CargarDataGridView();
            CargarComboBoxProveedor();
            cmb_Proveedor.SelectedIndex = -1;
        }

        public F_ReporteCompra()
        {
            InitializeComponent();
            CargarDataGridView();
            CargarComboBoxProveedor();
            cmb_Proveedor.SelectedIndex = -1;
        }
        public void CargarComboBoxProveedor()
        {
            cmb_Proveedor.DisplayMember = "Nombre";
            cmb_Proveedor.ValueMember = "Codigo";
            cmb_Proveedor.DataSource = _shalong.ProveedorMostrar();
        }
        public void CargarDataGridView()
        {
            dgv_Compra.AutoGenerateColumns = false;
            dgv_Compra.DataSource = null;
            dgv_Compra.DataSource = _shalong.ReporteCompraTodo();
            this.dgv_Compra.Columns["MontoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgv_Compra.Columns["MontoTotal"].DefaultCellStyle.Format = "0.00##";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_Proveedor.SelectedIndex != -1)
            {
                dgv_Compra.DataSource = null;
                dgv_Compra.DataSource = _shalong.ReporteCompraPorProveedor(Int32.Parse(cmb_Proveedor.SelectedValue.ToString()));
            }
            else
            {
                CargarDataGridView();
                cmb_Proveedor.SelectedIndex = -1;
                cmb_Proveedor.ResetText();
            }
        }

        private void btn_BuscarFecha_Click(object sender, EventArgs e)
        {
            if (dtp_De.Value == null && dtp_Hasta.Value == null)
            {
                CargarDataGridView();
                dtp_De.ResetText();
                dtp_Hasta.ResetText();
            }
            else
            {
                dgv_Compra.DataSource = null;
                dgv_Compra.DataSource = _shalong.ReporteCompraPorFechas(dtp_De.Value, dtp_Hasta.Value);
            }
        }

        private void CargarTodoDataGridView()
        {
            dgv_Compra.SelectAll();
            DataObject dataObj = dgv_Compra.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
        public void Exportar()
        {
            if (dgv_Compra.Rows.Count > 0)
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
                CR.Value = "Proveedor";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 2];
                CR.Value = "Tipo de Cambio";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 3];
                CR.Value = "Tipo de Documento";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 4];
                CR.Value = "Moneda";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 5];
                CR.Value = "Fecha de Compra";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 6];
                CR.Value = "Monto Total";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 7];
                CR.Value = "Número de Documento";
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

        private void F_ReporteCompra_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
