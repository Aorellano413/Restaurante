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
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarRegistroProducto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnRegistrarPlato = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnModificarPlato = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(330, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "GESTION DE PLATOS";
            // 
            // btnCerrarRegistroProducto
            // 
            this.btnCerrarRegistroProducto.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistroProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistroProducto.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistroProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistroProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistroProducto.Image")));
            this.btnCerrarRegistroProducto.Location = new System.Drawing.Point(762, 5);
            this.btnCerrarRegistroProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarRegistroProducto.Name = "btnCerrarRegistroProducto";
            this.btnCerrarRegistroProducto.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarRegistroProducto.TabIndex = 14;
            this.btnCerrarRegistroProducto.UseVisualStyleBackColor = false;
            this.btnCerrarRegistroProducto.Click += new System.EventHandler(this.btnCerrarRegistroProducto_Click);
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
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 16;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Black;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(712, 3);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(42, 37);
            this.btnRegresar.TabIndex = 27;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnRegistrarPlato
            // 
            this.btnRegistrarPlato.BackColor = System.Drawing.Color.Khaki;
            this.btnRegistrarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPlato.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarPlato.Location = new System.Drawing.Point(313, 283);
            this.btnRegistrarPlato.Name = "btnRegistrarPlato";
            this.btnRegistrarPlato.Size = new System.Drawing.Size(200, 84);
            this.btnRegistrarPlato.TabIndex = 19;
            this.btnRegistrarPlato.Text = "REGISTRAR PLATO";
            this.btnRegistrarPlato.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.button2.Location = new System.Drawing.Point(588, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 84);
            this.button2.TabIndex = 21;
            this.button2.Text = "ELIMINAR PLATO";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(313, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(587, 115);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 162);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // btnModificarPlato
            // 
            this.btnModificarPlato.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPlato.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModificarPlato.Location = new System.Drawing.Point(26, 283);
            this.btnModificarPlato.Name = "btnModificarPlato";
            this.btnModificarPlato.Size = new System.Drawing.Size(200, 84);
            this.btnModificarPlato.TabIndex = 20;
            this.btnModificarPlato.Text = "MODIFICAR PLATO";
            this.btnModificarPlato.UseVisualStyleBackColor = false;
            // 
            // RegistroProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModificarPlato);
            this.Controls.Add(this.btnRegistrarPlato);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegistroProductos";
            this.Text = "RegistroProductos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarRegistroProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnRegistrarPlato;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnModificarPlato;
    }
}