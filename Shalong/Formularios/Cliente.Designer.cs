namespace Shalong.Formularios
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_I_AMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_I_APaterno = new System.Windows.Forms.TextBox();
            this.txt_I_Dni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_I_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_M_AMaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_M_APaterno = new System.Windows.Forms.TextBox();
            this.txt_M_Dni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_M_Nombre = new System.Windows.Forms.TextBox();
            this.cmb_M_Nombre = new System.Windows.Forms.ComboBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_E_AMaterno = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_E_APaterno = new System.Windows.Forms.TextBox();
            this.txt_E_Dni = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmb_E_Nombre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
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
            this.tabControl1.Size = new System.Drawing.Size(317, 307);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txt_I_AMaterno);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_I_APaterno);
            this.tabPage1.Controls.Add(this.txt_I_Dni);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_I_Nombre);
            this.tabPage1.Controls.Add(this.btn_Guardar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(309, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "Apellido \r\nMaterno";
            // 
            // txt_I_AMaterno
            // 
            this.txt_I_AMaterno.Location = new System.Drawing.Point(86, 144);
            this.txt_I_AMaterno.MaxLength = 30;
            this.txt_I_AMaterno.Name = "txt_I_AMaterno";
            this.txt_I_AMaterno.Size = new System.Drawing.Size(202, 26);
            this.txt_I_AMaterno.TabIndex = 4;
            this.txt_I_AMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_I_AMaterno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Apellido \r\nPaterno\r\n";
            // 
            // txt_I_APaterno
            // 
            this.txt_I_APaterno.Location = new System.Drawing.Point(86, 94);
            this.txt_I_APaterno.MaxLength = 30;
            this.txt_I_APaterno.Name = "txt_I_APaterno";
            this.txt_I_APaterno.Size = new System.Drawing.Size(202, 26);
            this.txt_I_APaterno.TabIndex = 3;
            this.txt_I_APaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_I_APaterno_KeyPress);
            // 
            // txt_I_Dni
            // 
            this.txt_I_Dni.Location = new System.Drawing.Point(86, 56);
            this.txt_I_Dni.MaxLength = 16;
            this.txt_I_Dni.Name = "txt_I_Dni";
            this.txt_I_Dni.Size = new System.Drawing.Size(202, 26);
            this.txt_I_Dni.TabIndex = 2;
            this.txt_I_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_I_Dni_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // txt_I_Nombre
            // 
            this.txt_I_Nombre.Location = new System.Drawing.Point(86, 15);
            this.txt_I_Nombre.MaxLength = 30;
            this.txt_I_Nombre.Name = "txt_I_Nombre";
            this.txt_I_Nombre.Size = new System.Drawing.Size(202, 26);
            this.txt_I_Nombre.TabIndex = 1;
            this.txt_I_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_I_Nombre_KeyPress);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(100, 212);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 35);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_M_AMaterno);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_M_APaterno);
            this.tabPage2.Controls.Add(this.txt_M_Dni);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_M_Nombre);
            this.tabPage2.Controls.Add(this.cmb_M_Nombre);
            this.tabPage2.Controls.Add(this.btn_Modificar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(309, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 40);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellido \r\nMaterno";
            // 
            // txt_M_AMaterno
            // 
            this.txt_M_AMaterno.Location = new System.Drawing.Point(94, 182);
            this.txt_M_AMaterno.MaxLength = 30;
            this.txt_M_AMaterno.Name = "txt_M_AMaterno";
            this.txt_M_AMaterno.Size = new System.Drawing.Size(202, 26);
            this.txt_M_AMaterno.TabIndex = 5;
            this.txt_M_AMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_M_AMaterno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 40);
            this.label7.TabIndex = 17;
            this.label7.Text = "Apellido \r\nPaterno\r\n";
            // 
            // txt_M_APaterno
            // 
            this.txt_M_APaterno.Location = new System.Drawing.Point(94, 132);
            this.txt_M_APaterno.MaxLength = 30;
            this.txt_M_APaterno.Name = "txt_M_APaterno";
            this.txt_M_APaterno.Size = new System.Drawing.Size(202, 26);
            this.txt_M_APaterno.TabIndex = 4;
            this.txt_M_APaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_M_APaterno_KeyPress);
            // 
            // txt_M_Dni
            // 
            this.txt_M_Dni.Location = new System.Drawing.Point(94, 94);
            this.txt_M_Dni.MaxLength = 16;
            this.txt_M_Dni.Name = "txt_M_Dni";
            this.txt_M_Dni.Size = new System.Drawing.Size(202, 26);
            this.txt_M_Dni.TabIndex = 3;
            this.txt_M_Dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_M_Dni_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "DNI";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nombre";
            // 
            // txt_M_Nombre
            // 
            this.txt_M_Nombre.Location = new System.Drawing.Point(94, 53);
            this.txt_M_Nombre.MaxLength = 30;
            this.txt_M_Nombre.Name = "txt_M_Nombre";
            this.txt_M_Nombre.Size = new System.Drawing.Size(202, 26);
            this.txt_M_Nombre.TabIndex = 2;
            this.txt_M_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_M_Nombre_KeyPress);
            // 
            // cmb_M_Nombre
            // 
            this.cmb_M_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_M_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_M_Nombre.FormattingEnabled = true;
            this.cmb_M_Nombre.Location = new System.Drawing.Point(11, 8);
            this.cmb_M_Nombre.Name = "cmb_M_Nombre";
            this.cmb_M_Nombre.Size = new System.Drawing.Size(280, 28);
            this.cmb_M_Nombre.TabIndex = 10;
            this.cmb_M_Nombre.SelectedIndexChanged += new System.EventHandler(this.cmb_M_Nombre_SelectedIndexChanged);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(103, 229);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(112, 35);
            this.btn_Modificar.TabIndex = 6;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txt_E_AMaterno);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txt_E_APaterno);
            this.tabPage3.Controls.Add(this.txt_E_Dni);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.cmb_E_Nombre);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_Eliminar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(309, 274);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 40);
            this.label10.TabIndex = 20;
            this.label10.Text = "Apellido \r\nMaterno";
            // 
            // txt_E_AMaterno
            // 
            this.txt_E_AMaterno.Location = new System.Drawing.Point(94, 182);
            this.txt_E_AMaterno.Name = "txt_E_AMaterno";
            this.txt_E_AMaterno.Size = new System.Drawing.Size(202, 26);
            this.txt_E_AMaterno.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 40);
            this.label11.TabIndex = 18;
            this.label11.Text = "Apellido \r\nPaterno\r\n";
            // 
            // txt_E_APaterno
            // 
            this.txt_E_APaterno.Location = new System.Drawing.Point(94, 121);
            this.txt_E_APaterno.Name = "txt_E_APaterno";
            this.txt_E_APaterno.Size = new System.Drawing.Size(202, 26);
            this.txt_E_APaterno.TabIndex = 3;
            // 
            // txt_E_Dni
            // 
            this.txt_E_Dni.Location = new System.Drawing.Point(94, 70);
            this.txt_E_Dni.Name = "txt_E_Dni";
            this.txt_E_Dni.Size = new System.Drawing.Size(202, 26);
            this.txt_E_Dni.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "DNI";
            // 
            // cmb_E_Nombre
            // 
            this.cmb_E_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_E_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_E_Nombre.FormattingEnabled = true;
            this.cmb_E_Nombre.Location = new System.Drawing.Point(94, 27);
            this.cmb_E_Nombre.Name = "cmb_E_Nombre";
            this.cmb_E_Nombre.Size = new System.Drawing.Size(199, 28);
            this.cmb_E_Nombre.TabIndex = 1;
            this.cmb_E_Nombre.SelectedIndexChanged += new System.EventHandler(this.cmb_E_Nombre_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(97, 231);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(112, 35);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 335);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Cliente";
            this.Text = "Administrador de Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_I_AMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_I_APaterno;
        private System.Windows.Forms.TextBox txt_I_Dni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_I_Nombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_M_AMaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_M_APaterno;
        private System.Windows.Forms.TextBox txt_M_Dni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_M_Nombre;
        private System.Windows.Forms.ComboBox cmb_M_Nombre;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_E_AMaterno;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_E_APaterno;
        private System.Windows.Forms.TextBox txt_E_Dni;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_E_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Eliminar;

    }
}