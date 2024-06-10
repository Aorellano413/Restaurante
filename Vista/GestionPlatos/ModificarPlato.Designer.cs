namespace Vista.GestionPlatos
{
    partial class ModificarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPlato));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelModificarPlato = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelModificarPlato = new System.Windows.Forms.Label();
            this.txtBuscarPlatoMP = new System.Windows.Forms.TextBox();
            this.btnModificarMP = new System.Windows.Forms.Button();
            this.dgvModificarPlato = new System.Windows.Forms.DataGridView();
            this.labelNombreMP = new System.Windows.Forms.Label();
            this.labelDescripcionMP = new System.Windows.Forms.Label();
            this.labelPrecioMP = new System.Windows.Forms.Label();
            this.labelStockMP = new System.Windows.Forms.Label();
            this.txtNombreMP = new System.Windows.Forms.TextBox();
            this.txtPrecioMP = new System.Windows.Forms.TextBox();
            this.txtStockMP = new System.Windows.Forms.TextBox();
            this.cmbDescripcionMP = new System.Windows.Forms.ComboBox();
            this.btnAñadirNombreMP = new System.Windows.Forms.Button();
            this.btnAñadirDescripcionMP = new System.Windows.Forms.Button();
            this.btnAñadirPrecioMP = new System.Windows.Forms.Button();
            this.btnAñadirStockMP = new System.Windows.Forms.Button();
            this.btnLimpiarNombreMP = new System.Windows.Forms.Button();
            this.btnLimpiarDescripcionMP = new System.Windows.Forms.Button();
            this.btnLimpiarPrecioMP = new System.Windows.Forms.Button();
            this.btnLimpiarStockMP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelModificarPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarPlato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelModificarPlato
            // 
            this.panelModificarPlato.BackColor = System.Drawing.Color.Khaki;
            this.panelModificarPlato.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.panelModificarPlato.Controls.Add(this.labelModificarPlato);
            this.panelModificarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModificarPlato.Location = new System.Drawing.Point(0, 0);
            this.panelModificarPlato.Margin = new System.Windows.Forms.Padding(2);
            this.panelModificarPlato.Name = "panelModificarPlato";
            this.panelModificarPlato.Size = new System.Drawing.Size(830, 33);
            this.panelModificarPlato.TabIndex = 0;
            this.panelModificarPlato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelModificarPlato_MouseDown);
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(795, 3);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarRegistrarIngrediente.TabIndex = 17;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelModificarPlato
            // 
            this.labelModificarPlato.AutoSize = true;
            this.labelModificarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarPlato.Location = new System.Drawing.Point(333, 3);
            this.labelModificarPlato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModificarPlato.Name = "labelModificarPlato";
            this.labelModificarPlato.Size = new System.Drawing.Size(151, 29);
            this.labelModificarPlato.TabIndex = 1;
            this.labelModificarPlato.Text = "MODIFICAR PLATO";
            // 
            // txtBuscarPlatoMP
            // 
            this.txtBuscarPlatoMP.Location = new System.Drawing.Point(62, 64);
            this.txtBuscarPlatoMP.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarPlatoMP.Name = "txtBuscarPlatoMP";
            this.txtBuscarPlatoMP.Size = new System.Drawing.Size(192, 20);
            this.txtBuscarPlatoMP.TabIndex = 9;
            this.txtBuscarPlatoMP.TextChanged += new System.EventHandler(this.txtBuscarPlatoMP_TextChanged);
            // 
            // btnModificarMP
            // 
            this.btnModificarMP.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarMP.FlatAppearance.BorderSize = 0;
            this.btnModificarMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMP.ForeColor = System.Drawing.Color.Black;
            this.btnModificarMP.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarMP.Image")));
            this.btnModificarMP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarMP.Location = new System.Drawing.Point(301, 478);
            this.btnModificarMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarMP.Name = "btnModificarMP";
            this.btnModificarMP.Size = new System.Drawing.Size(167, 86);
            this.btnModificarMP.TabIndex = 11;
            this.btnModificarMP.Text = "MODIFICAR";
            this.btnModificarMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMP.UseVisualStyleBackColor = false;
            this.btnModificarMP.Click += new System.EventHandler(this.btnModificarMP_Click);
            // 
            // dgvModificarPlato
            // 
            this.dgvModificarPlato.AllowUserToAddRows = false;
            this.dgvModificarPlato.AllowUserToDeleteRows = false;
            this.dgvModificarPlato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModificarPlato.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvModificarPlato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModificarPlato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModificarPlato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModificarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModificarPlato.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModificarPlato.Location = new System.Drawing.Point(7, 105);
            this.dgvModificarPlato.Margin = new System.Windows.Forms.Padding(2);
            this.dgvModificarPlato.Name = "dgvModificarPlato";
            this.dgvModificarPlato.ReadOnly = true;
            this.dgvModificarPlato.RowHeadersVisible = false;
            this.dgvModificarPlato.RowHeadersWidth = 62;
            this.dgvModificarPlato.RowTemplate.Height = 28;
            this.dgvModificarPlato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModificarPlato.Size = new System.Drawing.Size(811, 192);
            this.dgvModificarPlato.TabIndex = 12;
            // 
            // labelNombreMP
            // 
            this.labelNombreMP.AutoSize = true;
            this.labelNombreMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreMP.Location = new System.Drawing.Point(157, 316);
            this.labelNombreMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreMP.Name = "labelNombreMP";
            this.labelNombreMP.Size = new System.Drawing.Size(97, 23);
            this.labelNombreMP.TabIndex = 13;
            this.labelNombreMP.Text = "NOMBRE        :";
            // 
            // labelDescripcionMP
            // 
            this.labelDescripcionMP.AutoSize = true;
            this.labelDescripcionMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionMP.Location = new System.Drawing.Point(157, 354);
            this.labelDescripcionMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcionMP.Name = "labelDescripcionMP";
            this.labelDescripcionMP.Size = new System.Drawing.Size(98, 23);
            this.labelDescripcionMP.TabIndex = 14;
            this.labelDescripcionMP.Text = "DESCRIPCION :";
            // 
            // labelPrecioMP
            // 
            this.labelPrecioMP.AutoSize = true;
            this.labelPrecioMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioMP.Location = new System.Drawing.Point(160, 393);
            this.labelPrecioMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecioMP.Name = "labelPrecioMP";
            this.labelPrecioMP.Size = new System.Drawing.Size(94, 23);
            this.labelPrecioMP.TabIndex = 15;
            this.labelPrecioMP.Text = "PRECIO         :";
            // 
            // labelStockMP
            // 
            this.labelStockMP.AutoSize = true;
            this.labelStockMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockMP.Location = new System.Drawing.Point(161, 433);
            this.labelStockMP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStockMP.Name = "labelStockMP";
            this.labelStockMP.Size = new System.Drawing.Size(93, 23);
            this.labelStockMP.TabIndex = 16;
            this.labelStockMP.Text = "STOCK          :";
            // 
            // txtNombreMP
            // 
            this.txtNombreMP.Location = new System.Drawing.Point(257, 321);
            this.txtNombreMP.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreMP.Name = "txtNombreMP";
            this.txtNombreMP.Size = new System.Drawing.Size(141, 20);
            this.txtNombreMP.TabIndex = 17;
            // 
            // txtPrecioMP
            // 
            this.txtPrecioMP.Location = new System.Drawing.Point(257, 399);
            this.txtPrecioMP.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioMP.Name = "txtPrecioMP";
            this.txtPrecioMP.Size = new System.Drawing.Size(141, 20);
            this.txtPrecioMP.TabIndex = 18;
            // 
            // txtStockMP
            // 
            this.txtStockMP.Location = new System.Drawing.Point(257, 439);
            this.txtStockMP.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockMP.Name = "txtStockMP";
            this.txtStockMP.Size = new System.Drawing.Size(141, 20);
            this.txtStockMP.TabIndex = 19;
            // 
            // cmbDescripcionMP
            // 
            this.cmbDescripcionMP.FormattingEnabled = true;
            this.cmbDescripcionMP.Location = new System.Drawing.Point(257, 358);
            this.cmbDescripcionMP.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDescripcionMP.Name = "cmbDescripcionMP";
            this.cmbDescripcionMP.Size = new System.Drawing.Size(141, 21);
            this.cmbDescripcionMP.TabIndex = 20;
            // 
            // btnAñadirNombreMP
            // 
            this.btnAñadirNombreMP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirNombreMP.FlatAppearance.BorderSize = 0;
            this.btnAñadirNombreMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirNombreMP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirNombreMP.Location = new System.Drawing.Point(418, 313);
            this.btnAñadirNombreMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirNombreMP.Name = "btnAñadirNombreMP";
            this.btnAñadirNombreMP.Size = new System.Drawing.Size(66, 28);
            this.btnAñadirNombreMP.TabIndex = 21;
            this.btnAñadirNombreMP.Text = "AÑADIR";
            this.btnAñadirNombreMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirNombreMP.UseVisualStyleBackColor = false;
            this.btnAñadirNombreMP.Click += new System.EventHandler(this.btnAñadirNombreMP_Click);
            // 
            // btnAñadirDescripcionMP
            // 
            this.btnAñadirDescripcionMP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirDescripcionMP.FlatAppearance.BorderSize = 0;
            this.btnAñadirDescripcionMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirDescripcionMP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirDescripcionMP.Location = new System.Drawing.Point(418, 349);
            this.btnAñadirDescripcionMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirDescripcionMP.Name = "btnAñadirDescripcionMP";
            this.btnAñadirDescripcionMP.Size = new System.Drawing.Size(66, 28);
            this.btnAñadirDescripcionMP.TabIndex = 22;
            this.btnAñadirDescripcionMP.Text = "AÑADIR";
            this.btnAñadirDescripcionMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirDescripcionMP.UseVisualStyleBackColor = false;
            this.btnAñadirDescripcionMP.Click += new System.EventHandler(this.btnAñadirDescripcionMP_Click);
            // 
            // btnAñadirPrecioMP
            // 
            this.btnAñadirPrecioMP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirPrecioMP.FlatAppearance.BorderSize = 0;
            this.btnAñadirPrecioMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirPrecioMP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirPrecioMP.Location = new System.Drawing.Point(418, 390);
            this.btnAñadirPrecioMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirPrecioMP.Name = "btnAñadirPrecioMP";
            this.btnAñadirPrecioMP.Size = new System.Drawing.Size(66, 28);
            this.btnAñadirPrecioMP.TabIndex = 23;
            this.btnAñadirPrecioMP.Text = "AÑADIR";
            this.btnAñadirPrecioMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirPrecioMP.UseVisualStyleBackColor = false;
            this.btnAñadirPrecioMP.Click += new System.EventHandler(this.btnAñadirPrecioMP_Click);
            // 
            // btnAñadirStockMP
            // 
            this.btnAñadirStockMP.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirStockMP.FlatAppearance.BorderSize = 0;
            this.btnAñadirStockMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirStockMP.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirStockMP.Location = new System.Drawing.Point(418, 431);
            this.btnAñadirStockMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadirStockMP.Name = "btnAñadirStockMP";
            this.btnAñadirStockMP.Size = new System.Drawing.Size(66, 28);
            this.btnAñadirStockMP.TabIndex = 24;
            this.btnAñadirStockMP.Text = "AÑADIR";
            this.btnAñadirStockMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirStockMP.UseVisualStyleBackColor = false;
            this.btnAñadirStockMP.Click += new System.EventHandler(this.btnAñadirStockMP_Click);
            // 
            // btnLimpiarNombreMP
            // 
            this.btnLimpiarNombreMP.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarNombreMP.FlatAppearance.BorderSize = 0;
            this.btnLimpiarNombreMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarNombreMP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarNombreMP.Location = new System.Drawing.Point(511, 313);
            this.btnLimpiarNombreMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarNombreMP.Name = "btnLimpiarNombreMP";
            this.btnLimpiarNombreMP.Size = new System.Drawing.Size(73, 28);
            this.btnLimpiarNombreMP.TabIndex = 25;
            this.btnLimpiarNombreMP.Text = "LIMPIAR";
            this.btnLimpiarNombreMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarNombreMP.UseVisualStyleBackColor = false;
            this.btnLimpiarNombreMP.Click += new System.EventHandler(this.btnLimpiarNombreMP_Click);
            // 
            // btnLimpiarDescripcionMP
            // 
            this.btnLimpiarDescripcionMP.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarDescripcionMP.FlatAppearance.BorderSize = 0;
            this.btnLimpiarDescripcionMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDescripcionMP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarDescripcionMP.Location = new System.Drawing.Point(511, 351);
            this.btnLimpiarDescripcionMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarDescripcionMP.Name = "btnLimpiarDescripcionMP";
            this.btnLimpiarDescripcionMP.Size = new System.Drawing.Size(73, 28);
            this.btnLimpiarDescripcionMP.TabIndex = 26;
            this.btnLimpiarDescripcionMP.Text = "LIMPIAR";
            this.btnLimpiarDescripcionMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDescripcionMP.UseVisualStyleBackColor = false;
            this.btnLimpiarDescripcionMP.Click += new System.EventHandler(this.btnLimpiarDescripcionMP_Click);
            // 
            // btnLimpiarPrecioMP
            // 
            this.btnLimpiarPrecioMP.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarPrecioMP.FlatAppearance.BorderSize = 0;
            this.btnLimpiarPrecioMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPrecioMP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarPrecioMP.Location = new System.Drawing.Point(511, 393);
            this.btnLimpiarPrecioMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarPrecioMP.Name = "btnLimpiarPrecioMP";
            this.btnLimpiarPrecioMP.Size = new System.Drawing.Size(73, 28);
            this.btnLimpiarPrecioMP.TabIndex = 27;
            this.btnLimpiarPrecioMP.Text = "LIMPIAR";
            this.btnLimpiarPrecioMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarPrecioMP.UseVisualStyleBackColor = false;
            this.btnLimpiarPrecioMP.Click += new System.EventHandler(this.btnLimpiarPrecioMP_Click);
            // 
            // btnLimpiarStockMP
            // 
            this.btnLimpiarStockMP.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarStockMP.FlatAppearance.BorderSize = 0;
            this.btnLimpiarStockMP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarStockMP.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiarStockMP.Location = new System.Drawing.Point(511, 433);
            this.btnLimpiarStockMP.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarStockMP.Name = "btnLimpiarStockMP";
            this.btnLimpiarStockMP.Size = new System.Drawing.Size(73, 28);
            this.btnLimpiarStockMP.TabIndex = 28;
            this.btnLimpiarStockMP.Text = "LIMPIAR";
            this.btnLimpiarStockMP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarStockMP.UseVisualStyleBackColor = false;
            this.btnLimpiarStockMP.Click += new System.EventHandler(this.btnLimpiarStockMP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // ModificarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(830, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimpiarStockMP);
            this.Controls.Add(this.btnLimpiarPrecioMP);
            this.Controls.Add(this.btnLimpiarDescripcionMP);
            this.Controls.Add(this.btnLimpiarNombreMP);
            this.Controls.Add(this.btnAñadirStockMP);
            this.Controls.Add(this.btnAñadirPrecioMP);
            this.Controls.Add(this.btnAñadirDescripcionMP);
            this.Controls.Add(this.btnAñadirNombreMP);
            this.Controls.Add(this.cmbDescripcionMP);
            this.Controls.Add(this.txtStockMP);
            this.Controls.Add(this.txtPrecioMP);
            this.Controls.Add(this.txtNombreMP);
            this.Controls.Add(this.labelStockMP);
            this.Controls.Add(this.labelPrecioMP);
            this.Controls.Add(this.labelDescripcionMP);
            this.Controls.Add(this.labelNombreMP);
            this.Controls.Add(this.dgvModificarPlato);
            this.Controls.Add(this.btnModificarMP);
            this.Controls.Add(this.txtBuscarPlatoMP);
            this.Controls.Add(this.panelModificarPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarPlato";
            this.Text = "ModificarPlato";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarPlato_MouseDown);
            this.panelModificarPlato.ResumeLayout(false);
            this.panelModificarPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarPlato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarPlato;
        private System.Windows.Forms.Label labelModificarPlato;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.TextBox txtBuscarPlatoMP;
        private System.Windows.Forms.Button btnModificarMP;
        private System.Windows.Forms.DataGridView dgvModificarPlato;
        private System.Windows.Forms.Label labelNombreMP;
        private System.Windows.Forms.Label labelDescripcionMP;
        private System.Windows.Forms.Label labelPrecioMP;
        private System.Windows.Forms.Label labelStockMP;
        private System.Windows.Forms.TextBox txtNombreMP;
        private System.Windows.Forms.TextBox txtPrecioMP;
        private System.Windows.Forms.TextBox txtStockMP;
        private System.Windows.Forms.ComboBox cmbDescripcionMP;
        private System.Windows.Forms.Button btnAñadirNombreMP;
        private System.Windows.Forms.Button btnAñadirDescripcionMP;
        private System.Windows.Forms.Button btnAñadirPrecioMP;
        private System.Windows.Forms.Button btnAñadirStockMP;
        private System.Windows.Forms.Button btnLimpiarNombreMP;
        private System.Windows.Forms.Button btnLimpiarDescripcionMP;
        private System.Windows.Forms.Button btnLimpiarPrecioMP;
        private System.Windows.Forms.Button btnLimpiarStockMP;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}