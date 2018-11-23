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
    public partial class TipoAlmacen : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public TipoAlmacen(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
        }
        public TipoAlmacen(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarTipoAlmacen();
        }

        private void GuardarTipoAlmacen()
        {
            C_TipoAlmacen objetoTipoAlmacen = new C_TipoAlmacen();
            objetoTipoAlmacen.Nombre = Txt_I_Nombre.Text;
            objetoTipoAlmacen.Codigo = 1;
            if (Txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.TipoAlmacen(1, objetoTipoAlmacen))
                {
                    MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarCombobox();
                    Txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo Nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Cmb_M_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarCombobox();
                return;
            }
            else
            {
                ModificarTipoAlmacen();
            }
        }

        private void ModificarTipoAlmacen()
        {
            C_TipoAlmacen objetoTipoAlmacen = new C_TipoAlmacen();
            objetoTipoAlmacen.Codigo = Int32.Parse(Cmb_M_Nombre.SelectedValue.ToString());
            objetoTipoAlmacen.Nombre = Txt_M_Nombre.Text;
            if (Txt_M_Nombre.Text != String.Empty)
            {
                if (_shalong.TipoAlmacen(2, objetoTipoAlmacen))
                {
                    MessageBox.Show("Modifiacion Correcta", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarCombobox();

                }
                else
                {
                    MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No deje el campo Nombre en blanco","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Cmb_E_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Tipo de Almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CargarCombobox();
                return;
            }
            else
            {
                EliminarTipoAlmacen();
            }
        }
        private void EliminarTipoAlmacen()
        {
            C_TipoAlmacen objetoTipoAlmacen = new C_TipoAlmacen();
            objetoTipoAlmacen.Codigo = Int32.Parse(Cmb_E_Nombre.SelectedValue.ToString());
            objetoTipoAlmacen.Nombre = " ";
            if (_shalong.TipoAlmacen(3, objetoTipoAlmacen ))
            {
                MessageBox.Show("Eliminacion Correcta", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
            }
            else
            {
                MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void CargarCombobox()
        {
            CargarComboBoxModificar();
            CargarComboBoxEliminar();
        }
        private void CargarComboBoxModificar()
        {
            Cmb_M_Nombre.DisplayMember = "Nombre";
            Cmb_M_Nombre.ValueMember = "Codigo";
            Cmb_M_Nombre.DataSource = _shalong.TipoAlmacenMostrar();
        }
        private void CargarComboBoxEliminar()
        {
            Cmb_E_Nombre.DisplayMember = "Nombre";
            Cmb_E_Nombre.ValueMember = "Codigo";
            Cmb_E_Nombre.DataSource = _shalong.TipoAlmacenMostrar();
        }

        private void Cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_TipoAlmacen obj = _shalong.TipoAlmacenMostrar1(Int32.Parse(Cmb_M_Nombre.SelectedValue.ToString()));
            Txt_M_Nombre.Text = obj.Nombre;
        }

        private void Txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TipoAlmacen_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }


    }
}
