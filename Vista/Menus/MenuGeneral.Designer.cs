namespace Vista
{
    partial class MenuGeneral
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGeneral));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventariosPlatos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHora1 = new System.Windows.Forms.Label();
            this.labelDia = new System.Windows.Forms.Label();
            this.pictureRegistrarProductos = new System.Windows.Forms.PictureBox();
            this.pictureRegistrarGramos = new System.Windows.Forms.PictureBox();
            this.pictureInventario = new System.Windows.Forms.PictureBox();
            this.btnRegistrarProductos = new System.Windows.Forms.Button();
            this.btnRegistrarGramos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarGramos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.Snow;
            this.panelGeneral.Controls.Add(this.pictureBox1);
            this.panelGeneral.Controls.Add(this.btnInventariosPlatos);
            this.panelGeneral.Controls.Add(this.panel1);
            this.panelGeneral.Controls.Add(this.pictureRegistrarProductos);
            this.panelGeneral.Controls.Add(this.pictureRegistrarGramos);
            this.panelGeneral.Controls.Add(this.pictureInventario);
            this.panelGeneral.Controls.Add(this.btnRegistrarProductos);
            this.panelGeneral.Controls.Add(this.btnRegistrarGramos);
            this.panelGeneral.Controls.Add(this.btnInventario);
            this.panelGeneral.Location = new System.Drawing.Point(0, 49);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1658, 718);
            this.panelGeneral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventariosPlatos
            // 
            this.btnInventariosPlatos.BackColor = System.Drawing.Color.Khaki;
            this.btnInventariosPlatos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventariosPlatos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnInventariosPlatos.Location = new System.Drawing.Point(459, 317);
            this.btnInventariosPlatos.Name = "btnInventariosPlatos";
            this.btnInventariosPlatos.Size = new System.Drawing.Size(300, 129);
            this.btnInventariosPlatos.TabIndex = 9;
            this.btnInventariosPlatos.Text = "INVENTARIO PLATOS";
            this.btnInventariosPlatos.UseVisualStyleBackColor = false;
            this.btnInventariosPlatos.Click += new System.EventHandler(this.btnInventariosPlatos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.labelHora1);
            this.panel1.Controls.Add(this.labelDia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1658, 95);
            this.panel1.TabIndex = 8;
            // 
            // labelHora1
            // 
            this.labelHora1.AutoSize = true;
            this.labelHora1.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelHora1.Location = new System.Drawing.Point(1388, 12);
            this.labelHora1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora1.Name = "labelHora1";
            this.labelHora1.Size = new System.Drawing.Size(126, 68);
            this.labelHora1.TabIndex = 6;
            this.labelHora1.Text = "HORA";
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDia.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelDia.Location = new System.Drawing.Point(22, 12);
            this.labelDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(87, 68);
            this.labelDia.TabIndex = 7;
            this.labelDia.Text = "DIA";
            // 
            // pictureRegistrarProductos
            // 
            this.pictureRegistrarProductos.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegistrarProductos.Image")));
            this.pictureRegistrarProductos.Location = new System.Drawing.Point(1341, 62);
            this.pictureRegistrarProductos.Name = "pictureRegistrarProductos";
            this.pictureRegistrarProductos.Size = new System.Drawing.Size(300, 249);
            this.pictureRegistrarProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRegistrarProductos.TabIndex = 5;
            this.pictureRegistrarProductos.TabStop = false;
            // 
            // pictureRegistrarGramos
            // 
            this.pictureRegistrarGramos.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegistrarGramos.Image")));
            this.pictureRegistrarGramos.Location = new System.Drawing.Point(902, 62);
            this.pictureRegistrarGramos.Name = "pictureRegistrarGramos";
            this.pictureRegistrarGramos.Size = new System.Drawing.Size(300, 249);
            this.pictureRegistrarGramos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRegistrarGramos.TabIndex = 4;
            this.pictureRegistrarGramos.TabStop = false;
            // 
            // pictureInventario
            // 
            this.pictureInventario.Image = ((System.Drawing.Image)(resources.GetObject("pictureInventario.Image")));
            this.pictureInventario.Location = new System.Drawing.Point(34, 62);
            this.pictureInventario.Name = "pictureInventario";
            this.pictureInventario.Size = new System.Drawing.Size(300, 249);
            this.pictureInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInventario.TabIndex = 3;
            this.pictureInventario.TabStop = false;
            // 
            // btnRegistrarProductos
            // 
            this.btnRegistrarProductos.BackColor = System.Drawing.Color.Khaki;
            this.btnRegistrarProductos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProductos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarProductos.Location = new System.Drawing.Point(1341, 317);
            this.btnRegistrarProductos.Name = "btnRegistrarProductos";
            this.btnRegistrarProductos.Size = new System.Drawing.Size(300, 129);
            this.btnRegistrarProductos.TabIndex = 2;
            this.btnRegistrarProductos.Text = "GESTIONAR PLATOS";
            this.btnRegistrarProductos.UseVisualStyleBackColor = false;
            this.btnRegistrarProductos.Click += new System.EventHandler(this.btnRegistrarProductos_Click);
            // 
            // btnRegistrarGramos
            // 
            this.btnRegistrarGramos.BackColor = System.Drawing.Color.Khaki;
            this.btnRegistrarGramos.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGramos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarGramos.Location = new System.Drawing.Point(902, 317);
            this.btnRegistrarGramos.Name = "btnRegistrarGramos";
            this.btnRegistrarGramos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrarGramos.Size = new System.Drawing.Size(300, 129);
            this.btnRegistrarGramos.TabIndex = 1;
            this.btnRegistrarGramos.Text = "GESTIONAR INGREDIENTES";
            this.btnRegistrarGramos.UseVisualStyleBackColor = false;
            this.btnRegistrarGramos.Click += new System.EventHandler(this.btnRegistrarGramos_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Khaki;
            this.btnInventario.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnInventario.Location = new System.Drawing.Point(34, 317);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(300, 129);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "INVENTARIO INGREDIENTES";
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // buttonClose2
            // 
            this.buttonClose2.BackColor = System.Drawing.Color.Khaki;
            this.buttonClose2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose2.FlatAppearance.BorderSize = 0;
            this.buttonClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose2.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose2.Image")));
            this.buttonClose2.Location = new System.Drawing.Point(1606, 5);
            this.buttonClose2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(34, 35);
            this.buttonClose2.TabIndex = 2;
            this.buttonClose2.UseVisualStyleBackColor = false;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(1545, -2);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(46, 48);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(752, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 43);
            this.label3.TabIndex = 26;
            this.label3.Text = "MENU GENERAL";
            // 
            // MenuGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1659, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.buttonClose2);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuGeneral";
            this.Text = "MenuGeneral";
            this.panelGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarGramos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Button buttonClose2;
        private System.Windows.Forms.Button btnRegistrarGramos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnRegistrarProductos;
        private System.Windows.Forms.PictureBox pictureRegistrarProductos;
        private System.Windows.Forms.PictureBox pictureRegistrarGramos;
        private System.Windows.Forms.PictureBox pictureInventario;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelHora1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInventariosPlatos;
    }
}