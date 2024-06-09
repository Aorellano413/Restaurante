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
            this.panelAsignarValores.Name = "panelAsignarValores";
            this.panelAsignarValores.Size = new System.Drawing.Size(1197, 51);
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
            this.btnCerrarAsignarValores.Location = new System.Drawing.Point(1150, 8);
            this.btnCerrarAsignarValores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarAsignarValores.Name = "btnCerrarAsignarValores";
            this.btnCerrarAsignarValores.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarAsignarValores.TabIndex = 18;
            this.btnCerrarAsignarValores.UseVisualStyleBackColor = false;
            this.btnCerrarAsignarValores.Click += new System.EventHandler(this.btnCerrarAsignarValores_Click);
            // 
            // labelAsignarValores
            // 
            this.labelAsignarValores.AutoSize = true;
            this.labelAsignarValores.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAsignarValores.Location = new System.Drawing.Point(494, 0);
            this.labelAsignarValores.Name = "labelAsignarValores";
            this.labelAsignarValores.Size = new System.Drawing.Size(230, 43);
            this.labelAsignarValores.TabIndex = 2;
            this.labelAsignarValores.Text = "ASIGNAR VALORES";
            // 
            // cmbBuscarPlatoAV
            // 
            this.cmbBuscarPlatoAV.FormattingEnabled = true;
            this.cmbBuscarPlatoAV.Location = new System.Drawing.Point(259, 91);
            this.cmbBuscarPlatoAV.Name = "cmbBuscarPlatoAV";
            this.cmbBuscarPlatoAV.Size = new System.Drawing.Size(336, 28);
            this.cmbBuscarPlatoAV.TabIndex = 1;
            // 
            // btnBuscarAV
            // 
            this.btnBuscarAV.FlatAppearance.BorderSize = 0;
            this.btnBuscarAV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAV.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAV.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarAV.Image")));
            this.btnBuscarAV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarAV.Location = new System.Drawing.Point(116, 64);
            this.btnBuscarAV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarAV.Name = "btnBuscarAV";
            this.btnBuscarAV.Size = new System.Drawing.Size(136, 68);
            this.btnBuscarAV.TabIndex = 6;
            this.btnBuscarAV.Text = "BUSCAR";
            this.btnBuscarAV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarAV.UseVisualStyleBackColor = true;
            this.btnBuscarAV.Click += new System.EventHandler(this.btnBuscarAV_Click);
            // 
            // dgvAsignarValores
            // 
            this.dgvAsignarValores.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvAsignarValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsignarValores.Location = new System.Drawing.Point(12, 230);
            this.dgvAsignarValores.Name = "dgvAsignarValores";
            this.dgvAsignarValores.RowHeadersWidth = 62;
            this.dgvAsignarValores.RowTemplate.Height = 28;
            this.dgvAsignarValores.Size = new System.Drawing.Size(1172, 425);
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
            this.btnAsignarAV.Location = new System.Drawing.Point(474, 661);
            this.btnAsignarAV.Name = "btnAsignarAV";
            this.btnAsignarAV.Size = new System.Drawing.Size(250, 132);
            this.btnAsignarAV.TabIndex = 12;
            this.btnAsignarAV.Text = "ASIGNAR";
            this.btnAsignarAV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarAV.UseVisualStyleBackColor = false;
            this.btnAsignarAV.Click += new System.EventHandler(this.btnAsignarAV_Click);
            // 
            // AsignarValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1197, 817);
            this.Controls.Add(this.btnAsignarAV);
            this.Controls.Add(this.dgvAsignarValores);
            this.Controls.Add(this.btnBuscarAV);
            this.Controls.Add(this.cmbBuscarPlatoAV);
            this.Controls.Add(this.panelAsignarValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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