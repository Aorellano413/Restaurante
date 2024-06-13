namespace Vista
{
    partial class DisponibilidadPlatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisponibilidadPlatos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisponibilidadPlatos = new System.Windows.Forms.Button();
            this.labelModificarPlato = new System.Windows.Forms.Label();
            this.btnRestablecerRegistroPedido = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDisponibilidadPlatos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.btnDisponibilidadPlatos);
            this.panel1.Controls.Add(this.labelModificarPlato);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 38);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnDisponibilidadPlatos
            // 
            this.btnDisponibilidadPlatos.BackColor = System.Drawing.Color.Khaki;
            this.btnDisponibilidadPlatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisponibilidadPlatos.FlatAppearance.BorderSize = 0;
            this.btnDisponibilidadPlatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisponibilidadPlatos.Image = ((System.Drawing.Image)(resources.GetObject("btnDisponibilidadPlatos.Image")));
            this.btnDisponibilidadPlatos.Location = new System.Drawing.Point(795, 4);
            this.btnDisponibilidadPlatos.Name = "btnDisponibilidadPlatos";
            this.btnDisponibilidadPlatos.Size = new System.Drawing.Size(23, 23);
            this.btnDisponibilidadPlatos.TabIndex = 20;
            this.btnDisponibilidadPlatos.UseVisualStyleBackColor = false;
            this.btnDisponibilidadPlatos.Click += new System.EventHandler(this.btnDisponibilidadPlatos_Click);
            // 
            // labelModificarPlato
            // 
            this.labelModificarPlato.AutoSize = true;
            this.labelModificarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarPlato.Location = new System.Drawing.Point(325, 4);
            this.labelModificarPlato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModificarPlato.Name = "labelModificarPlato";
            this.labelModificarPlato.Size = new System.Drawing.Size(182, 29);
            this.labelModificarPlato.TabIndex = 3;
            this.labelModificarPlato.Text = "Disponibilidad Platos";
            // 
            // btnRestablecerRegistroPedido
            // 
            this.btnRestablecerRegistroPedido.FlatAppearance.BorderSize = 0;
            this.btnRestablecerRegistroPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecerRegistroPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerRegistroPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnRestablecerRegistroPedido.Image")));
            this.btnRestablecerRegistroPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecerRegistroPedido.Location = new System.Drawing.Point(663, 56);
            this.btnRestablecerRegistroPedido.Name = "btnRestablecerRegistroPedido";
            this.btnRestablecerRegistroPedido.Size = new System.Drawing.Size(138, 45);
            this.btnRestablecerRegistroPedido.TabIndex = 21;
            this.btnRestablecerRegistroPedido.Text = "RESTABLECER";
            this.btnRestablecerRegistroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestablecerRegistroPedido.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(789, 246);
            this.dataGridView1.TabIndex = 22;
            // 
            // txtDisponibilidadPlatos
            // 
            this.txtDisponibilidadPlatos.Location = new System.Drawing.Point(105, 72);
            this.txtDisponibilidadPlatos.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisponibilidadPlatos.Name = "txtDisponibilidadPlatos";
            this.txtDisponibilidadPlatos.Size = new System.Drawing.Size(192, 20);
            this.txtDisponibilidadPlatos.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // DisponibilidadPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDisponibilidadPlatos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRestablecerRegistroPedido);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisponibilidadPlatos";
            this.Text = "DisponibilidadPlatos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisponibilidadPlatos_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelModificarPlato;
        private System.Windows.Forms.Button btnDisponibilidadPlatos;
        private System.Windows.Forms.Button btnRestablecerRegistroPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDisponibilidadPlatos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}