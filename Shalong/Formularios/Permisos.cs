using Shalong.Conexion;
using Shalong.Clases;
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
    public partial class Permisos : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Permisos(I_Parametros parametros)
        {
            InitializeComponent();
            _interfazParametros = parametros;
            CargarComboBoxUsuario();
            CargarDataGridView();
        }

        public Permisos(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            _interfazParametros = parametros;
            _objetoParametros = objetoParametros;
            CargarComboBoxUsuario();
            CargarDataGridView();
        }

        public Permisos()
        {
            InitializeComponent();
            CargarComboBoxUsuario();
            CargarDataGridView();
        }
        
        private void CargarComboBoxUsuario()
        {
            Cmb_usuario.DisplayMember = "nombreCompleto";
            Cmb_usuario.ValueMember = "Dni";
            Cmb_usuario.DataSource = _shalong.UsuarioMostrar();
        }
        private void CargarDataGridView()
        {
            CardarDataGridViewInicio();
            CardarDataGridViewProductos();
            CardarDataGridViewMaestros();
            CardarDataGridViewReportes();
        }

        private void CardarDataGridViewInicio()
        {
            dtg_Inicio.AutoGenerateColumns = false;
            dtg_Inicio.DataSource = _shalong.MenuMostrar(2, 73020238);
        }
        private void CardarDataGridViewProductos()
        {
            dtg_Productos.AutoGenerateColumns = false;
            dtg_Productos.DataSource = _shalong.MenuMostrar(3, 73020238);
        }
        private void CardarDataGridViewMaestros()
        {

            dtg_Maestros.AutoGenerateColumns = false;
            dtg_Maestros.DataSource = _shalong.MenuMostrar(4, 73020238);
        }
        private void CardarDataGridViewReportes()
        {

            dtg_Reportes.AutoGenerateColumns = false;
            dtg_Reportes.DataSource = _shalong.MenuMostrar(5, 73020238);
        }
        private void chk_Inicio_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Inicio.Checked)
            {
                pnl_Inicio.Enabled = true;
                dtg_Inicio.Enabled = true;
            }
            else
            {
                pnl_Inicio.Enabled = false;
                dtg_Inicio.Enabled = false;
            }
        }

        private void chk_Productos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Productos.Checked)
            {
                Pnl_Productos.Enabled = true;
                dtg_Productos.Enabled = true;
            }
            else
            {
                Pnl_Productos.Enabled = false;
                dtg_Productos.Enabled = false;
            }
        }

        private void chk_Maestros_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Maestros.Checked)
            {
                pnl_Maestros.Enabled = true;
                dtg_Maestros.Enabled = true;
                
            }
            else
            {
                pnl_Maestros.Enabled = false;
                dtg_Maestros.Enabled = false;
            }
        }

        private void chk_Reportes_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Reportes.Checked)
            {
                pnl_Reportes.Enabled = true;
                dtg_Reportes.Enabled = true;
            }
            else
            {
                pnl_Reportes.Enabled = false;
                dtg_Reportes.Enabled = false;
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cmb_usuario.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Usuario Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBoxUsuario();
                return;
            }
            else
            {
                Guardar();
            }
            
        }

        public void Guardar()
        {
            int usuario = Int32.Parse(Cmb_usuario.SelectedValue.ToString());
            _shalong.Menu_Union(2, 2, usuario);
            if (chk_Inicio.Checked)
                _shalong.Menu_Union(1, 2, usuario);
            if (chk_Productos.Checked)
                _shalong.Menu_Union(1, 3, usuario);
            if (chk_Maestros.Checked)
                _shalong.Menu_Union(1, 4, usuario);
            if (chk_Reportes.Checked)
                _shalong.Menu_Union(1, 5, usuario);
            foreach (DataGridViewRow row in dtg_Inicio.Rows)
            {
                bool isCellChecked;
                try
                {
                    isCellChecked = (bool)row.Cells["Permiso"].Value;
                }
                catch
                {
                    isCellChecked = false;
                }
                if (isCellChecked)
                {
                    _shalong.Menu_Union(1, Int32.Parse(row.Cells[0].Value.ToString()), usuario);
                }
            }
            foreach (DataGridViewRow row in dtg_Maestros.Rows)
            {
                bool isCellChecked;
                try
                {
                    isCellChecked = (bool)row.Cells[2].Value;
                }
                catch
                {
                    isCellChecked = false;
                }
                if (isCellChecked)
                {
                    _shalong.Menu_Union(1, Int32.Parse(row.Cells[0].Value.ToString()), usuario);
                }
            }
            foreach (DataGridViewRow row in dtg_Productos.Rows)
            {
                bool isCellChecked;
                try
                {
                    isCellChecked = (bool)row.Cells[2].Value;
                }
                catch
                {
                    isCellChecked = false;
                }
                if (isCellChecked)
                {
                    _shalong.Menu_Union(1, Int32.Parse(row.Cells[0].Value.ToString()), usuario);
                }

            }
            foreach (DataGridViewRow row in dtg_Reportes.Rows)
            {
                bool isCellChecked;
                try
                {
                    isCellChecked = (bool)row.Cells[2].Value;
                }
                catch
                {
                    isCellChecked = false;
                }
                if (isCellChecked)
                {
                    _shalong.Menu_Union(1, Int32.Parse(row.Cells[0].Value.ToString()), usuario);
                }
            }
            MessageBox.Show("Ingreso correctamente los permisos", "Gestion Ventas", MessageBoxButtons.OK);
        }
        private void Permisos_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
