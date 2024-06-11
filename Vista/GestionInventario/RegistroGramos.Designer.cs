namespace Vista
{
    partial class RegistoGramos
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistoGramos));
            this.btnCerraGramos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrarIngrediente = new System.Windows.Forms.Button();
            this.btnModificarIngrediente = new System.Windows.Forms.Button();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.pictureInventario = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerraGramos
            // 
            this.btnCerraGramos.BackColor = System.Drawing.Color.Khaki;
            this.btnCerraGramos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerraGramos.FlatAppearance.BorderSize = 0;
            this.btnCerraGramos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerraGramos.Image = ((System.Drawing.Image)(resources.GetObject("btnCerraGramos.Image")));
            this.btnCerraGramos.Location = new System.Drawing.Point(1317, 3);
            this.btnCerraGramos.Name = "btnCerraGramos";
            this.btnCerraGramos.Size = new System.Drawing.Size(33, 32);
            this.btnCerraGramos.TabIndex = 16;
            this.btnCerraGramos.UseVisualStyleBackColor = false;
            this.btnCerraGramos.Click += new System.EventHandler(this.btnCerraGramos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCerraGramos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 43);
            this.panel1.TabIndex = 17;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Khaki;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(1278, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(33, 32);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(593, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "GESTION DE INGREDIENTES";
            // 
            // btnRegistrarIngrediente
            // 
            this.btnRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnRegistrarIngrediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarIngrediente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRegistrarIngrediente.Location = new System.Drawing.Point(304, 322);
            this.btnRegistrarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarIngrediente.Name = "btnRegistrarIngrediente";
            this.btnRegistrarIngrediente.Size = new System.Drawing.Size(200, 84);
            this.btnRegistrarIngrediente.TabIndex = 18;
            this.btnRegistrarIngrediente.Text = "REGISTRAR INGREDIENTE";
            this.btnRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnRegistrarIngrediente.Click += new System.EventHandler(this.btnRegistrarIngrediente_Click);
            // 
            // btnModificarIngrediente
            // 
            this.btnModificarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnModificarIngrediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarIngrediente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModificarIngrediente.Location = new System.Drawing.Point(591, 322);
            this.btnModificarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarIngrediente.Name = "btnModificarIngrediente";
            this.btnModificarIngrediente.Size = new System.Drawing.Size(200, 84);
            this.btnModificarIngrediente.TabIndex = 19;
            this.btnModificarIngrediente.Text = "MODIFICAR INGREDIENTE";
            this.btnModificarIngrediente.UseVisualStyleBackColor = false;
            this.btnModificarIngrediente.Click += new System.EventHandler(this.btnModificarIngrediente_Click_1);
            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnEliminarIngrediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIngrediente.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(865, 322);
            this.btnEliminarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(200, 84);
            this.btnEliminarIngrediente.TabIndex = 20;
            this.btnEliminarIngrediente.Text = "ELIMINAR INGREDIENTE";
            this.btnEliminarIngrediente.UseVisualStyleBackColor = false;
            this.btnEliminarIngrediente.Click += new System.EventHandler(this.btnEliminarIngrediente_Click);
            // 
            // pictureInventario
            // 
            this.pictureInventario.Image = ((System.Drawing.Image)(resources.GetObject("pictureInventario.Image")));
            this.pictureInventario.Location = new System.Drawing.Point(591, 156);
            this.pictureInventario.Margin = new System.Windows.Forms.Padding(2);
            this.pictureInventario.Name = "pictureInventario";
            this.pictureInventario.Size = new System.Drawing.Size(200, 162);
            this.pictureInventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInventario.TabIndex = 21;
            this.pictureInventario.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(865, 156);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // RegistoGramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureInventario);
            this.Controls.Add(this.btnEliminarIngrediente);
            this.Controls.Add(this.btnModificarIngrediente);
            this.Controls.Add(this.btnRegistrarIngrediente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistoGramos";
            this.Text = "RegistroGramos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerraGramos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnRegistrarIngrediente;
        private System.Windows.Forms.Button btnModificarIngrediente;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.PictureBox pictureInventario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
