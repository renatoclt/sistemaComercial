﻿using Shalong.Clases;
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
    public partial class Almacen : Form
    {
        Shalong_Service _shalong = new Shalong_Service();
        private I_Parametros _interfazParametros;
        private C_Parametros _objetoParametros;
        public Almacen(I_Parametros parametros)
        {
            InitializeComponent();
            CargarCombobox();
        }
        public Almacen(I_Parametros parametros, C_Parametros objetoParametros)
            : this(parametros)
        {
            this._interfazParametros = parametros;
            this._objetoParametros = objetoParametros;
        }
        
        private void CargarCombobox()
        {
            CargarComboBoxTipoAlmacen();
            CargarComboboxAlmacen();
        }
        
        private void CargarComboBoxTipoAlmacen()
        {
            Cmb_I_TipoAlmacen.DisplayMember = "Nombre";
            Cmb_I_TipoAlmacen.ValueMember = "Codigo";
            Cmb_I_TipoAlmacen.DataSource = _shalong.TipoAlmacenMostrar();

            Cmb_M_TipoAlmacen.DisplayMember = "Nombre";
            Cmb_M_TipoAlmacen.ValueMember = "Codigo";
            Cmb_M_TipoAlmacen.DataSource = _shalong.TipoAlmacenMostrar();

           
        }

        private void CargarComboboxAlmacen() 
        {
            Cmb_M_Nombre.DisplayMember = "Nombre";
            Cmb_M_Nombre.ValueMember = "Codigo";
            Cmb_M_Nombre.DataSource = _shalong.AlmacenMostrar();

            Cmb_E_Nombre.DisplayMember = "Nombre";
            Cmb_E_Nombre.ValueMember = "Codigo";
            Cmb_E_Nombre.DataSource = _shalong.AlmacenMostrar();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarAlmacen();
        }
        private void GuardarAlmacen()
        {
            C_Almacen objetoAlmacen = new C_Almacen();
            objetoAlmacen.Codigo = 1;
            if (Cmb_I_TipoAlmacen.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoAlmacen.CodigoTipoAlmacen = Int32.Parse(Cmb_I_TipoAlmacen.SelectedValue.ToString());
            }
            objetoAlmacen.Nombre = Txt_I_Nombre.Text;
            if (Txt_I_Nombre.Text != String.Empty)
            {
                if (_shalong.Almacen(1, objetoAlmacen))
                {
                    MessageBox.Show("Ingreso Correcto","Gestion Ventas",MessageBoxButtons.OK);
                    CargarCombobox();
                    Txt_I_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Revise los datos","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un Nombre al Almacen","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarAlmacen();
        }
        private void ModificarAlmacen()
        {
            C_Almacen objetoAlmacen = new C_Almacen();
            if (Cmb_M_TipoAlmacen.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Tipo de Almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoAlmacen.CodigoTipoAlmacen = Int32.Parse(Cmb_M_TipoAlmacen.SelectedValue.ToString());
            }
            if (Cmb_M_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoAlmacen.Codigo = Int32.Parse(Cmb_M_Nombre.SelectedValue.ToString());
            }
            objetoAlmacen.Nombre = Txt_M_Nombre.Text;
            if (Txt_M_Nombre.Text != String.Empty)
            {
                if (_shalong.Almacen(2, objetoAlmacen))
                {
                    MessageBox.Show("Modificacion Correcta","Gestion Ventas",MessageBoxButtons.OK);
                    CargarCombobox();
                    Txt_M_Nombre.Clear();
                }
                else
                {
                    MessageBox.Show("Revise los datos","Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No deje el campo Nombre vacio","Gestion Ventas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarAlmacen();
        }
        private void EliminarAlmacen()
        {
            C_Almacen objetoAlmacen = new C_Almacen();
            if (Cmb_E_Nombre.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese un Almacen Por Favor", "Gestion Ventas", MessageBoxButtons.OK);
                return;
            }
            else
            {
                objetoAlmacen.Codigo = Int32.Parse(Cmb_E_Nombre.SelectedValue.ToString());
            }
            objetoAlmacen.CodigoTipoAlmacen = 1;
            objetoAlmacen.Nombre = " ";
            if (_shalong.Almacen(3, objetoAlmacen ))
            {
                MessageBox.Show("Eleminación Correcta", "Gestion Ventas", MessageBoxButtons.OK);
                CargarCombobox();
            }
            else
            {
                MessageBox.Show("Revise los datos", "Gestion Ventas", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Cmb_M_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            C_Almacen obj = _shalong.AlmacenMostrar1(Int32.Parse(Cmb_M_Nombre.SelectedValue.ToString()));
            Txt_M_Nombre.Text = obj.Nombre;
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height)/2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
