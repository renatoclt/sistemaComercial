using Shalong.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Clases;

namespace Shalong.Formularios
{
    public partial class Serial_Producto : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoVenta ;
        string _garantia;
        public Serial_Producto(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBoxProducto();
        }
        public Serial_Producto(int codigo, int codigoVenta,string garantia)
        {
            InitializeComponent();
            CargarComboBoxProducto();
            cmb_Producto.SelectedValue = codigo;
            _codigoVenta = codigoVenta;
            _garantia = garantia;
        }
        public Serial_Producto(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
        }
        private void CargarComboBoxProducto()
        {
            cmb_Producto.DisplayMember = "Nombre";
            cmb_Producto.ValueMember = "CodigoBarras";
            cmb_Producto.DataSource = _shalong.ProductoMostrar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_Producto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Producto Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                CargarComboBoxProducto();
                return;
            }
            else
            {
                Guardar();
            }
            
        }
        public void Guardar()
        {
            C_CodigoSerial objetoCodigoSerial = new C_CodigoSerial();
            C_SerialProducto objetoSerialProducto = new C_SerialProducto();
            objetoCodigoSerial.Garantia = _garantia;
            objetoCodigoSerial.CodigoVenta = _codigoVenta;
            bool flag = true;
                foreach (DataGridViewRow row in dtg_Serial.Rows)
                {
                    if (row.Cells["Serial"].Value != null)
                    {
                        objetoCodigoSerial.CodigoSerial = row.Cells["Serial"].Value.ToString();
                        objetoSerialProducto.Serial = row.Cells["Serial"].Value.ToString();

                        if (_shalong.CodigoSerieExiste(objetoSerialProducto) == true)
                        {
                            flag = false;
                            if (_shalong.SerialExiste(objetoCodigoSerial) == false)
                            {
                                flag = false;
                                if (!_shalong.CodigoSerial(1, objetoCodigoSerial))
                                {
                                    MessageBox.Show("Error al ingresar el serial numero " + (row.Index + 1));
                                    _shalong.CodigoSerial(3, objetoCodigoSerial);
                                    return;
                                }
                            }
                            else 
                            {
                                MessageBox.Show("Codigo existente");
                            }
                        }
                        else 
                        {
                            MessageBox.Show("No existe ese codigo");
                        }
                }
                    if (flag)
                    {
                        MessageBox.Show("Ingreso Correctamente codigo serial", "Gestion Ventas", MessageBoxButtons.OK);
                    }
                this.Hide();
            }  
            
        }

        private void Serial_Producto_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
