namespace Vista
{
    partial class AsignarValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignarValores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelAsignarValores = new System.Windows.Forms.Panel();
            this.btnCerrarAsignarValores = new System.Windows.Forms.Button();
            this.labelAsignarValores = new System.Windows.Forms.Label();
            this.cmbBuscarPlatoAV = new System.Windows.Forms.ComboBox();
            this.btnBuscarAV = new System.Windows.Forms.Button();
            this.dgvAsignarValores = new System.Windows.Forms.DataGridView();
            this.btnAsignarAV = new System.Windows.Forms.Button();
            this.panelAsignarValores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignarValores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAsignarValores
            // 
            this.panelAsignarValores.BackColor = System.Drawing.Color.Khaki;
            this.panelAsignarValores.Controls.Add(this.btnCerrarAsignarValores);
            this.panelAsignarValores.Controls.Add(this.labelAsignarValores);
            this.panelAsignarValores.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAsignarValores.Location = new System.Drawing.Point(0, 0);
            this.panelAsignarValores.Margin = new System.Windows.Forms.Padding(2);
            this.panelAsignarValores.Name = "panelAsignarValores";
            this.panelAsignarValores.Size = new System.Drawing.Size(798, 33);
            this.panelAsignarValores.TabIndex = 0;
            this.panelAsignarValores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAsignarValores_MouseDown);
            // 
            // btnCerrarAsignarValores
            // 
            this.btnCerrarAsignarValores.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarAsignarValores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAsignarValores.FlatAppearance.BorderSize = 0;
            this.btnCerrarAsignarValores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAsignarValores.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarAsignarValores.Image")));
            this.btnCerrarAsignarValores.Location = new System.Drawing.Point(766, 6);
            this.btnCerrarAsignarValores.Name = "btnCerrarAsignarValores";
            this.btnCerrarAsignarValores.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarAsignarValores.TabIndex = 18;
            this.btnCerrarAsignarValores.UseVisualStyleBackColor = false;
            this.btnCerrarAsignarValores.Click += new System.EventHandler(this.btnCerrarAsignarValores_Click);
            // 
            // labelAsignarValores
            // 
            this.labelAsignarValores.AutoSize = true;
            this.labelAsignarValores.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignarValores.Location = new System.Drawing.Point(329, 0);
            this.labelAsignarValores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAsignarValores.Name = "labelAsignarValores";
            this.labelAsignarValores.Size = new System.Drawing.Size(156, 29);
            this.labelAsignarValores.TabIndex = 2;
            this.labelAsignarValores.Text = "ASIGNAR VALORES";
            // 
            // cmbBuscarPlatoAV
            // 
            this.cmbBuscarPlatoAV.FormattingEnabled = true;
            this.cmbBuscarPlatoAV.Location = new System.Drawing.Point(138, 75);
            this.cmbBuscarPlatoAV.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBuscarPlatoAV.Name = "cmbBuscarPlatoAV";
            this.cmbBuscarPlatoAV.Size = new System.Drawing.Size(225, 21);
            this.cmbBuscarPlatoAV.TabIndex = 1;

            // 
            // btnBuscarAV
            // 
            this.btnBuscarAV.FlatAppearance.BorderSize = 0;
            this.btnBuscarAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAV.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAV.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAV.Image")));
            this.btnBuscarAV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAV.Location = new System.Drawing.Point(8, 59);
            this.btnBuscarAV.Name = "btnBuscarAV";
            this.btnBuscarAV.Size = new System.Drawing.Size(100, 44);
            this.btnBuscarAV.TabIndex = 6;
            this.btnBuscarAV.Text = "BUSCAR";
            this.btnBuscarAV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAV.UseVisualStyleBackColor = true;
            this.btnBuscarAV.Click += new System.EventHandler(this.btnBuscarAV_Click);
            // 
            // dgvAsignarValores
            // 
            this.dgvAsignarValores.AllowUserToAddRows = false;
            this.dgvAsignarValores.AllowUserToDeleteRows = false;
            this.dgvAsignarValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsignarValores.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvAsignarValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsignarValores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAsignarValores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAsignarValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsignarValores.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsignarValores.Location = new System.Drawing.Point(8, 120);
            this.dgvAsignarValores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAsignarValores.Name = "dgvAsignarValores";
            this.dgvAsignarValores.RowHeadersVisible = false;
            this.dgvAsignarValores.RowHeadersWidth = 62;
            this.dgvAsignarValores.RowTemplate.Height = 28;
            this.dgvAsignarValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsignarValores.Size = new System.Drawing.Size(781, 162);
            this.dgvAsignarValores.TabIndex = 7;
            // 
            // btnAsignarAV
            // 
            this.btnAsignarAV.BackColor = System.Drawing.Color.Transparent;
            this.btnAsignarAV.FlatAppearance.BorderSize = 0;
            this.btnAsignarAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarAV.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarAV.ForeColor = System.Drawing.Color.Black;
            this.btnAsignarAV.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarAV.Image")));
            this.btnAsignarAV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarAV.Location = new System.Drawing.Point(318, 332);
            this.btnAsignarAV.Margin = new System.Windows.Forms.Padding(2);
            this.btnAsignarAV.Name = "btnAsignarAV";
            this.btnAsignarAV.Size = new System.Drawing.Size(167, 86);
            this.btnAsignarAV.TabIndex = 12;
            this.btnAsignarAV.Text = "ASIGNAR";
            this.btnAsignarAV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarAV.UseVisualStyleBackColor = false;
            this.btnAsignarAV.Click += new System.EventHandler(this.btnAsignarAV_Click);
            // 
            // AsignarValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(798, 425);
            this.Controls.Add(this.btnAsignarAV);
            this.Controls.Add(this.dgvAsignarValores);
            this.Controls.Add(this.btnBuscarAV);
            this.Controls.Add(this.cmbBuscarPlatoAV);
            this.Controls.Add(this.panelAsignarValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AsignarValores";
            this.Text = "AsignarValores";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AsignarValores_MouseDown);
            this.panelAsignarValores.ResumeLayout(false);
            this.panelAsignarValores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsignarValores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAsignarValores;
        private System.Windows.Forms.Label labelAsignarValores;
        private System.Windows.Forms.Button btnCerrarAsignarValores;
        private System.Windows.Forms.ComboBox cmbBuscarPlatoAV;
        private System.Windows.Forms.Button btnBuscarAV;
        private System.Windows.Forms.DataGridView dgvAsignarValores;
        private System.Windows.Forms.Button btnAsignarAV;
    }
}