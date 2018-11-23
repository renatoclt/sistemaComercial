namespace Shalong.Formularios
{
    partial class Empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresa));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txt_I_Telefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_I_Direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_I_Ruc = new System.Windows.Forms.TextBox();
            this.Txt_I_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Txt_M_Telefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_M_Direccion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_M_Empresa = new System.Windows.Forms.ComboBox();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_M_Ruc = new System.Windows.Forms.TextBox();
            this.Txt_M_Nombre = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Txt_E_Telefono = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_E_Direccion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cmb_E_Empresa = new System.Windows.Forms.ComboBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Txt_E_Ruc = new System.Windows.Forms.TextBox();
            this.Txt_E_Nombre = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(305, 311);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Txt_I_Telefono);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.Txt_I_Direccion);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.Btn_guardar);
            this.tabPage1.Controls.Add(this.Txt_I_Ruc);
            this.tabPage1.Controls.Add(this.Txt_I_Nombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(297, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Txt_I_Telefono
            // 
            this.Txt_I_Telefono.Location = new System.Drawing.Point(109, 150);
            this.Txt_I_Telefono.MaxLength = 20;
            this.Txt_I_Telefono.Name = "Txt_I_Telefono";
            this.Txt_I_Telefono.Size = new System.Drawing.Size(170, 26);
            this.Txt_I_Telefono.TabIndex = 4;
            this.Txt_I_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_Telefono_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Telefono";
            // 
            // Txt_I_Direccion
            // 
            this.Txt_I_Direccion.Location = new System.Drawing.Point(109, 104);
            this.Txt_I_Direccion.MaxLength = 40;
            this.Txt_I_Direccion.Name = "Txt_I_Direccion";
            this.Txt_I_Direccion.Size = new System.Drawing.Size(170, 26);
            this.Txt_I_Direccion.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Direccion";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(109, 207);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(102, 32);
            this.Btn_guardar.TabIndex = 5;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Txt_I_Ruc
            // 
            this.Txt_I_Ruc.Location = new System.Drawing.Point(109, 62);
            this.Txt_I_Ruc.MaxLength = 30;
            this.Txt_I_Ruc.Name = "Txt_I_Ruc";
            this.Txt_I_Ruc.Size = new System.Drawing.Size(170, 26);
            this.Txt_I_Ruc.TabIndex = 2;
            this.Txt_I_Ruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_Ruc_KeyPress);
            // 
            // Txt_I_Nombre
            // 
            this.Txt_I_Nombre.Location = new System.Drawing.Point(109, 24);
            this.Txt_I_Nombre.MaxLength = 30;
            this.Txt_I_Nombre.Name = "Txt_I_Nombre";
            this.Txt_I_Nombre.Size = new System.Drawing.Size(170, 26);
            this.Txt_I_Nombre.TabIndex = 1;
            this.Txt_I_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RUC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Txt_M_Telefono);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.Txt_M_Direccion);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Cmb_M_Empresa);
            this.tabPage2.Controls.Add(this.Btn_Modificar);
            this.tabPage2.Controls.Add(this.Txt_M_Ruc);
            this.tabPage2.Controls.Add(this.Txt_M_Nombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(297, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt_M_Telefono
            // 
            this.Txt_M_Telefono.Location = new System.Drawing.Point(108, 183);
            this.Txt_M_Telefono.MaxLength = 20;
            this.Txt_M_Telefono.Name = "Txt_M_Telefono";
            this.Txt_M_Telefono.Size = new System.Drawing.Size(170, 26);
            this.Txt_M_Telefono.TabIndex = 5;
            this.Txt_M_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_M_Telefono_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Telefono";
            // 
            // Txt_M_Direccion
            // 
            this.Txt_M_Direccion.Location = new System.Drawing.Point(108, 137);
            this.Txt_M_Direccion.MaxLength = 40;
            this.Txt_M_Direccion.Name = "Txt_M_Direccion";
            this.Txt_M_Direccion.Size = new System.Drawing.Size(170, 26);
            this.Txt_M_Direccion.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "RUC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre";
            // 
            // Cmb_M_Empresa
            // 
            this.Cmb_M_Empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_M_Empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_M_Empresa.FormattingEnabled = true;
            this.Cmb_M_Empresa.Location = new System.Drawing.Point(15, 9);
            this.Cmb_M_Empresa.Name = "Cmb_M_Empresa";
            this.Cmb_M_Empresa.Size = new System.Drawing.Size(263, 28);
            this.Cmb_M_Empresa.TabIndex = 1;
            this.Cmb_M_Empresa.SelectedIndexChanged += new System.EventHandler(this.Cmb_M_Empresa_SelectedIndexChanged);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(108, 224);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Modificar.TabIndex = 6;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Txt_M_Ruc
            // 
            this.Txt_M_Ruc.Location = new System.Drawing.Point(108, 93);
            this.Txt_M_Ruc.MaxLength = 30;
            this.Txt_M_Ruc.Name = "Txt_M_Ruc";
            this.Txt_M_Ruc.Size = new System.Drawing.Size(170, 26);
            this.Txt_M_Ruc.TabIndex = 3;
            this.Txt_M_Ruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_M_Ruc_KeyPress);
            // 
            // Txt_M_Nombre
            // 
            this.Txt_M_Nombre.Location = new System.Drawing.Point(108, 55);
            this.Txt_M_Nombre.MaxLength = 30;
            this.Txt_M_Nombre.Name = "Txt_M_Nombre";
            this.Txt_M_Nombre.Size = new System.Drawing.Size(170, 26);
            this.Txt_M_Nombre.TabIndex = 2;
            this.Txt_M_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_M_Nombre_KeyPress);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Txt_E_Telefono);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.Txt_E_Direccion);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.Cmb_E_Empresa);
            this.tabPage3.Controls.Add(this.Btn_Eliminar);
            this.tabPage3.Controls.Add(this.Txt_E_Ruc);
            this.tabPage3.Controls.Add(this.Txt_E_Nombre);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(297, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Txt_E_Telefono
            // 
            this.Txt_E_Telefono.Enabled = false;
            this.Txt_E_Telefono.Location = new System.Drawing.Point(112, 184);
            this.Txt_E_Telefono.Name = "Txt_E_Telefono";
            this.Txt_E_Telefono.Size = new System.Drawing.Size(170, 26);
            this.Txt_E_Telefono.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Telefono";
            // 
            // Txt_E_Direccion
            // 
            this.Txt_E_Direccion.Enabled = false;
            this.Txt_E_Direccion.Location = new System.Drawing.Point(112, 138);
            this.Txt_E_Direccion.Name = "Txt_E_Direccion";
            this.Txt_E_Direccion.Size = new System.Drawing.Size(170, 26);
            this.Txt_E_Direccion.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "RUC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombre";
            // 
            // Cmb_E_Empresa
            // 
            this.Cmb_E_Empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_E_Empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_E_Empresa.FormattingEnabled = true;
            this.Cmb_E_Empresa.Location = new System.Drawing.Point(19, 12);
            this.Cmb_E_Empresa.Name = "Cmb_E_Empresa";
            this.Cmb_E_Empresa.Size = new System.Drawing.Size(263, 28);
            this.Cmb_E_Empresa.TabIndex = 1;
            this.Cmb_E_Empresa.SelectedIndexChanged += new System.EventHandler(this.Cmb_E_Empresa_SelectedIndexChanged);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(112, 231);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Eliminar.TabIndex = 6;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Txt_E_Ruc
            // 
            this.Txt_E_Ruc.Enabled = false;
            this.Txt_E_Ruc.Location = new System.Drawing.Point(112, 96);
            this.Txt_E_Ruc.Name = "Txt_E_Ruc";
            this.Txt_E_Ruc.Size = new System.Drawing.Size(170, 26);
            this.Txt_E_Ruc.TabIndex = 3;
            // 
            // Txt_E_Nombre
            // 
            this.Txt_E_Nombre.Enabled = false;
            this.Txt_E_Nombre.Location = new System.Drawing.Point(112, 58);
            this.Txt_E_Nombre.Name = "Txt_E_Nombre";
            this.Txt_E_Nombre.Size = new System.Drawing.Size(170, 26);
            this.Txt_E_Nombre.TabIndex = 2;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 339);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Empresa";
            this.Text = "Administrador de Empresas";
            this.Load += new System.EventHandler(this.Empresa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.TextBox Txt_I_Ruc;
        private System.Windows.Forms.TextBox Txt_I_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_M_Empresa;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox Txt_M_Ruc;
        private System.Windows.Forms.TextBox Txt_M_Nombre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cmb_E_Empresa;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.TextBox Txt_E_Ruc;
        private System.Windows.Forms.TextBox Txt_E_Nombre;
        private System.Windows.Forms.TextBox Txt_I_Telefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Txt_I_Direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_M_Telefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_M_Direccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_E_Telefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Txt_E_Direccion;
        private System.Windows.Forms.Label label12;

    }
}