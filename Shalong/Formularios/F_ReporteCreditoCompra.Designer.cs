namespace Shalong.Formularios
{
    partial class F_ReporteCreditoCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ReporteCreditoCompra));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Credito = new System.Windows.Forms.DataGridView();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntidadBancaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Caja = new System.Windows.Forms.Button();
            this.cmb_Caja = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Proveedor = new System.Windows.Forms.Button();
            this.cmb_Proveedor = new System.Windows.Forms.ComboBox();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_NVoucher = new System.Windows.Forms.Button();
            this.btn_NDocumento = new System.Windows.Forms.Button();
            this.txt_NVoucher = new System.Windows.Forms.TextBox();
            this.txt_NDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credito)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.dgv_Credito, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3945F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.60551F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1037, 545);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Credito
            // 
            this.dgv_Credito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Credito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDocumento,
            this.NombreProveedor,
            this.NombreTipoPago,
            this.NombreCaja,
            this.MontoPagar,
            this.Moneda,
            this.FechaPago,
            this.EntidadBancaria,
            this.NumVoucher});
            this.dgv_Credito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Credito.Location = new System.Drawing.Point(3, 185);
            this.dgv_Credito.Name = "dgv_Credito";
            this.dgv_Credito.RowHeadersVisible = false;
            this.dgv_Credito.Size = new System.Drawing.Size(1031, 357);
            this.dgv_Credito.TabIndex = 1;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumDocumento";
            this.NumeroDocumento.HeaderText = "Numero de Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            // 
            // NombreProveedor
            // 
            this.NombreProveedor.DataPropertyName = "NombreProveedor";
            this.NombreProveedor.HeaderText = "Nombre de Proveedor";
            this.NombreProveedor.Name = "NombreProveedor";
            // 
            // NombreTipoPago
            // 
            this.NombreTipoPago.DataPropertyName = "NombreTipoPago";
            this.NombreTipoPago.HeaderText = "Tipo de Pago";
            this.NombreTipoPago.Name = "NombreTipoPago";
            // 
            // NombreCaja
            // 
            this.NombreCaja.DataPropertyName = "NombreCaja";
            this.NombreCaja.HeaderText = "Caja";
            this.NombreCaja.Name = "NombreCaja";
            // 
            // MontoPagar
            // 
            this.MontoPagar.DataPropertyName = "MontoPagar";
            this.MontoPagar.HeaderText = "Monto Pagado";
            this.MontoPagar.Name = "MontoPagar";
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "NombreMoneda";
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            // 
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha de Pago";
            this.FechaPago.Name = "FechaPago";
            // 
            // EntidadBancaria
            // 
            this.EntidadBancaria.DataPropertyName = "EntidadBancaria";
            this.EntidadBancaria.HeaderText = "Entidad Bancaria";
            this.EntidadBancaria.Name = "EntidadBancaria";
            // 
            // NumVoucher
            // 
            this.NumVoucher.DataPropertyName = "NumVoucher";
            this.NumVoucher.HeaderText = "Numero de Voucher";
            this.NumVoucher.Name = "NumVoucher";
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1031, 176);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.02439F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.63415F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.82927F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.04878F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.19512F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.73171F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Caja, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Caja, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Proveedor, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Proveedor, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Exportar, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1025, 52);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedor :";
            // 
            // btn_Caja
            // 
            this.btn_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Caja.Location = new System.Drawing.Point(769, 9);
            this.btn_Caja.Name = "btn_Caja";
            this.btn_Caja.Size = new System.Drawing.Size(103, 34);
            this.btn_Caja.TabIndex = 0;
            this.btn_Caja.Text = "Buscar";
            this.btn_Caja.UseVisualStyleBackColor = true;
            this.btn_Caja.Click += new System.EventHandler(this.btn_Caja_Click);
            // 
            // cmb_Caja
            // 
            this.cmb_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Caja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Caja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Caja.FormattingEnabled = true;
            this.cmb_Caja.Location = new System.Drawing.Point(562, 15);
            this.cmb_Caja.Name = "cmb_Caja";
            this.cmb_Caja.Size = new System.Drawing.Size(191, 28);
            this.cmb_Caja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caja :";
            // 
            // btn_Proveedor
            // 
            this.btn_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Proveedor.Location = new System.Drawing.Point(389, 9);
            this.btn_Proveedor.Name = "btn_Proveedor";
            this.btn_Proveedor.Size = new System.Drawing.Size(103, 34);
            this.btn_Proveedor.TabIndex = 3;
            this.btn_Proveedor.Text = "Buscar";
            this.btn_Proveedor.UseVisualStyleBackColor = true;
            this.btn_Proveedor.Click += new System.EventHandler(this.btn_Proveedor_Click);
            // 
            // cmb_Proveedor
            // 
            this.cmb_Proveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Proveedor.FormattingEnabled = true;
            this.cmb_Proveedor.Location = new System.Drawing.Point(116, 15);
            this.cmb_Proveedor.Name = "cmb_Proveedor";
            this.cmb_Proveedor.Size = new System.Drawing.Size(266, 28);
            this.cmb_Proveedor.TabIndex = 4;
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exportar.Location = new System.Drawing.Point(899, 9);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(103, 34);
            this.btn_Exportar.TabIndex = 6;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.26829F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.41463F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.97561F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.19512F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_NVoucher, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_NDocumento, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_NVoucher, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_NDocumento, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1025, 52);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº de Documento :";
            // 
            // btn_NVoucher
            // 
            this.btn_NVoucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_NVoucher.Location = new System.Drawing.Point(903, 9);
            this.btn_NVoucher.Name = "btn_NVoucher";
            this.btn_NVoucher.Size = new System.Drawing.Size(103, 34);
            this.btn_NVoucher.TabIndex = 1;
            this.btn_NVoucher.Text = "Buscar";
            this.btn_NVoucher.UseVisualStyleBackColor = true;
            this.btn_NVoucher.Click += new System.EventHandler(this.btn_NVoucher_Click);
            // 
            // btn_NDocumento
            // 
            this.btn_NDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_NDocumento.Location = new System.Drawing.Point(405, 9);
            this.btn_NDocumento.Name = "btn_NDocumento";
            this.btn_NDocumento.Size = new System.Drawing.Size(107, 34);
            this.btn_NDocumento.TabIndex = 4;
            this.btn_NDocumento.Text = "Buscar";
            this.btn_NDocumento.UseVisualStyleBackColor = true;
            this.btn_NDocumento.Click += new System.EventHandler(this.btn_NDocumento_Click);
            // 
            // txt_NVoucher
            // 
            this.txt_NVoucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_NVoucher.Location = new System.Drawing.Point(655, 13);
            this.txt_NVoucher.Name = "txt_NVoucher";
            this.txt_NVoucher.Size = new System.Drawing.Size(218, 26);
            this.txt_NVoucher.TabIndex = 5;
            this.txt_NVoucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NVoucher_KeyPress);
            // 
            // txt_NDocumento
            // 
            this.txt_NDocumento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_NDocumento.Location = new System.Drawing.Point(180, 13);
            this.txt_NDocumento.Name = "txt_NDocumento";
            this.txt_NDocumento.Size = new System.Drawing.Size(219, 26);
            this.txt_NDocumento.TabIndex = 6;
            this.txt_NDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NDocumento_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nº de Voucher :";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.878049F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.12195F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.21951F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.46341F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.21951F));
            this.tableLayoutPanel5.Controls.Add(this.dtp_hasta, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_Buscar, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtp_de, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 119);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1025, 54);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_hasta.Location = new System.Drawing.Point(528, 14);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(287, 26);
            this.dtp_hasta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "De :";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Buscar.Location = new System.Drawing.Point(871, 10);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(103, 34);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hasta :";
            // 
            // dtp_de
            // 
            this.dtp_de.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_de.Location = new System.Drawing.Point(94, 14);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(288, 26);
            this.dtp_de.TabIndex = 8;
            // 
            // F_ReporteCreditoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_ReporteCreditoCompra";
            this.Text = "Reporte de Compras al Credito";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credito)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_Credito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Caja;
        private System.Windows.Forms.ComboBox cmb_Caja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Proveedor;
        private System.Windows.Forms.ComboBox cmb_Proveedor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NVoucher;
        private System.Windows.Forms.Button btn_NDocumento;
        private System.Windows.Forms.TextBox txt_NVoucher;
        private System.Windows.Forms.TextBox txt_NDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntidadBancaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVoucher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_de;
        private System.Windows.Forms.Button btn_Exportar;
    }
}