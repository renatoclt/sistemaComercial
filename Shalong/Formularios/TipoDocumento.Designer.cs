﻿namespace Shalong.Formularios
{
    partial class TipoDocumento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoDocumento));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ingresar = new System.Windows.Forms.TabPage();
            this.btn_I_TipoDocumento = new System.Windows.Forms.Button();
            this.txt_I_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Modificar = new System.Windows.Forms.TabPage();
            this.btn_M_TipoDocumento = new System.Windows.Forms.Button();
            this.txt_M_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_M_TipoDocumento = new System.Windows.Forms.Label();
            this.cmb_M_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.btn_E_TipoDocumento = new System.Windows.Forms.Button();
            this.cmb_E_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.txt_E_TipoDocumento = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Ingresar.SuspendLayout();
            this.Modificar.SuspendLayout();
            this.Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ingresar);
            this.tabControl1.Controls.Add(this.Modificar);
            this.tabControl1.Controls.Add(this.Eliminar);
            this.tabControl1.Location = new System.Drawing.Point(24, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 197);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // Ingresar
            // 
            this.Ingresar.Controls.Add(this.btn_I_TipoDocumento);
            this.Ingresar.Controls.Add(this.txt_I_Nombre);
            this.Ingresar.Controls.Add(this.label1);
            this.Ingresar.Location = new System.Drawing.Point(4, 29);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Padding = new System.Windows.Forms.Padding(3);
            this.Ingresar.Size = new System.Drawing.Size(339, 164);
            this.Ingresar.TabIndex = 0;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = true;
            // 
            // btn_I_TipoDocumento
            // 
            this.btn_I_TipoDocumento.Location = new System.Drawing.Point(104, 104);
            this.btn_I_TipoDocumento.Name = "btn_I_TipoDocumento";
            this.btn_I_TipoDocumento.Size = new System.Drawing.Size(113, 37);
            this.btn_I_TipoDocumento.TabIndex = 6;
            this.btn_I_TipoDocumento.Text = "Ingresar";
            this.btn_I_TipoDocumento.UseVisualStyleBackColor = true;
            this.btn_I_TipoDocumento.Click += new System.EventHandler(this.btn_I_TipoDocumento_Click);
            // 
            // txt_I_Nombre
            // 
            this.txt_I_Nombre.Location = new System.Drawing.Point(104, 50);
            this.txt_I_Nombre.MaxLength = 50;
            this.txt_I_Nombre.Name = "txt_I_Nombre";
            this.txt_I_Nombre.Size = new System.Drawing.Size(217, 26);
            this.txt_I_Nombre.TabIndex = 1;
            this.txt_I_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_I_Nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // Modificar
            // 
            this.Modificar.Controls.Add(this.btn_M_TipoDocumento);
            this.Modificar.Controls.Add(this.txt_M_Nombre);
            this.Modificar.Controls.Add(this.lbl_M_TipoDocumento);
            this.Modificar.Controls.Add(this.cmb_M_TipoDocumento);
            this.Modificar.Location = new System.Drawing.Point(4, 29);
            this.Modificar.Name = "Modificar";
            this.Modificar.Padding = new System.Windows.Forms.Padding(3);
            this.Modificar.Size = new System.Drawing.Size(339, 164);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_M_TipoDocumento
            // 
            this.btn_M_TipoDocumento.Location = new System.Drawing.Point(112, 108);
            this.btn_M_TipoDocumento.Name = "btn_M_TipoDocumento";
            this.btn_M_TipoDocumento.Size = new System.Drawing.Size(112, 38);
            this.btn_M_TipoDocumento.TabIndex = 3;
            this.btn_M_TipoDocumento.Text = "Modificar";
            this.btn_M_TipoDocumento.UseVisualStyleBackColor = true;
            this.btn_M_TipoDocumento.Click += new System.EventHandler(this.btn_M_TipoDocumento_Click);
            // 
            // txt_M_Nombre
            // 
            this.txt_M_Nombre.Location = new System.Drawing.Point(123, 62);
            this.txt_M_Nombre.MaxLength = 50;
            this.txt_M_Nombre.Name = "txt_M_Nombre";
            this.txt_M_Nombre.Size = new System.Drawing.Size(193, 26);
            this.txt_M_Nombre.TabIndex = 1;
            this.txt_M_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_M_Nombre_KeyPress);
            // 
            // lbl_M_TipoDocumento
            // 
            this.lbl_M_TipoDocumento.AutoSize = true;
            this.lbl_M_TipoDocumento.Location = new System.Drawing.Point(36, 65);
            this.lbl_M_TipoDocumento.Name = "lbl_M_TipoDocumento";
            this.lbl_M_TipoDocumento.Size = new System.Drawing.Size(65, 20);
            this.lbl_M_TipoDocumento.TabIndex = 0;
            this.lbl_M_TipoDocumento.Text = "Nombre";
            // 
            // cmb_M_TipoDocumento
            // 
            this.cmb_M_TipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_M_TipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_M_TipoDocumento.FormattingEnabled = true;
            this.cmb_M_TipoDocumento.Location = new System.Drawing.Point(24, 15);
            this.cmb_M_TipoDocumento.Name = "cmb_M_TipoDocumento";
            this.cmb_M_TipoDocumento.Size = new System.Drawing.Size(292, 28);
            this.cmb_M_TipoDocumento.TabIndex = 0;
            this.cmb_M_TipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmb_M_TipoDocumento_SelectedIndexChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.btn_E_TipoDocumento);
            this.Eliminar.Controls.Add(this.cmb_E_TipoDocumento);
            this.Eliminar.Controls.Add(this.txt_E_TipoDocumento);
            this.Eliminar.Location = new System.Drawing.Point(4, 29);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminar.Size = new System.Drawing.Size(339, 164);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_E_TipoDocumento
            // 
            this.btn_E_TipoDocumento.Location = new System.Drawing.Point(113, 104);
            this.btn_E_TipoDocumento.Name = "btn_E_TipoDocumento";
            this.btn_E_TipoDocumento.Size = new System.Drawing.Size(111, 37);
            this.btn_E_TipoDocumento.TabIndex = 2;
            this.btn_E_TipoDocumento.Text = "Eliminar";
            this.btn_E_TipoDocumento.UseVisualStyleBackColor = true;
            this.btn_E_TipoDocumento.Click += new System.EventHandler(this.btn_E_TipoDocumento_Click);
            // 
            // cmb_E_TipoDocumento
            // 
            this.cmb_E_TipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_E_TipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_E_TipoDocumento.FormattingEnabled = true;
            this.cmb_E_TipoDocumento.Location = new System.Drawing.Point(113, 48);
            this.cmb_E_TipoDocumento.Name = "cmb_E_TipoDocumento";
            this.cmb_E_TipoDocumento.Size = new System.Drawing.Size(204, 28);
            this.cmb_E_TipoDocumento.TabIndex = 1;
            this.cmb_E_TipoDocumento.SelectedIndexChanged += new System.EventHandler(this.cmb_E_TipoDocumento_SelectedIndexChanged);
            // 
            // txt_E_TipoDocumento
            // 
            this.txt_E_TipoDocumento.AutoSize = true;
            this.txt_E_TipoDocumento.Location = new System.Drawing.Point(31, 51);
            this.txt_E_TipoDocumento.Name = "txt_E_TipoDocumento";
            this.txt_E_TipoDocumento.Size = new System.Drawing.Size(65, 20);
            this.txt_E_TipoDocumento.TabIndex = 0;
            this.txt_E_TipoDocumento.Text = "Nombre";
            // 
            // TipoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 237);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TipoDocumento";
            this.Text = "Administrador de Tipo de Documento";
            this.Load += new System.EventHandler(this.TipoDocumento_Load);
            this.tabControl1.ResumeLayout(false);
            this.Ingresar.ResumeLayout(false);
            this.Ingresar.PerformLayout();
            this.Modificar.ResumeLayout(false);
            this.Modificar.PerformLayout();
            this.Eliminar.ResumeLayout(false);
            this.Eliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ingresar;
        private System.Windows.Forms.TabPage Modificar;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.Button btn_I_TipoDocumento;
        private System.Windows.Forms.TextBox txt_I_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_M_TipoDocumento;
        private System.Windows.Forms.TextBox txt_M_Nombre;
        private System.Windows.Forms.Label lbl_M_TipoDocumento;
        private System.Windows.Forms.ComboBox cmb_M_TipoDocumento;
        private System.Windows.Forms.Button btn_E_TipoDocumento;
        private System.Windows.Forms.ComboBox cmb_E_TipoDocumento;
        private System.Windows.Forms.Label txt_E_TipoDocumento;
    }
}