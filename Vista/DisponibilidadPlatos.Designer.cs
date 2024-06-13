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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDisponibilidadPlatos = new System.Windows.Forms.Button();
            this.labelDisponibilidadPlatos = new System.Windows.Forms.Label();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.dgvDisponibilidadPlatos = new System.Windows.Forms.DataGridView();
            this.txtDisponibilidadPlatos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidadPlatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.btnDisponibilidadPlatos);
            this.panel1.Controls.Add(this.labelDisponibilidadPlatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 38);
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
            this.btnDisponibilidadPlatos.Location = new System.Drawing.Point(820, 4);
            this.btnDisponibilidadPlatos.Name = "btnDisponibilidadPlatos";
            this.btnDisponibilidadPlatos.Size = new System.Drawing.Size(23, 23);
            this.btnDisponibilidadPlatos.TabIndex = 20;
            this.btnDisponibilidadPlatos.UseVisualStyleBackColor = false;
            this.btnDisponibilidadPlatos.Click += new System.EventHandler(this.btnDisponibilidadPlatos_Click);
            // 
            // labelDisponibilidadPlatos
            // 
            this.labelDisponibilidadPlatos.AutoSize = true;
            this.labelDisponibilidadPlatos.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponibilidadPlatos.Location = new System.Drawing.Point(325, 4);
            this.labelDisponibilidadPlatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDisponibilidadPlatos.Name = "labelDisponibilidadPlatos";
            this.labelDisponibilidadPlatos.Size = new System.Drawing.Size(198, 29);
            this.labelDisponibilidadPlatos.TabIndex = 3;
            this.labelDisponibilidadPlatos.Text = "DISPONIBILIDAD PLATOS";
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("btnRestablecer.Image")));
            this.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecer.Location = new System.Drawing.Point(663, 56);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(138, 45);
            this.btnRestablecer.TabIndex = 21;
            this.btnRestablecer.Text = "RESTABLECER";
            this.btnRestablecer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // dgvDisponibilidadPlatos
            // 
            this.dgvDisponibilidadPlatos.AllowUserToAddRows = false;
            this.dgvDisponibilidadPlatos.AllowUserToDeleteRows = false;
            this.dgvDisponibilidadPlatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisponibilidadPlatos.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvDisponibilidadPlatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisponibilidadPlatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDisponibilidadPlatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDisponibilidadPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisponibilidadPlatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisponibilidadPlatos.Location = new System.Drawing.Point(12, 113);
            this.dgvDisponibilidadPlatos.Name = "dgvDisponibilidadPlatos";
            this.dgvDisponibilidadPlatos.ReadOnly = true;
            this.dgvDisponibilidadPlatos.RowHeadersVisible = false;
            this.dgvDisponibilidadPlatos.RowHeadersWidth = 51;
            this.dgvDisponibilidadPlatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisponibilidadPlatos.Size = new System.Drawing.Size(806, 246);
            this.dgvDisponibilidadPlatos.TabIndex = 22;
            // 
            // txtDisponibilidadPlatos
            // 
            this.txtDisponibilidadPlatos.Location = new System.Drawing.Point(105, 72);
            this.txtDisponibilidadPlatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDisponibilidadPlatos.Name = "txtDisponibilidadPlatos";
            this.txtDisponibilidadPlatos.Size = new System.Drawing.Size(233, 20);
            this.txtDisponibilidadPlatos.TabIndex = 23;
            this.txtDisponibilidadPlatos.TextChanged += new System.EventHandler(this.txtDisponibilidadPlatos_TextChanged);
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
            this.ClientSize = new System.Drawing.Size(855, 546);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDisponibilidadPlatos);
            this.Controls.Add(this.dgvDisponibilidadPlatos);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisponibilidadPlatos";
            this.Text = "DisponibilidadPlatos";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DisponibilidadPlatos_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponibilidadPlatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDisponibilidadPlatos;
        private System.Windows.Forms.Button btnDisponibilidadPlatos;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.DataGridView dgvDisponibilidadPlatos;
        private System.Windows.Forms.TextBox txtDisponibilidadPlatos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}