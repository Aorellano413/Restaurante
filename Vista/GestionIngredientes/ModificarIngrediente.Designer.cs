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
            this.PanelModificarIngrediente = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.PanelModificarIngrediente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelModificarIngrediente
            // 
            this.PanelModificarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.PanelModificarIngrediente.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.PanelModificarIngrediente.Controls.Add(this.label1);
            this.PanelModificarIngrediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelModificarIngrediente.Location = new System.Drawing.Point(0, 0);
            this.PanelModificarIngrediente.Margin = new System.Windows.Forms.Padding(2);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODIFICAR INGREDIENTE";
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
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(105, 56);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(192, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(463, 164);
            this.dataGridView1.TabIndex = 9;
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
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(162, 80);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "MODIFICAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // ModificarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(479, 366);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.PanelModificarIngrediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarIngrediente";
            this.Text = "ModificarIngrediente";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModificarIngrediente_MouseDown);
            this.PanelModificarIngrediente.ResumeLayout(false);
            this.PanelModificarIngrediente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelModificarIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}