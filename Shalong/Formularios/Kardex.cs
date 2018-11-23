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
    public partial class Kardex : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        string _cod;
       
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public Kardex(I_Parametros parametros)
        {
            InitializeComponent();
            _interfazParametros = parametros;
            CargarCombobox();
            CargarDataGridView(_cod);
        }

        public Kardex(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _interfazParametros = parametros;
            _objetoParametros = objetoParametros;
            CargarCombobox();
            CargarDataGridView(_cod);
        }

        public Kardex()
        {
            InitializeComponent();
            CargarCombobox();
            CargarDataGridView(_cod);
        }
        private void CargarCombobox()
        {
            Cmb_Documento.DisplayMember = "Nombre";
            Cmb_Documento.ValueMember = "CodigoBarras";
            Cmb_Documento.DataSource = _shalong.ProductoMostrar();
        }
        private void Cmb_Documento_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Producto obj = _shalong.ProductoMostrar1(Cmb_Documento.SelectedValue.ToString());
            _cod = obj.CodigoBarras;
            CargarDataGridView(_cod);
        }
        private void CargarDataGridView(string _cod)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _shalong.KardexMostrar(_cod);    
        }

        private void Kardex_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

 
    }
}
