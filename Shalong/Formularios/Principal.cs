using Shalong.Conexion;
using Shalong.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Shalong.Formularios
{
    public partial class Principal : Form, I_Parametros
    {
        int _codigoCaja;
        bool _isValido;
        int _codigoUsuario;
        C_Parametros _parametros;
        Shalong_Service _shalong = new Shalong_Service();

        #region I_Parametros
        public void SetParametros(C_Parametros objetoParametros)
        {
            _codigoUsuario = objetoParametros.DniUsuario;
            Txt_Dni.Text = " " + objetoParametros.DniUsuario;
            _codigoCaja = objetoParametros.CodigoCaja;
            Txt_Caja.Text = "" + _codigoCaja;
            Txt_Almacen.Text = "" + objetoParametros.NombreAlmacen;
            //Txt_Almacen.Text = "" + objetoParametros.CodigoAlmacen;
            Txt_Dolar.Text = String.Format("{0:0.00}", objetoParametros.ValorDolar);
            Txt_TipoTrabajador.Text = "" + objetoParametros.TipoTrabajador;
            _parametros = objetoParametros;
            ConfiguracionMenu();
            Pnl_M_Botones.Controls.Clear();
        }
        #endregion

        public Principal(C_Parametros objetoParametros)
        {
            InitializeComponent();
            _isValido = true;
            //Txt_Caja.Text = "" + _codigoCaja;
            SetParametros(objetoParametros);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ConfiguracionPantallaPrincipal();
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            //ConfiguracionPantallaPrincipal();
        }

        private void Principal_Move(object sender, EventArgs e)
        {
            //ConfiguracionPantallaPrincipal();
        }
        //metodo para reajustar la pantalla a diferentes resoluciones

        private void ConfiguracionPantallaPrincipal()
        {
            int width = ActiveForm.Bounds.Width;
            int height = ActiveForm.Bounds.Height;
            this.SetBounds(0, 0, Width, Height);
            //configuracion del menu
            ConfiguracionMenu();
            //configuracion del cuerpo
            ConfiguracionCuerpo(Height);

        }

        private void ConfiguracionMenu()
        {
            //listas de menu disponible
            List<C_Menu> objetoMenu = _shalong.MenuMostrar(1, _codigoUsuario);
            //solo ingrese la primera vez
            if (Pnl_M_Cabezera.Controls.Count < 1)
            {
                //recorrer todos los menus
                foreach (C_Menu menu in objetoMenu)
                {
                    Button Btn = new Button();
                    Btn.Name = "Btn_" + menu.CodigoMenu;
                    Btn.Text = menu.Nombre;
                    Btn.Width = 120;
                    Btn.BackColor = SystemColors.Control;
                    Btn.Dock = System.Windows.Forms.DockStyle.Left;
                    Btn.Click += new System.EventHandler(dynamicButtonMenu_Click);
                    this.Pnl_M_Cabezera.Controls.Add(Btn);
                }
            }
        }

        private void dynamicButtonMenu_Click(Object sender, System.EventArgs e)
        {
            Button Btn_Menu = sender as Button;
            Pnl_M_Botones.Controls.Clear();
            int codigoMenu = Int32.Parse(Btn_Menu.Name.Substring(4, Btn_Menu.Name.Length - 4));
            List<C_Menu> objetoMenu = _shalong.MenuMostrar(codigoMenu, _codigoUsuario);
            //recorrer todos los menus
            foreach (C_Menu menu in objetoMenu)
            {
                Button Btn = new Button();
                Btn.Name = "Btn_" + menu.CodigoMenu;
                //Btn.Text = menu.Nombre;
                Btn.Width = 100;
                Btn.BackgroundImage = Bytes2Image(menu.Image);
                if (menu.Habilitado || _parametros.EstadoCaja)
                {
                    Btn.Visible = true;
                }
                else
                {
                    Btn.Visible = false;
                }
                Btn.BackgroundImageLayout = ImageLayout.Stretch;
                Btn.TextAlign = ContentAlignment.BottomCenter;
                Btn.BackColor = SystemColors.Control;
                Btn.Dock = System.Windows.Forms.DockStyle.Left;
                Btn.Click += new System.EventHandler(dynamicButtonMenu1_Click);
                this.Pnl_M_Botones.Controls.Add(Btn);
            }
        }

        public static Image Bytes2Image(byte[] bytes)
        {
            if (bytes == null) return null;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Bitmap bm = null;
                try
                {
                    bm = new Bitmap(ms);
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                return bm;
            }
        }

        private void dynamicButtonMenu1_Click(Object sender, System.EventArgs e)
        {
            Button Btn_Menu = sender as Button;
            Btn_Menu.Width = 100;
            int codigoMenu = Int32.Parse(Btn_Menu.Name.Substring(4, Btn_Menu.Name.Length - 4));
            C_Menu objetoMenu = _shalong.MenuMostrar1(codigoMenu);
            Assembly asm = Assembly.GetEntryAssembly();
            Type formType = asm.GetType("Shalong.Formularios." + objetoMenu.Formulario);
            Form formularioDinamico = (Form)Activator.CreateInstance(formType, this, _parametros);
            formularioDinamico.ShowDialog();
        }

        private void ConfiguracionCuerpo(int Height)
        {
            //titulo 30 --- px cabezera 30px -- botones menu -- 90 -- pie 30
            Pnl_Cuerpo.Height = (Height - 180);
        }

        private void Btn_I_Empresa_Click(object sender, EventArgs e)
        {
            AbrirEmpresa();
        }

        private void AbrirEmpresa()
        {
            Empresa obj = new Empresa();
            obj.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parametros.EstadoCaja == false)
            {
                Application.Exit();
            }
            else
            {
                if (MessageBox.Show("¿Desea salir de la Aplicacion sin Cerrar Caja?", "Caja", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
                //else 
                //{
                //    Principal obj = new Principal(_parametros);
                //    obj.ShowDialog();
                //}

            }
        }

    }
}