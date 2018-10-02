namespace Shalong.Formularios
{
    partial class Almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacen));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb_I_TipoAlmacen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_I_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_M_TipoAlmacen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_M_Nombre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_M_Nombre = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabControl1.Size = new System.Drawing.Size(317, 212);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_I_TipoAlmacen);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_I_Nombre);
            this.tabPage1.Controls.Add(this.btn_Guardar);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(309, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmb_I_TipoAlmacen
            // 
            this.cmb_I_TipoAlmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_I_TipoAlmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_I_TipoAlmacen.FormattingEnabled = true;
            this.cmb_I_TipoAlmacen.Location = new System.Drawing.Point(86, 67);
            this.cmb_I_TipoAlmacen.Name = "cmb_I_TipoAlmacen";
            this.cmb_I_TipoAlmacen.Size = new System.Drawing.Size(202, 28);
            this.cmb_I_TipoAlmacen.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 40);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo \r\nAlmacen";
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
            this.txt_I_Nombre.Name = "txt_I_Nombre";
            this.txt_I_Nombre.Size = new System.Drawing.Size(202, 26);
            this.txt_I_Nombre.TabIndex = 1;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(86, 122);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 35);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmb_M_TipoAlmacen);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cmb_M_Nombre);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_M_Nombre);
            this.tabPage2.Controls.Add(this.btn_Modificar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(309, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_M_TipoAlmacen
            // 
            this.cmb_M_TipoAlmacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_M_TipoAlmacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_M_TipoAlmacen.FormattingEnabled = true;
            this.cmb_M_TipoAlmacen.Location = new System.Drawing.Point(85, 86);
            this.cmb_M_TipoAlmacen.Name = "cmb_M_TipoAlmacen";
            this.cmb_M_TipoAlmacen.Size = new System.Drawing.Size(202, 28);
            this.cmb_M_TipoAlmacen.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo \r\nAlmacen";
            // 
            // cmb_M_Nombre
            // 
            this.cmb_M_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_M_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_M_Nombre.FormattingEnabled = true;
            this.cmb_M_Nombre.Location = new System.Drawing.Point(11, 8);
            this.cmb_M_Nombre.Name = "cmb_M_Nombre";
            this.cmb_M_Nombre.Size = new System.Drawing.Size(280, 28);
            this.cmb_M_Nombre.TabIndex = 1;
            this.cmb_M_Nombre.SelectedIndexChanged += new System.EventHandler(this.Cmb_M_Nombre_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // txt_M_Nombre
            // 
            this.txt_M_Nombre.Location = new System.Drawing.Point(85, 42);
            this.txt_M_Nombre.Name = "txt_M_Nombre";
            this.txt_M_Nombre.Size = new System.Drawing.Size(202, 26);
            this.txt_M_Nombre.TabIndex = 2;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(85, 134);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(112, 35);
            this.btn_Modificar.TabIndex = 4;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmb_E_Nombre);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btn_Eliminar);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(309, 179);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmb_E_Nombre
            // 
            this.cmb_E_Nombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_E_Nombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_E_Nombre.FormattingEnabled = true;
            this.cmb_E_Nombre.Location = new System.Drawing.Point(100, 40);
            this.cmb_E_Nombre.Name = "cmb_E_Nombre";
            this.cmb_E_Nombre.Size = new System.Drawing.Size(199, 28);
            this.cmb_E_Nombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(97, 120);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(112, 35);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 240);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Almacen";
            this.Text = "Admistrador de Almacenes";
            this.Load += new System.EventHandler(this.Almacen_Load);
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
        private System.Windows.Forms.ComboBox cmb_I_TipoAlmacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_I_Nombre;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmb_M_TipoAlmacen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_M_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_M_Nombre;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmb_E_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Eliminar;

    }
}