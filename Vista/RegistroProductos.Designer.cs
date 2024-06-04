namespace Vista
{
    partial class RegistroProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            this.labelId = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.dataGridProducto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGEN = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonSeleccionarJPG = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonNuevo2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarRegistroProducto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(14, 95);
            this.labelId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(24, 23);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(14, 231);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(57, 23);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "PRECIO:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(14, 163);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 23);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "NOMBRE:";
            // 
            // textId
            // 
            this.textId.BackColor = System.Drawing.Color.White;
            this.textId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(180, 95);
            this.textId.Margin = new System.Windows.Forms.Padding(5);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(164, 26);
            this.textId.TabIndex = 3;
            // 
            // textPrecio
            // 
            this.textPrecio.BackColor = System.Drawing.Color.White;
            this.textPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrecio.Location = new System.Drawing.Point(180, 225);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(164, 26);
            this.textPrecio.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.BackColor = System.Drawing.Color.White;
            this.textNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(180, 163);
            this.textNombre.Margin = new System.Windows.Forms.Padding(5);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(164, 26);
            this.textNombre.TabIndex = 5;
            // 
            // dataGridProducto
            // 
            this.dataGridProducto.AllowUserToAddRows = false;
            this.dataGridProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridProducto.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HelveticaNeueLT Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.PRECIO,
            this.IMAGEN});
            this.dataGridProducto.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridProducto.EnableHeadersVisualStyles = false;
            this.dataGridProducto.Location = new System.Drawing.Point(18, 268);
            this.dataGridProducto.Name = "dataGridProducto";
            this.dataGridProducto.ReadOnly = true;
            this.dataGridProducto.RowHeadersVisible = false;
            this.dataGridProducto.RowHeadersWidth = 62;
            this.dataGridProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducto.Size = new System.Drawing.Size(657, 255);
            this.dataGridProducto.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // IMAGEN
            // 
            this.IMAGEN.HeaderText = "IMAGEN";
            this.IMAGEN.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.IMAGEN.Name = "IMAGEN";
            this.IMAGEN.ReadOnly = true;
            // 
            // buttonSeleccionarJPG
            // 
            this.buttonSeleccionarJPG.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.buttonSeleccionarJPG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSeleccionarJPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionarJPG.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeleccionarJPG.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeleccionarJPG.Image")));
            this.buttonSeleccionarJPG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeleccionarJPG.Location = new System.Drawing.Point(779, 538);
            this.buttonSeleccionarJPG.Name = "buttonSeleccionarJPG";
            this.buttonSeleccionarJPG.Size = new System.Drawing.Size(221, 50);
            this.buttonSeleccionarJPG.TabIndex = 8;
            this.buttonSeleccionarJPG.Text = "SELECCIONAR IMAGEN";
            this.buttonSeleccionarJPG.UseVisualStyleBackColor = true;
            this.buttonSeleccionarJPG.Click += new System.EventHandler(this.buttonSeleccionarJPG_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.buttonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(257, 538);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(109, 50);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.buttonBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.Image")));
            this.buttonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrar.Location = new System.Drawing.Point(548, 538);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(102, 50);
            this.buttonBorrar.TabIndex = 10;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonNuevo2
            // 
            this.buttonNuevo2.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.buttonNuevo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonNuevo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo2.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo2.Image")));
            this.buttonNuevo2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevo2.Location = new System.Drawing.Point(18, 538);
            this.buttonNuevo2.Name = "buttonNuevo2";
            this.buttonNuevo2.Size = new System.Drawing.Size(92, 50);
            this.buttonNuevo2.TabIndex = 11;
            this.buttonNuevo2.Text = "NUEVO";
            this.buttonNuevo2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevo2.UseVisualStyleBackColor = true;
            this.buttonNuevo2.Click += new System.EventHandler(this.buttonNuevo2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(459, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "REGISTRO DE PRODUCTOS AJS";
            // 
            // btnCerrarRegistroProducto
            // 
            this.btnCerrarRegistroProducto.BackColor = System.Drawing.Color.Red;
            this.btnCerrarRegistroProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistroProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistroProducto.Image")));
            this.btnCerrarRegistroProducto.Location = new System.Drawing.Point(1122, 5);
            this.btnCerrarRegistroProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarRegistroProducto.Name = "btnCerrarRegistroProducto";
            this.btnCerrarRegistroProducto.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarRegistroProducto.TabIndex = 14;
            this.btnCerrarRegistroProducto.UseVisualStyleBackColor = false;
            this.btnCerrarRegistroProducto.Click += new System.EventHandler(this.btnCerrarRegistroProducto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(718, 121);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(412, 360);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCerrarRegistroProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 51);
            this.panel1.TabIndex = 16;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(1069, 2);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(45, 40);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1160, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonNuevo2);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonSeleccionarJPG);
            this.Controls.Add(this.dataGridProducto);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegistroProductos";
            this.Text = "RegistroProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.DataGridView dataGridProducto;
        private System.Windows.Forms.Button buttonSeleccionarJPG;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonNuevo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarRegistroProducto;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewImageColumn IMAGEN;
    }
}