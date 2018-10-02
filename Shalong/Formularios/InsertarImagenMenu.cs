using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shalong.Formularios
{
    public partial class InsertarImagenMenu : Form
    {
        public InsertarImagenMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivo JPG|*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_Imagen.Image = Image.FromFile(fileDialog.FileName);
            }
        }
        public static byte[] Image2Bytes(Image pImagen)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(pImagen, typeof(byte[]));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            string cadenaConexion = "Server=192.168.1.37; port = 5432 ;User Id=postgres;Password=root;Database=Gestion_ventas";
            try
            {
                byte[] Blob = Image2Bytes(pic_Imagen.Image);
                NpgsqlConnection cnn = new NpgsqlConnection(cadenaConexion);
                cnn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("UPDATE menu SET \"Imagen\"	= ( :Imagen1) WHERE CODIGO_MENU =  " + textBox1.Text + ";", cnn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();

                NpgsqlParameter param1 = new NpgsqlParameter("Imagen1", NpgsqlDbType.Bytea);
                param1.Value = Blob;
                cmd.Parameters.Add(param1);
                cmd.ExecuteNonQuery();
                cnn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
                return ;
            }
        }

        private void InsertarImagenMenu_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }
    }
}
