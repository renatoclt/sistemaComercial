namespace Shalong.Formularios
{
    partial class CreditoTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditoTrabajador));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CodigoUsuario = new System.Windows.Forms.TextBox();
            this.txt_Dolar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_TipoDocumento = new System.Windows.Forms.ComboBox();
            this.cmb_TipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nroDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Observacion = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo de Usuario";
            // 
            // txt_CodigoUsuario
            // 
            this.txt_CodigoUsuario.Location = new System.Drawing.Point(182, 25);
            this.txt_CodigoUsuario.Name = "txt_CodigoUsuario";
            this.txt_CodigoUsuario.Size = new System.Drawing.Size(173, 26);
            this.txt_CodigoUsuario.TabIndex = 1;
            this.txt_CodigoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoUsuario_KeyPress);
            // 
            // txt_Dolar
            // 
            this.txt_Dolar.Location = new System.Drawing.Point(182, 75);
            this.txt_Dolar.Name = "txt_Dolar";
            this.txt_Dolar.Size = new System.Drawing.Size(173, 26);
            this.txt_Dolar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo Documento";
            // 
            // cmb_TipoDocumento
            // 
            this.cmb_TipoDocumento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_TipoDocumento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_TipoDocumento.FormattingEnabled = true;
            this.cmb_TipoDocumento.Location = new System.Drawing.Point(182, 121);
            this.cmb_TipoDocumento.Name = "cmb_TipoDocumento";
            this.cmb_TipoDocumento.Size = new System.Drawing.Size(173, 28);
            this.cmb_TipoDocumento.TabIndex = 5;
            // 
            // cmb_TipoPago
            // 
            this.cmb_TipoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_TipoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_TipoPago.FormattingEnabled = true;
            this.cmb_TipoPago.Location = new System.Drawing.Point(182, 173);
            this.cmb_TipoPago.Name = "cmb_TipoPago";
            this.cmb_TipoPago.Size = new System.Drawing.Size(173, 28);
            this.cmb_TipoPago.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moneda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto ";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(182, 228);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(173, 26);
            this.txt_Monto.TabIndex = 9;
            this.txt_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Monto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Numero documento";
            // 
            // txt_nroDocumento
            // 
            this.txt_nroDocumento.Location = new System.Drawing.Point(182, 273);
            this.txt_nroDocumento.Name = "txt_nroDocumento";
            this.txt_nroDocumento.Size = new System.Drawing.Size(173, 26);
            this.txt_nroDocumento.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Observacion";
            // 
            // txt_Observacion
            // 
            this.txt_Observacion.Location = new System.Drawing.Point(182, 324);
            this.txt_Observacion.Multiline = true;
            this.txt_Observacion.Name = "txt_Observacion";
            this.txt_Observacion.Size = new System.Drawing.Size(173, 134);
            this.txt_Observacion.TabIndex = 13;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(142, 487);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 35);
            this.btn_Guardar.TabIndex = 14;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // CreditoTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 554);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_Observacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nroDocumento);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_TipoPago);
            this.Controls.Add(this.cmb_TipoDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Dolar);
            this.Controls.Add(this.txt_CodigoUsuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreditoTrabajador";
            this.Text = "CreditoTrabajador";
            this.Load += new System.EventHandler(this.CreditoTrabajador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CodigoUsuario;
        private System.Windows.Forms.TextBox txt_Dolar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_TipoDocumento;
        private System.Windows.Forms.ComboBox cmb_TipoPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nroDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Observacion;
        private System.Windows.Forms.Button btn_Guardar;
    }
}