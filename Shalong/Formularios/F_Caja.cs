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
    public partial class F_Caja : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public F_Caja(I_Parametros parametros)
        {
            InitializeComponent();
            _interfazParametros = parametros;
            CargarDataGridView();
            CargarComboBox();
        }

        public F_Caja(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _interfazParametros = parametros;
            _objetoParametros = objetoParametros;
            CargarDataGridView();
            CargarComboBox();
        }
        public F_Caja()
        {
            InitializeComponent();
            CargarDataGridView();
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            CargarComboBoxCaja();
            CargarComboBoxTrabajador();
        }
        public void CargarComboBoxCaja()
        {
            cmb_Caja.DisplayMember = "NombreCaja";
            cmb_Caja.ValueMember = "CodigoCaja";
            cmb_Caja.DataSource = _shalong.CajaMostrar();
        }
        public void CargarComboBoxTrabajador()
        {
            cmb_Trabajador.DisplayMember = "NombreCompleto";
            cmb_Trabajador.ValueMember = "Dni";
            cmb_Trabajador.DataSource = _shalong.UsuarioMostrar();
        }
        public void CargarDataGridView()
        {
            dgv_Caja.AutoGenerateColumns = false;
            dgv_Caja.DataSource = _shalong.ReporteCajaTodo();
        }

        private void btn_Trabajador_Click(object sender, EventArgs e)
        {

            dgv_Caja.DataSource = null;
            dgv_Caja.DataSource = _shalong.ReporteCajaPorTrabajador(Int32.Parse(cmb_Trabajador.SelectedValue.ToString()));
        }

        private void btn_Caja_Click(object sender, EventArgs e)
        {
            dgv_Caja.DataSource = null;
            dgv_Caja.DataSource = _shalong.ReporteCajaPorNombreCaja(Int32.Parse(cmb_Caja.SelectedValue.ToString()));
        }

        private void btn_Fechas_Click(object sender, EventArgs e)
        {
            if (cmb_Por.SelectedIndex == 0)
            {
                dgv_Caja.DataSource = null;
                dgv_Caja.DataSource = _shalong.ReporteCajaPorFechaInicio(dtp_De.Value, dtp_Hasta.Value);
            }
            else if (cmb_Por.SelectedIndex == 1)
            {
                dgv_Caja.DataSource = null;
                dgv_Caja.DataSource = _shalong.ReporteCajaPorFechaCierre(dtp_De.Value, dtp_Hasta.Value);
            }
            else if (cmb_Por.SelectedIndex == 2)
            {
                dgv_Caja.DataSource = null;
                dgv_Caja.DataSource = _shalong.ReporteCajaPorAmbasFechas(dtp_De.Value, dtp_Hasta.Value);
            }
            else if (cmb_Por.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una accion valida");
                cmb_Por.SelectedIndex = -1;
                cmb_Por.ResetText();
                CargarDataGridView();
                return;

            }
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            Exportar();
        }
        private void CargarTodoDataGridView()
        {
            dgv_Caja.SelectAll();
            DataObject dataObj = dgv_Caja.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        public void Exportar()
        {
            if (dgv_Caja.Rows.Count > 0)
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
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 2];
                CR.Value = "Trabajador";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 3];
                CR.Value = "Tipo de Cambio";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 4];
                CR.Value = "Fecha de Apertura";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 5];
                CR.Value = "Fecha de Cierre";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 6];
                CR.Value = "Saldo Inicial";
                CR.Font.Bold = "TRUE";
                CR.Font.Size = "14";
                CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 7];
                CR.Value = "Saldo Final";
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

        private void F_Caja_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
