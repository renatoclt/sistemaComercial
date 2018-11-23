namespace Shalong.Formularios
{
    partial class Unidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unidad));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_I_Simbolo = new System.Windows.Forms.TextBox();
            this.Txt_I_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Cmb_M_Unidad = new System.Windows.Forms.ComboBox();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_M_Simbolo = new System.Windows.Forms.TextBox();
            this.Txt_M_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Cmb_E_Unidad = new System.Windows.Forms.ComboBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Txt_E_Simbolo = new System.Windows.Forms.TextBox();
            this.Txt_E_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.tabControl1.Size = new System.Drawing.Size(305, 208);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Btn_guardar);
            this.tabPage1.Controls.Add(this.Txt_I_Simbolo);
            this.tabPage1.Controls.Add(this.Txt_I_Nombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(297, 175);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insertar Unidad de Equivalencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(98, 87);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(102, 32);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Txt_I_Simbolo
            // 
            this.Txt_I_Simbolo.Location = new System.Drawing.Point(109, 46);
            this.Txt_I_Simbolo.MaxLength = 10;
            this.Txt_I_Simbolo.Name = "Txt_I_Simbolo";
            this.Txt_I_Simbolo.Size = new System.Drawing.Size(170, 26);
            this.Txt_I_Simbolo.TabIndex = 2;
            this.Txt_I_Simbolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_Simbolo_KeyPress);
            // 
            // Txt_I_Nombre
            // 
            this.Txt_I_Nombre.Location = new System.Drawing.Point(109, 8);
            this.Txt_I_Nombre.MaxLength = 40;
            this.Txt_I_Nombre.Name = "Txt_I_Nombre";
            this.Txt_I_Nombre.Size = new System.Drawing.Size(170, 26);
            this.Txt_I_Nombre.TabIndex = 1;
            this.Txt_I_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_Nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simbolo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Cmb_M_Unidad);
            this.tabPage2.Controls.Add(this.Btn_Modificar);
            this.tabPage2.Controls.Add(this.Txt_M_Simbolo);
            this.tabPage2.Controls.Add(this.Txt_M_Nombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(297, 175);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Cmb_M_Unidad
            // 
            this.Cmb_M_Unidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_M_Unidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_M_Unidad.FormattingEnabled = true;
            this.Cmb_M_Unidad.Location = new System.Drawing.Point(15, 9);
            this.Cmb_M_Unidad.Name = "Cmb_M_Unidad";
            this.Cmb_M_Unidad.Size = new System.Drawing.Size(263, 28);
            this.Cmb_M_Unidad.TabIndex = 1;
            this.Cmb_M_Unidad.SelectedIndexChanged += new System.EventHandler(this.Cmb_M_Unidad_SelectedIndexChanged);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(108, 128);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Modificar.TabIndex = 4;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Txt_M_Simbolo
            // 
            this.Txt_M_Simbolo.Location = new System.Drawing.Point(108, 93);
            this.Txt_M_Simbolo.MaxLength = 10;
            this.Txt_M_Simbolo.Name = "Txt_M_Simbolo";
            this.Txt_M_Simbolo.Size = new System.Drawing.Size(170, 26);
            this.Txt_M_Simbolo.TabIndex = 3;
            this.Txt_M_Simbolo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_M_Simbolo_KeyPress);
            // 
            // Txt_M_Nombre
            // 
            this.Txt_M_Nombre.Location = new System.Drawing.Point(108, 55);
            this.Txt_M_Nombre.MaxLength = 40;
            this.Txt_M_Nombre.Name = "Txt_M_Nombre";
            this.Txt_M_Nombre.Size = new System.Drawing.Size(170, 26);
            this.Txt_M_Nombre.TabIndex = 2;
            this.Txt_M_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_M_Nombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Simbolo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Cmb_E_Unidad);
            this.tabPage3.Controls.Add(this.Btn_Eliminar);
            this.tabPage3.Controls.Add(this.Txt_E_Simbolo);
            this.tabPage3.Controls.Add(this.Txt_E_Nombre);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(297, 175);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Cmb_E_Unidad
            // 
            this.Cmb_E_Unidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_E_Unidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_E_Unidad.FormattingEnabled = true;
            this.Cmb_E_Unidad.Location = new System.Drawing.Point(19, 12);
            this.Cmb_E_Unidad.Name = "Cmb_E_Unidad";
            this.Cmb_E_Unidad.Size = new System.Drawing.Size(263, 28);
            this.Cmb_E_Unidad.TabIndex = 1;
            this.Cmb_E_Unidad.SelectedIndexChanged += new System.EventHandler(this.Cmb_E_Unidad_SelectedIndexChanged);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Location = new System.Drawing.Point(112, 131);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Eliminar.TabIndex = 4;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Txt_E_Simbolo
            // 
            this.Txt_E_Simbolo.Enabled = false;
            this.Txt_E_Simbolo.Location = new System.Drawing.Point(112, 96);
            this.Txt_E_Simbolo.Name = "Txt_E_Simbolo";
            this.Txt_E_Simbolo.Size = new System.Drawing.Size(170, 26);
            this.Txt_E_Simbolo.TabIndex = 3;
            // 
            // Txt_E_Nombre
            // 
            this.Txt_E_Nombre.Enabled = false;
            this.Txt_E_Nombre.Location = new System.Drawing.Point(112, 58);
            this.Txt_E_Nombre.Name = "Txt_E_Nombre";
            this.Txt_E_Nombre.Size = new System.Drawing.Size(170, 26);
            this.Txt_E_Nombre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Simbolo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nombre";
            // 
            // Unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 236);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Unidad";
            this.Text = "Administrador de Unidad";
            this.Load += new System.EventHandler(this.Unidad_Load);
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
        private System.Windows.Forms.TextBox Txt_I_Simbolo;
        private System.Windows.Forms.TextBox Txt_I_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Cmb_M_Unidad;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox Txt_M_Simbolo;
        private System.Windows.Forms.TextBox Txt_M_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox Cmb_E_Unidad;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.TextBox Txt_E_Simbolo;
        private System.Windows.Forms.TextBox Txt_E_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}