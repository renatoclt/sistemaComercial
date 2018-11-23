using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Conexion;
namespace Shalong.Formularios
{
    public partial class ProductoBusqueda : Form
    {
        Shalong_Service _servicio = new Shalong_Service();
        string _codigoNuevo;

        public string CodigoNuevo
        {
            get { return _codigoNuevo; }
            set { _codigoNuevo = value; }
        }

       
        public ProductoBusqueda()
        {
            InitializeComponent();
            CargarComboBox();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        private void Cerrar()
        {
            _codigoNuevo = Cmb_Nombre.SelectedValue.ToString();
            this.Hide();
        }
        private void CargarComboBox()
        {
            Cmb_Nombre.DataSource = _servicio.ProductoMostrar();
            Cmb_Nombre.DisplayMember = "Nombre";
            Cmb_Nombre.ValueMember = "CodigoBarras";
        }
        private void CargarDataGridView() 
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cmb_Nombre_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
