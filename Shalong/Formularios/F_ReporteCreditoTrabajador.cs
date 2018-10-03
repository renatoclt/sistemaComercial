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
    public partial class F_ReporteCreditoTrabajador : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public F_ReporteCreditoTrabajador(I_Parametros parametros) 
        {
            InitializeComponent();
            CargarDataGridView();
            CargarComboBox();
        }

        public F_ReporteCreditoTrabajador(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros) 
        {
            CargarDataGridView();
            CargarComboBox();
        }

        public F_ReporteCreditoTrabajador()
        {
            InitializeComponent();
            CargarDataGridView();
            CargarComboBox();
        }

        //CARGAR COMBO BOX
        public void CargarComboBox()
        {
            CargarComboBoxTrabajador();
            CargarComboBoxCaja();
        }
        public void CargarComboBoxTrabajador()
        {
            cmb_Trabajador.DisplayMember = "NombreCompleto";
            cmb_Trabajador.ValueMember = "Dni";
            cmb_Trabajador.DataSource = _shalong.UsuarioMostrar();
        }
        public void CargarComboBoxCaja()
        {
            cmb_Caja.DisplayMember = "NombreCaja";
            cmb_Caja.ValueMember = "CodigoCaja";
            cmb_Caja.DataSource = _shalong.CajaMostrar();
        }

        //CARGAR DATA GRID VIEW
        public void CargarDataGridView()
        {
            dgv_Credito.AutoGenerateColumns = false;
            dgv_Credito.DataSource = _shalong.ReporteTrabajadorTodo();
            this.dgv_Credito.Columns["MontoPagar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            this.dgv_Credito.Columns["MontoPagar"].DefaultCellStyle.Format = "0.00##";
        }

        //BOTONES

        private void btn_Trabajador_Click(object sender, EventArgs e)
        {
            if (cmb_Trabajador.SelectedIndex != -1)
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReporteTrabajadorPorTrabajador(Int32.Parse(cmb_Trabajador.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Ingrese un trabajador Por favor");
                CargarDataGridView();
                return;
            }
        }
        private void btn_Caja_Click(object sender, EventArgs e)
        {
            if (cmb_Caja.SelectedIndex != -1)
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReporteTrabajadorPorCaja(Int32.Parse(cmb_Caja.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Ingrese una Caja Por Favor");
                CargarDataGridView();
                return;
            }
        }
        private void btn_Documento_Click(object sender, EventArgs e)
        {
            if (txt_Documento.Text != string.Empty)
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReporteTrabajadorPorDocumento(txt_Documento.Text);
            }
            else
            {
                MessageBox.Show("Ingrese un Número de documento Por Favor");
                CargarDataGridView();
                return;
            }
        }
        private void btn_Voucher_Click(object sender, EventArgs e)
        {
            if (txt_Voucher.Text != string.Empty)
            {
                dgv_Credito.DataSource = null;
                dgv_Credito.DataSource = _shalong.ReporteTrabajdorPorVoucher(txt_Voucher.Text);
            }
            else
            {
                MessageBox.Show("Ingrese un Número de voucher Por favor");
                CargarDataGridView();
                return;
            }
        }

        //eventos
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

        //EXPORTAR
        private void CargarTodoDataGridView()
        {
            dgv_Credito.SelectAll();
            DataObject dataObj = dgv_Credito.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btn_Exportar_Click(object sender, EventArgs e)
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
                CR.Value = "Fecha de Pago";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 7];
                CR.Value = "Entidad Bancaria";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 8];
                CR.Value = "Número de Cuenta";
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

    }
}
