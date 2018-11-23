namespace Shalong.Formularios
{
    partial class Producto_Precio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto_Precio));
            this.dtg_ProductoPrecio = new System.Windows.Forms.DataGridView();
            this.Tipo_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ProductoPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_ProductoPrecio
            // 
            this.dtg_ProductoPrecio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_ProductoPrecio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ProductoPrecio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo_Precio,
            this.Codigo,
            this.Precio});
            this.dtg_ProductoPrecio.Location = new System.Drawing.Point(18, 86);
            this.dtg_ProductoPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtg_ProductoPrecio.Name = "dtg_ProductoPrecio";
            this.dtg_ProductoPrecio.Size = new System.Drawing.Size(360, 231);
            this.dtg_ProductoPrecio.TabIndex = 2;
            this.dtg_ProductoPrecio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ProductoPrecio_CellContentClick);
            // 
            // Tipo_Precio
            // 
            this.Tipo_Precio.DataPropertyName = "nombre";
            this.Tipo_Precio.HeaderText = "Tipo Precio";
            this.Tipo_Precio.Name = "Tipo_Precio";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(119, 30);
            this.Cmb_Producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(259, 28);
            this.Cmb_Producto.TabIndex = 1;
            this.Cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.Cmb_Producto_SelectedIndexChanged);
            this.Cmb_Producto.SelectionChangeCommitted += new System.EventHandler(this.Cmb_Producto_SelectionChangeCommitted);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(14, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Producto";
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(146, 326);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(117, 35);
            this.Btn_Guardar.TabIndex = 3;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Producto_Precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 373);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Cmb_Producto);
            this.Controls.Add(this.dtg_ProductoPrecio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Producto_Precio";
            this.Text = "Precio de Producto";
            this.Load += new System.EventHandler(this.Producto_Precio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ProductoPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_ProductoPrecio;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}