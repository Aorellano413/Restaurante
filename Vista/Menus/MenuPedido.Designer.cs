namespace Vista.Menus
{
    partial class MenuPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPedido));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenuPedido = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.labelMenuPedido = new System.Windows.Forms.Label();
            this.btnCerrarMP = new System.Windows.Forms.Button();
            this.cmbPlatosMP = new System.Windows.Forms.ComboBox();
            this.dgvMenuPedido = new System.Windows.Forms.DataGridView();
            this.btnConfirmarMP = new System.Windows.Forms.Button();
            this.btnLimpiarMP = new System.Windows.Forms.Button();
            this.labelTotalAPagar = new System.Windows.Forms.Label();
            this.labelTotalMP = new System.Windows.Forms.Label();
            this.labelEfectivo = new System.Windows.Forms.Label();
            this.txtEfectivoMP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCambioMP = new System.Windows.Forms.Label();
            this.btnAñadirPlatoMP = new System.Windows.Forms.Button();
            this.btnPagarMP = new System.Windows.Forms.Button();
            this.btnRegistroPedido = new System.Windows.Forms.Button();
            this.panelMenuPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuPedido
            // 
            this.panelMenuPedido.BackColor = System.Drawing.Color.Khaki;
            this.panelMenuPedido.Controls.Add(this.btnRegresar);
            this.panelMenuPedido.Controls.Add(this.labelMenuPedido);
            this.panelMenuPedido.Controls.Add(this.btnCerrarMP);
            this.panelMenuPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuPedido.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPedido.Name = "panelMenuPedido";
            this.panelMenuPedido.Size = new System.Drawing.Size(1946, 51);
            this.panelMenuPedido.TabIndex = 0;
            this.panelMenuPedido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenuPedido_MouseDown);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(1922, 0);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(46, 48);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // labelMenuPedido
            // 
            this.labelMenuPedido.AutoSize = true;
            this.labelMenuPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuPedido.ForeColor = System.Drawing.Color.Black;
            this.labelMenuPedido.Location = new System.Drawing.Point(934, 5);
            this.labelMenuPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuPedido.Name = "labelMenuPedido";
            this.labelMenuPedido.Size = new System.Drawing.Size(175, 43);
            this.labelMenuPedido.TabIndex = 27;
            this.labelMenuPedido.Text = "MENU PEDIDO";
            // 
            // btnCerrarMP
            // 
            this.btnCerrarMP.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMP.FlatAppearance.BorderSize = 0;
            this.btnCerrarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarMP.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarMP.Image")));
            this.btnCerrarMP.Location = new System.Drawing.Point(1977, 6);
            this.btnCerrarMP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarMP.Name = "btnCerrarMP";
            this.btnCerrarMP.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarMP.TabIndex = 3;
            this.btnCerrarMP.UseVisualStyleBackColor = false;
            this.btnCerrarMP.Click += new System.EventHandler(this.btnCerrarMP_Click);
            // 
            // cmbPlatosMP
            // 
            this.cmbPlatosMP.FormattingEnabled = true;
            this.cmbPlatosMP.Location = new System.Drawing.Point(33, 82);
            this.cmbPlatosMP.Name = "cmbPlatosMP";
            this.cmbPlatosMP.Size = new System.Drawing.Size(294, 28);
            this.cmbPlatosMP.TabIndex = 1;
            // 
            // dgvMenuPedido
            // 
            this.dgvMenuPedido.AllowUserToAddRows = false;
            this.dgvMenuPedido.AllowUserToDeleteRows = false;
            this.dgvMenuPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenuPedido.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvMenuPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMenuPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMenuPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMenuPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMenuPedido.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMenuPedido.Location = new System.Drawing.Point(33, 162);
            this.dgvMenuPedido.Name = "dgvMenuPedido";
            this.dgvMenuPedido.RowHeadersVisible = false;
            this.dgvMenuPedido.RowHeadersWidth = 62;
            this.dgvMenuPedido.RowTemplate.Height = 28;
            this.dgvMenuPedido.Size = new System.Drawing.Size(1886, 782);
            this.dgvMenuPedido.TabIndex = 2;
            // 
            // btnConfirmarMP
            // 
            this.btnConfirmarMP.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmarMP.FlatAppearance.BorderSize = 0;
            this.btnConfirmarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarMP.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmarMP.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarMP.Image")));
            this.btnConfirmarMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmarMP.Location = new System.Drawing.Point(768, 1043);
            this.btnConfirmarMP.Name = "btnConfirmarMP";
            this.btnConfirmarMP.Size = new System.Drawing.Size(234, 102);
            this.btnConfirmarMP.TabIndex = 12;
            this.btnConfirmarMP.Text = "CONFIRMAR";
            this.btnConfirmarMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarMP.UseVisualStyleBackColor = false;
            this.btnConfirmarMP.Click += new System.EventHandler(this.btnConfirmarMP_Click);
            // 
            // btnLimpiarMP
            // 
            this.btnLimpiarMP.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarMP.FlatAppearance.BorderSize = 0;
            this.btnLimpiarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarMP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarMP.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarMP.Image")));
            this.btnLimpiarMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarMP.Location = new System.Drawing.Point(1206, 1043);
            this.btnLimpiarMP.Name = "btnLimpiarMP";
            this.btnLimpiarMP.Size = new System.Drawing.Size(234, 102);
            this.btnLimpiarMP.TabIndex = 13;
            this.btnLimpiarMP.Text = "LIMPIAR";
            this.btnLimpiarMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarMP.UseVisualStyleBackColor = false;
            this.btnLimpiarMP.Click += new System.EventHandler(this.btnLimpiarMP_Click);
            // 
            // labelTotalAPagar
            // 
            this.labelTotalAPagar.AutoSize = true;
            this.labelTotalAPagar.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAPagar.Location = new System.Drawing.Point(26, 986);
            this.labelTotalAPagar.Name = "labelTotalAPagar";
            this.labelTotalAPagar.Size = new System.Drawing.Size(206, 43);
            this.labelTotalAPagar.TabIndex = 14;
            this.labelTotalAPagar.Text = "TOTAL A PAGAR :";
            // 
            // labelTotalMP
            // 
            this.labelTotalMP.AutoSize = true;
            this.labelTotalMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalMP.Location = new System.Drawing.Point(237, 986);
            this.labelTotalMP.Name = "labelTotalMP";
            this.labelTotalMP.Size = new System.Drawing.Size(34, 43);
            this.labelTotalMP.TabIndex = 15;
            this.labelTotalMP.Text = "0";
            // 
            // labelEfectivo
            // 
            this.labelEfectivo.AutoSize = true;
            this.labelEfectivo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEfectivo.Location = new System.Drawing.Point(26, 1043);
            this.labelEfectivo.Name = "labelEfectivo";
            this.labelEfectivo.Size = new System.Drawing.Size(209, 43);
            this.labelEfectivo.TabIndex = 16;
            this.labelEfectivo.Text = "EFECTIVO           :";
            // 
            // txtEfectivoMP
            // 
            this.txtEfectivoMP.Location = new System.Drawing.Point(234, 1060);
            this.txtEfectivoMP.Name = "txtEfectivoMP";
            this.txtEfectivoMP.Size = new System.Drawing.Size(198, 26);
            this.txtEfectivoMP.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 1102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 43);
            this.label1.TabIndex = 18;
            this.label1.Text = "CAMBIO              :";
            // 
            // labelCambioMP
            // 
            this.labelCambioMP.AutoSize = true;
            this.labelCambioMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCambioMP.Location = new System.Drawing.Point(237, 1102);
            this.labelCambioMP.Name = "labelCambioMP";
            this.labelCambioMP.Size = new System.Drawing.Size(34, 43);
            this.labelCambioMP.TabIndex = 19;
            this.labelCambioMP.Text = "0";
            // 
            // btnAñadirPlatoMP
            // 
            this.btnAñadirPlatoMP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirPlatoMP.FlatAppearance.BorderSize = 0;
            this.btnAñadirPlatoMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirPlatoMP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirPlatoMP.Location = new System.Drawing.Point(358, 68);
            this.btnAñadirPlatoMP.Name = "btnAñadirPlatoMP";
            this.btnAñadirPlatoMP.Size = new System.Drawing.Size(98, 46);
            this.btnAñadirPlatoMP.TabIndex = 22;
            this.btnAñadirPlatoMP.Text = "AÑADIR";
            this.btnAñadirPlatoMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirPlatoMP.UseVisualStyleBackColor = false;
            this.btnAñadirPlatoMP.Click += new System.EventHandler(this.btnAñadirPlatoMP_Click);
            // 
            // btnPagarMP
            // 
            this.btnPagarMP.BackColor = System.Drawing.Color.Transparent;
            this.btnPagarMP.FlatAppearance.BorderSize = 0;
            this.btnPagarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarMP.ForeColor = System.Drawing.Color.Transparent;
            this.btnPagarMP.Location = new System.Drawing.Point(470, 649);
            this.btnPagarMP.Name = "btnPagarMP";
            this.btnPagarMP.Size = new System.Drawing.Size(99, 43);
            this.btnPagarMP.TabIndex = 23;
            this.btnPagarMP.Text = "PAGAR";
            this.btnPagarMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagarMP.UseVisualStyleBackColor = false;
            this.btnPagarMP.Click += new System.EventHandler(this.btnPagarMP_Click);
            // 
            // btnRegistroPedido
            // 
            this.btnRegistroPedido.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistroPedido.FlatAppearance.BorderSize = 0;
            this.btnRegistroPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPedido.ForeColor = System.Drawing.Color.Black;
            this.btnRegistroPedido.Location = new System.Drawing.Point(977, 67);
            this.btnRegistroPedido.Name = "btnRegistroPedido";
            this.btnRegistroPedido.Size = new System.Drawing.Size(211, 43);
            this.btnRegistroPedido.TabIndex = 26;
            this.btnRegistroPedido.Text = "REGISTRO PEDIDOS";
            this.btnRegistroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroPedido.UseVisualStyleBackColor = false;
            this.btnRegistroPedido.Click += new System.EventHandler(this.btnRegistroPedido_Click);
            // 
            // MenuPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1946, 1106);
            this.Controls.Add(this.btnRegistroPedido);
            this.Controls.Add(this.btnPagarMP);
            this.Controls.Add(this.btnAñadirPlatoMP);
            this.Controls.Add(this.labelCambioMP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEfectivoMP);
            this.Controls.Add(this.labelEfectivo);
            this.Controls.Add(this.labelTotalMP);
            this.Controls.Add(this.labelTotalAPagar);
            this.Controls.Add(this.btnLimpiarMP);
            this.Controls.Add(this.btnConfirmarMP);
            this.Controls.Add(this.dgvMenuPedido);
            this.Controls.Add(this.cmbPlatosMP);
            this.Controls.Add(this.panelMenuPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPedido";
            this.Text = "MenuPedido";
            this.Load += new System.EventHandler(this.MenuPedido_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuPedido_MouseMove);
            this.panelMenuPedido.ResumeLayout(false);
            this.panelMenuPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPedido;
        private System.Windows.Forms.Button btnCerrarMP;
        private System.Windows.Forms.Label labelMenuPedido;
        private System.Windows.Forms.ComboBox cmbPlatosMP;
        private System.Windows.Forms.DataGridView dgvMenuPedido;
        private System.Windows.Forms.Button btnConfirmarMP;
        private System.Windows.Forms.Button btnLimpiarMP;
        private System.Windows.Forms.Label labelTotalAPagar;
        private System.Windows.Forms.Label labelTotalMP;
        private System.Windows.Forms.Label labelEfectivo;
        private System.Windows.Forms.TextBox txtEfectivoMP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCambioMP;
        private System.Windows.Forms.Button btnAñadirPlatoMP;
        private System.Windows.Forms.Button btnPagarMP;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnRegistroPedido;
    }
}