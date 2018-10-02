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
    public partial class Categoria : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        public Categoria()
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Categoria(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
        }
        public Categoria(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        
        private void CargarComboBox()
        {
            cmb_M_Nombre.DisplayMember = "Nombre";
            cmb_M_Nombre.ValueMember = "Codigo";
            cmb_M_Nombre.DataSource = _shalong.CategoriaMostrar();
            cmb_E_Nombre.DisplayMember = "Nombre";
            cmb_E_Nombre.ValueMember = "Codigo";
            cmb_E_Nombre.DataSource = _shalong.CategoriaMostrar();
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }
        private void GuardarCategoria()
        {
            C_Categoria objetoCategoria = new C_Categoria();
            objetoCategoria.Codigo = 1;
            objetoCategoria.Nombre = txt_I_Nombre.Text;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.Categoria(1, objetoCategoria))
                {
                    MessageBox.Show("Ingreso correctamente","Gestion Ventas",MessageBoxButtons.OK);
                    CargarComboBox();
                    txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Error al ingresar categoria","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Categoria obj = _shalong.CategoriaMostrar1(Int32.Parse(cmb_M_Nombre.SelectedValue.ToString()));
            txt_M_Nombre.Text = obj.Nombre;
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Nombre.SelectedIndex != -1)
            {
                modificarCategoria();
            }
            else
            {
                MessageBox.Show("Ingrese una Categoria Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                cmb_M_Nombre.ResetText();
                return;
            }
        }
        private void modificarCategoria()
        {
            C_Categoria objectoCategoria = new C_Categoria();
            objectoCategoria.Nombre = txt_M_Nombre.Text;
            objectoCategoria.Codigo = Int32.Parse(cmb_M_Nombre.SelectedValue.ToString());
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (_shalong.Categoria(2, objectoCategoria))
                {
                    MessageBox.Show("Se modifico correctamente","Gestion Ventas",MessageBoxButtons.OK);
                    CargarComboBox();
                    txt_M_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Error al modificar categoria","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje campos en blanco","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Nombre.SelectedIndex != -1)
            {
                EliminarCategoria();
            }
            else
            {
                MessageBox.Show("Ingrese una Categoria Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                cmb_E_Nombre.ResetText();
                return;
            }
        }
        private void EliminarCategoria()
        {
            C_Categoria objectoCategoria = new C_Categoria();
            objectoCategoria.Nombre = "";
            objectoCategoria.Codigo = Int32.Parse(cmb_E_Nombre.SelectedValue.ToString());
            if (_shalong.Categoria(3, objectoCategoria))
            {
                MessageBox.Show("Se elimino correctamente","Gestion Ventas",MessageBoxButtons.OK);
                CargarComboBox();
            }
            else
            {
                MessageBox.Show("Error al eliminar categoria","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
 
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
