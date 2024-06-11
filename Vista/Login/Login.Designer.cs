namespace Vista
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelfecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.Horafecha = new System.Windows.Forms.Timer(this.components);
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(664, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(832, 251);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(210, 26);
            this.textUsuario.TabIndex = 3;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(832, 309);
            this.textContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(210, 26);
            this.textContraseña.TabIndex = 4;
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.BackColor = System.Drawing.Color.Transparent;
            this.buttonContinuar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinuar.Image = ((System.Drawing.Image)(resources.GetObject("buttonContinuar.Image")));
            this.buttonContinuar.Location = new System.Drawing.Point(850, 375);
            this.buttonContinuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(69, 69);
            this.buttonContinuar.TabIndex = 5;
            this.buttonContinuar.UseVisualStyleBackColor = false;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCancelar.FlatAppearance.BorderSize = 0;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelar.Image")));
            this.buttonCancelar.Location = new System.Drawing.Point(958, 375);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(74, 69);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Snow;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(1136, 5);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(46, 42);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(4, 126);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(446, 426);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(818, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 115);
            this.label3.TabIndex = 9;
            this.label3.Text = "LOGIN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.labelfecha);
            this.panel1.Controls.Add(this.labelHora);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 692);
            this.panel1.TabIndex = 10;
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelfecha.Location = new System.Drawing.Point(32, 578);
            this.labelfecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(109, 53);
            this.labelfecha.TabIndex = 10;
            this.labelfecha.Text = "Fecha";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Bahnschrift Condensed", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelHora.Location = new System.Drawing.Point(130, 14);
            this.labelHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(101, 60);
            this.labelHora.TabIndex = 9;
            this.labelHora.Text = "Hora";
            // 
            // Horafecha
            // 
            this.Horafecha.Enabled = true;
            this.Horafecha.Tick += new System.EventHandler(this.Horafecha_Tick);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Items.AddRange(new object[] {
            "Administrador",
            "Cajero"});
            this.cmbRol.Location = new System.Drawing.Point(832, 191);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(210, 28);
            this.cmbRol.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "TIIPO:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer Horafecha;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelfecha;
    }
}

