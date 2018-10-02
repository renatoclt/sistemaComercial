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
    public partial class Dolar : Form
    {
        Shalong_Service _Shalong = new Shalong_Service();
        int _codigoAdministrador;
        string _observacion;
        double _valorDolar;
        int _flag;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;

        public Dolar(I_Parametros parametros)
        {
            _flag = 1;
            InitializeComponent();
            tab_TipoCambio.TabPages[1].Enabled = true;
            //Dt_I_Fecha.Enabled = true;
        }
        public Dolar(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            if (objetoParametros.Ok == false)
            {
                _valorDolar = objetoParametros.ValorDolar;
                _objetoParametros = objetoParametros;
                _interfazParametros = parametros;
                if (_valorDolar != 0.00)
                {
                    ComprobarTabSeleccionado(0);
                    tab_TipoCambio.SelectedIndex = 1;
                }
            }
            else if (objetoParametros.Ok == true)
            {
                _valorDolar = objetoParametros.ValorDolar;
                _objetoParametros = objetoParametros;
                _interfazParametros = parametros;
                _codigoAdministrador = objetoParametros.CodigoUsuario;
                if (_valorDolar != 0.00)
                {
                    ComprobarTabSeleccionado(1);
                    tab_TipoCambio.SelectedIndex = 1;
                }
            }

        }

        public Dolar(I_Parametros parametros, C_Parametros objetoParametros, string observacion)
            : this(parametros)
        {
            if (objetoParametros.Ok == false)
            {
                _valorDolar = objetoParametros.ValorDolar;
                _objetoParametros = objetoParametros;
                _interfazParametros = parametros;
                if (_valorDolar != 0.00)
                {
                    ComprobarTabSeleccionado(0);
                    tab_TipoCambio.SelectedIndex = 1;
                }
            }
            else if (objetoParametros.Ok == true)
            {
                _valorDolar = objetoParametros.ValorDolar;
                _objetoParametros = objetoParametros;
                _interfazParametros = parametros;
                _codigoAdministrador = objetoParametros.CodigoUsuario;
                _observacion = observacion;
                if (_valorDolar != 0.00)
                {
                    ComprobarTabSeleccionado(1);
                    tab_TipoCambio.SelectedIndex = 1;
                }
            }

        }
        public Dolar(int codigo, string observacion)
        {
            InitializeComponent();
            _codigoAdministrador = codigo;
            _observacion = observacion;

        }
        public Dolar(int codigo, string observacion, bool isAdministrador)
        {
            _flag = 0;
            InitializeComponent();
            _codigoAdministrador = codigo;
            _observacion = observacion;
            if (!isAdministrador)
            {
                tab_TipoCambio.TabPages[1].Enabled = false;
                //Dt_I_Fecha.Enabled = false;
            }
        }

        private bool ComprobarTabSeleccionado(int tabSeleccionado)
        {
            bool isValido = false;
            if (/*tabSeleccionado == 0 ||*/ tabSeleccionado == 0 /*|| tabSeleccionado == 2*/)
            {
                isValido = AbrirContraseña();
            }
            return isValido;
        }

        private bool AbrirContraseña()
        {
            C_Parametros objetoParametros = new C_Parametros();
            Contraseña obj = new Contraseña(objetoParametros);
            DialogResult dg = obj.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK)
            {
                _codigoAdministrador = obj.CodigoAdministrador;
                _observacion = obj.Observacion;
                return true;
            }
            return false;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarDolar();
        }
        private void GuardarDolar()
        {
            C_TipoCambio objetoTipoCambio = new C_TipoCambio();
            objetoTipoCambio.Codigo = _codigoAdministrador;
            objetoTipoCambio.Fecha = Dt_I_Fecha.Value;
            objetoTipoCambio.Observacion = _observacion;
            //objetoTipoCambio.Valor = Double.Parse(Txt_I_Valor.Text);
            if (Txt_I_Valor.Text != String.Empty)
            {
                objetoTipoCambio.Valor = Double.Parse(Txt_I_Valor.Text);
                if (_Shalong.TipoCambio(1, objetoTipoCambio))
                {
                    if (_flag != 0)
                    {
                        _objetoParametros.ValorDolar = objetoTipoCambio.Valor;
                        _interfazParametros.SetParametros(_objetoParametros);
                        MessageBox.Show("Se Ingreso el Tipo de Cambio Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    }
                    else if (_flag == 0)
                    {
                        MessageBox.Show("Se Ingreso el Tipo de Cambio Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("No se Pudo Ingresar el Tipo de Cambio ", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                objetoTipoCambio.Valor = 0.0;
                MessageBox.Show("No deje el Valor en Blanco ", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Modificar_Click_1(object sender, EventArgs e)
        {
            ModificarTipoCambio();
        }
        private void ModificarTipoCambio()
        {
            if (Txt_M_Valor.Text == string.Empty)
            {
                MessageBox.Show("No deje el Valor en Blanco ", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                C_TipoCambio objetoTipoCambio = new C_TipoCambio();
                objetoTipoCambio.Codigo = _codigoAdministrador;
                objetoTipoCambio.Fecha = Dt_M_Fecha.Value;
                objetoTipoCambio.Observacion = _observacion;
                objetoTipoCambio.Valor = Double.Parse(Txt_M_Valor.Text);
                if (_Shalong.TipoCambio(2, objetoTipoCambio))
                {
                    MessageBox.Show("Se modifico el Tipo de Cambio Correctamente", "Gestion Ventas", MessageBoxButtons.OK);
                    _objetoParametros.ValorDolar = objetoTipoCambio.Valor;
                    _interfazParametros.SetParametros(_objetoParametros);

                }
                else
                {
                    MessageBox.Show("No se pudo modificar el Tipo de Cambio ", "Gestion Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Txt_I_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void Dolar_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }




    }
}
