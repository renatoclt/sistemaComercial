namespace Shalong.Formularios
{
    partial class Productos_Almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos_Almacen));
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Producto = new System.Windows.Forms.ComboBox();
            this.btn_Transferir = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_almacen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            this.SuspendLayout();
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
            this.dtg_Productos.Location = new System.Drawing.Point(12, 50);
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.Size = new System.Drawing.Size(417, 243);
            this.dtg_Productos.TabIndex = 10;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodigoAlmacen";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "NombreAlmacen";
            this.Producto.HeaderText = "Almacen";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Producto";
            // 
            // cmb_Producto
            // 
            this.cmb_Producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Producto.FormattingEnabled = true;
            this.cmb_Producto.Location = new System.Drawing.Point(85, 14);
            this.cmb_Producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_Producto.Name = "cmb_Producto";
            this.cmb_Producto.Size = new System.Drawing.Size(337, 28);
            this.cmb_Producto.TabIndex = 8;
            this.cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.cmb_Producto_SelectedIndexChanged);
            // 
            // btn_Transferir
            // 
            this.btn_Transferir.Location = new System.Drawing.Point(170, 338);
            this.btn_Transferir.Name = "btn_Transferir";
            this.btn_Transferir.Size = new System.Drawing.Size(99, 47);
            this.btn_Transferir.TabIndex = 11;
            this.btn_Transferir.Text = "Transferir";
            this.btn_Transferir.UseVisualStyleBackColor = true;
            this.btn_Transferir.Click += new System.EventHandler(this.btn_Transferir_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(322, 302);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 26);
            this.txt_cantidad.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Almacen";
            // 
            // cmb_almacen
            // 
            this.cmb_almacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_almacen.FormattingEnabled = true;
            this.cmb_almacen.Location = new System.Drawing.Point(83, 302);
            this.cmb_almacen.Name = "cmb_almacen";
            this.cmb_almacen.Size = new System.Drawing.Size(152, 28);
            this.cmb_almacen.TabIndex = 15;
            // 
            // Productos_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 397);
            this.Controls.Add(this.cmb_almacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.btn_Transferir);
            this.Controls.Add(this.dtg_Productos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Producto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Productos_Almacen";
            this.Text = "Productos por Almacen";
            this.Load += new System.EventHandler(this.Productos_Almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Producto;
        private System.Windows.Forms.Button btn_Transferir;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;

    }
}