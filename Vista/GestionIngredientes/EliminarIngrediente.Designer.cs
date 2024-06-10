namespace Vista.GestionIngredientes
{
    partial class EliminarIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarIngrediente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelEliminarIngrediente = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelEliminarIngrediente = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvEliminarIngrediente = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelEliminarIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEliminarIngrediente
            // 
            this.PanelEliminarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.PanelEliminarIngrediente.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.PanelEliminarIngrediente.Controls.Add(this.labelEliminarIngrediente);
            this.PanelEliminarIngrediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelEliminarIngrediente.Location = new System.Drawing.Point(0, 0);
            this.PanelEliminarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.PanelEliminarIngrediente.Name = "PanelEliminarIngrediente";
            this.PanelEliminarIngrediente.Size = new System.Drawing.Size(479, 33);
            this.PanelEliminarIngrediente.TabIndex = 0;
            this.PanelEliminarIngrediente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelEliminarIngrediente_MouseDown);
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
            this.btnCerrarRegistrarIngrediente.TabIndex = 17;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelEliminarIngrediente
            // 
            this.labelEliminarIngrediente.AutoSize = true;
            this.labelEliminarIngrediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEliminarIngrediente.Location = new System.Drawing.Point(122, 0);
            this.labelEliminarIngrediente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEliminarIngrediente.Name = "labelEliminarIngrediente";
            this.labelEliminarIngrediente.Size = new System.Drawing.Size(192, 29);
            this.labelEliminarIngrediente.TabIndex = 0;
            this.labelEliminarIngrediente.Text = "ELIMINAR INGREDIENTE";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(64, 63);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvEliminarIngrediente
            // 
            this.dgvEliminarIngrediente.AllowUserToAddRows = false;
            this.dgvEliminarIngrediente.AllowUserToDeleteRows = false;
            this.dgvEliminarIngrediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEliminarIngrediente.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvEliminarIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEliminarIngrediente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEliminarIngrediente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEliminarIngrediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEliminarIngrediente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEliminarIngrediente.Location = new System.Drawing.Point(9, 88);
            this.dgvEliminarIngrediente.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEliminarIngrediente.Name = "dgvEliminarIngrediente";
            this.dgvEliminarIngrediente.ReadOnly = true;
            this.dgvEliminarIngrediente.RowHeadersVisible = false;
            this.dgvEliminarIngrediente.RowHeadersWidth = 62;
            this.dgvEliminarIngrediente.RowTemplate.Height = 28;
            this.dgvEliminarIngrediente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEliminarIngrediente.Size = new System.Drawing.Size(462, 169);
            this.dgvEliminarIngrediente.TabIndex = 10;
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
            this.btnEliminar.Location = new System.Drawing.Point(163, 271);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(151, 68);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // EliminarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(479, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvEliminarIngrediente);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.PanelEliminarIngrediente);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EliminarIngrediente";
            this.Text = "EliminarIngrediente";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EliminarIngrediente_MouseDown);
            this.PanelEliminarIngrediente.ResumeLayout(false);
            this.PanelEliminarIngrediente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelEliminarIngrediente;
        private System.Windows.Forms.Label labelEliminarIngrediente;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvEliminarIngrediente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}