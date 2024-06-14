namespace Vista
{
    partial class Informe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informe));
            this.panelInforme = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelInforme = new System.Windows.Forms.Label();
            this.dgvInforme = new System.Windows.Forms.DataGridView();
            this.btnRestablecer = new System.Windows.Forms.Button();
            this.dateTimeInforme = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.panelInforme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInforme
            // 
            this.panelInforme.BackColor = System.Drawing.Color.Khaki;
            this.panelInforme.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.panelInforme.Controls.Add(this.labelInforme);
            this.panelInforme.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInforme.Location = new System.Drawing.Point(0, 0);
            this.panelInforme.Name = "panelInforme";
            this.panelInforme.Size = new System.Drawing.Size(742, 41);
            this.panelInforme.TabIndex = 0;
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(698, 4);
            this.btnCerrarRegistrarIngrediente.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(31, 28);
            this.btnCerrarRegistrarIngrediente.TabIndex = 19;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelInforme
            // 
            this.labelInforme.AutoSize = true;
            this.labelInforme.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforme.Location = new System.Drawing.Point(279, 0);
            this.labelInforme.Name = "labelInforme";
            this.labelInforme.Size = new System.Drawing.Size(101, 36);
            this.labelInforme.TabIndex = 3;
            this.labelInforme.Text = "INFORME";
            // 
            // dgvInforme
            // 
            this.dgvInforme.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme.Location = new System.Drawing.Point(121, 149);
            this.dgvInforme.Name = "dgvInforme";
            this.dgvInforme.RowHeadersWidth = 51;
            this.dgvInforme.RowTemplate.Height = 24;
            this.dgvInforme.Size = new System.Drawing.Size(460, 304);
            this.dgvInforme.TabIndex = 1;
            // 
            // btnRestablecer
            // 
            this.btnRestablecer.FlatAppearance.BorderSize = 0;
            this.btnRestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecer.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecer.Image = ((System.Drawing.Image)(resources.GetObject("btnRestablecer.Image")));
            this.btnRestablecer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecer.Location = new System.Drawing.Point(397, 74);
            this.btnRestablecer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestablecer.Name = "btnRestablecer";
            this.btnRestablecer.Size = new System.Drawing.Size(184, 55);
            this.btnRestablecer.TabIndex = 6;
            this.btnRestablecer.Text = "RESTABLECER";
            this.btnRestablecer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestablecer.UseVisualStyleBackColor = true;
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);
            // 
            // dateTimeInforme
            // 
            this.dateTimeInforme.Location = new System.Drawing.Point(121, 93);
            this.dateTimeInforme.Name = "dateTimeInforme";
            this.dateTimeInforme.Size = new System.Drawing.Size(259, 22);
            this.dateTimeInforme.TabIndex = 17;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerarInforme.FlatAppearance.BorderSize = 0;
            this.btnGenerarInforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarInforme.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarInforme.ForeColor = System.Drawing.Color.Black;
            this.btnGenerarInforme.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerarInforme.Image")));
            this.btnGenerarInforme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarInforme.Location = new System.Drawing.Point(218, 470);
            this.btnGenerarInforme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(275, 62);
            this.btnGenerarInforme.TabIndex = 28;
            this.btnGenerarInforme.Text = "GENERAR INFORME";
            this.btnGenerarInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarInforme.UseVisualStyleBackColor = false;
            this.btnGenerarInforme.Click += new System.EventHandler(this.btnGenerarInforme_Click_1);
            // 
            // Informe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(742, 554);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.dateTimeInforme);
            this.Controls.Add(this.btnRestablecer);
            this.Controls.Add(this.dgvInforme);
            this.Controls.Add(this.panelInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Informe";
            this.Text = "Informe";
            this.panelInforme.ResumeLayout(false);
            this.panelInforme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInforme;
        private System.Windows.Forms.Label labelInforme;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.DataGridView dgvInforme;
        private System.Windows.Forms.Button btnRestablecer;
        private System.Windows.Forms.DateTimePicker dateTimeInforme;
        private System.Windows.Forms.Button btnGenerarInforme;
    }
}