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
            this.Cmb_Producto = new System.Windows.Forms.ComboBox();
            this.Btn_Transferir = new System.Windows.Forms.Button();
            this.Txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_almacen = new System.Windows.Forms.ComboBox();
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
            // Cmb_Producto
            // 
            this.Cmb_Producto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Producto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Producto.FormattingEnabled = true;
            this.Cmb_Producto.Location = new System.Drawing.Point(85, 14);
            this.Cmb_Producto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cmb_Producto.Name = "Cmb_Producto";
            this.Cmb_Producto.Size = new System.Drawing.Size(337, 28);
            this.Cmb_Producto.TabIndex = 8;
            this.Cmb_Producto.SelectedIndexChanged += new System.EventHandler(this.Cmb_Producto_SelectedIndexChanged);
            // 
            // Btn_Transferir
            // 
            this.Btn_Transferir.Location = new System.Drawing.Point(170, 338);
            this.Btn_Transferir.Name = "Btn_Transferir";
            this.Btn_Transferir.Size = new System.Drawing.Size(99, 47);
            this.Btn_Transferir.TabIndex = 11;
            this.Btn_Transferir.Text = "Transferir";
            this.Btn_Transferir.UseVisualStyleBackColor = true;
            this.Btn_Transferir.Click += new System.EventHandler(this.Btn_Transferir_Click);
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(322, 302);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(100, 26);
            this.Txt_cantidad.TabIndex = 12;
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
            // Cmb_almacen
            // 
            this.Cmb_almacen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_almacen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_almacen.FormattingEnabled = true;
            this.Cmb_almacen.Location = new System.Drawing.Point(83, 302);
            this.Cmb_almacen.Name = "Cmb_almacen";
            this.Cmb_almacen.Size = new System.Drawing.Size(152, 28);
            this.Cmb_almacen.TabIndex = 15;
            // 
            // Productos_Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 397);
            this.Controls.Add(this.Cmb_almacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_cantidad);
            this.Controls.Add(this.Btn_Transferir);
            this.Controls.Add(this.dtg_Productos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_Producto);
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
        private System.Windows.Forms.ComboBox Cmb_Producto;
        private System.Windows.Forms.Button Btn_Transferir;
        private System.Windows.Forms.TextBox Txt_cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_almacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;

    }
}