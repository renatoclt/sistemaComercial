using Shalong.Clases;
using Shalong.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shalong.Formularios
{
    public partial class Unidades : Form
    {
        private Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Unidades()
        {
            InitializeComponent();
            CargarComboboxUnidad();
            CargarDataGridView();
        }
         public Unidades(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboboxUnidad();
            CargarDataGridView();
        }
         public Unidades(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarComboboxUnidad()
        {
            Cmb_I_HijoUnidad.ValueMember = "Codigo";
            Cmb_I_HijoUnidad.DisplayMember = "Nombre";
            Cmb_I_HijoUnidad.DataSource = _shalong.UnidadMostrar();
            Cmb_I_PadreUnidad.ValueMember = "Codigo";
            Cmb_I_PadreUnidad.DisplayMember = "Nombre";
            Cmb_I_PadreUnidad.DataSource = _shalong.UnidadMostrar();
            Cmb_M_HijoUnidad.ValueMember = "Codigo";
            Cmb_M_HijoUnidad.DisplayMember = "Nombre";
            Cmb_M_HijoUnidad.DataSource = _shalong.UnidadMostrar();
            Cmb_M_PadreUnidad.ValueMember = "Codigo";
            Cmb_M_PadreUnidad.DisplayMember = "Nombre";
            Cmb_M_PadreUnidad.DataSource = _shalong.UnidadMostrar();
            Cmb_E_HijoUnidad.ValueMember = "Codigo";
            Cmb_E_HijoUnidad.DisplayMember = "Nombre";
            Cmb_E_HijoUnidad.DataSource = _shalong.UnidadMostrar();
            Cmb_E_PadreUnidad.ValueMember = "Codigo";
            Cmb_E_PadreUnidad.DisplayMember = "Nombre";
            Cmb_E_PadreUnidad.DataSource = _shalong.UnidadMostrar();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cmb_I_HijoUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Hijo", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cmb_I_PadreUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Padre", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Guardar();
            }
            
          
        }
        public void Guardar()
        {
            C_UnidadEquivalencias objeto = new C_UnidadEquivalencias();
            objeto.CantidadHijo = Double.Parse(Txt_I_HijoUnidad.Text);
            objeto.CantidadPadre = Double.Parse(Txt_I_PadreUnidad.Text);
            objeto.CodigoHijo = Int32.Parse(Cmb_I_HijoUnidad.SelectedValue.ToString());
            objeto.CodigoPadre = Int32.Parse(Cmb_I_PadreUnidad.SelectedValue.ToString());
            if (_shalong.UnidadEquivalencias(1, objeto))
            {
                MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Cmb_M_HijoUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Hijo", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cmb_M_PadreUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Padre", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else 
            {
                Modificar();
            }
            
        }
        public void Modificar()
        {

            C_UnidadEquivalencias objeto = new C_UnidadEquivalencias();
            objeto.CantidadHijo = Double.Parse(Txt_M_HijoUnidad.Text);
            objeto.CantidadPadre = Double.Parse(Txt_M_PadreUnidad.Text);
            objeto.CodigoHijo = Int32.Parse(Cmb_M_HijoUnidad.SelectedValue.ToString());
            objeto.CodigoPadre = Int32.Parse(Cmb_M_PadreUnidad.SelectedValue.ToString());
            if (_shalong.UnidadEquivalencias(2, objeto))
            {
                MessageBox.Show("Modifico Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Cmb_E_HijoUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Hijo", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Cmb_E_PadreUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Padre", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Eliminar();
            }
            
        }
        public void Eliminar()
        {
            C_UnidadEquivalencias objeto = new C_UnidadEquivalencias();
            objeto.CantidadHijo = 1;
            objeto.CantidadPadre = 1;
            objeto.CodigoHijo = Int32.Parse(Cmb_M_HijoUnidad.SelectedValue.ToString());
            objeto.CodigoPadre = Int32.Parse(Cmb_M_PadreUnidad.SelectedValue.ToString());
            if (_shalong.UnidadEquivalencias(3, objeto))
            {
                MessageBox.Show("Elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
            }
        }
        private void CargarDataGridView()
        {
            dtg_Equivalencias.AutoGenerateColumns = false;
            dtg_Equivalencias.DataSource = _shalong.Unidadesequivalencias();
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
