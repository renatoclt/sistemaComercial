namespace Shalong.Formularios
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Pnl_M_Cabezera = new System.Windows.Forms.Panel();
            this.Pnl_M_Botones = new System.Windows.Forms.Panel();
            this.Pnl_Cuerpo = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Dni = new System.Windows.Forms.TextBox();
            this.Pnl_M_Pie = new System.Windows.Forms.Panel();
            this.txt_Almacen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TipoTrabajador = new System.Windows.Forms.TextBox();
            this.txt_Caja = new System.Windows.Forms.TextBox();
            this.txt_Dolar = new System.Windows.Forms.TextBox();
            this.Pnl_M_Pie.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_M_Cabezera
            // 
            this.Pnl_M_Cabezera.BackColor = System.Drawing.SystemColors.Control;
            this.Pnl_M_Cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_M_Cabezera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pnl_M_Cabezera.Location = new System.Drawing.Point(0, 0);
            this.Pnl_M_Cabezera.Margin = new System.Windows.Forms.Padding(5);
            this.Pnl_M_Cabezera.Name = "Pnl_M_Cabezera";
            this.Pnl_M_Cabezera.Size = new System.Drawing.Size(1284, 30);
            this.Pnl_M_Cabezera.TabIndex = 0;
            // 
            // Pnl_M_Botones
            // 
            this.Pnl_M_Botones.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Pnl_M_Botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_M_Botones.Location = new System.Drawing.Point(0, 30);
            this.Pnl_M_Botones.Name = "Pnl_M_Botones";
            this.Pnl_M_Botones.Size = new System.Drawing.Size(1284, 90);
            this.Pnl_M_Botones.TabIndex = 1;
            // 
            // Pnl_Cuerpo
            // 
            this.Pnl_Cuerpo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pnl_Cuerpo.Location = new System.Drawing.Point(0, 120);
            this.Pnl_Cuerpo.Name = "Pnl_Cuerpo";
            this.Pnl_Cuerpo.Size = new System.Drawing.Size(1284, 585);
            this.Pnl_Cuerpo.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(-33, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Dni:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "Dolar";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 20);
            this.label14.TabIndex = 4;
            this.label14.Text = "Caja";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(442, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Tipo Trabajador";
            // 
            // txt_Dni
            // 
            this.txt_Dni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Dni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Dni.Enabled = false;
            this.txt_Dni.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_Dni.Location = new System.Drawing.Point(10, 7);
            this.txt_Dni.Name = "txt_Dni";
            this.txt_Dni.Size = new System.Drawing.Size(100, 26);
            this.txt_Dni.TabIndex = 8;
            // 
            // Pnl_M_Pie
            // 
            this.Pnl_M_Pie.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Pnl_M_Pie.Controls.Add(this.txt_Almacen);
            this.Pnl_M_Pie.Controls.Add(this.label1);
            this.Pnl_M_Pie.Controls.Add(this.txt_TipoTrabajador);
            this.Pnl_M_Pie.Controls.Add(this.txt_Caja);
            this.Pnl_M_Pie.Controls.Add(this.txt_Dolar);
            this.Pnl_M_Pie.Controls.Add(this.txt_Dni);
            this.Pnl_M_Pie.Controls.Add(this.label15);
            this.Pnl_M_Pie.Controls.Add(this.label14);
            this.Pnl_M_Pie.Controls.Add(this.label13);
            this.Pnl_M_Pie.Controls.Add(this.label12);
            this.Pnl_M_Pie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_M_Pie.Location = new System.Drawing.Point(0, 712);
            this.Pnl_M_Pie.Name = "Pnl_M_Pie";
            this.Pnl_M_Pie.Size = new System.Drawing.Size(1284, 30);
            this.Pnl_M_Pie.TabIndex = 2;
            // 
            // txt_Almacen
            // 
            this.txt_Almacen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Almacen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Almacen.Enabled = false;
            this.txt_Almacen.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_Almacen.Location = new System.Drawing.Point(778, 4);
            this.txt_Almacen.Name = "txt_Almacen";
            this.txt_Almacen.Size = new System.Drawing.Size(168, 26);
            this.txt_Almacen.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(701, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Almacen";
            // 
            // txt_TipoTrabajador
            // 
            this.txt_TipoTrabajador.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TipoTrabajador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_TipoTrabajador.Enabled = false;
            this.txt_TipoTrabajador.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_TipoTrabajador.Location = new System.Drawing.Point(560, 7);
            this.txt_TipoTrabajador.Name = "txt_TipoTrabajador";
            this.txt_TipoTrabajador.Size = new System.Drawing.Size(135, 26);
            this.txt_TipoTrabajador.TabIndex = 11;
            // 
            // txt_Caja
            // 
            this.txt_Caja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Caja.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Caja.Enabled = false;
            this.txt_Caja.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_Caja.Location = new System.Drawing.Point(336, 7);
            this.txt_Caja.Name = "txt_Caja";
            this.txt_Caja.Size = new System.Drawing.Size(100, 26);
            this.txt_Caja.TabIndex = 10;
            // 
            // txt_Dolar
            // 
            this.txt_Dolar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Dolar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_Dolar.Enabled = false;
            this.txt_Dolar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_Dolar.Location = new System.Drawing.Point(183, 7);
            this.txt_Dolar.Name = "txt_Dolar";
            this.txt_Dolar.Size = new System.Drawing.Size(100, 26);
            this.txt_Dolar.TabIndex = 9;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1284, 742);
            this.Controls.Add(this.Pnl_Cuerpo);
            this.Controls.Add(this.Pnl_M_Pie);
            this.Controls.Add(this.Pnl_M_Botones);
            this.Controls.Add(this.Pnl_M_Cabezera);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Move += new System.EventHandler(this.Principal_Move);
            this.Resize += new System.EventHandler(this.Principal_Resize);
            this.Pnl_M_Pie.ResumeLayout(false);
            this.Pnl_M_Pie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_M_Cabezera;
        private System.Windows.Forms.Panel Pnl_M_Botones;
        private System.Windows.Forms.Panel Pnl_Cuerpo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Dni;
        private System.Windows.Forms.Panel Pnl_M_Pie;
        private System.Windows.Forms.TextBox txt_TipoTrabajador;
        private System.Windows.Forms.TextBox txt_Caja;
        private System.Windows.Forms.TextBox txt_Dolar;
        private System.Windows.Forms.TextBox txt_Almacen;
        private System.Windows.Forms.Label label1;
    }
}

