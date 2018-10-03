namespace Shalong.Formularios
{
    partial class F_ReporteCreditoVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ReporteCreditoVenta));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Pagos = new System.Windows.Forms.DataGridView();
            this.NumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntidadBancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Caja = new System.Windows.Forms.Button();
            this.cmb_Caja = new System.Windows.Forms.ComboBox();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Voucher = new System.Windows.Forms.Button();
            this.btn_Documento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.txt_Voucher = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Fecha = new System.Windows.Forms.Button();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pagos)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Pagos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.04301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.95699F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1043, 469);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Pagos
            // 
            this.dgv_Pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Pagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDocumento,
            this.NumVoucher,
            this.NombreCaja,
            this.NombreTipoPago,
            this.Cliente,
            this.NumCuenta,
            this.EntidadBancaria,
            this.MontoPagado,
            this.FechaPago});
            this.dgv_Pagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Pagos.Location = new System.Drawing.Point(4, 155);
            this.dgv_Pagos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Pagos.Name = "dgv_Pagos";
            this.dgv_Pagos.RowHeadersVisible = false;
            this.dgv_Pagos.Size = new System.Drawing.Size(1035, 309);
            this.dgv_Pagos.TabIndex = 0;
            // 
            // NumDocumento
            // 
            this.NumDocumento.DataPropertyName = "NumDocumento";
            this.NumDocumento.HeaderText = "Numero de Documento";
            this.NumDocumento.Name = "NumDocumento";
            // 
            // NumVoucher
            // 
            this.NumVoucher.DataPropertyName = "NumVoucher";
            this.NumVoucher.HeaderText = "Numero de Voucher";
            this.NumVoucher.Name = "NumVoucher";
            // 
            // NombreCaja
            // 
            this.NombreCaja.DataPropertyName = "NombreCaja";
            this.NombreCaja.HeaderText = "Caja";
            this.NombreCaja.Name = "NombreCaja";
            // 
            // NombreTipoPago
            // 
            this.NombreTipoPago.DataPropertyName = "NombreTipoPago";
            this.NombreTipoPago.HeaderText = "Tipo de Pago";
            this.NombreTipoPago.Name = "NombreTipoPago";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NombreCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // NumCuenta
            // 
            this.NumCuenta.DataPropertyName = "NumCuenta";
            this.NumCuenta.HeaderText = "Numero de Cuenta";
            this.NumCuenta.Name = "NumCuenta";
            // 
            // EntidadBancaria
            // 
            this.EntidadBancaria.DataPropertyName = "EntidadBancaria";
            this.EntidadBancaria.HeaderText = "Entidad Bancaria";
            this.EntidadBancaria.Name = "EntidadBancaria";
            // 
            // MontoPagado
            // 
            this.MontoPagado.DataPropertyName = "MontoPagar";
            this.MontoPagado.HeaderText = "Monto Pagado";
            this.MontoPagado.Name = "MontoPagado";
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha de Pago";
            this.FechaPago.Name = "FechaPago";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1037, 144);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.177497F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.88361F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.86324F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.341416F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.03104F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.25121F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.35499F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Cliente, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Caja, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Caja, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Cliente, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Exportar, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1031, 42);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caja :";
            // 
            // cmb_Cliente
            // 
            this.cmb_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Cliente.FormattingEnabled = true;
            this.cmb_Cliente.Location = new System.Drawing.Point(480, 10);
            this.cmb_Cliente.Name = "cmb_Cliente";
            this.cmb_Cliente.Size = new System.Drawing.Size(276, 28);
            this.cmb_Cliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente :";
            // 
            // btn_Caja
            // 
            this.btn_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Caja.Location = new System.Drawing.Point(282, 4);
            this.btn_Caja.Name = "btn_Caja";
            this.btn_Caja.Size = new System.Drawing.Size(105, 34);
            this.btn_Caja.TabIndex = 3;
            this.btn_Caja.Text = "Buscar";
            this.btn_Caja.UseVisualStyleBackColor = true;
            this.btn_Caja.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_Caja
            // 
            this.cmb_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Caja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Caja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Caja.FormattingEnabled = true;
            this.cmb_Caja.Location = new System.Drawing.Point(77, 7);
            this.cmb_Caja.Name = "cmb_Caja";
            this.cmb_Caja.Size = new System.Drawing.Size(193, 28);
            this.cmb_Caja.TabIndex = 4;
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Cliente.Location = new System.Drawing.Point(769, 4);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(105, 34);
            this.btn_Cliente.TabIndex = 0;
            this.btn_Cliente.Text = "Buscar";
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exportar.Location = new System.Drawing.Point(904, 4);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(105, 34);
            this.btn_Exportar.TabIndex = 6;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.06402F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.8904F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.09408F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.8031F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53928F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.51212F));
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Voucher, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Documento, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_Documento, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_Voucher, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1031, 42);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nº Documento :";
            // 
            // btn_Voucher
            // 
            this.btn_Voucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Voucher.Location = new System.Drawing.Point(904, 4);
            this.btn_Voucher.Name = "btn_Voucher";
            this.btn_Voucher.Size = new System.Drawing.Size(105, 34);
            this.btn_Voucher.TabIndex = 4;
            this.btn_Voucher.Text = "Buscar";
            this.btn_Voucher.UseVisualStyleBackColor = true;
            this.btn_Voucher.Click += new System.EventHandler(this.btn_Voucher_Click);
            // 
            // btn_Documento
            // 
            this.btn_Documento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Documento.Location = new System.Drawing.Point(384, 4);
            this.btn_Documento.Name = "btn_Documento";
            this.btn_Documento.Size = new System.Drawing.Size(105, 34);
            this.btn_Documento.TabIndex = 5;
            this.btn_Documento.Text = "Buscar";
            this.btn_Documento.UseVisualStyleBackColor = true;
            this.btn_Documento.Click += new System.EventHandler(this.btn_Documento_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(555, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nº Voucher";
            // 
            // txt_Documento
            // 
            this.txt_Documento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Documento.Location = new System.Drawing.Point(148, 8);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(208, 26);
            this.txt_Documento.TabIndex = 8;
            this.txt_Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_KeyPress);
            // 
            // txt_Voucher
            // 
            this.txt_Voucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Voucher.Location = new System.Drawing.Point(651, 8);
            this.txt_Voucher.Name = "txt_Voucher";
            this.txt_Voucher.Size = new System.Drawing.Size(225, 26);
            this.txt_Voucher.TabIndex = 9;
            this.txt_Voucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Voucher_KeyPress);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.923375F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.03783F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.632396F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.45587F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.24151F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_Fecha, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtp_hasta, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtp_de, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1031, 42);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "De :";
            // 
            // btn_Fecha
            // 
            this.btn_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Fecha.Location = new System.Drawing.Point(814, 4);
            this.btn_Fecha.Name = "btn_Fecha";
            this.btn_Fecha.Size = new System.Drawing.Size(105, 34);
            this.btn_Fecha.TabIndex = 6;
            this.btn_Fecha.Text = "Buscar";
            this.btn_Fecha.UseVisualStyleBackColor = true;
            this.btn_Fecha.Click += new System.EventHandler(this.btn_Fecha_Click);
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_hasta.Location = new System.Drawing.Point(501, 8);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(291, 26);
            this.dtp_hasta.TabIndex = 7;
            // 
            // dtp_de
            // 
            this.dtp_de.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_de.Location = new System.Drawing.Point(94, 8);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(288, 26);
            this.dtp_de.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hasta :";
            // 
            // F_ReporteCreditoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 469);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_ReporteCreditoVenta";
            this.Text = "Reporte de Ventas al Credito";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pagos)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Pagos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.ComboBox cmb_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Caja;
        private System.Windows.Forms.ComboBox cmb_Caja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txt_Voucher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Voucher;
        private System.Windows.Forms.Button btn_Documento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntidadBancaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Fecha;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.DateTimePicker dtp_de;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Exportar;
    }
}