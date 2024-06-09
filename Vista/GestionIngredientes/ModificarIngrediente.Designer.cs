namespace Vista.GestionIngredientes
{
    partial class ModificarIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarIngrediente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelModificarIngrediente = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelModificarIngrediente = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvModificarIngrediente = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.PanelModificarIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarIngrediente)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelModificarIngrediente
            // 
            this.PanelModificarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.PanelModificarIngrediente.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.PanelModificarIngrediente.Controls.Add(this.labelModificarIngrediente);
            this.PanelModificarIngrediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelModificarIngrediente.Location = new System.Drawing.Point(0, 0);
            this.PanelModificarIngrediente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelModificarIngrediente.Name = "PanelModificarIngrediente";
            this.PanelModificarIngrediente.Size = new System.Drawing.Size(479, 33);
            this.PanelModificarIngrediente.TabIndex = 0;
            this.PanelModificarIngrediente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelModificarIngrediente_MouseDown);
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(448, 3);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(23, 23);
            this.btnCerrarRegistrarIngrediente.TabIndex = 16;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelModificarIngrediente
            // 
            this.labelModificarIngrediente.AutoSize = true;
            this.labelModificarIngrediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarIngrediente.Location = new System.Drawing.Point(124, 3);
            this.labelModificarIngrediente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModificarIngrediente.Name = "labelModificarIngrediente";
            this.labelModificarIngrediente.Size = new System.Drawing.Size(202, 29);
            this.labelModificarIngrediente.TabIndex = 0;
            this.labelModificarIngrediente.Text = "MODIFICAR INGREDIENTE";
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
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(105, 56);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // dgvModificarIngrediente
            // 
            this.dgvModificarIngrediente.AllowUserToAddRows = false;
            this.dgvModificarIngrediente.AllowUserToDeleteRows = false;
            this.dgvModificarIngrediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModificarIngrediente.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvModificarIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModificarIngrediente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModificarIngrediente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModificarIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModificarIngrediente.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModificarIngrediente.Location = new System.Drawing.Point(9, 88);
            this.dgvModificarIngrediente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvModificarIngrediente.Name = "dgvModificarIngrediente";
            this.dgvModificarIngrediente.RowHeadersVisible = false;
            this.dgvModificarIngrediente.RowHeadersWidth = 62;
            this.dgvModificarIngrediente.RowTemplate.Height = 28;
            this.dgvModificarIngrediente.Size = new System.Drawing.Size(463, 164);
            this.dgvModificarIngrediente.TabIndex = 9;
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
            this.btnRegistrar.Location = new System.Drawing.Point(150, 266);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 80);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "MODIFICAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // ModificarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(479, 366);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvModificarIngrediente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.PanelModificarIngrediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModificarIngrediente";
            this.Text = "ModificarIngrediente";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarIngrediente_MouseDown);
            this.PanelModificarIngrediente.ResumeLayout(false);
            this.PanelModificarIngrediente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarIngrediente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelModificarIngrediente;
        private System.Windows.Forms.Label labelModificarIngrediente;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvModificarIngrediente;
        private System.Windows.Forms.Button btnRegistrar;
    }
}