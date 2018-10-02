namespace Shalong.Formularios
{
    partial class Credito_Trabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito_Trabajador));
            this.txt_I_NumVoucherTrabajador = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_TipoPagoTrabajador = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_CodigoCreditoTrabajador = new System.Windows.Forms.ComboBox();
            this.btn_I_PagoTrabajador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_ProxPagoTrabajador = new System.Windows.Forms.DateTimePicker();
            this.txt_I_MontoPagarTrabajador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_CreditoCompraTrabajador = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto_Pagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_I_EntidadBancariaTrabajador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_I_NumCuentaTrabajador = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_IngresoCredito = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CreditoCompraTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_I_NumVoucherTrabajador
            // 
            this.txt_I_NumVoucherTrabajador.Location = new System.Drawing.Point(600, 360);
            this.txt_I_NumVoucherTrabajador.Name = "txt_I_NumVoucherTrabajador";
            this.txt_I_NumVoucherTrabajador.Size = new System.Drawing.Size(217, 26);
            this.txt_I_NumVoucherTrabajador.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 109;
            this.label7.Text = "Num voucher";
            // 
            // cmb_TipoPagoTrabajador
            // 
            this.cmb_TipoPagoTrabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_TipoPagoTrabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_TipoPagoTrabajador.FormattingEnabled = true;
            this.cmb_TipoPagoTrabajador.Location = new System.Drawing.Point(201, 360);
            this.cmb_TipoPagoTrabajador.Name = "cmb_TipoPagoTrabajador";
            this.cmb_TipoPagoTrabajador.Size = new System.Drawing.Size(156, 28);
            this.cmb_TipoPagoTrabajador.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 107;
            this.label4.Text = "Tipo Pago";
            // 
            // cmb_CodigoCreditoTrabajador
            // 
            this.cmb_CodigoCreditoTrabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_CodigoCreditoTrabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_CodigoCreditoTrabajador.FormattingEnabled = true;
            this.cmb_CodigoCreditoTrabajador.Location = new System.Drawing.Point(201, 267);
            this.cmb_CodigoCreditoTrabajador.Name = "cmb_CodigoCreditoTrabajador";
            this.cmb_CodigoCreditoTrabajador.Size = new System.Drawing.Size(140, 28);
            this.cmb_CodigoCreditoTrabajador.TabIndex = 106;
            // 
            // btn_I_PagoTrabajador
            // 
            this.btn_I_PagoTrabajador.Location = new System.Drawing.Point(671, 308);
            this.btn_I_PagoTrabajador.Name = "btn_I_PagoTrabajador";
            this.btn_I_PagoTrabajador.Size = new System.Drawing.Size(146, 37);
            this.btn_I_PagoTrabajador.TabIndex = 105;
            this.btn_I_PagoTrabajador.Text = "Pagar";
            this.btn_I_PagoTrabajador.UseVisualStyleBackColor = true;
            this.btn_I_PagoTrabajador.Click += new System.EventHandler(this.btn_I_PagoTrabajador_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Proximo pago";
            // 
            // dtp_ProxPagoTrabajador
            // 
            this.dtp_ProxPagoTrabajador.Location = new System.Drawing.Point(201, 319);
            this.dtp_ProxPagoTrabajador.Name = "dtp_ProxPagoTrabajador";
            this.dtp_ProxPagoTrabajador.Size = new System.Drawing.Size(315, 26);
            this.dtp_ProxPagoTrabajador.TabIndex = 103;
            // 
            // txt_I_MontoPagarTrabajador
            // 
            this.txt_I_MontoPagarTrabajador.Location = new System.Drawing.Point(484, 269);
            this.txt_I_MontoPagarTrabajador.Name = "txt_I_MontoPagarTrabajador";
            this.txt_I_MontoPagarTrabajador.Size = new System.Drawing.Size(142, 26);
            this.txt_I_MontoPagarTrabajador.TabIndex = 102;
            this.txt_I_MontoPagarTrabajador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_I_MontoPagarTrabajador_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 101;
            this.label2.Text = "Monto Pagar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 100;
            this.label1.Text = "Codigo Credito";
            // 
            // dtg_CreditoCompraTrabajador
            // 
            this.dtg_CreditoCompraTrabajador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_CreditoCompraTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_CreditoCompraTrabajador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Proveedor,
            this.Nro_Documento,
            this.Total,
            this.Monto_Pagado,
            this.Deuda,
            this.Fecha});
            this.dtg_CreditoCompraTrabajador.Enabled = false;
            this.dtg_CreditoCompraTrabajador.Location = new System.Drawing.Point(33, 15);
            this.dtg_CreditoCompraTrabajador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_CreditoCompraTrabajador.Name = "dtg_CreditoCompraTrabajador";
            this.dtg_CreditoCompraTrabajador.Size = new System.Drawing.Size(784, 231);
            this.dtg_CreditoCompraTrabajador.TabIndex = 111;
            this.dtg_CreditoCompraTrabajador.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtg_CreditoCompraTrabajador_DataBindingComplete);
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
            this.Proveedor.HeaderText = "Trabajador";
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
            // txt_I_EntidadBancariaTrabajador
            // 
            this.txt_I_EntidadBancariaTrabajador.Location = new System.Drawing.Point(600, 410);
            this.txt_I_EntidadBancariaTrabajador.Name = "txt_I_EntidadBancariaTrabajador";
            this.txt_I_EntidadBancariaTrabajador.Size = new System.Drawing.Size(217, 26);
            this.txt_I_EntidadBancariaTrabajador.TabIndex = 115;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 114;
            this.label6.Text = "Entidad bancaria";
            // 
            // txt_I_NumCuentaTrabajador
            // 
            this.txt_I_NumCuentaTrabajador.Location = new System.Drawing.Point(201, 410);
            this.txt_I_NumCuentaTrabajador.Name = "txt_I_NumCuentaTrabajador";
            this.txt_I_NumCuentaTrabajador.Size = new System.Drawing.Size(217, 26);
            this.txt_I_NumCuentaTrabajador.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 413);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 112;
            this.label5.Text = "Numero de cuenta";
            // 
            // btn_IngresoCredito
            // 
            this.btn_IngresoCredito.Location = new System.Drawing.Point(671, 270);
            this.btn_IngresoCredito.Name = "btn_IngresoCredito";
            this.btn_IngresoCredito.Size = new System.Drawing.Size(146, 32);
            this.btn_IngresoCredito.TabIndex = 116;
            this.btn_IngresoCredito.Text = "Nuevo Credito";
            this.btn_IngresoCredito.UseVisualStyleBackColor = true;
            this.btn_IngresoCredito.Click += new System.EventHandler(this.btn_IngresoCredito_Click_1);
            // 
            // Credito_Trabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 453);
            this.Controls.Add(this.btn_IngresoCredito);
            this.Controls.Add(this.txt_I_EntidadBancariaTrabajador);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_I_NumCuentaTrabajador);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_I_NumVoucherTrabajador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_TipoPagoTrabajador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_CodigoCreditoTrabajador);
            this.Controls.Add(this.btn_I_PagoTrabajador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_ProxPagoTrabajador);
            this.Controls.Add(this.txt_I_MontoPagarTrabajador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_CreditoCompraTrabajador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Credito_Trabajador";
            this.Text = "Credito_Trabajador";
            this.Load += new System.EventHandler(this.Credito_Trabajador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_CreditoCompraTrabajador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_I_NumVoucherTrabajador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_TipoPagoTrabajador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_CodigoCreditoTrabajador;
        private System.Windows.Forms.Button btn_I_PagoTrabajador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_ProxPagoTrabajador;
        private System.Windows.Forms.TextBox txt_I_MontoPagarTrabajador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_CreditoCompraTrabajador;
        private System.Windows.Forms.TextBox txt_I_EntidadBancariaTrabajador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_I_NumCuentaTrabajador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_IngresoCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto_Pagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;

    }
}