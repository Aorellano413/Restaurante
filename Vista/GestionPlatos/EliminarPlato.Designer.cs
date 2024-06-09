namespace Vista.GestionPlatos
{
    partial class EliminarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarPlato));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEliminarPlato = new System.Windows.Forms.Panel();
            this.btnCerrarEliminarPlato = new System.Windows.Forms.Button();
            this.labelEliminarPlato = new System.Windows.Forms.Label();
            this.btnBuscarEP = new System.Windows.Forms.Button();
            this.txtBuscarEP = new System.Windows.Forms.TextBox();
            this.dgvEliminarPlato = new System.Windows.Forms.DataGridView();
            this.btnEliminarEP = new System.Windows.Forms.Button();
            this.panelEliminarPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEliminarPlato
            // 
            this.panelEliminarPlato.BackColor = System.Drawing.Color.Khaki;
            this.panelEliminarPlato.Controls.Add(this.btnCerrarEliminarPlato);
            this.panelEliminarPlato.Controls.Add(this.labelEliminarPlato);
            this.panelEliminarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEliminarPlato.Location = new System.Drawing.Point(0, 0);
            this.panelEliminarPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEliminarPlato.Name = "panelEliminarPlato";
            this.panelEliminarPlato.Size = new System.Drawing.Size(536, 33);
            this.panelEliminarPlato.TabIndex = 0;
            this.panelEliminarPlato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelEliminarPlato_MouseDown);
            // 
            // btnCerrarEliminarPlato
            // 
            this.btnCerrarEliminarPlato.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarEliminarPlato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarEliminarPlato.FlatAppearance.BorderSize = 0;
            this.btnCerrarEliminarPlato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarEliminarPlato.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarEliminarPlato.Image")));
            this.btnCerrarEliminarPlato.Location = new System.Drawing.Point(505, 5);
            this.btnCerrarEliminarPlato.Name = "btnCerrarEliminarPlato";
            this.btnCerrarEliminarPlato.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarEliminarPlato.TabIndex = 18;
            this.btnCerrarEliminarPlato.UseVisualStyleBackColor = false;
            this.btnCerrarEliminarPlato.Click += new System.EventHandler(this.btnCerrarEliminarPlato_Click);
            // 
            // labelEliminarPlato
            // 
            this.labelEliminarPlato.AutoSize = true;
            this.labelEliminarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarPlato.Location = new System.Drawing.Point(190, 0);
            this.labelEliminarPlato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEliminarPlato.Name = "labelEliminarPlato";
            this.labelEliminarPlato.Size = new System.Drawing.Size(141, 29);
            this.labelEliminarPlato.TabIndex = 1;
            this.labelEliminarPlato.Text = "ELIMINAR PLATO";
            // 
            // btnBuscarEP
            // 
            this.btnBuscarEP.FlatAppearance.BorderSize = 0;
            this.btnBuscarEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEP.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEP.Image")));
            this.btnBuscarEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarEP.Location = new System.Drawing.Point(9, 44);
            this.btnBuscarEP.Name = "btnBuscarEP";
            this.btnBuscarEP.Size = new System.Drawing.Size(92, 44);
            this.btnBuscarEP.TabIndex = 6;
            this.btnBuscarEP.Text = "BUSCAR";
            this.btnBuscarEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarEP.UseVisualStyleBackColor = true;
            this.btnBuscarEP.Click += new System.EventHandler(this.btnBuscarEP_Click);
            // 
            // txtBuscarEP
            // 
            this.txtBuscarEP.Location = new System.Drawing.Point(105, 62);
            this.txtBuscarEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarEP.Name = "txtBuscarEP";
            this.txtBuscarEP.Size = new System.Drawing.Size(192, 20);
            this.txtBuscarEP.TabIndex = 10;
            // 
            // dgvEliminarPlato
            // 
            this.dgvEliminarPlato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEliminarPlato.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvEliminarPlato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEliminarPlato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEliminarPlato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEliminarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEliminarPlato.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEliminarPlato.Location = new System.Drawing.Point(9, 94);
            this.dgvEliminarPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEliminarPlato.Name = "dgvEliminarPlato";
            this.dgvEliminarPlato.ReadOnly = true;
            this.dgvEliminarPlato.RowHeadersVisible = false;
            this.dgvEliminarPlato.RowHeadersWidth = 62;
            this.dgvEliminarPlato.RowTemplate.Height = 28;
            this.dgvEliminarPlato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminarPlato.Size = new System.Drawing.Size(519, 169);
            this.dgvEliminarPlato.TabIndex = 11;
            // 
            // btnEliminarEP
            // 
            this.btnEliminarEP.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarEP.FlatAppearance.BorderSize = 0;
            this.btnEliminarEP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEP.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEP.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarEP.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEP.Image")));
            this.btnEliminarEP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEP.Location = new System.Drawing.Point(177, 282);
            this.btnEliminarEP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarEP.Name = "btnEliminarEP";
            this.btnEliminarEP.Size = new System.Drawing.Size(151, 68);
            this.btnEliminarEP.TabIndex = 12;
            this.btnEliminarEP.Text = "ELIMINAR";
            this.btnEliminarEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEP.UseVisualStyleBackColor = false;
            this.btnEliminarEP.Click += new System.EventHandler(this.btnEliminarEP_Click);
            // 
            // EliminarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(536, 374);
            this.Controls.Add(this.btnEliminarEP);
            this.Controls.Add(this.dgvEliminarPlato);
            this.Controls.Add(this.txtBuscarEP);
            this.Controls.Add(this.btnBuscarEP);
            this.Controls.Add(this.panelEliminarPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EliminarPlato";
            this.Text = "EliminarPlato";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EliminarPlato_MouseDown);
            this.panelEliminarPlato.ResumeLayout(false);
            this.panelEliminarPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEliminarPlato;
        private System.Windows.Forms.Label labelEliminarPlato;
        private System.Windows.Forms.Button btnCerrarEliminarPlato;
        private System.Windows.Forms.Button btnBuscarEP;
        private System.Windows.Forms.TextBox txtBuscarEP;
        private System.Windows.Forms.DataGridView dgvEliminarPlato;
        private System.Windows.Forms.Button btnEliminarEP;
    }
}