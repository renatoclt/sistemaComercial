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
    public partial class Marca : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Marca()
        {
            InitializeComponent();
            CargarCombobox();
        }
        public Marca(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
        }
        public Marca(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarCombobox()
        {
            Cmb_M_Marca.ValueMember = "Codigo";
            Cmb_M_Marca.DisplayMember = "Nombre";
            Cmb_M_Marca.DataSource = _shalong.MarcaMostrar();
            Cmb_E_Marca.ValueMember = "Codigo";
            Cmb_E_Marca.DisplayMember = "Nombre";
            Cmb_E_Marca.DataSource = _shalong.MarcaMostrar();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarMarca();
        }
        private void GuardarMarca()
        {
            C_Marca objetoMarca = new C_Marca();
            objetoMarca.Codigo = 1;
            objetoMarca.Nombre = Txt_I_Nombre.Text;
            //Validaciones validacion = new Validaciones();
            if (Txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.Marca(1, objetoMarca))
                {
                    MessageBox.Show("Ingreso Correcto","Gestion Ventas",MessageBoxButtons.OK);
                    CargarCombobox();
                    Txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Revise los datos","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje en blanco el campo nombre", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Cmb_M_Marca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Marca Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                return;
            }
            else
            {
                ModificarMarca();
            }
        }
        private void ModificarMarca()
        {
            C_Marca objetoMarca = new C_Marca();
            objetoMarca.Codigo = Int32.Parse(Cmb_M_Marca.SelectedValue.ToString());
            objetoMarca.Nombre = Txt_M_Nombre.Text;
            if (Txt_M_Nombre.Text != String.Empty)
            {
                if (_shalong.Marca(2, objetoMarca))
                {
                    MessageBox.Show("Se modifico Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    CargarCombobox();
                    Txt_M_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("No deje el campo nombre en blanco", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Cmb_E_Marca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Marca Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
                return;
            }
            else
            {
                EliminarMarca();
            }
        }
        private void EliminarMarca()
        {
            C_Marca objetoMarca = new C_Marca();
            objetoMarca.Codigo = Int32.Parse(Cmb_E_Marca.SelectedValue.ToString());
            //objetoMarca.Nombre = "";
            if (_shalong.Marca(3, objetoMarca ))
            {
                MessageBox.Show("Se elimino Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
 
        }

        private void Cmb_M_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Marca obj = _shalong.MarcaMostrar1(Int32.Parse(Cmb_M_Marca.SelectedValue.ToString()));
            Txt_M_Nombre.Text = obj.Nombre;
        }

        private void Txt_I_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Txt_M_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Marca_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
