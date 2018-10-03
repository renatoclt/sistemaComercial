namespace Shalong.Formularios
{
    partial class F_ReporteCreditoTrabajador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ReporteCreditoTrabajador));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Credito = new System.Windows.Forms.DataGridView();
            this.NumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Caja = new System.Windows.Forms.Button();
            this.btn_Trabajador = new System.Windows.Forms.Button();
            this.cmb_Caja = new System.Windows.Forms.ComboBox();
            this.cmb_Trabajador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_Documento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Voucher = new System.Windows.Forms.Button();
            this.btn_Documento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Voucher = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credito)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.30939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.69061F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1088, 543);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Credito
            // 
            this.dgv_Credito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Credito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDocumento,
            this.NombreTrabajador,
            this.NombreTipoPago,
            this.NombreCaja,
            this.MontoPagar,
            this.FechaPago,
            this.Entidad,
            this.NumCuenta,
            this.NumVoucher});
            this.dgv_Credito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Credito.Location = new System.Drawing.Point(3, 134);
            this.dgv_Credito.Name = "dgv_Credito";
            this.dgv_Credito.RowHeadersVisible = false;
            this.dgv_Credito.Size = new System.Drawing.Size(1082, 406);
            this.dgv_Credito.TabIndex = 0;
            // 
            // NumDocumento
            // 
            this.NumDocumento.DataPropertyName = "NumDocumento";
            this.NumDocumento.HeaderText = "NumeroDocumento";
            this.NumDocumento.Name = "NumDocumento";
            // 
            // NombreTrabajador
            // 
            this.NombreTrabajador.DataPropertyName = "NombreTrabajador";
            this.NombreTrabajador.HeaderText = "Trabajador";
            this.NombreTrabajador.Name = "NombreTrabajador";
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
            // FechaPago
            // 
            this.FechaPago.DataPropertyName = "FechaPago";
            this.FechaPago.HeaderText = "Fecha de Pago";
            this.FechaPago.Name = "FechaPago";
            // 
            // Entidad
            // 
            this.Entidad.DataPropertyName = "EntidadBancaria";
            this.Entidad.HeaderText = "Entidad Bancaria";
            this.Entidad.Name = "Entidad";
            // 
            // NumCuenta
            // 
            this.NumCuenta.DataPropertyName = "NumCuenta";
            this.NumCuenta.HeaderText = "Nº de Cuenta";
            this.NumCuenta.Name = "NumCuenta";
            // 
            // NumVoucher
            // 
            this.NumVoucher.DataPropertyName = "NumVoucher";
            this.NumVoucher.HeaderText = "Nª de Voucher";
            this.NumVoucher.Name = "NumVoucher";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1082, 125);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.03718F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.23048F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.98885F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.598513F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.40149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.24535F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Caja, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Trabajador, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Caja, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Trabajador, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Exportar, 6, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1076, 56);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Trabajador :";
            // 
            // btn_Caja
            // 
            this.btn_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Caja.Location = new System.Drawing.Point(802, 8);
            this.btn_Caja.Name = "btn_Caja";
            this.btn_Caja.Size = new System.Drawing.Size(115, 40);
            this.btn_Caja.TabIndex = 0;
            this.btn_Caja.Text = "Buscar";
            this.btn_Caja.UseVisualStyleBackColor = true;
            this.btn_Caja.Click += new System.EventHandler(this.btn_Caja_Click);
            // 
            // btn_Trabajador
            // 
            this.btn_Trabajador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Trabajador.Location = new System.Drawing.Point(404, 8);
            this.btn_Trabajador.Name = "btn_Trabajador";
            this.btn_Trabajador.Size = new System.Drawing.Size(115, 40);
            this.btn_Trabajador.TabIndex = 1;
            this.btn_Trabajador.Text = "Buscar";
            this.btn_Trabajador.UseVisualStyleBackColor = true;
            this.btn_Trabajador.Click += new System.EventHandler(this.btn_Trabajador_Click);
            // 
            // cmb_Caja
            // 
            this.cmb_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Caja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Caja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Caja.FormattingEnabled = true;
            this.cmb_Caja.Location = new System.Drawing.Point(604, 14);
            this.cmb_Caja.Name = "cmb_Caja";
            this.cmb_Caja.Size = new System.Drawing.Size(185, 28);
            this.cmb_Caja.TabIndex = 2;
            // 
            // cmb_Trabajador
            // 
            this.cmb_Trabajador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Trabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Trabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Trabajador.FormattingEnabled = true;
            this.cmb_Trabajador.Location = new System.Drawing.Point(111, 17);
            this.cmb_Trabajador.Name = "cmb_Trabajador";
            this.cmb_Trabajador.Size = new System.Drawing.Size(287, 28);
            this.cmb_Trabajador.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(549, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Caja :";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exportar.Location = new System.Drawing.Point(940, 8);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(115, 40);
            this.btn_Exportar.TabIndex = 6;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.03346F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.11896F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.75465F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.17472F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.18587F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.10409F));
            this.tableLayoutPanel4.Controls.Add(this.txt_Documento, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Voucher, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Documento, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_Voucher, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1076, 57);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // txt_Documento
            // 
            this.txt_Documento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Documento.Location = new System.Drawing.Point(153, 15);
            this.txt_Documento.Name = "txt_Documento";
            this.txt_Documento.Size = new System.Drawing.Size(231, 26);
            this.txt_Documento.TabIndex = 8;
            this.txt_Documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Documento_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nº Documento :";
            // 
            // btn_Voucher
            // 
            this.btn_Voucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Voucher.Location = new System.Drawing.Point(936, 8);
            this.btn_Voucher.Name = "btn_Voucher";
            this.btn_Voucher.Size = new System.Drawing.Size(115, 40);
            this.btn_Voucher.TabIndex = 1;
            this.btn_Voucher.Text = "Buscar";
            this.btn_Voucher.UseVisualStyleBackColor = true;
            this.btn_Voucher.Click += new System.EventHandler(this.btn_Voucher_Click);
            // 
            // btn_Documento
            // 
            this.btn_Documento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Documento.Location = new System.Drawing.Point(390, 8);
            this.btn_Documento.Name = "btn_Documento";
            this.btn_Documento.Size = new System.Drawing.Size(115, 40);
            this.btn_Documento.TabIndex = 2;
            this.btn_Documento.Text = "Buscar";
            this.btn_Documento.UseVisualStyleBackColor = true;
            this.btn_Documento.Click += new System.EventHandler(this.btn_Documento_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nº Voucher :";
            // 
            // txt_Voucher
            // 
            this.txt_Voucher.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Voucher.Location = new System.Drawing.Point(667, 15);
            this.txt_Voucher.Name = "txt_Voucher";
            this.txt_Voucher.Size = new System.Drawing.Size(245, 26);
            this.txt_Voucher.TabIndex = 7;
            this.txt_Voucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Voucher_KeyPress);
            // 
            // F_ReporteCreditoTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_ReporteCreditoTrabajador";
            this.Text = "Reporte de Creditos a Trabajadores";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credito)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Credito;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Caja;
        private System.Windows.Forms.Button btn_Trabajador;
        private System.Windows.Forms.ComboBox cmb_Caja;
        private System.Windows.Forms.ComboBox cmb_Trabajador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txt_Documento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Voucher;
        private System.Windows.Forms.Button btn_Documento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Voucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVoucher;
        private System.Windows.Forms.Button btn_Exportar;
    }
}