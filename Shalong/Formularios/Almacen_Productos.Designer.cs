namespace Shalong.Formularios
{
    partial class Almacen_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacen_Productos));
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cmb_Almacen = new System.Windows.Forms.ComboBox();
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.lbl_Unidad = new System.Windows.Forms.Label();
            this.TxtUnidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(255, 390);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(132, 34);
            this.Btn_Guardar.TabIndex = 6;
            this.Btn_Guardar.Text = "Añadir";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Almacen";
            // 
            // Cmb_Almacen
            // 
            this.Cmb_Almacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Almacen.FormattingEnabled = true;
            this.Cmb_Almacen.Location = new System.Drawing.Point(164, 14);
            this.Cmb_Almacen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cmb_Almacen.Name = "Cmb_Almacen";
            this.Cmb_Almacen.Size = new System.Drawing.Size(180, 28);
            this.Cmb_Almacen.TabIndex = 0;
            this.Cmb_Almacen.SelectedIndexChanged += new System.EventHandler(this.Cmb_Almacen_SelectedIndexChanged);
            // 
            // dtg_Productos
            // 
            this.dtg_Productos.AllowUserToAddRows = false;
            this.dtg_Productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Cantidad});
            this.dtg_Productos.Location = new System.Drawing.Point(12, 59);
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.Size = new System.Drawing.Size(417, 274);
            this.dtg_Productos.TabIndex = 7;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodigoProducto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "NombreProducto";
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.Width = 187;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 187;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto";
            // 
            // Cmb_Producto
            // 
            this.Cmb_Producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(91, 341);
            this.Cmb_Producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(152, 28);
            this.Cmb_Producto.TabIndex = 8;
            this.Cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.Cmb_Producto_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(329, 341);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(100, 26);
            this.Txt_Cantidad.TabIndex = 11;
            this.Txt_Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Cantidad_KeyPress);
            // 
            // lbl_Unidad
            // 
            this.lbl_Unidad.AutoSize = true;
            this.lbl_Unidad.Location = new System.Drawing.Point(12, 397);
            this.lbl_Unidad.Name = "lbl_Unidad";
            this.lbl_Unidad.Size = new System.Drawing.Size(60, 20);
            this.lbl_Unidad.TabIndex = 12;
            this.lbl_Unidad.Text = "Unidad";
            // 
            // TxtUnidad
            // 
            this.TxtUnidad.Enabled = false;
            this.TxtUnidad.Location = new System.Drawing.Point(91, 397);
            this.TxtUnidad.Name = "TxtUnidad";
            this.TxtUnidad.ReadOnly = true;
            this.TxtUnidad.Size = new System.Drawing.Size(152, 26);
            this.TxtUnidad.TabIndex = 13;
            // 
            // Almacen_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 436);
            this.Controls.Add(this.TxtUnidad);
            this.Controls.Add(this.lbl_Unidad);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_Producto);
            this.Controls.Add(this.dtg_Productos);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Almacen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Almacen_Productos";
            this.Text = "Productos en Almacen";
            this.Load += new System.EventHandler(this.Almacen_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cmb_Almacen;
        private System.Windows.Forms.DataGridView dtg_Productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Label lbl_Unidad;
        private System.Windows.Forms.TextBox TxtUnidad;
    }
}