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
    public partial class NombreCaja : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public NombreCaja(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
        }
        public NombreCaja(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Cmb_I_Almacen.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Almacen", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                return;
            }
            else
            {
                GuardarNombreCaja();
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarNombreCaja();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarNombreCaja();
        }

        private void CargarCombobox()
        {
            CargarComboboxAlmacen();
            CargarComboboxCaja();
        }
        private void CargarComboboxCaja()
        {
            Cmb_M_Nombre.ValueMember = "Codigo";
            Cmb_M_Nombre.DisplayMember = "Nombre";
            Cmb_M_Nombre.DataSource = _shalong.NombreCajaMostrar();
            Cmb_E_Nombre.ValueMember = "Codigo";
            Cmb_E_Nombre.DisplayMember = "Nombre";
            Cmb_E_Nombre.DataSource = _shalong.NombreCajaMostrar();

        }
        private void CargarComboboxAlmacen()
        {

            Cmb_I_Almacen.DisplayMember = "Nombre";
            Cmb_I_Almacen.ValueMember = "Codigo";
            Cmb_I_Almacen.DataSource = _shalong.AlmacenMostrar();
            Cmb_M_Almacen.DisplayMember = "Nombre";
            Cmb_M_Almacen.ValueMember = "Codigo";
            Cmb_M_Almacen.DataSource = _shalong.AlmacenMostrar();
            
        }

        private void GuardarNombreCaja()
        {
            if (Txt_I_Nombre.Text != String.Empty)
            {

                if (_shalong.NombreCaja(1, Txt_I_Nombre.Text, Int32.Parse(Cmb_I_Almacen.SelectedValue.ToString()), 1))
                {
                    MessageBox.Show("Ingreso Correcto","Gestion Ventas", MessageBoxButtons.OK);
                    CargarCombobox();
                }
                else
                {
                    MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        
        private void ModificarNombreCaja()
        {
            if (Txt_M_Nombre.Text != String.Empty && Cmb_M_Nombre.SelectedValue == null)
            {
                if (_shalong.NombreCaja(2, Txt_M_Nombre.Text, Int32.Parse(Cmb_M_Almacen.SelectedValue.ToString()),Int32.Parse(Cmb_M_Nombre.SelectedValue.ToString())))
                {
                    MessageBox.Show("Modifico Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarCombobox();
                }
                else
                {
                    MessageBox.Show("Revise los datos","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EliminarNombreCaja()
        {
            if (_shalong.NombreCaja(3, " ",1, Int32.Parse(Cmb_E_Nombre.SelectedValue.ToString())))
            {
                MessageBox.Show("Elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                this.Limpiar();
            }
            else
            {
                MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (char.IsNumber(e.KeyChar))) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (char.IsNumber(e.KeyChar))) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_NombreCaja obj = _shalong.NombreCajaMostrar1(Int32.Parse(Cmb_M_Nombre.SelectedValue.ToString()));
            Txt_M_Nombre.Text = obj.Nombre;
        }

        private void NombreCaja_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }     
        
        private void Limpiar()
        {
            Txt_I_Nombre.Clear();
            Txt_M_Nombre.Clear();
            Cmb_E_Nombre.ResetText();
            Cmb_M_Nombre.ResetText();

        }
    }
}
