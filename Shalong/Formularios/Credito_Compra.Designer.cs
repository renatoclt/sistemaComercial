namespace Shalong.Formularios
{
    partial class Credito_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito_Compra));
            this.dtg_CreditoCompra = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_I_MontoPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_ProxPago = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_I_Pago = new System.Windows.Forms.Button();
            this.Cmb_CodigoCredito = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Cmb_TipoPago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_I_NumCuenta = new System.Windows.Forms.TextBox();
            this.Txt_I_EntidadBancaria = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_I_NumVoucher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CreditoCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_CreditoCompra
            // 
            this.dtg_CreditoCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_CreditoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CreditoCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Proveedor,
            this.Nro_Documento,
            this.Total,
            this.Monto_Pagado,
            this.Deuda,
            this.Fecha});
            this.dtg_CreditoCompra.Enabled = false;
            this.dtg_CreditoCompra.Location = new System.Drawing.Point(22, 14);
            this.dtg_CreditoCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_CreditoCompra.Name = "dtg_CreditoCompra";
            this.dtg_CreditoCompra.Size = new System.Drawing.Size(754, 231);
            this.dtg_CreditoCompra.TabIndex = 99;
            this.dtg_CreditoCompra.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtg_CreditoCompra_DataBindingComplete);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodigoCredito";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Proveedor
            // 
            this.Proveedor.DataPropertyName = "Nombre";
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            // 
            // Nro_Documento
            // 
            this.Nro_Documento.DataPropertyName = "NumeroDocumento";
            this.Nro_Documento.HeaderText = "Nro Documento";
            this.Nro_Documento.Name = "Nro_Documento";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "TotalDeudaString";
            this.Total.HeaderText = "Total Deuda";
            this.Total.Name = "Total";
            // 
            // Monto_Pagado
            // 
            this.Monto_Pagado.DataPropertyName = "MontoString";
            this.Monto_Pagado.HeaderText = "Monto Pagado";
            this.Monto_Pagado.Name = "Monto_Pagado";
            // 
            // Deuda
            // 
            this.Deuda.DataPropertyName = "DeudaString";
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha Pago";
            this.Fecha.Name = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo Credito";
            // 
            // Txt_I_MontoPagar
            // 
            this.Txt_I_MontoPagar.Location = new System.Drawing.Point(443, 268);
            this.Txt_I_MontoPagar.Name = "Txt_I_MontoPagar";
            this.Txt_I_MontoPagar.Size = new System.Drawing.Size(142, 26);
            this.Txt_I_MontoPagar.TabIndex = 4;
            this.Txt_I_MontoPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_I_MontoPagar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto Pagar";
            // 
            // dtp_ProxPago
            // 
            this.dtp_ProxPago.Location = new System.Drawing.Point(160, 318);
            this.dtp_ProxPago.Name = "dtp_ProxPago";
            this.dtp_ProxPago.Size = new System.Drawing.Size(315, 26);
            this.dtp_ProxPago.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proximo pago";
            // 
            // Btn_I_Pago
            // 
            this.Btn_I_Pago.Location = new System.Drawing.Point(664, 268);
            this.Btn_I_Pago.Name = "Btn_I_Pago";
            this.Btn_I_Pago.Size = new System.Drawing.Size(112, 72);
            this.Btn_I_Pago.TabIndex = 7;
            this.Btn_I_Pago.Text = "Pagar";
            this.Btn_I_Pago.UseVisualStyleBackColor = true;
            this.Btn_I_Pago.Click += new System.EventHandler(this.Btn_I_Pago_Click);
            // 
            // Cmb_CodigoCredito
            // 
            this.Cmb_CodigoCredito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_CodigoCredito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_CodigoCredito.FormattingEnabled = true;
            this.Cmb_CodigoCredito.Location = new System.Drawing.Point(160, 266);
            this.Cmb_CodigoCredito.Name = "Cmb_CodigoCredito";
            this.Cmb_CodigoCredito.Size = new System.Drawing.Size(140, 28);
            this.Cmb_CodigoCredito.TabIndex = 17;
            this.Cmb_CodigoCredito.SelectedIndexChanged += new System.EventHandler(this.Cmb_CodigoCredito_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo Pago";
            // 
            // Cmb_TipoPago
            // 
            this.Cmb_TipoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_TipoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_TipoPago.FormattingEnabled = true;
            this.Cmb_TipoPago.Location = new System.Drawing.Point(160, 359);
            this.Cmb_TipoPago.Name = "Cmb_TipoPago";
            this.Cmb_TipoPago.Size = new System.Drawing.Size(156, 28);
            this.Cmb_TipoPago.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Numero de cuenta";
            // 
            // Txt_I_NumCuenta
            // 
            this.Txt_I_NumCuenta.Location = new System.Drawing.Point(168, 398);
            this.Txt_I_NumCuenta.Name = "Txt_I_NumCuenta";
            this.Txt_I_NumCuenta.Size = new System.Drawing.Size(217, 26);
            this.Txt_I_NumCuenta.TabIndex = 21;
            // 
            // Txt_I_EntidadBancaria
            // 
            this.Txt_I_EntidadBancaria.Location = new System.Drawing.Point(559, 398);
            this.Txt_I_EntidadBancaria.Name = "Txt_I_EntidadBancaria";
            this.Txt_I_EntidadBancaria.Size = new System.Drawing.Size(217, 26);
            this.Txt_I_EntidadBancaria.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Entidad bancaria";
            // 
            // Txt_I_NumVoucher
            // 
            this.Txt_I_NumVoucher.Location = new System.Drawing.Point(559, 359);
            this.Txt_I_NumVoucher.Name = "Txt_I_NumVoucher";
            this.Txt_I_NumVoucher.Size = new System.Drawing.Size(217, 26);
            this.Txt_I_NumVoucher.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Num voucher";
            // 
            // Credito_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 452);
            this.Controls.Add(this.Txt_I_NumVoucher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_I_EntidadBancaria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_I_NumCuenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cmb_TipoPago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cmb_CodigoCredito);
            this.Controls.Add(this.Btn_I_Pago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_ProxPago);
            this.Controls.Add(this.Txt_I_MontoPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_CreditoCompra);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Credito_Compra";
            this.Text = "Compras al Credito";
            this.Load += new System.EventHandler(this.Credito_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CreditoCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_CreditoCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_I_MontoPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ProxPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_I_Pago;
        private System.Windows.Forms.ComboBox Cmb_CodigoCredito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Cmb_TipoPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_I_NumCuenta;
        private System.Windows.Forms.TextBox Txt_I_EntidadBancaria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_I_NumVoucher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}