namespace Shalong.Formularios
{
    partial class Credito_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito_Venta));
            this.btn_Pagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_CodigoCredito = new System.Windows.Forms.ComboBox();
            this.dtg_CreditoVenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_TipoPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CreditoVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.Location = new System.Drawing.Point(655, 268);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(112, 72);
            this.btn_Pagar.TabIndex = 15;
            this.btn_Pagar.Text = "Pagar";
            this.btn_Pagar.UseVisualStyleBackColor = true;
            this.btn_Pagar.Click += new System.EventHandler(this.btn_Pagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Proximo pago";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(151, 356);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(308, 26);
            this.dtp_Fecha.TabIndex = 13;
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(434, 268);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(142, 26);
            this.txt_Monto.TabIndex = 12;
            this.txt_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Monto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Monto Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo Credito";
            // 
            // cmb_CodigoCredito
            // 
            this.cmb_CodigoCredito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_CodigoCredito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_CodigoCredito.FormattingEnabled = true;
            this.cmb_CodigoCredito.Location = new System.Drawing.Point(151, 267);
            this.cmb_CodigoCredito.Name = "cmb_CodigoCredito";
            this.cmb_CodigoCredito.Size = new System.Drawing.Size(140, 28);
            this.cmb_CodigoCredito.TabIndex = 16;
            // 
            // dtg_CreditoVenta
            // 
            this.dtg_CreditoVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_CreditoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CreditoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cliente,
            this.Nro_Documento,
            this.Total,
            this.Monto_Pagado,
            this.Deuda,
            this.Fecha});
            this.dtg_CreditoVenta.Enabled = false;
            this.dtg_CreditoVenta.Location = new System.Drawing.Point(17, 14);
            this.dtg_CreditoVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_CreditoVenta.Name = "dtg_CreditoVenta";
            this.dtg_CreditoVenta.Size = new System.Drawing.Size(754, 231);
            this.dtg_CreditoVenta.TabIndex = 100;
            this.dtg_CreditoVenta.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtg_CreditoVenta_DataBindingComplete);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodigoCredito";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Nombre";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
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
            // cmb_TipoPago
            // 
            this.cmb_TipoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_TipoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_TipoPago.FormattingEnabled = true;
            this.cmb_TipoPago.Location = new System.Drawing.Point(151, 314);
            this.cmb_TipoPago.Name = "cmb_TipoPago";
            this.cmb_TipoPago.Size = new System.Drawing.Size(161, 28);
            this.cmb_TipoPago.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tipo Pago";
            // 
            // Credito_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 394);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_TipoPago);
            this.Controls.Add(this.dtg_CreditoVenta);
            this.Controls.Add(this.cmb_CodigoCredito);
            this.Controls.Add(this.btn_Pagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Credito_Venta";
            this.Text = "Credito_Venta";
            this.Load += new System.EventHandler(this.Credito_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CreditoVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_CodigoCredito;
        private System.Windows.Forms.DataGridView dtg_CreditoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.ComboBox cmb_TipoPago;
        private System.Windows.Forms.Label label4;
    }
}