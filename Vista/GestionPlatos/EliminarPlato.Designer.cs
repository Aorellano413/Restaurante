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
            this.panelEliminarPlato = new System.Windows.Forms.Panel();
            this.btnCerrarEliminarPlato = new System.Windows.Forms.Button();
            this.labelEliminarPlato = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvEliminarPlato = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
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
            this.panelEliminarPlato.Name = "panelEliminarPlato";
            this.panelEliminarPlato.Size = new System.Drawing.Size(718, 51);
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
            this.btnCerrarEliminarPlato.Location = new System.Drawing.Point(671, 8);
            this.btnCerrarEliminarPlato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarEliminarPlato.Name = "btnCerrarEliminarPlato";
            this.btnCerrarEliminarPlato.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarEliminarPlato.TabIndex = 18;
            this.btnCerrarEliminarPlato.UseVisualStyleBackColor = false;
            this.btnCerrarEliminarPlato.Click += new System.EventHandler(this.btnCerrarEliminarPlato_Click);
            // 
            // labelEliminarPlato
            // 
            this.labelEliminarPlato.AutoSize = true;
            this.labelEliminarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarPlato.Location = new System.Drawing.Point(258, 0);
            this.labelEliminarPlato.Name = "labelEliminarPlato";
            this.labelEliminarPlato.Size = new System.Drawing.Size(207, 43);
            this.labelEliminarPlato.TabIndex = 1;
            this.labelEliminarPlato.Text = "ELIMINAR PLATO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(13, 68);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 68);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(158, 95);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(286, 26);
            this.txtBuscar.TabIndex = 10;
            // 
            // dgvEliminarPlato
            // 
            this.dgvEliminarPlato.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvEliminarPlato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEliminarPlato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEliminarPlato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEliminarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarPlato.Location = new System.Drawing.Point(13, 144);
            this.dgvEliminarPlato.Name = "dgvEliminarPlato";
            this.dgvEliminarPlato.RowHeadersWidth = 62;
            this.dgvEliminarPlato.RowTemplate.Height = 28;
            this.dgvEliminarPlato.Size = new System.Drawing.Size(693, 260);
            this.dgvEliminarPlato.TabIndex = 11;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(239, 429);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(226, 105);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // EliminarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(718, 563);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEliminarPlato);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelEliminarPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvEliminarPlato;
        private System.Windows.Forms.Button btnEliminar;
    }
}