namespace Shalong.Formularios
{
    partial class NombreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NombreCaja));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Cmb_I_Almacen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_I_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Cmb_M_Almacen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmb_M_Nombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_M_Nombre = new System.Windows.Forms.TextBox();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Cmb_E_Nombre = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
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
            this.tabControl1.Size = new System.Drawing.Size(330, 208);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Cmb_I_Almacen);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Txt_I_Nombre);
            this.tabPage1.Controls.Add(this.Btn_Guardar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(322, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Cmb_I_Almacen
            // 
            this.Cmb_I_Almacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_I_Almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_I_Almacen.FormattingEnabled = true;
            this.Cmb_I_Almacen.Location = new System.Drawing.Point(99, 70);
            this.Cmb_I_Almacen.Name = "Cmb_I_Almacen";
            this.Cmb_I_Almacen.Size = new System.Drawing.Size(202, 28);
            this.Cmb_I_Almacen.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Almacen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // Txt_I_Nombre
            // 
            this.Txt_I_Nombre.Location = new System.Drawing.Point(99, 26);
            this.Txt_I_Nombre.MaxLength = 40;
            this.Txt_I_Nombre.Name = "Txt_I_Nombre";
            this.Txt_I_Nombre.Size = new System.Drawing.Size(202, 26);
            this.Txt_I_Nombre.TabIndex = 1;
            this.Txt_I_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_Nombre_KeyPress);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(120, 117);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(112, 35);
            this.Btn_Guardar.TabIndex = 0;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Cmb_M_Almacen);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Cmb_M_Nombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.Txt_M_Nombre);
            this.tabPage2.Controls.Add(this.Btn_Modificar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(322, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Cmb_M_Almacen
            // 
            this.Cmb_M_Almacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_M_Almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_M_Almacen.FormattingEnabled = true;
            this.Cmb_M_Almacen.Location = new System.Drawing.Point(101, 94);
            this.Cmb_M_Almacen.Name = "Cmb_M_Almacen";
            this.Cmb_M_Almacen.Size = new System.Drawing.Size(202, 28);
            this.Cmb_M_Almacen.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Almacen";
            // 
            // Cmb_M_Nombre
            // 
            this.Cmb_M_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_M_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_M_Nombre.FormattingEnabled = true;
            this.Cmb_M_Nombre.Location = new System.Drawing.Point(23, 8);
            this.Cmb_M_Nombre.Name = "Cmb_M_Nombre";
            this.Cmb_M_Nombre.Size = new System.Drawing.Size(280, 28);
            this.Cmb_M_Nombre.TabIndex = 6;
            this.Cmb_M_Nombre.SelectedIndexChanged += new System.EventHandler(this.Cmb_M_Nombre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // Txt_M_Nombre
            // 
            this.Txt_M_Nombre.Location = new System.Drawing.Point(101, 59);
            this.Txt_M_Nombre.MaxLength = 40;
            this.Txt_M_Nombre.Name = "Txt_M_Nombre";
            this.Txt_M_Nombre.Size = new System.Drawing.Size(202, 26);
            this.Txt_M_Nombre.TabIndex = 4;
            this.Txt_M_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_M_Nombre_KeyPress);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(101, 130);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(112, 35);
            this.Btn_Modificar.TabIndex = 3;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Cmb_E_Nombre);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.Btn_Eliminar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(322, 175);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Cmb_E_Nombre
            // 
            this.Cmb_E_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_E_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_E_Nombre.FormattingEnabled = true;
            this.Cmb_E_Nombre.Location = new System.Drawing.Point(103, 31);
            this.Cmb_E_Nombre.Name = "Cmb_E_Nombre";
            this.Cmb_E_Nombre.Size = new System.Drawing.Size(199, 28);
            this.Cmb_E_Nombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(103, 82);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(112, 35);
            this.Btn_Eliminar.TabIndex = 6;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // NombreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 236);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NombreCaja";
            this.Text = "Administrador de Cajas";
            this.Load += new System.EventHandler(this.NombreCaja_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_I_Nombre;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Cmb_M_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_M_Nombre;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox Cmb_E_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.ComboBox Cmb_I_Almacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_M_Almacen;
        private System.Windows.Forms.Label label5;
    }
}