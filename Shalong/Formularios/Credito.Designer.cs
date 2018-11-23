namespace Shalong.Formularios
{
    partial class Credito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito));
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_proximoPago = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_I_TotalDeuda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_I_MontoPagado = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.Txt_I_NumDocumento = new System.Windows.Forms.TextBox();
            this.lbl_Proveedor = new System.Windows.Forms.Label();
            this.Cmb_I_Proveedor = new System.Windows.Forms.ComboBox();
            this.Cmb_SelectCredito = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Proximo Pago";
            // 
            // dtp_proximoPago
            // 
            this.dtp_proximoPago.Location = new System.Drawing.Point(199, 172);
            this.dtp_proximoPago.Name = "dtp_proximoPago";
            this.dtp_proximoPago.Size = new System.Drawing.Size(200, 26);
            this.dtp_proximoPago.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total de Deuda";
            // 
            // Txt_I_TotalDeuda
            // 
            this.Txt_I_TotalDeuda.Location = new System.Drawing.Point(199, 219);
            this.Txt_I_TotalDeuda.Name = "Txt_I_TotalDeuda";
            this.Txt_I_TotalDeuda.Size = new System.Drawing.Size(200, 26);
            this.Txt_I_TotalDeuda.TabIndex = 5;
            this.Txt_I_TotalDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Monto de Pagado";
            // 
            // Txt_I_MontoPagado
            // 
            this.Txt_I_MontoPagado.Location = new System.Drawing.Point(199, 272);
            this.Txt_I_MontoPagado.Name = "Txt_I_MontoPagado";
            this.Txt_I_MontoPagado.Size = new System.Drawing.Size(200, 26);
            this.Txt_I_MontoPagado.TabIndex = 6;
            this.Txt_I_MontoPagado.Text = "0";
            this.Txt_I_MontoPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(161, 326);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(119, 38);
            this.Btn_Guardar.TabIndex = 7;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(17, 91);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(112, 20);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "N° Documento";
            // 
            // Txt_I_NumDocumento
            // 
            this.Txt_I_NumDocumento.Location = new System.Drawing.Point(199, 85);
            this.Txt_I_NumDocumento.Name = "Txt_I_NumDocumento";
            this.Txt_I_NumDocumento.Size = new System.Drawing.Size(200, 26);
            this.Txt_I_NumDocumento.TabIndex = 2;
            this.Txt_I_NumDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Proveedor
            // 
            this.lbl_Proveedor.AutoSize = true;
            this.lbl_Proveedor.Location = new System.Drawing.Point(17, 128);
            this.lbl_Proveedor.Name = "lbl_Proveedor";
            this.lbl_Proveedor.Size = new System.Drawing.Size(81, 20);
            this.lbl_Proveedor.TabIndex = 10;
            this.lbl_Proveedor.Text = "Proveedor";
            // 
            // Cmb_I_Proveedor
            // 
            this.Cmb_I_Proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_I_Proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_I_Proveedor.FormattingEnabled = true;
            this.Cmb_I_Proveedor.Items.AddRange(new object[] {
            "Credito de Compra",
            "Credito de Venta"});
            this.Cmb_I_Proveedor.Location = new System.Drawing.Point(199, 125);
            this.Cmb_I_Proveedor.Name = "Cmb_I_Proveedor";
            this.Cmb_I_Proveedor.Size = new System.Drawing.Size(200, 28);
            this.Cmb_I_Proveedor.TabIndex = 3;
            // 
            // Cmb_SelectCredito
            // 
            this.Cmb_SelectCredito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_SelectCredito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_SelectCredito.Enabled = false;
            this.Cmb_SelectCredito.FormattingEnabled = true;
            this.Cmb_SelectCredito.Items.AddRange(new object[] {
            "Credito de Compra",
            "Credito de Venta"});
            this.Cmb_SelectCredito.Location = new System.Drawing.Point(104, 12);
            this.Cmb_SelectCredito.Name = "Cmb_SelectCredito";
            this.Cmb_SelectCredito.Size = new System.Drawing.Size(235, 28);
            this.Cmb_SelectCredito.TabIndex = 1;
            this.Cmb_SelectCredito.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectCredito_SelectedIndexChanged);
            // 
            // Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 385);
            this.Controls.Add(this.Cmb_I_Proveedor);
            this.Controls.Add(this.lbl_Proveedor);
            this.Controls.Add(this.Txt_I_NumDocumento);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Cmb_SelectCredito);
            this.Controls.Add(this.Txt_I_MontoPagado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_I_TotalDeuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_proximoPago);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Credito";
            this.Text = "Crear Credito";
            this.Load += new System.EventHandler(this.Credito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_proximoPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_I_TotalDeuda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_I_MontoPagado;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox Txt_I_NumDocumento;
        private System.Windows.Forms.Label lbl_Proveedor;
        private System.Windows.Forms.ComboBox Cmb_I_Proveedor;
        private System.Windows.Forms.ComboBox Cmb_SelectCredito;
    }
}