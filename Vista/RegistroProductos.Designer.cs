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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProductos));
            this.labelId = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FOTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonNuevo2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarRegistroProducto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(14, 95);
            this.labelId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(33, 20);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "ID:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(14, 231);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(81, 20);
            this.labelPrecio.TabIndex = 1;
            this.labelPrecio.Text = "PRECIO:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(14, 163);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(90, 20);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOMBRE,
            this.PRECIO,
            this.FOTO});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(663, 255);
            this.dataGridView1.TabIndex = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 8;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 150;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 8;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 150;
            // 
            // FOTO
            // 
            this.FOTO.HeaderText = "FOTO";
            this.FOTO.MinimumWidth = 8;
            this.FOTO.Name = "FOTO";
            this.FOTO.Width = 150;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeleccionar.Image")));
            this.buttonSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeleccionar.Location = new System.Drawing.Point(870, 544);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(277, 44);
            this.buttonSeleccionar.TabIndex = 8;
            this.buttonSeleccionar.Text = "SELECCIONAR IMAGEN";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar.Location = new System.Drawing.Point(257, 526);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(148, 50);
            this.buttonGuardar.TabIndex = 9;
            this.buttonGuardar.Text = "GUARDAR";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.Image")));
            this.buttonBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrar.Location = new System.Drawing.Point(548, 526);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(127, 50);
            this.buttonBorrar.TabIndex = 10;
            this.buttonBorrar.Text = "BORRAR";
            this.buttonBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonNuevo2
            // 
            this.buttonNuevo2.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonNuevo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonNuevo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo2.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo2.Image")));
            this.buttonNuevo2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevo2.Location = new System.Drawing.Point(18, 526);
            this.buttonNuevo2.Name = "buttonNuevo2";
            this.buttonNuevo2.Size = new System.Drawing.Size(116, 50);
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
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCerrarRegistroProducto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 51);
            this.panel1.TabIndex = 16;
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1160, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonNuevo2);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonNuevo2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarRegistroProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FOTO;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
    }
}