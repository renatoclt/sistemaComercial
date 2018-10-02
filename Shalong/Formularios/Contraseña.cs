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
    public partial class Contraseña : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        public Contraseña(C_Parametros objetoParametros)
        {

            InitializeComponent();
            if (objetoParametros.TipoTrabajador == "Administrador")
            {
                txt_Usuario.Text = "" + objetoParametros.DniUsuario;
                txt_Contraseña.Select();
            }
        }
         public Contraseña(I_Parametros parametros)
        {
            InitializeComponent();

        }
         public Contraseña(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            txt_Usuario.Text = "" + objetoParametros.DniUsuario;
            txt_Contraseña.Select();
        }
        int _codigoAdministrador;
        string _observacion;
        string _tipoTrabajador;

        public string TipoTrabajador
        {
            get { return _tipoTrabajador; }
            set { _tipoTrabajador = value; }
        }
        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }
        public int CodigoAdministrador
        {
            get { return _codigoAdministrador; }
            set { _codigoAdministrador = value; }
        }

        private void Contraseña_Load(object sender, EventArgs e)
        {
            //centrar formulario
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            C_Contraseña obj = new C_Contraseña();
            if (txt_Usuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Usuario Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                _codigoAdministrador = Int32.Parse(txt_Usuario.Text);
            }
            _observacion = txt_Observacion.Text;
            if (_shalong.Auditoria(_codigoAdministrador, txt_Contraseña.Text))
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
                if (_shalong.IngresoAuditoria(1, obj))
                {
                    MessageBox.Show("Ingreso Correcto", "Gestion Ventas", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Revise los datos", "Gestion VEntas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            obj.CodigoAdministrador = Int32.Parse(txt_Usuario.Text);
            obj.Observacion = txt_Observacion.Text;
            //if (_shalong.IngresoAuditoria(1, obj))
            //{
            //    MessageBox.Show("Ingreso Correcto","Gestion Ventas",MessageBoxButtons.OK);

            //}
            //else
            //{
            //    MessageBox.Show("Revise los datos","Gestion VEntas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
