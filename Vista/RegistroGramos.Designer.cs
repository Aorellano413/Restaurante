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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistoGramos));
            this.btnCerraGramos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewGramos = new System.Windows.Forms.DataGridView();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRAMOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboRegistro = new System.Windows.Forms.ComboBox();
            this.textGramos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBorrar3 = new System.Windows.Forms.Button();
            this.buttonGuardar3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGramos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerraGramos
            // 
            this.btnCerraGramos.BackColor = System.Drawing.Color.Red;
            this.btnCerraGramos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerraGramos.Image = ((System.Drawing.Image)(resources.GetObject("btnCerraGramos.Image")));
            this.btnCerraGramos.Location = new System.Drawing.Point(755, 3);
            this.btnCerraGramos.Name = "btnCerraGramos";
            this.btnCerraGramos.Size = new System.Drawing.Size(33, 32);
            this.btnCerraGramos.TabIndex = 16;
            this.btnCerraGramos.UseVisualStyleBackColor = false;
            this.btnCerraGramos.Click += new System.EventHandler(this.btnCerraGramos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCerraGramos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "REGISTRO DE GRAMOS (gr)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = " GRAMOS:";
            // 
            // dataGridViewGramos
            // 
            this.dataGridViewGramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGramos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCTO,
            this.GRAMOS});
            this.dataGridViewGramos.Location = new System.Drawing.Point(17, 216);
            this.dataGridViewGramos.Name = "dataGridViewGramos";
            this.dataGridViewGramos.Size = new System.Drawing.Size(342, 98);
            this.dataGridViewGramos.TabIndex = 19;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.Width = 150;
            // 
            // GRAMOS
            // 
            this.GRAMOS.HeaderText = "GRAMOS";
            this.GRAMOS.Name = "GRAMOS";
            this.GRAMOS.Width = 150;
            // 
            // comboRegistro
            // 
            this.comboRegistro.FormattingEnabled = true;
            this.comboRegistro.Items.AddRange(new object[] {
            "PEPERONI",
            "PAPA",
            "SALCHICHA SENCILLA",
            "SALCHICHA RANCHERA",
            "CHORIZO",
            "BUTIFARRA",
            "LECHUGA",
            "TOMATE",
            "CEBOLLA",
            "MAIZ TIERNO",
            "CARNE",
            "QUESO"});
            this.comboRegistro.Location = new System.Drawing.Point(217, 71);
            this.comboRegistro.Name = "comboRegistro";
            this.comboRegistro.Size = new System.Drawing.Size(121, 21);
            this.comboRegistro.TabIndex = 20;
            // 
            // textGramos
            // 
            this.textGramos.Location = new System.Drawing.Point(217, 160);
            this.textGramos.Name = "textGramos";
            this.textGramos.Size = new System.Drawing.Size(100, 20);
            this.textGramos.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "PRODUCTOS:";
            // 
            // buttonBorrar3
            // 
            this.buttonBorrar3.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonBorrar3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonBorrar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar3.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrar3.Image")));
            this.buttonBorrar3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrar3.Location = new System.Drawing.Point(256, 320);
            this.buttonBorrar3.Name = "buttonBorrar3";
            this.buttonBorrar3.Size = new System.Drawing.Size(103, 50);
            this.buttonBorrar3.TabIndex = 23;
            this.buttonBorrar3.Text = "BORRAR";
            this.buttonBorrar3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBorrar3.UseVisualStyleBackColor = true;
            this.buttonBorrar3.Click += new System.EventHandler(this.buttonBorrar3_Click);
            // 
            // buttonGuardar3
            // 
            this.buttonGuardar3.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonGuardar3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonGuardar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar3.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar3.Image")));
            this.buttonGuardar3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuardar3.Location = new System.Drawing.Point(17, 320);
            this.buttonGuardar3.Name = "buttonGuardar3";
            this.buttonGuardar3.Size = new System.Drawing.Size(148, 50);
            this.buttonGuardar3.TabIndex = 24;
            this.buttonGuardar3.Text = "GUARDAR";
            this.buttonGuardar3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGuardar3.UseVisualStyleBackColor = true;
            this.buttonGuardar3.Click += new System.EventHandler(this.buttonGuardar3_Click);
            // 
            // RegistoGramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuardar3);
            this.Controls.Add(this.buttonBorrar3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textGramos);
            this.Controls.Add(this.comboRegistro);
            this.Controls.Add(this.dataGridViewGramos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistoGramos";
            this.Text = "RegistroGramos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGramos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerraGramos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGramos;
        private System.Windows.Forms.ComboBox comboRegistro;
        private System.Windows.Forms.TextBox textGramos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBorrar3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRAMOS;
        private System.Windows.Forms.Button buttonGuardar3;
        private System.Windows.Forms.Label label3;
    }
}