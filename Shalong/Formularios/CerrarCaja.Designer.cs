namespace Shalong.Formularios
{
    partial class CerrarCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CerrarCaja));
            this.Lbl_Ingresos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Ingresos = new System.Windows.Forms.TextBox();
            this.Txt_Egresos = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.txt_TotalDia = new System.Windows.Forms.TextBox();
            this.dtg_Ingresos = new System.Windows.Forms.DataGridView();
            this.codigoTipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPagoIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_Egresos = new System.Windows.Forms.DataGridView();
            this.codigoTipoPagoEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPagoEgreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egresoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_Efectivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Efectivo = new System.Windows.Forms.TextBox();
            this.btn_Cuadrar = new System.Windows.Forms.Button();
            this.btn_CerrarCaja = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtg_Billetaje = new System.Windows.Forms.DataGridView();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Dolar = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Egresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Billetaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Ingresos
            // 
            this.Lbl_Ingresos.AutoSize = true;
            this.Lbl_Ingresos.Location = new System.Drawing.Point(12, 17);
            this.Lbl_Ingresos.Name = "Lbl_Ingresos";
            this.Lbl_Ingresos.Size = new System.Drawing.Size(71, 20);
            this.Lbl_Ingresos.TabIndex = 9;
            this.Lbl_Ingresos.Text = "Ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Egresos";
            // 
            // Txt_Ingresos
            // 
            this.Txt_Ingresos.Enabled = false;
            this.Txt_Ingresos.Location = new System.Drawing.Point(109, 16);
            this.Txt_Ingresos.Name = "Txt_Ingresos";
            this.Txt_Ingresos.Size = new System.Drawing.Size(212, 26);
            this.Txt_Ingresos.TabIndex = 11;
            // 
            // Txt_Egresos
            // 
            this.Txt_Egresos.Enabled = false;
            this.Txt_Egresos.Location = new System.Drawing.Point(109, 58);
            this.Txt_Egresos.Name = "Txt_Egresos";
            this.Txt_Egresos.Size = new System.Drawing.Size(212, 26);
            this.Txt_Egresos.TabIndex = 12;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Location = new System.Drawing.Point(12, 109);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(44, 20);
            this.Lbl_Total.TabIndex = 13;
            this.Lbl_Total.Text = "Total";
            // 
            // txt_TotalDia
            // 
            this.txt_TotalDia.Enabled = false;
            this.txt_TotalDia.Location = new System.Drawing.Point(109, 106);
            this.txt_TotalDia.Name = "txt_TotalDia";
            this.txt_TotalDia.Size = new System.Drawing.Size(212, 26);
            this.txt_TotalDia.TabIndex = 14;
            // 
            // dtg_Ingresos
            // 
            this.dtg_Ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Ingresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTipoPago,
            this.TipoPagoIngreso,
            this.IngresoTotal});
            this.dtg_Ingresos.Enabled = false;
            this.dtg_Ingresos.Location = new System.Drawing.Point(16, 138);
            this.dtg_Ingresos.Name = "dtg_Ingresos";
            this.dtg_Ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Ingresos.Size = new System.Drawing.Size(305, 209);
            this.dtg_Ingresos.TabIndex = 15;
            // 
            // codigoTipoPago
            // 
            this.codigoTipoPago.DataPropertyName = "Codigo";
            this.codigoTipoPago.HeaderText = "codigo";
            this.codigoTipoPago.Name = "codigoTipoPago";
            this.codigoTipoPago.Visible = false;
            // 
            // TipoPagoIngreso
            // 
            this.TipoPagoIngreso.DataPropertyName = "Nombre";
            this.TipoPagoIngreso.HeaderText = "Tipo Pago";
            this.TipoPagoIngreso.Name = "TipoPagoIngreso";
            // 
            // IngresoTotal
            // 
            this.IngresoTotal.DataPropertyName = "CantidadString";
            this.IngresoTotal.HeaderText = "Total";
            this.IngresoTotal.Name = "IngresoTotal";
            // 
            // dtg_Egresos
            // 
            this.dtg_Egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Egresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoTipoPagoEgreso,
            this.tipoPagoEgreso,
            this.egresoTotal});
            this.dtg_Egresos.Enabled = false;
            this.dtg_Egresos.Location = new System.Drawing.Point(16, 353);
            this.dtg_Egresos.Name = "dtg_Egresos";
            this.dtg_Egresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Egresos.Size = new System.Drawing.Size(305, 173);
            this.dtg_Egresos.TabIndex = 16;
            // 
            // codigoTipoPagoEgreso
            // 
            this.codigoTipoPagoEgreso.DataPropertyName = "Codigo";
            this.codigoTipoPagoEgreso.HeaderText = "Codigo";
            this.codigoTipoPagoEgreso.Name = "codigoTipoPagoEgreso";
            this.codigoTipoPagoEgreso.Visible = false;
            // 
            // tipoPagoEgreso
            // 
            this.tipoPagoEgreso.DataPropertyName = "Nombre";
            this.tipoPagoEgreso.HeaderText = "Egreso";
            this.tipoPagoEgreso.Name = "tipoPagoEgreso";
            // 
            // egresoTotal
            // 
            this.egresoTotal.DataPropertyName = "CantidadString";
            this.egresoTotal.HeaderText = "Total";
            this.egresoTotal.Name = "egresoTotal";
            // 
            // Lbl_Efectivo
            // 
            this.Lbl_Efectivo.AutoSize = true;
            this.Lbl_Efectivo.Location = new System.Drawing.Point(20, 548);
            this.Lbl_Efectivo.Name = "Lbl_Efectivo";
            this.Lbl_Efectivo.Size = new System.Drawing.Size(66, 20);
            this.Lbl_Efectivo.TabIndex = 17;
            this.Lbl_Efectivo.Text = "Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Efectivo";
            // 
            // txt_Efectivo
            // 
            this.txt_Efectivo.Location = new System.Drawing.Point(109, 542);
            this.txt_Efectivo.Name = "txt_Efectivo";
            this.txt_Efectivo.ReadOnly = true;
            this.txt_Efectivo.Size = new System.Drawing.Size(185, 26);
            this.txt_Efectivo.TabIndex = 19;
            // 
            // btn_Cuadrar
            // 
            this.btn_Cuadrar.Location = new System.Drawing.Point(350, 585);
            this.btn_Cuadrar.Name = "btn_Cuadrar";
            this.btn_Cuadrar.Size = new System.Drawing.Size(126, 38);
            this.btn_Cuadrar.TabIndex = 21;
            this.btn_Cuadrar.Text = "Cuadrar";
            this.btn_Cuadrar.UseVisualStyleBackColor = true;
            this.btn_Cuadrar.Click += new System.EventHandler(this.btn_Cuadrar_Click);
            // 
            // btn_CerrarCaja
            // 
            this.btn_CerrarCaja.Enabled = false;
            this.btn_CerrarCaja.Location = new System.Drawing.Point(183, 585);
            this.btn_CerrarCaja.Name = "btn_CerrarCaja";
            this.btn_CerrarCaja.Size = new System.Drawing.Size(126, 38);
            this.btn_CerrarCaja.TabIndex = 22;
            this.btn_CerrarCaja.Text = "Cerrar Caja";
            this.btn_CerrarCaja.UseVisualStyleBackColor = true;
            this.btn_CerrarCaja.Click += new System.EventHandler(this.btn_CerrarCaja_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor dolar";
            // 
            // dtg_Billetaje
            // 
            this.dtg_Billetaje.AllowUserToAddRows = false;
            this.dtg_Billetaje.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtg_Billetaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Billetaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Moneda,
            this.Codigo,
            this.Valor,
            this.Cantidad});
            this.dtg_Billetaje.Location = new System.Drawing.Point(362, 17);
            this.dtg_Billetaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_Billetaje.Name = "dtg_Billetaje";
            this.dtg_Billetaje.Size = new System.Drawing.Size(273, 430);
            this.dtg_Billetaje.TabIndex = 28;
            this.dtg_Billetaje.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Billetaje_CellEnter);
            this.dtg_Billetaje.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Billetaje_CellValueChanged);
            this.dtg_Billetaje.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dtg_Billetaje_DataError);
            // 
            // Moneda
            // 
            this.Moneda.DataPropertyName = "Denominacion";
            this.Moneda.Frozen = true;
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Name = "Moneda";
            this.Moneda.ReadOnly = true;
            this.Moneda.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Moneda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.Visible = false;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // txt_Dolar
            // 
            this.txt_Dolar.Enabled = false;
            this.txt_Dolar.Location = new System.Drawing.Point(476, 500);
            this.txt_Dolar.Name = "txt_Dolar";
            this.txt_Dolar.Size = new System.Drawing.Size(160, 26);
            this.txt_Dolar.TabIndex = 30;
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(475, 542);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(160, 26);
            this.txt_Total.TabIndex = 29;
            // 
            // CerrarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 645);
            this.Controls.Add(this.txt_Dolar);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.dtg_Billetaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_CerrarCaja);
            this.Controls.Add(this.btn_Cuadrar);
            this.Controls.Add(this.txt_Efectivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Efectivo);
            this.Controls.Add(this.dtg_Egresos);
            this.Controls.Add(this.dtg_Ingresos);
            this.Controls.Add(this.txt_TotalDia);
            this.Controls.Add(this.Lbl_Total);
            this.Controls.Add(this.Txt_Egresos);
            this.Controls.Add(this.Txt_Ingresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Lbl_Ingresos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CerrarCaja";
            this.Text = "Cerrar Caja";
            this.Load += new System.EventHandler(this.CerrarCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Egresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Billetaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Ingresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Ingresos;
        private System.Windows.Forms.TextBox Txt_Egresos;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.TextBox txt_TotalDia;
        private System.Windows.Forms.DataGridView dtg_Ingresos;
        private System.Windows.Forms.DataGridView dtg_Egresos;
        private System.Windows.Forms.Label Lbl_Efectivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Efectivo;
        private System.Windows.Forms.Button btn_Cuadrar;
        private System.Windows.Forms.Button btn_CerrarCaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtg_Billetaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txt_Dolar;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPagoIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTipoPagoEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPagoEgreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn egresoTotal;
    }
}