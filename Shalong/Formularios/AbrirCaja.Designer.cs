namespace Shalong.Formularios
{
    partial class AbrirCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbrirCaja));
            this.Btn_CambiarDolar = new System.Windows.Forms.Button();
            this.cmb_NombreCaja = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtg_Billetaje = new System.Windows.Forms.DataGridView();
            this.Moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_AbrirCaja = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Dolar = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Billetaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_CambiarDolar
            // 
            this.Btn_CambiarDolar.Location = new System.Drawing.Point(221, 485);
            this.Btn_CambiarDolar.Name = "Btn_CambiarDolar";
            this.Btn_CambiarDolar.Size = new System.Drawing.Size(44, 26);
            this.Btn_CambiarDolar.TabIndex = 21;
            this.Btn_CambiarDolar.Text = "...";
            this.Btn_CambiarDolar.UseVisualStyleBackColor = true;
            this.Btn_CambiarDolar.Click += new System.EventHandler(this.Btn_CambiarDolar_Click);
            // 
            // cmb_NombreCaja
            // 
            this.cmb_NombreCaja.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_NombreCaja.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_NombreCaja.FormattingEnabled = true;
            this.cmb_NombreCaja.Location = new System.Drawing.Point(105, 521);
            this.cmb_NombreCaja.Name = "cmb_NombreCaja";
            this.cmb_NombreCaja.Size = new System.Drawing.Size(160, 28);
            this.cmb_NombreCaja.TabIndex = 20;
            this.cmb_NombreCaja.SelectedIndexChanged += new System.EventHandler(this.cmb_NombreCaja_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Caja";
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
            this.dtg_Billetaje.Enabled = false;
            this.dtg_Billetaje.Location = new System.Drawing.Point(13, 14);
            this.dtg_Billetaje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_Billetaje.Name = "dtg_Billetaje";
            this.dtg_Billetaje.Size = new System.Drawing.Size(273, 430);
            this.dtg_Billetaje.TabIndex = 18;
            this.dtg_Billetaje.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Billetaje_CellEnter);
            this.dtg_Billetaje.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Billetaje_CellValueChanged);
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
            // Btn_AbrirCaja
            // 
            this.Btn_AbrirCaja.Location = new System.Drawing.Point(166, 580);
            this.Btn_AbrirCaja.Name = "Btn_AbrirCaja";
            this.Btn_AbrirCaja.Size = new System.Drawing.Size(99, 37);
            this.Btn_AbrirCaja.TabIndex = 17;
            this.Btn_AbrirCaja.Text = "Abrir Caja";
            this.Btn_AbrirCaja.UseVisualStyleBackColor = true;
            this.Btn_AbrirCaja.Click += new System.EventHandler(this.Btn_AbrirCaja_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(18, 580);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(99, 37);
            this.Btn_Modificar.TabIndex = 16;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Dolar";
            // 
            // txt_Dolar
            // 
            this.txt_Dolar.Enabled = false;
            this.txt_Dolar.Location = new System.Drawing.Point(105, 485);
            this.txt_Dolar.Name = "txt_Dolar";
            this.txt_Dolar.Size = new System.Drawing.Size(110, 26);
            this.txt_Dolar.TabIndex = 14;
            // 
            // txt_Total
            // 
            this.txt_Total.Enabled = false;
            this.txt_Total.Location = new System.Drawing.Point(105, 452);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(160, 26);
            this.txt_Total.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Monto";
            // 
            // AbrirCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 636);
            this.Controls.Add(this.Btn_CambiarDolar);
            this.Controls.Add(this.cmb_NombreCaja);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtg_Billetaje);
            this.Controls.Add(this.Btn_AbrirCaja);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Dolar);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AbrirCaja";
            this.Text = "Abrir Caja";
            this.Load += new System.EventHandler(this.AbrirCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Billetaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_CambiarDolar;
        private System.Windows.Forms.ComboBox cmb_NombreCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtg_Billetaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button Btn_AbrirCaja;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Dolar;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label1;

    }
}