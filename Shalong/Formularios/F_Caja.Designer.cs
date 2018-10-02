namespace Shalong.Formularios
{
    partial class F_Caja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Caja));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Caja = new System.Windows.Forms.DataGridView();
            this.NombreCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Trabajador = new System.Windows.Forms.Button();
            this.cmb_Trabajador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Exportar = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Caja = new System.Windows.Forms.Button();
            this.cmb_Caja = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dtp_Hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_De = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Fechas = new System.Windows.Forms.Button();
            this.cmb_Por = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caja)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.dgv_Caja, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.76159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.23841F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Caja
            // 
            this.dgv_Caja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Caja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCaja,
            this.Trabajador,
            this.TipoCambio,
            this.FechaInicio,
            this.FechaFinal,
            this.SaldoInicial,
            this.SaldoFinal});
            this.dgv_Caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Caja.Location = new System.Drawing.Point(3, 153);
            this.dgv_Caja.Name = "dgv_Caja";
            this.dgv_Caja.RowHeadersVisible = false;
            this.dgv_Caja.Size = new System.Drawing.Size(1081, 265);
            this.dgv_Caja.TabIndex = 0;
            // 
            // NombreCaja
            // 
            this.NombreCaja.DataPropertyName = "NombreCaja";
            this.NombreCaja.HeaderText = "Nombre de Caja";
            this.NombreCaja.Name = "NombreCaja";
            // 
            // Trabajador
            // 
            this.Trabajador.DataPropertyName = "NombreCompleto";
            this.Trabajador.HeaderText = "Trabajador";
            this.Trabajador.Name = "Trabajador";
            // 
            // TipoCambio
            // 
            this.TipoCambio.DataPropertyName = "ValorTipoCambio";
            this.TipoCambio.HeaderText = "Tipo de Cambio";
            this.TipoCambio.Name = "TipoCambio";
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicioCaja";
            this.FechaInicio.HeaderText = "Fecha de Apertura";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // FechaFinal
            // 
            this.FechaFinal.DataPropertyName = "FechaFinalCaja";
            this.FechaFinal.HeaderText = "Fecha de Cierre";
            this.FechaFinal.Name = "FechaFinal";
            // 
            // SaldoInicial
            // 
            this.SaldoInicial.DataPropertyName = "SaldoInicial";
            this.SaldoInicial.HeaderText = "Saldo Inicial";
            this.SaldoInicial.Name = "SaldoInicial";
            // 
            // SaldoFinal
            // 
            this.SaldoFinal.DataPropertyName = "SaldoFinal";
            this.SaldoFinal.HeaderText = "Saldo Final";
            this.SaldoFinal.Name = "SaldoFinal";
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1081, 144);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btn_Trabajador, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmb_Trabajador, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_Exportar, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1075, 42);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_Trabajador
            // 
            this.btn_Trabajador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Trabajador.Location = new System.Drawing.Point(539, 4);
            this.btn_Trabajador.Name = "btn_Trabajador";
            this.btn_Trabajador.Size = new System.Drawing.Size(206, 34);
            this.btn_Trabajador.TabIndex = 0;
            this.btn_Trabajador.Text = "Buscar por Trabajador";
            this.btn_Trabajador.UseVisualStyleBackColor = true;
            this.btn_Trabajador.Click += new System.EventHandler(this.btn_Trabajador_Click);
            // 
            // cmb_Trabajador
            // 
            this.cmb_Trabajador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Trabajador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Trabajador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Trabajador.FormattingEnabled = true;
            this.cmb_Trabajador.Location = new System.Drawing.Point(271, 7);
            this.cmb_Trabajador.Name = "cmb_Trabajador";
            this.cmb_Trabajador.Size = new System.Drawing.Size(262, 28);
            this.cmb_Trabajador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar Trabajador :";
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Exportar.Location = new System.Drawing.Point(836, 4);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(206, 34);
            this.btn_Exportar.TabIndex = 3;
            this.btn_Exportar.Text = "Exportar";
            this.btn_Exportar.UseVisualStyleBackColor = true;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.02597F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.30736F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.77489F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Caja, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.cmb_Caja, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 51);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1075, 42);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Caja :";
            // 
            // btn_Caja
            // 
            this.btn_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Caja.Location = new System.Drawing.Point(628, 4);
            this.btn_Caja.Name = "btn_Caja";
            this.btn_Caja.Size = new System.Drawing.Size(206, 34);
            this.btn_Caja.TabIndex = 1;
            this.btn_Caja.Text = "Buscar por Caja";
            this.btn_Caja.UseVisualStyleBackColor = true;
            this.btn_Caja.Click += new System.EventHandler(this.btn_Caja_Click);
            // 
            // cmb_Caja
            // 
            this.cmb_Caja.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_Caja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Caja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Caja.FormattingEnabled = true;
            this.cmb_Caja.Location = new System.Drawing.Point(260, 10);
            this.cmb_Caja.Name = "cmb_Caja";
            this.cmb_Caja.Size = new System.Drawing.Size(228, 28);
            this.cmb_Caja.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 6;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.18605F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.67442F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.88372F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.95349F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.55814F));
            this.tableLayoutPanel5.Controls.Add(this.dtp_Hasta, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.dtp_De, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_Fechas, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.cmb_Por, 4, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1075, 42);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // dtp_Hasta
            // 
            this.dtp_Hasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Hasta.Location = new System.Drawing.Point(460, 8);
            this.dtp_Hasta.Name = "dtp_Hasta";
            this.dtp_Hasta.Size = new System.Drawing.Size(122, 26);
            this.dtp_Hasta.TabIndex = 1;
            // 
            // dtp_De
            // 
            this.dtp_De.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_De.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_De.Location = new System.Drawing.Point(182, 8);
            this.dtp_De.Name = "dtp_De";
            this.dtp_De.Size = new System.Drawing.Size(125, 26);
            this.dtp_De.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasta :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "De :";
            // 
            // btn_Fechas
            // 
            this.btn_Fechas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Fechas.Location = new System.Drawing.Point(856, 4);
            this.btn_Fechas.Name = "btn_Fechas";
            this.btn_Fechas.Size = new System.Drawing.Size(155, 34);
            this.btn_Fechas.TabIndex = 0;
            this.btn_Fechas.Text = "Buscar Fechas";
            this.btn_Fechas.UseVisualStyleBackColor = true;
            this.btn_Fechas.Click += new System.EventHandler(this.btn_Fechas_Click);
            // 
            // cmb_Por
            // 
            this.cmb_Por.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Por.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Por.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Por.FormattingEnabled = true;
            this.cmb_Por.Items.AddRange(new object[] {
            "Fecha de Apertura",
            "Fecha de Cierre",
            "Ambas Fechas"});
            this.cmb_Por.Location = new System.Drawing.Point(622, 7);
            this.cmb_Por.Name = "cmb_Por";
            this.cmb_Por.Size = new System.Drawing.Size(225, 28);
            this.cmb_Por.TabIndex = 5;
            // 
            // F_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 421);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Caja";
            this.Text = "F_Caja";
            this.Load += new System.EventHandler(this.F_Caja_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Caja)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_Caja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_Trabajador;
        private System.Windows.Forms.ComboBox cmb_Trabajador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Caja;
        private System.Windows.Forms.ComboBox cmb_Caja;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btn_Fechas;
        private System.Windows.Forms.DateTimePicker dtp_Hasta;
        private System.Windows.Forms.DateTimePicker dtp_De;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoFinal;
        private System.Windows.Forms.ComboBox cmb_Por;
        private System.Windows.Forms.Button btn_Exportar;
    }
}