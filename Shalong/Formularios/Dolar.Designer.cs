namespace Shalong.Formularios
{
    partial class Dolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dolar));
            this.tab_TipoCambio = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Dt_I_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Txt_I_Valor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Dt_M_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Txt_M_Valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tab_TipoCambio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_TipoCambio
            // 
            this.tab_TipoCambio.Controls.Add(this.tabPage1);
            this.tab_TipoCambio.Controls.Add(this.tabPage2);
            this.tab_TipoCambio.Location = new System.Drawing.Point(12, 16);
            this.tab_TipoCambio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tab_TipoCambio.Name = "tab_TipoCambio";
            this.tab_TipoCambio.SelectedIndex = 0;
            this.tab_TipoCambio.Size = new System.Drawing.Size(435, 190);
            this.tab_TipoCambio.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Dt_I_Fecha);
            this.tabPage1.Controls.Add(this.Btn_guardar);
            this.tabPage1.Controls.Add(this.Txt_I_Valor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(427, 157);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Dt_I_Fecha
            // 
            this.Dt_I_Fecha.Enabled = false;
            this.Dt_I_Fecha.Location = new System.Drawing.Point(109, 46);
            this.Dt_I_Fecha.Name = "Dt_I_Fecha";
            this.Dt_I_Fecha.Size = new System.Drawing.Size(310, 26);
            this.Dt_I_Fecha.TabIndex = 11;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.Location = new System.Drawing.Point(193, 102);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(102, 32);
            this.Btn_guardar.TabIndex = 4;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Txt_I_Valor
            // 
            this.Txt_I_Valor.Location = new System.Drawing.Point(109, 8);
            this.Txt_I_Valor.Name = "Txt_I_Valor";
            this.Txt_I_Valor.Size = new System.Drawing.Size(310, 26);
            this.Txt_I_Valor.TabIndex = 2;
            this.Txt_I_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_Valor_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Dt_M_Fecha);
            this.tabPage2.Controls.Add(this.Btn_Modificar);
            this.tabPage2.Controls.Add(this.Txt_M_Valor);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(427, 157);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Dt_M_Fecha
            // 
            this.Dt_M_Fecha.Enabled = false;
            this.Dt_M_Fecha.Location = new System.Drawing.Point(110, 57);
            this.Dt_M_Fecha.Name = "Dt_M_Fecha";
            this.Dt_M_Fecha.Size = new System.Drawing.Size(310, 26);
            this.Dt_M_Fecha.TabIndex = 10;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(199, 99);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(102, 32);
            this.Btn_Modificar.TabIndex = 9;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click_1);
            // 
            // Txt_M_Valor
            // 
            this.Txt_M_Valor.Location = new System.Drawing.Point(110, 20);
            this.Txt_M_Valor.Name = "Txt_M_Valor";
            this.Txt_M_Valor.Size = new System.Drawing.Size(310, 26);
            this.Txt_M_Valor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor";
            // 
            // Dolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 223);
            this.Controls.Add(this.tab_TipoCambio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dolar";
            this.Text = "Valor del Dolar";
            this.Load += new System.EventHandler(this.Dolar_Load);
            this.tab_TipoCambio.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_TipoCambio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker Dt_I_Fecha;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.TextBox Txt_I_Valor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker Dt_M_Fecha;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.TextBox Txt_M_Valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;


    }
}