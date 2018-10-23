using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shalong.Conexion;
using Shalong.Clases;

namespace Shalong.Formularios
{
    public partial class AbrirCaja : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        int _codigoUsuario;
        int _codigoAdministrador;
        string _observacion;
        bool _isAdministrador;
        double _valorDolar;
        int _codigoDolar;
        int _codigoCaja;
        double _total;
        int _accion;
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public AbrirCaja(I_Parametros parametros)
        {
            InitializeComponent();
            CargarComboBox();
            CargarValorDolar();
            CargarDataGridView();
            CargarBilletaje();
            /*CargarComboBox();
            CargarValorDolar();
            CargarDataGridView();
            CargarBilletaje();
            _codigoUsuario = objetoParametros.CodigoUsuario;
            _codigoCaja = 0;
            _codigoDolar = 1;
            _observacion = " ";
            _isAdministrador = false;*/
            _interfazParametros = parametros;
        }
        public AbrirCaja(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {

            _objetoParametros = objetoParametros;
            _codigoUsuario = objetoParametros.DniUsuario;
            _codigoCaja = objetoParametros.CodigoCaja;
            _valorDolar = objetoParametros.ValorDolar;
            //_ok = objetoParametros.Ok;
            _codigoDolar = 1;
            _accion = 1;
            _observacion = " ";
            _isAdministrador = false;

        }

        private void AbrirCaja_Load(object sender, EventArgs e)
        {
            //centrar formulario
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }


        //CARGAR COMBOBOX
        private void CargarComboBox()
        {
            cmb_NombreCaja.DisplayMember = "Nombre";
            cmb_NombreCaja.ValueMember = "Codigo";
            cmb_NombreCaja.DataSource = _shalong.NombreCajaMostrar();
        }
        private void CargarValorDolar()
        {
            _valorDolar = _shalong.TipoCambioDiario();
            _codigoDolar = _shalong.TipoCambioCodigo();
            txt_Dolar.Text = "" + _valorDolar;
        }
        //CARGAR DATAGIRDVIEW
        private void CargarDataGridView()
        {
            dtg_Billetaje.AutoGenerateColumns = false;
            dtg_Billetaje.DataSource = _shalong.BilletajeMostrar();
        }
        private void CargarBilletaje()
        {
            int codigoCajaAnterior;
            if(cmb_NombreCaja.SelectedValue != null)
            {
                codigoCajaAnterior = _shalong.CajaUltima(Int32.Parse(cmb_NombreCaja.SelectedValue.ToString()));
                if(codigoCajaAnterior == 0)
                {
                    dtg_Billetaje.Enabled = true;
                }
                List<C_Billetaje> objetoBilletaje = _shalong.BilletajeCajaMostrar(codigoCajaAnterior);
                foreach (DataGridViewRow row in dtg_Billetaje.Rows)
                {
                    row.Cells["Cantidad"].Value = "0";
                    foreach (C_Billetaje objeto in objetoBilletaje)
                    {
                        if (objeto.Codigo == Int32.Parse(row.Cells["Codigo"].Value.ToString()))
                        {
                            row.Cells["Cantidad"].Value = objeto.Cantidad;
                            break;
                        }
                    }
                }
                Total();
            }
        }

        //BOTONES
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Contraseña obj = new Contraseña(_objetoParametros);
            if (cmb_NombreCaja.SelectedIndex == -1)
            {
                MessageBox.Show("Ingresar una Caja Valida Por Favor","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CargarComboBox();
                return;

            }
            else
            {
                if (_isAdministrador)
                {
                    _accion = 2;
                    _codigoCaja = _shalong.CajaCodigo(_codigoUsuario);
                    ModificarCaja();
                }
                else
                {
                    if (AbrirContraseña())
                    {
                        _isAdministrador = true;
                        dtg_Billetaje.Enabled = true;
                        _accion = 2;
                    }
                }
            }
        }
        private void Btn_AbrirCaja_Click(object sender, EventArgs e)
        {
            C_Caja objetoCaja = new C_Caja();
            if (cmb_NombreCaja.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Caja Valida","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                CargarComboBox();
                return;
            }
            else
            {
                objetoCaja.CodigoNombreCaja = Int32.Parse(cmb_NombreCaja.SelectedValue.ToString());
            }
            objetoCaja.CodigoDniUsuario = _codigoUsuario;
            objetoCaja.CodigoTipoCambio = _codigoDolar;
            objetoCaja.SaldoInicial = _total;
            objetoCaja.SaldoFinal = 0;
            objetoCaja.CodigoAdministrador = _codigoAdministrador;
            objetoCaja.Observacion = " ";
            objetoCaja.CodigoCaja = _codigoCaja;
            if (_shalong.Caja(_accion, objetoCaja))
            {
                MessageBox.Show("Abrio Caja");
                C_Almacen objetoAlmacen = _shalong.AlmacenMostrarCaja(Int32.Parse(cmb_NombreCaja.SelectedValue.ToString()));
                _objetoParametros.CodigoAlmacen = objetoAlmacen.CodigoTipoAlmacen;
                _objetoParametros.NombreAlmacen = objetoAlmacen.Nombre;
                _objetoParametros.CodigoCaja = _codigoCaja;
                _objetoParametros.EstadoCaja = true;
                _interfazParametros.SetParametros(_objetoParametros);
                C_BilletajeCaja objetoBilletajeCaja = new C_BilletajeCaja();
                _codigoCaja = _shalong.CajaCodigo(_codigoUsuario);
                objetoBilletajeCaja.CodigoCaja = _codigoCaja;
                objetoBilletajeCaja.Accion = 1;
                _shalong.BilletajeCajaBorrar(_codigoCaja, 1);
                foreach (DataGridViewRow row in dtg_Billetaje.Rows)
                {
                    objetoBilletajeCaja.CodigoBilletaje = Int32.Parse(row.Cells["Codigo"].Value.ToString());
                    objetoBilletajeCaja.Cantidad = Int32.Parse(row.Cells["Cantidad"].Value.ToString());
                    if (!_shalong.BilletajeCajaGuardar(objetoBilletajeCaja))
                    {
                        MessageBox.Show("Error al ingresar el billetaje intenlo de nuevo","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return;
                    }
                }
                this.Hide();

            }
            else
            {
                /*if (_shalong.CajaAbierta(_codigoUsuario))
                {*/
                    _codigoCaja = _shalong.CajaCodigo(_codigoUsuario);
                    _objetoParametros.CodigoCaja = _codigoCaja;
                    C_Almacen objetoAlmacen = _shalong.AlmacenMostrarCaja(Int32.Parse(cmb_NombreCaja.SelectedValue.ToString()));
                    _objetoParametros.CodigoAlmacen = objetoAlmacen.CodigoTipoAlmacen;
                    _objetoParametros.NombreAlmacen = objetoAlmacen.Nombre;
                    _objetoParametros.EstadoCaja = true;
                    _interfazParametros.SetParametros(_objetoParametros);
                    MessageBox.Show("Se continuara con su sesion anterior y el billetaje no sera remplazado","Gestion Ventas",MessageBoxButtons.OK);
                    _codigoCaja = _shalong.CajaCodigo(_codigoUsuario);
                    this.Hide();
                /*}
                else
                {
                    MessageBox.Show("Error al abrir caja","Gestion Ventas",MessageBoxButtons.OK);
                }*/
            }
        }



        private void ModificarCaja()
        {
            C_Caja objetoCaja = new C_Caja();
            if (cmb_NombreCaja.SelectedIndex == -1)
            {
                MessageBox.Show("Ingresar una Caja Valida Por Favor","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                objetoCaja.CodigoNombreCaja = Int32.Parse(cmb_NombreCaja.SelectedValue.ToString());
            }
            objetoCaja.CodigoDniUsuario = _codigoUsuario;
            objetoCaja.CodigoTipoCambio = _codigoDolar;
            objetoCaja.SaldoInicial = _total;
            objetoCaja.SaldoFinal = 0;
            objetoCaja.CodigoAdministrador = _codigoAdministrador;
            objetoCaja.Observacion = _observacion;
            objetoCaja.CodigoCaja = _codigoCaja;

            if (_shalong.Caja(2, objetoCaja))
            {
                MessageBox.Show("Modifico Caja");
                _objetoParametros.CodigoCaja = _codigoCaja;
                _objetoParametros.EstadoCaja = true;
                C_BilletajeCaja objetoBilletajeCaja = new C_BilletajeCaja();
                _codigoCaja = _shalong.CajaCodigo(_codigoUsuario);
                objetoBilletajeCaja.CodigoCaja = _codigoCaja;
                objetoBilletajeCaja.Accion = 1;
                _shalong.BilletajeCajaBorrar(_codigoCaja, 1);
                foreach (DataGridViewRow row in dtg_Billetaje.Rows)
                {
                    objetoBilletajeCaja.CodigoBilletaje = Int32.Parse(row.Cells["Codigo"].Value.ToString());
                    objetoBilletajeCaja.Cantidad = Int32.Parse(row.Cells["Cantidad"].Value.ToString());
                    if (!_shalong.BilletajeCajaGuardar(objetoBilletajeCaja))
                    {
                        MessageBox.Show("Error al ingresar el billetaje intenlo de nuevo","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al modificar Caja","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private bool AbrirContraseña()
        {
            Contraseña obj = new Contraseña(_objetoParametros);
            DialogResult dg = obj.ShowDialog();
            if (dg == System.Windows.Forms.DialogResult.OK)
            {
                _codigoAdministrador = obj.CodigoAdministrador;
                _observacion = obj.Observacion;
                CargarComboBox();
                return true;
            }
            return false;
        }
        private void Total()
        {
            //almacenaremos el valor de todo el gridview
            _total = 0;
            //si el dolar no tiene valor
            try
            {
                _valorDolar = Double.Parse(txt_Dolar.Text);
            }
            catch
            {
                _valorDolar = 0.0;
            }
            //recorremos el gridview y sumamos el valor
            foreach (DataGridViewRow row in dtg_Billetaje.Rows)
            {
                if (row.Cells["Moneda"].Value.ToString().Contains("S/."))
                {
                    _total = _total + (Double.Parse(row.Cells["Valor"].Value.ToString()) * Double.Parse(row.Cells["Cantidad"].Value.ToString()));
                }
                else
                {
                    _total = _total + ((Double.Parse(row.Cells["Valor"].Value.ToString()) * Double.Parse(row.Cells["Cantidad"].Value.ToString())) * _valorDolar);
                }
            }
            //signo de moneda
            txt_Total.Text = _total.ToString("C", CultureInfo.CurrentCulture);
        }


        //FUNCIONES
        private void dgv_Billetaje_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dtg_Billetaje.CurrentRow.Cells[e.ColumnIndex].ReadOnly)
            {
                SendKeys.Send("{tab}");
            }
        }
        private void cmb_NombreCaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarBilletaje();
        }
        private void dgv_Billetaje_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Total();
        }
        


        //VALIDAR INGRESO DE NUEVO TIPO DE CAMBIO
        private void Btn_CambiarDolar_Click(object sender, EventArgs e)
        {
            if (_valorDolar == 0.0 || _isAdministrador)
            {
                Dolar objetoDolar = new Dolar(_codigoUsuario, "Cambio del dolar diario", _isAdministrador);
                objetoDolar.ShowDialog();
                CargarValorDolar();
                _objetoParametros.ValorDolar = double.Parse(txt_Dolar.Text);
                _interfazParametros.SetParametros(_objetoParametros);

            }
            else
            {
                if (AbrirContraseña() == true)
                {
                    _objetoParametros.Ok = true;
                    _objetoParametros.CodigoUsuario = _codigoAdministrador;

                    Dolar objetoDolar = new Dolar(_interfazParametros, _objetoParametros, _observacion);//_codigoUsuario, "Modificación del Cambio de Dolar", _isAdministrador);
                    objetoDolar.ShowDialog();
                    CargarValorDolar();
                    _objetoParametros.ValorDolar = double.Parse(txt_Dolar.Text);
                    _interfazParametros.SetParametros(_objetoParametros);
                    //_ok = true;
                }
                else
                {
                    this.Close();
                }

            }
        }

    }
}
