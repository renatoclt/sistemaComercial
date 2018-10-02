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
    public partial class Unidad : Form
    {
        private Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Unidad()
        {
            InitializeComponent();
            CargarCombobox();
        }
        public Unidad(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
        }
        public Unidad(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarCombobox()
        {
            cmb_M_Unidad.ValueMember = "Codigo";
            cmb_M_Unidad.DisplayMember = "Nombre";
            cmb_M_Unidad.DataSource = _shalong.UnidadMostrar();
            cmb_E_Unidad.ValueMember = "Codigo";
            cmb_E_Unidad.DisplayMember = "Nombre";
            cmb_E_Unidad.DataSource = _shalong.UnidadMostrar();
        }
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarUnidad();

        }
        private void GuardarUnidad()
        {
            C_Unidad objetoUnidad = new C_Unidad();
            objetoUnidad.Codigo = 1;
            objetoUnidad.Nombre = txt_I_Nombre.Text;
            objetoUnidad.Simbolo = txt_I_Simbolo.Text;
            if (txt_I_Nombre.Text != String.Empty)
            {
                if (txt_I_Simbolo.Text != String.Empty)
                {
                    if (_shalong.Unidad(1, objetoUnidad))
                    {
                        MessageBox.Show("Ingreso Correcto","Gestion Ventas",MessageBoxButtons.OK);
                        CargarCombobox();
                        txt_I_Nombre.Clear();
                        txt_I_Simbolo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Revise los datos","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campo  Simbolo en blanco","Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No deje el campo nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (cmb_M_Unidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarCombobox();
                return;
            }
            else
            {
                ModificarUnidad();
            }
        }
        private void ModificarUnidad()
        {
            C_Unidad objetoUnidad = new C_Unidad();
            objetoUnidad.Codigo = Int32.Parse(cmb_M_Unidad.SelectedValue.ToString());
            objetoUnidad.Nombre = txt_M_Nombre.Text;
            objetoUnidad.Simbolo = txt_M_Simbolo.Text;
            if (txt_M_Nombre.Text != String.Empty)
            {
                if (txt_M_Simbolo.Text != String.Empty)
                {
                    if (_shalong.Unidad(2, objetoUnidad))
                    {
                        MessageBox.Show("Modificacion Correcta","Gestion Ventas",MessageBoxButtons.OK);
                        CargarCombobox();
                        txt_M_Nombre.Clear();
                        txt_M_Simbolo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("No deje el campo Simbolo en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cmb_M_Unidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = Int32.Parse(cmb_M_Unidad.SelectedValue.ToString());
            C_Unidad obj = _shalong.UnidadMostrar1(codigo);
            txt_M_Nombre.Text = obj.Nombre;
            txt_M_Simbolo.Text = obj.Simbolo;
        }

        private void Cmb_E_Unidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Unidad obj = _shalong.UnidadMostrar1(Int32.Parse(cmb_E_Unidad.SelectedValue.ToString()));
            txt_E_Nombre.Text = obj.Nombre;
            txt_E_Simbolo.Text = obj.Simbolo;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCombobox();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_E_Unidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Unidad Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarCombobox();
                return;
            }
            else
            {
                EliminarUnidad();
            }
        }
        private void EliminarUnidad()
        {
            C_Unidad objetoUnidad = new C_Unidad();
            objetoUnidad.Codigo = Int32.Parse(cmb_E_Unidad.SelectedValue.ToString());
            objetoUnidad.Nombre = txt_E_Nombre.Text;
            objetoUnidad.Simbolo = txt_E_Simbolo.Text;
            if (_shalong.Unidad(3, objetoUnidad))
            {
                MessageBox.Show("Eliminacion Correcta","Gestion Ventas",MessageBoxButtons.OK);
                CargarCombobox();
            }
            else
            {
                MessageBox.Show("No se puede eliminar","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Txt_I_Simbolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt_M_Simbolo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Unidades obj = new Unidades();
            obj.ShowDialog();
        }

        private void Unidad_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }





    }
}
