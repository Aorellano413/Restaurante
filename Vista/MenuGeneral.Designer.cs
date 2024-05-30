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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGeneral));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnRegistrarGramos = new System.Windows.Forms.Button();
            this.btnRegistrarProductos = new System.Windows.Forms.Button();
            this.pictureInventario = new System.Windows.Forms.PictureBox();
            this.pictureRegistrarGramos = new System.Windows.Forms.PictureBox();
            this.pictureRegistrarProductos = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarGramos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.BackColor = System.Drawing.Color.Snow;
            this.panelGeneral.Controls.Add(this.pictureRegistrarProductos);
            this.panelGeneral.Controls.Add(this.pictureRegistrarGramos);
            this.panelGeneral.Controls.Add(this.pictureInventario);
            this.panelGeneral.Controls.Add(this.btnRegistrarProductos);
            this.panelGeneral.Controls.Add(this.btnRegistrarGramos);
            this.panelGeneral.Controls.Add(this.btnInventario);
            this.panelGeneral.Location = new System.Drawing.Point(0, 42);
            this.panelGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1238, 726);
            this.panelGeneral.TabIndex = 1;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // buttonClose2
            // 
            this.buttonClose2.BackColor = System.Drawing.Color.Red;
            this.buttonClose2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose2.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose2.Image")));
            this.buttonClose2.Location = new System.Drawing.Point(1198, 2);
            this.buttonClose2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(34, 35);
            this.buttonClose2.TabIndex = 2;
            this.buttonClose2.UseVisualStyleBackColor = false;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Khaki;
            this.btnInventario.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnInventario.Location = new System.Drawing.Point(34, 317);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(300, 130);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "INVENTARIO";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarGramos
            // 
            this.btnRegistrarGramos.BackColor = System.Drawing.Color.Khaki;
            this.btnRegistrarGramos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGramos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarGramos.Location = new System.Drawing.Point(468, 317);
            this.btnRegistrarGramos.Name = "btnRegistrarGramos";
            this.btnRegistrarGramos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRegistrarGramos.Size = new System.Drawing.Size(300, 130);
            this.btnRegistrarGramos.TabIndex = 1;
            this.btnRegistrarGramos.Text = "REGISTRAR GRAMOS";
            this.btnRegistrarGramos.UseVisualStyleBackColor = false;
            this.btnRegistrarGramos.Click += new System.EventHandler(this.btnRegistrarGramos_Click);
            // 
            // btnRegistrarProductos
            // 
            this.btnRegistrarProductos.BackColor = System.Drawing.Color.Khaki;
            this.btnRegistrarProductos.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProductos.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarProductos.Location = new System.Drawing.Point(901, 317);
            this.btnRegistrarProductos.Name = "btnRegistrarProductos";
            this.btnRegistrarProductos.Size = new System.Drawing.Size(300, 130);
            this.btnRegistrarProductos.TabIndex = 2;
            this.btnRegistrarProductos.Text = "REGISTRAR PRODUCTOS";
            this.btnRegistrarProductos.UseVisualStyleBackColor = false;
            this.btnRegistrarProductos.Click += new System.EventHandler(this.btnRegistrarProductos_Click);
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
            // pictureRegistrarGramos
            // 
            this.pictureRegistrarGramos.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegistrarGramos.Image")));
            this.pictureRegistrarGramos.Location = new System.Drawing.Point(485, 62);
            this.pictureRegistrarGramos.Name = "pictureRegistrarGramos";
            this.pictureRegistrarGramos.Size = new System.Drawing.Size(300, 249);
            this.pictureRegistrarGramos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRegistrarGramos.TabIndex = 4;
            this.pictureRegistrarGramos.TabStop = false;
            // 
            // pictureRegistrarProductos
            // 
            this.pictureRegistrarProductos.Image = ((System.Drawing.Image)(resources.GetObject("pictureRegistrarProductos.Image")));
            this.pictureRegistrarProductos.Location = new System.Drawing.Point(901, 62);
            this.pictureRegistrarProductos.Name = "pictureRegistrarProductos";
            this.pictureRegistrarProductos.Size = new System.Drawing.Size(300, 249);
            this.pictureRegistrarProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRegistrarProductos.TabIndex = 5;
            this.pictureRegistrarProductos.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(1144, -1);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(46, 41);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // MenuGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1238, 768);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.buttonClose2);
            this.Controls.Add(this.panelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuGeneral";
            this.Text = "MenuGeneral";
            this.panelGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarGramos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRegistrarProductos)).EndInit();
            this.ResumeLayout(false);

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
    }
}