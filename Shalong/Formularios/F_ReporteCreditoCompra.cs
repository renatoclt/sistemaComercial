using System;
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

    public partial class F_ReporteCreditoCompra : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
     
        public F_ReporteCreditoCompra(I_Parametros parametros)
        {
            InitializeComponent();
            _interfazParametros = parametros;
            CargarDataGridViewTodo();
            CargarComboBox();
        }

        public F_ReporteCreditoCompra(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _interfazParametros = parametros;
            _objetoParametros = objetoParametros;
            CargarDataGridViewTodo();
            CargarComboBox();
        }

        public F_ReporteCreditoCompra() 
        {
            InitializeComponent();
            CargarDataGridViewTodo();
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            CargarComboBoxProveedor();
            CargarComboBoxCaja();
        }
        public void CargarComboBoxProveedor()
        {
            cmb_Proveedor.DisplayMember = "Nombre";
            cmb_Proveedor.ValueMember = "Codigo";
            cmb_Proveedor.DataSource = _shalong.ProveedorMostrar();
        }
        public void CargarComboBoxCaja()
        {
            cmb_Caja.DisplayMember = "NombreCaja";
            cmb_Caja.ValueMember = "CodigoCaja";
            cmb_Caja.DataSource = _shalong.CajaMostrar();
        }

        public void CargarDataGridViewTodo()
        {
            dgv_Credito.AutoGenerateColumns = false;
            dgv_Credito.DataSource = _shalong.ReportePagoTodo();
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            if (cmb_Proveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Proveedor Valido");
                CargarDataGridViewTodo();
            }
            else
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReportePagoPorProveedor(Int32.Parse(cmb_Proveedor.SelectedValue.ToString()));
            }
        }

        private void btn_Caja_Click(object sender, EventArgs e)
        {
            if (cmb_Caja.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Caja Registrada");
                CargarDataGridViewTodo();
            }
            else
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReportePagoPorCaja(Int32.Parse(cmb_Caja.SelectedValue.ToString()));
            }
        }

        private void btn_NDocumento_Click(object sender, EventArgs e)
        {
            if (txt_NDocumento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Número de Documento Por Favor");
                CargarDataGridViewTodo();
            }
            else
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReportePagoPorDocumento(txt_NDocumento.Text);
            }
        }

        private void btn_NVoucher_Click(object sender, EventArgs e)
        {
            if (txt_NVoucher.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Número de Voucher Por Favor");
                CargarDataGridViewTodo();
            }
            else
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReportePagoPorVoucher(txt_NVoucher.Text);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dgv_Credito.DataSource = null;
            dgv_Credito.DataSource = _shalong.ReportePagoPorFechas(dtp_de.Value, dtp_hasta.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exportar();
        }
        public void Exportar()
        {
            if (dgv_Credito.Rows.Count > 0)
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
                CR.Value = "Nombre de Trabajador";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 3];
                CR.Value = "Tipo de Pago";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 4];
                CR.Value = "Nombre de Caja";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 5];
                CR.Value = "Monto Pagado";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 6];
                CR.Value = "Moneda";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 7];
                CR.Value = "Fecha de Pago";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 8];
                CR.Value = "Entidad Bancaria";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 9];
                CR.Value = "Número de Voucher";
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
        private void CargarTodoDataGridView()
        {
            dgv_Credito.SelectAll();
            DataObject dataObj = dgv_Credito.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void txt_NDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || (char.IsLetter(e.KeyChar)) || e.KeyChar == '-' || (char.IsWhiteSpace(e.KeyChar))) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("No se Aceptan Espacios");
                e.Handled = true;
                return;
            }
        }

        private void txt_NVoucher_KeyPress(object sender, KeyPressEventArgs e)
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
