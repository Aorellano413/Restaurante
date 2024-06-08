namespace Vista.GestionPlatos
{
    partial class ModificarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPlato));
            this.panelModificarPlato = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelModificarPlato = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvModificarPlato = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelModificarPlato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarPlato)).BeginInit();
            this.SuspendLayout();
            // 
            // panelModificarPlato
            // 
            this.panelModificarPlato.BackColor = System.Drawing.Color.Khaki;
            this.panelModificarPlato.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.panelModificarPlato.Controls.Add(this.labelModificarPlato);
            this.panelModificarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModificarPlato.Location = new System.Drawing.Point(0, 0);
            this.panelModificarPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelModificarPlato.Name = "panelModificarPlato";
            this.panelModificarPlato.Size = new System.Drawing.Size(479, 33);
            this.panelModificarPlato.TabIndex = 0;
            this.panelModificarPlato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelModificarPlato_MouseDown);
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(453, 3);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarRegistrarIngrediente.TabIndex = 17;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelModificarPlato
            // 
            this.labelModificarPlato.AutoSize = true;
            this.labelModificarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarPlato.Location = new System.Drawing.Point(162, 0);
            this.labelModificarPlato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModificarPlato.Name = "labelModificarPlato";
            this.labelModificarPlato.Size = new System.Drawing.Size(151, 29);
            this.labelModificarPlato.TabIndex = 1;
            this.labelModificarPlato.Text = "MODIFICAR PLATO";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(9, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 44);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(104, 56);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // dgvModificarPlato
            // 
            this.dgvModificarPlato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModificarPlato.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvModificarPlato.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModificarPlato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModificarPlato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModificarPlato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarPlato.Location = new System.Drawing.Point(8, 88);
            this.dgvModificarPlato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvModificarPlato.Name = "dgvModificarPlato";
            this.dgvModificarPlato.RowHeadersWidth = 62;
            this.dgvModificarPlato.RowTemplate.Height = 28;
            this.dgvModificarPlato.Size = new System.Drawing.Size(463, 164);
            this.dgvModificarPlato.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(133, 263);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 80);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "MODIFICAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // ModificarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(479, 366);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvModificarPlato);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.panelModificarPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarPlato";
            this.Text = "ModificarPlato";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarPlato_MouseDown);
            this.panelModificarPlato.ResumeLayout(false);
            this.panelModificarPlato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarPlato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelModificarPlato;
        private System.Windows.Forms.Label labelModificarPlato;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvModificarPlato;
        private System.Windows.Forms.Button btnRegistrar;
    }
}