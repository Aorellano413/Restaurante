namespace Vista.GestionPlatos
{
    partial class RegistrarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPlato));
            this.panelRegistrarPlato = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelRegistrarPlato = new System.Windows.Forms.Label();
            this.labelNombreRP = new System.Windows.Forms.Label();
            this.labelStockRP = new System.Windows.Forms.Label();
            this.txtNombreRP = new System.Windows.Forms.TextBox();
            this.txtStockRP = new System.Windows.Forms.TextBox();
            this.btnRegistrarRP = new System.Windows.Forms.Button();
            this.btnAñadirDescripcionRP = new System.Windows.Forms.Button();
            this.labelDescripcionRP = new System.Windows.Forms.Label();
            this.labelPrecioRP = new System.Windows.Forms.Label();
            this.txtPrecioRP = new System.Windows.Forms.TextBox();
            this.cmbDescripcionRP = new System.Windows.Forms.ComboBox();
            this.btnLimpiarRP = new System.Windows.Forms.Button();
            this.btnAñadirPrecioRP = new System.Windows.Forms.Button();
            this.btnAñadirStockRP = new System.Windows.Forms.Button();
            this.btnAñadirNombreRP = new System.Windows.Forms.Button();
            this.dgvRegistrarPlato = new System.Windows.Forms.DataGridView();
            this.panelRegistrarPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistrarPlato
            // 
            this.panelRegistrarPlato.BackColor = System.Drawing.Color.Khaki;
            this.panelRegistrarPlato.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.panelRegistrarPlato.Controls.Add(this.labelRegistrarPlato);
            this.panelRegistrarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistrarPlato.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrarPlato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRegistrarPlato.Name = "panelRegistrarPlato";
            this.panelRegistrarPlato.Size = new System.Drawing.Size(1067, 41);
            this.panelRegistrarPlato.TabIndex = 0;
            this.panelRegistrarPlato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistrarPlato_MouseDown);
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(1021, 4);
            this.btnCerrarRegistrarIngrediente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(31, 28);
            this.btnCerrarRegistrarIngrediente.TabIndex = 18;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelRegistrarPlato
            // 
            this.labelRegistrarPlato.AutoSize = true;
            this.labelRegistrarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarPlato.Location = new System.Drawing.Point(247, 0);
            this.labelRegistrarPlato.Name = "labelRegistrarPlato";
            this.labelRegistrarPlato.Size = new System.Drawing.Size(189, 36);
            this.labelRegistrarPlato.TabIndex = 17;
            this.labelRegistrarPlato.Text = "REGISTRAR PLATO";
            // 
            // labelNombreRP
            // 
            this.labelNombreRP.AutoSize = true;
            this.labelNombreRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreRP.Location = new System.Drawing.Point(56, 65);
            this.labelNombreRP.Name = "labelNombreRP";
            this.labelNombreRP.Size = new System.Drawing.Size(122, 29);
            this.labelNombreRP.TabIndex = 2;
            this.labelNombreRP.Text = "NOMBRE        :";
            // 
            // labelStockRP
            // 
            this.labelStockRP.AutoSize = true;
            this.labelStockRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockRP.Location = new System.Drawing.Point(57, 220);
            this.labelStockRP.Name = "labelStockRP";
            this.labelStockRP.Size = new System.Drawing.Size(116, 29);
            this.labelStockRP.TabIndex = 3;
            this.labelStockRP.Text = "STOCK          :";
            // 
            // txtNombreRP
            // 
            this.txtNombreRP.Location = new System.Drawing.Point(201, 71);
            this.txtNombreRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRP.Name = "txtNombreRP";
            this.txtNombreRP.Size = new System.Drawing.Size(187, 22);
            this.txtNombreRP.TabIndex = 4;
            // 
            // txtStockRP
            // 
            this.txtStockRP.Location = new System.Drawing.Point(201, 228);
            this.txtStockRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockRP.Name = "txtStockRP";
            this.txtStockRP.Size = new System.Drawing.Size(187, 22);
            this.txtStockRP.TabIndex = 5;
            // 
            // btnRegistrarRP
            // 
            this.btnRegistrarRP.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarRP.FlatAppearance.BorderSize = 0;
            this.btnRegistrarRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRP.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarRP.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarRP.Image")));
            this.btnRegistrarRP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarRP.Location = new System.Drawing.Point(461, 421);
            this.btnRegistrarRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarRP.Name = "btnRegistrarRP";
            this.btnRegistrarRP.Size = new System.Drawing.Size(223, 106);
            this.btnRegistrarRP.TabIndex = 6;
            this.btnRegistrarRP.Text = "REGISTRAR";
            this.btnRegistrarRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarRP.UseVisualStyleBackColor = false;
            this.btnRegistrarRP.Click += new System.EventHandler(this.btnRegistrarRP_Click);
            // 
            // btnAñadirDescripcionRP
            // 
            this.btnAñadirDescripcionRP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirDescripcionRP.FlatAppearance.BorderSize = 0;
            this.btnAñadirDescripcionRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirDescripcionRP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirDescripcionRP.Location = new System.Drawing.Point(409, 116);
            this.btnAñadirDescripcionRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirDescripcionRP.Name = "btnAñadirDescripcionRP";
            this.btnAñadirDescripcionRP.Size = new System.Drawing.Size(88, 34);
            this.btnAñadirDescripcionRP.TabIndex = 7;
            this.btnAñadirDescripcionRP.Text = "AÑADIR";
            this.btnAñadirDescripcionRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirDescripcionRP.UseVisualStyleBackColor = false;
            this.btnAñadirDescripcionRP.Click += new System.EventHandler(this.btnAñadirDescripcionRP_Click);
            // 
            // labelDescripcionRP
            // 
            this.labelDescripcionRP.AutoSize = true;
            this.labelDescripcionRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionRP.Location = new System.Drawing.Point(56, 116);
            this.labelDescripcionRP.Name = "labelDescripcionRP";
            this.labelDescripcionRP.Size = new System.Drawing.Size(124, 29);
            this.labelDescripcionRP.TabIndex = 8;
            this.labelDescripcionRP.Text = "DESCRIPCION :";
            // 
            // labelPrecioRP
            // 
            this.labelPrecioRP.AutoSize = true;
            this.labelPrecioRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioRP.Location = new System.Drawing.Point(57, 170);
            this.labelPrecioRP.Name = "labelPrecioRP";
            this.labelPrecioRP.Size = new System.Drawing.Size(118, 29);
            this.labelPrecioRP.TabIndex = 9;
            this.labelPrecioRP.Text = "PRECIO         :";
            // 
            // txtPrecioRP
            // 
            this.txtPrecioRP.Location = new System.Drawing.Point(201, 176);
            this.txtPrecioRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioRP.Name = "txtPrecioRP";
            this.txtPrecioRP.Size = new System.Drawing.Size(187, 22);
            this.txtPrecioRP.TabIndex = 10;
            // 
            // cmbDescripcionRP
            // 
            this.cmbDescripcionRP.FormattingEnabled = true;
            this.cmbDescripcionRP.Location = new System.Drawing.Point(201, 123);
            this.cmbDescripcionRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDescripcionRP.Name = "cmbDescripcionRP";
            this.cmbDescripcionRP.Size = new System.Drawing.Size(187, 24);
            this.cmbDescripcionRP.TabIndex = 11;
            // 
            // btnLimpiarRP
            // 
            this.btnLimpiarRP.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarRP.FlatAppearance.BorderSize = 0;
            this.btnLimpiarRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarRP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarRP.Location = new System.Drawing.Point(953, 421);
            this.btnLimpiarRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarRP.Name = "btnLimpiarRP";
            this.btnLimpiarRP.Size = new System.Drawing.Size(99, 34);
            this.btnLimpiarRP.TabIndex = 13;
            this.btnLimpiarRP.Text = "LIMPIAR";
            this.btnLimpiarRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarRP.UseVisualStyleBackColor = false;
            this.btnLimpiarRP.Click += new System.EventHandler(this.btnLimpiarRP_Click);
            // 
            // btnAñadirPrecioRP
            // 
            this.btnAñadirPrecioRP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirPrecioRP.FlatAppearance.BorderSize = 0;
            this.btnAñadirPrecioRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirPrecioRP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirPrecioRP.Location = new System.Drawing.Point(409, 176);
            this.btnAñadirPrecioRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirPrecioRP.Name = "btnAñadirPrecioRP";
            this.btnAñadirPrecioRP.Size = new System.Drawing.Size(88, 34);
            this.btnAñadirPrecioRP.TabIndex = 14;
            this.btnAñadirPrecioRP.Text = "AÑADIR";
            this.btnAñadirPrecioRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirPrecioRP.UseVisualStyleBackColor = false;
            this.btnAñadirPrecioRP.Click += new System.EventHandler(this.btnAñadirPrecioRP_Click);
            // 
            // btnAñadirStockRP
            // 
            this.btnAñadirStockRP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirStockRP.FlatAppearance.BorderSize = 0;
            this.btnAñadirStockRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirStockRP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirStockRP.Location = new System.Drawing.Point(409, 228);
            this.btnAñadirStockRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirStockRP.Name = "btnAñadirStockRP";
            this.btnAñadirStockRP.Size = new System.Drawing.Size(88, 34);
            this.btnAñadirStockRP.TabIndex = 15;
            this.btnAñadirStockRP.Text = "AÑADIR";
            this.btnAñadirStockRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirStockRP.UseVisualStyleBackColor = false;
            this.btnAñadirStockRP.Click += new System.EventHandler(this.btnAñadirStockRP_Click);
            // 
            // btnAñadirNombreRP
            // 
            this.btnAñadirNombreRP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirNombreRP.FlatAppearance.BorderSize = 0;
            this.btnAñadirNombreRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirNombreRP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirNombreRP.Location = new System.Drawing.Point(409, 65);
            this.btnAñadirNombreRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAñadirNombreRP.Name = "btnAñadirNombreRP";
            this.btnAñadirNombreRP.Size = new System.Drawing.Size(88, 34);
            this.btnAñadirNombreRP.TabIndex = 16;
            this.btnAñadirNombreRP.Text = "AÑADIR";
            this.btnAñadirNombreRP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirNombreRP.UseVisualStyleBackColor = false;
            this.btnAñadirNombreRP.Click += new System.EventHandler(this.btnAñadirNombreRP_Click);
            // 
            // dgvRegistrarPlato
            // 
            this.dgvRegistrarPlato.AllowUserToAddRows = false;
            this.dgvRegistrarPlato.AllowUserToDeleteRows = false;
            this.dgvRegistrarPlato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistrarPlato.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvRegistrarPlato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistrarPlato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRegistrarPlato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegistrarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistrarPlato.Location = new System.Drawing.Point(11, 273);
            this.dgvRegistrarPlato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRegistrarPlato.Name = "dgvRegistrarPlato";
            this.dgvRegistrarPlato.ReadOnly = true;
            this.dgvRegistrarPlato.RowHeadersVisible = false;
            this.dgvRegistrarPlato.RowHeadersWidth = 62;
            this.dgvRegistrarPlato.RowTemplate.Height = 28;
            this.dgvRegistrarPlato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistrarPlato.Size = new System.Drawing.Size(1041, 143);
            this.dgvRegistrarPlato.TabIndex = 17;
            // 
            // RegistrarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1067, 528);
            this.Controls.Add(this.dgvRegistrarPlato);
            this.Controls.Add(this.btnAñadirNombreRP);
            this.Controls.Add(this.btnAñadirStockRP);
            this.Controls.Add(this.btnAñadirPrecioRP);
            this.Controls.Add(this.btnLimpiarRP);
            this.Controls.Add(this.cmbDescripcionRP);
            this.Controls.Add(this.txtPrecioRP);
            this.Controls.Add(this.labelPrecioRP);
            this.Controls.Add(this.labelDescripcionRP);
            this.Controls.Add(this.btnAñadirDescripcionRP);
            this.Controls.Add(this.btnRegistrarRP);
            this.Controls.Add(this.txtStockRP);
            this.Controls.Add(this.txtNombreRP);
            this.Controls.Add(this.labelStockRP);
            this.Controls.Add(this.labelNombreRP);
            this.Controls.Add(this.panelRegistrarPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistrarPlato";
            this.Text = "RegistrarPlato";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrarPlato_MouseDown);
            this.panelRegistrarPlato.ResumeLayout(false);
            this.panelRegistrarPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistrarPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistrarPlato;
        private System.Windows.Forms.Label labelRegistrarPlato;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.Label labelNombreRP;
        private System.Windows.Forms.Label labelStockRP;
        private System.Windows.Forms.TextBox txtNombreRP;
        private System.Windows.Forms.TextBox txtStockRP;
        private System.Windows.Forms.Button btnRegistrarRP;
        private System.Windows.Forms.Button btnAñadirDescripcionRP;
        private System.Windows.Forms.Label labelDescripcionRP;
        private System.Windows.Forms.Label labelPrecioRP;
        private System.Windows.Forms.TextBox txtPrecioRP;
        private System.Windows.Forms.ComboBox cmbDescripcionRP;
        private System.Windows.Forms.Button btnLimpiarRP;
        private System.Windows.Forms.Button btnAñadirPrecioRP;
        private System.Windows.Forms.Button btnAñadirStockRP;
        private System.Windows.Forms.Button btnAñadirNombreRP;
        private System.Windows.Forms.DataGridView dgvRegistrarPlato;
    }
}