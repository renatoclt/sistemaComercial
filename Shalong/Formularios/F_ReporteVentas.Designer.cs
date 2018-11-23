namespace Shalong.Formularios
{
    partial class F_ReporteVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ReporteVentas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Ventas = new System.Windows.Forms.DataGridView();
            this.NombreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Fecha = new System.Windows.Forms.Button();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_de = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Cmb_Empresa = new System.Windows.Forms.ComboBox();
            this.Cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Empresa = new System.Windows.Forms.Button();
            this.Btn_Cliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Exportar = new System.Windows.Forms.Button();
            this.Btn_TipoPago = new System.Windows.Forms.Button();
            this.Btn_Caja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_TipoPago = new System.Windows.Forms.ComboBox();
            this.Cmb_Caja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_TipoDeVenta = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_Ventas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1056, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Ventas
            // 
            this.dgv_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCaja,
            this.NombreDocumento,
            this.TipoPago,
            this.Cliente,
            this.Empresa,
            this.NumeroDocumento,
            this.FechaVenta,
            this.TotalVenta});
            this.dgv_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Ventas.Location = new System.Drawing.Point(3, 208);
            this.dgv_Ventas.Name = "dgv_Ventas";
            this.dgv_Ventas.RowHeadersVisible = false;
            this.dgv_Ventas.Size = new System.Drawing.Size(1050, 200);
            this.dgv_Ventas.TabIndex = 0;
            // 
            // NombreCaja
            // 
            this.NombreCaja.DataPropertyName = "NombreCaja";
            this.NombreCaja.HeaderText = "Nombre de Caja";
            this.NombreCaja.Name = "NombreCaja";
            // 
            // NombreDocumento
            // 
            this.NombreDocumento.DataPropertyName = "NombreDocumento";
            this.NombreDocumento.HeaderText = "Nombre de Documento";
            this.NombreDocumento.Name = "NombreDocumento";
            // 
            // TipoPago
            // 
            this.TipoPago.DataPropertyName = "NombreTipoPago";
            this.TipoPago.HeaderText = "Tipo de Pago";
            this.TipoPago.Name = "TipoPago";
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "NombreCliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Empresa
            // 
            this.Empresa.DataPropertyName = "NombreEmpresa";
            this.Empresa.HeaderText = "Empresa";
            this.Empresa.Name = "Empresa";
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumentoVenta";
            this.NumeroDocumento.HeaderText = "Numero de Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            // 
            // FechaVenta
            // 
            this.FechaVenta.DataPropertyName = "FechaVenta";
            this.FechaVenta.HeaderText = "Fecha de Venta";
            this.FechaVenta.Name = "FechaVenta";
            // 
            // TotalVenta
            // 
            this.TotalVenta.DataPropertyName = "TotalVenta";
            this.TotalVenta.HeaderText = "Total de Venta";
            this.TotalVenta.Name = "TotalVenta";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Cmb_TipoDeVenta, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.01802F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.32733F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.32733F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.32733F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1050, 199);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.56705F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.27969F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.429119F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.55556F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.45594F));
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Btn_Fecha, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtp_hasta, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtp_de, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 146);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1044, 50);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "De :";
            // 
            // Btn_Fecha
            // 
            this.Btn_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Fecha.Location = new System.Drawing.Point(822, 3);
            this.Btn_Fecha.Name = "Btn_Fecha";
            this.Btn_Fecha.Size = new System.Drawing.Size(177, 43);
            this.Btn_Fecha.TabIndex = 2;
            this.Btn_Fecha.Text = "Buscar Fecha";
            this.Btn_Fecha.UseVisualStyleBackColor = true;
            this.Btn_Fecha.Click += new System.EventHandler(this.Btn_Fecha_Click);
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_hasta.Location = new System.Drawing.Point(504, 12);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(307, 26);
            this.dtp_hasta.TabIndex = 3;
            // 
            // dtp_de
            // 
            this.dtp_de.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_de.Location = new System.Drawing.Point(81, 12);
            this.dtp_de.Name = "dtp_de";
            this.dtp_de.Size = new System.Drawing.Size(302, 26);
            this.dtp_de.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Hasta :";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 6;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.758621F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.78927F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.26054F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.195402F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.13793F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel4.Controls.Add(this.Cmb_Empresa, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.Cmb_Cliente, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Btn_Empresa, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.Btn_Cliente, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 92);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1044, 48);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // Cmb_Empresa
            // 
            this.Cmb_Empresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cmb_Empresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Empresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Empresa.FormattingEnabled = true;
            this.Cmb_Empresa.Location = new System.Drawing.Point(619, 13);
            this.Cmb_Empresa.Name = "Cmb_Empresa";
            this.Cmb_Empresa.Size = new System.Drawing.Size(246, 28);
            this.Cmb_Empresa.TabIndex = 7;
            // 
            // Cmb_Cliente
            // 
            this.Cmb_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cmb_Cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Cliente.FormattingEnabled = true;
            this.Cmb_Cliente.Location = new System.Drawing.Point(84, 13);
            this.Cmb_Cliente.Name = "Cmb_Cliente";
            this.Cmb_Cliente.Size = new System.Drawing.Size(301, 28);
            this.Cmb_Cliente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cliente :";
            // 
            // Btn_Empresa
            // 
            this.Btn_Empresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Empresa.Location = new System.Drawing.Point(871, 5);
            this.Btn_Empresa.Name = "Btn_Empresa";
            this.Btn_Empresa.Size = new System.Drawing.Size(167, 37);
            this.Btn_Empresa.TabIndex = 1;
            this.Btn_Empresa.Text = "Buscar Empresa";
            this.Btn_Empresa.UseVisualStyleBackColor = true;
            this.Btn_Empresa.Click += new System.EventHandler(this.Btn_Empresa_Click);
            // 
            // Btn_Cliente
            // 
            this.Btn_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Cliente.Location = new System.Drawing.Point(395, 5);
            this.Btn_Cliente.Name = "Btn_Cliente";
            this.Btn_Cliente.Size = new System.Drawing.Size(122, 37);
            this.Btn_Cliente.TabIndex = 2;
            this.Btn_Cliente.Text = "Buscar Cliente";
            this.Btn_Cliente.UseVisualStyleBackColor = true;
            this.Btn_Cliente.Click += new System.EventHandler(this.Btn_Cliente_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 7;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.662835F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.57088F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.87739F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.54789F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.16858F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.8046F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.Controls.Add(this.Btn_Exportar, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_TipoPago, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.Btn_Caja, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.Cmb_TipoPago, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Cmb_Caja, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1044, 48);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Btn_Exportar
            // 
            this.Btn_Exportar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Exportar.Location = new System.Drawing.Point(897, 3);
            this.Btn_Exportar.Name = "Btn_Exportar";
            this.Btn_Exportar.Size = new System.Drawing.Size(144, 42);
            this.Btn_Exportar.TabIndex = 0;
            this.Btn_Exportar.Text = "Exportar";
            this.Btn_Exportar.UseVisualStyleBackColor = true;
            this.Btn_Exportar.Click += new System.EventHandler(this.Btn_Exportar_Click);
            // 
            // Btn_TipoPago
            // 
            this.Btn_TipoPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_TipoPago.Location = new System.Drawing.Point(732, 6);
            this.Btn_TipoPago.Name = "Btn_TipoPago";
            this.Btn_TipoPago.Size = new System.Drawing.Size(159, 35);
            this.Btn_TipoPago.TabIndex = 1;
            this.Btn_TipoPago.Text = "Buscar Tipo Pago";
            this.Btn_TipoPago.UseVisualStyleBackColor = true;
            this.Btn_TipoPago.Click += new System.EventHandler(this.Btn_TipoPago_Click);
            // 
            // Btn_Caja
            // 
            this.Btn_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Caja.Location = new System.Drawing.Point(256, 6);
            this.Btn_Caja.Name = "Btn_Caja";
            this.Btn_Caja.Size = new System.Drawing.Size(118, 35);
            this.Btn_Caja.TabIndex = 2;
            this.Btn_Caja.Text = "Buscar Caja";
            this.Btn_Caja.UseVisualStyleBackColor = true;
            this.Btn_Caja.Click += new System.EventHandler(this.Btn_Caja_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Pago :";
            // 
            // Cmb_TipoPago
            // 
            this.Cmb_TipoPago.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cmb_TipoPago.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_TipoPago.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_TipoPago.FormattingEnabled = true;
            this.Cmb_TipoPago.Location = new System.Drawing.Point(511, 13);
            this.Cmb_TipoPago.Name = "Cmb_TipoPago";
            this.Cmb_TipoPago.Size = new System.Drawing.Size(211, 28);
            this.Cmb_TipoPago.TabIndex = 4;
            // 
            // Cmb_Caja
            // 
            this.Cmb_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Cmb_Caja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Caja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Caja.FormattingEnabled = true;
            this.Cmb_Caja.Location = new System.Drawing.Point(83, 13);
            this.Cmb_Caja.Name = "Cmb_Caja";
            this.Cmb_Caja.Size = new System.Drawing.Size(157, 28);
            this.Cmb_Caja.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Caja :";
            // 
            // Cmb_TipoDeVenta
            // 
            this.Cmb_TipoDeVenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cmb_TipoDeVenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_TipoDeVenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_TipoDeVenta.FormattingEnabled = true;
            this.Cmb_TipoDeVenta.Items.AddRange(new object[] {
            "Ventas Realizadas",
            "Ventas Anuladas"});
            this.Cmb_TipoDeVenta.Location = new System.Drawing.Point(396, 3);
            this.Cmb_TipoDeVenta.Name = "Cmb_TipoDeVenta";
            this.Cmb_TipoDeVenta.Size = new System.Drawing.Size(257, 28);
            this.Cmb_TipoDeVenta.TabIndex = 3;
            this.Cmb_TipoDeVenta.SelectedIndexChanged += new System.EventHandler(this.Cmb_TipoDeVenta_SelectedIndexChanged);
            // 
            // F_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_ReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.F_ReporteVentas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ventas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_Ventas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button Btn_Exportar;
        private System.Windows.Forms.Button Btn_TipoPago;
        private System.Windows.Forms.Button Btn_Caja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_TipoPago;
        private System.Windows.Forms.ComboBox Cmb_Caja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Empresa;
        private System.Windows.Forms.Button Btn_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_Cliente;
        private System.Windows.Forms.ComboBox Cmb_Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVenta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Fecha;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.DateTimePicker dtp_de;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cmb_TipoDeVenta;
    }
}