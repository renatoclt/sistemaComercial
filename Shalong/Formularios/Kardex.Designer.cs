namespace Shalong.Formularios
{
    partial class Kardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kardex));
            this.tlpNivel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Nivel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Documento = new System.Windows.Forms.Label();
            this.Cmb_Documento = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpNivel1.SuspendLayout();
            this.tlp_Nivel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpNivel1
            // 
            this.tlpNivel1.ColumnCount = 1;
            this.tlpNivel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNivel1.Controls.Add(this.tlp_Nivel2, 0, 0);
            this.tlpNivel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tlpNivel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNivel1.Location = new System.Drawing.Point(0, 0);
            this.tlpNivel1.Name = "tlpNivel1";
            this.tlpNivel1.RowCount = 2;
            this.tlpNivel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNivel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tlpNivel1.Size = new System.Drawing.Size(611, 326);
            this.tlpNivel1.TabIndex = 0;
            // 
            // tlp_Nivel2
            // 
            this.tlp_Nivel2.ColumnCount = 2;
            this.tlp_Nivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Nivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Nivel2.Controls.Add(this.lbl_Documento, 0, 0);
            this.tlp_Nivel2.Controls.Add(this.Cmb_Documento, 1, 0);
            this.tlp_Nivel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Nivel2.Location = new System.Drawing.Point(3, 3);
            this.tlp_Nivel2.Name = "tlp_Nivel2";
            this.tlp_Nivel2.RowCount = 1;
            this.tlp_Nivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Nivel2.Size = new System.Drawing.Size(605, 64);
            this.tlp_Nivel2.TabIndex = 0;
            // 
            // lbl_Documento
            // 
            this.lbl_Documento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Documento.AutoSize = true;
            this.lbl_Documento.Location = new System.Drawing.Point(114, 22);
            this.lbl_Documento.Name = "lbl_Documento";
            this.lbl_Documento.Size = new System.Drawing.Size(73, 20);
            this.lbl_Documento.TabIndex = 0;
            this.lbl_Documento.Text = "Producto";
            // 
            // Cmb_Documento
            // 
            this.Cmb_Documento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cmb_Documento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Documento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Documento.FormattingEnabled = true;
            this.Cmb_Documento.Location = new System.Drawing.Point(364, 21);
            this.Cmb_Documento.Name = "Cmb_Documento";
            this.Cmb_Documento.Size = new System.Drawing.Size(178, 28);
            this.Cmb_Documento.TabIndex = 1;
            this.Cmb_Documento.SelectedIndexChanged += new System.EventHandler(this.Cmb_Documento_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDocumento,
            this.Fecha,
            this.Codigo,
            this.CantidadCompra,
            this.CantidadVenta});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.DataPropertyName = "NumeroDocumento";
            this.NumeroDocumento.HeaderText = "Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // CantidadCompra
            // 
            this.CantidadCompra.DataPropertyName = "Ingreso";
            this.CantidadCompra.HeaderText = "Ingreso";
            this.CantidadCompra.Name = "CantidadCompra";
            // 
            // CantidadVenta
            // 
            this.CantidadVenta.DataPropertyName = "Egreso";
            this.CantidadVenta.HeaderText = "Egreso";
            this.CantidadVenta.Name = "CantidadVenta";
            // 
            // Kardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 326);
            this.Controls.Add(this.tlpNivel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kardex";
            this.Text = "Reporte de Kardex";
            this.Load += new System.EventHandler(this.Kardex_Load);
            this.tlpNivel1.ResumeLayout(false);
            this.tlp_Nivel2.ResumeLayout(false);
            this.tlp_Nivel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpNivel1;
        private System.Windows.Forms.TableLayoutPanel tlp_Nivel2;
        private System.Windows.Forms.Label lbl_Documento;
        private System.Windows.Forms.ComboBox Cmb_Documento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVenta;



    }
}