namespace Shalong.Formularios
{
    partial class Permisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permisos));
            this.cmb_usuario = new System.Windows.Forms.ComboBox();
            this.chk_Inicio = new System.Windows.Forms.CheckBox();
            this.chk_Productos = new System.Windows.Forms.CheckBox();
            this.chk_Maestros = new System.Windows.Forms.CheckBox();
            this.Pnl_Productos = new System.Windows.Forms.Panel();
            this.dtg_Productos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chk_Reportes = new System.Windows.Forms.CheckBox();
            this.pnl_Inicio = new System.Windows.Forms.Panel();
            this.dtg_Inicio = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Permiso = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_Maestros = new System.Windows.Forms.Panel();
            this.dtg_Maestros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnl_Reportes = new System.Windows.Forms.Panel();
            this.dtg_Reportes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Pnl_Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).BeginInit();
            this.pnl_Inicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Inicio)).BeginInit();
            this.pnl_Maestros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Maestros)).BeginInit();
            this.pnl_Reportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Reportes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_usuario
            // 
            this.cmb_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_usuario.FormattingEnabled = true;
            this.cmb_usuario.Location = new System.Drawing.Point(323, 12);
            this.cmb_usuario.Name = "cmb_usuario";
            this.cmb_usuario.Size = new System.Drawing.Size(341, 28);
            this.cmb_usuario.TabIndex = 1;
            // 
            // chk_Inicio
            // 
            this.chk_Inicio.AutoSize = true;
            this.chk_Inicio.Location = new System.Drawing.Point(86, 57);
            this.chk_Inicio.Name = "chk_Inicio";
            this.chk_Inicio.Size = new System.Drawing.Size(65, 24);
            this.chk_Inicio.TabIndex = 2;
            this.chk_Inicio.Text = "Inicio";
            this.chk_Inicio.UseVisualStyleBackColor = true;
            this.chk_Inicio.CheckedChanged += new System.EventHandler(this.chk_Inicio_CheckedChanged);
            // 
            // chk_Productos
            // 
            this.chk_Productos.AutoSize = true;
            this.chk_Productos.Location = new System.Drawing.Point(313, 57);
            this.chk_Productos.Name = "chk_Productos";
            this.chk_Productos.Size = new System.Drawing.Size(100, 24);
            this.chk_Productos.TabIndex = 3;
            this.chk_Productos.Text = "Productos";
            this.chk_Productos.UseVisualStyleBackColor = true;
            this.chk_Productos.CheckedChanged += new System.EventHandler(this.chk_Productos_CheckedChanged);
            // 
            // chk_Maestros
            // 
            this.chk_Maestros.AutoSize = true;
            this.chk_Maestros.Location = new System.Drawing.Point(570, 57);
            this.chk_Maestros.Name = "chk_Maestros";
            this.chk_Maestros.Size = new System.Drawing.Size(94, 24);
            this.chk_Maestros.TabIndex = 4;
            this.chk_Maestros.Text = "Maestros";
            this.chk_Maestros.UseVisualStyleBackColor = true;
            this.chk_Maestros.CheckedChanged += new System.EventHandler(this.chk_Maestros_CheckedChanged);
            // 
            // Pnl_Productos
            // 
            this.Pnl_Productos.Controls.Add(this.dtg_Productos);
            this.Pnl_Productos.Location = new System.Drawing.Point(253, 87);
            this.Pnl_Productos.Name = "Pnl_Productos";
            this.Pnl_Productos.Size = new System.Drawing.Size(235, 298);
            this.Pnl_Productos.TabIndex = 6;
            // 
            // dtg_Productos
            // 
            this.dtg_Productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.dtg_Productos.Enabled = false;
            this.dtg_Productos.Location = new System.Drawing.Point(3, 3);
            this.dtg_Productos.Name = "dtg_Productos";
            this.dtg_Productos.RowHeadersVisible = false;
            this.dtg_Productos.Size = new System.Drawing.Size(229, 292);
            this.dtg_Productos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodigoMenu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Permiso";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chk_Reportes
            // 
            this.chk_Reportes.AutoSize = true;
            this.chk_Reportes.Location = new System.Drawing.Point(812, 57);
            this.chk_Reportes.Name = "chk_Reportes";
            this.chk_Reportes.Size = new System.Drawing.Size(94, 24);
            this.chk_Reportes.TabIndex = 7;
            this.chk_Reportes.Text = "Reportes";
            this.chk_Reportes.UseVisualStyleBackColor = true;
            this.chk_Reportes.CheckedChanged += new System.EventHandler(this.chk_Reportes_CheckedChanged);
            // 
            // pnl_Inicio
            // 
            this.pnl_Inicio.Controls.Add(this.dtg_Inicio);
            this.pnl_Inicio.Location = new System.Drawing.Point(12, 87);
            this.pnl_Inicio.Name = "pnl_Inicio";
            this.pnl_Inicio.Size = new System.Drawing.Size(235, 298);
            this.pnl_Inicio.TabIndex = 7;
            // 
            // dtg_Inicio
            // 
            this.dtg_Inicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Inicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtg_Inicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Inicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Menu,
            this.Permiso});
            this.dtg_Inicio.Enabled = false;
            this.dtg_Inicio.Location = new System.Drawing.Point(3, 3);
            this.dtg_Inicio.Name = "dtg_Inicio";
            this.dtg_Inicio.RowHeadersVisible = false;
            this.dtg_Inicio.Size = new System.Drawing.Size(229, 292);
            this.dtg_Inicio.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodigoMenu";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            // 
            // Menu
            // 
            this.Menu.DataPropertyName = "Nombre";
            this.Menu.HeaderText = "Menu";
            this.Menu.Name = "Menu";
            // 
            // Permiso
            // 
            this.Permiso.HeaderText = "Permiso";
            this.Permiso.Name = "Permiso";
            this.Permiso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Permiso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnl_Maestros
            // 
            this.pnl_Maestros.Controls.Add(this.dtg_Maestros);
            this.pnl_Maestros.Location = new System.Drawing.Point(494, 87);
            this.pnl_Maestros.Name = "pnl_Maestros";
            this.pnl_Maestros.Size = new System.Drawing.Size(235, 298);
            this.pnl_Maestros.TabIndex = 7;
            // 
            // dtg_Maestros
            // 
            this.dtg_Maestros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Maestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Maestros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn2});
            this.dtg_Maestros.Enabled = false;
            this.dtg_Maestros.Location = new System.Drawing.Point(3, 3);
            this.dtg_Maestros.Name = "dtg_Maestros";
            this.dtg_Maestros.RowHeadersVisible = false;
            this.dtg_Maestros.Size = new System.Drawing.Size(229, 292);
            this.dtg_Maestros.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodigoMenu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.HeaderText = "Permiso";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pnl_Reportes
            // 
            this.pnl_Reportes.Controls.Add(this.dtg_Reportes);
            this.pnl_Reportes.Location = new System.Drawing.Point(735, 87);
            this.pnl_Reportes.Name = "pnl_Reportes";
            this.pnl_Reportes.Size = new System.Drawing.Size(235, 298);
            this.pnl_Reportes.TabIndex = 8;
            // 
            // dtg_Reportes
            // 
            this.dtg_Reportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Reportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn3});
            this.dtg_Reportes.Enabled = false;
            this.dtg_Reportes.Location = new System.Drawing.Point(3, 3);
            this.dtg_Reportes.Name = "dtg_Reportes";
            this.dtg_Reportes.RowHeadersVisible = false;
            this.dtg_Reportes.Size = new System.Drawing.Size(229, 292);
            this.dtg_Reportes.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CodigoMenu";
            this.dataGridViewTextBoxColumn5.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Menu";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.HeaderText = "Permiso";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(427, 392);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(111, 32);
            this.Btn_Guardar.TabIndex = 9;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 436);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.pnl_Reportes);
            this.Controls.Add(this.pnl_Maestros);
            this.Controls.Add(this.pnl_Inicio);
            this.Controls.Add(this.chk_Reportes);
            this.Controls.Add(this.Pnl_Productos);
            this.Controls.Add(this.chk_Maestros);
            this.Controls.Add(this.chk_Productos);
            this.Controls.Add(this.chk_Inicio);
            this.Controls.Add(this.cmb_usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Permisos";
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.Pnl_Productos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Productos)).EndInit();
            this.pnl_Inicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Inicio)).EndInit();
            this.pnl_Maestros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Maestros)).EndInit();
            this.pnl_Reportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Reportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_usuario;
        private System.Windows.Forms.CheckBox chk_Inicio;
        private System.Windows.Forms.CheckBox chk_Productos;
        private System.Windows.Forms.CheckBox chk_Maestros;
        private System.Windows.Forms.Panel Pnl_Productos;
        private System.Windows.Forms.CheckBox chk_Reportes;
        private System.Windows.Forms.DataGridView dtg_Productos;
        private System.Windows.Forms.Panel pnl_Inicio;
        private System.Windows.Forms.DataGridView dtg_Inicio;
        private System.Windows.Forms.Panel pnl_Maestros;
        private System.Windows.Forms.DataGridView dtg_Maestros;
        private System.Windows.Forms.Panel pnl_Reportes;
        private System.Windows.Forms.DataGridView dtg_Reportes;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Permiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    }
}