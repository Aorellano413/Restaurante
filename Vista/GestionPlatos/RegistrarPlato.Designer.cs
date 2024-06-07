namespace Vista.GestionPlatos
{
    partial class RegistrarPlato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarPlato));
            this.panelRegistrarPlato = new System.Windows.Forms.Panel();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelRegistrarPlato = new System.Windows.Forms.Label();
            this.labelNombreRP = new System.Windows.Forms.Label();
            this.labelStockRP = new System.Windows.Forms.Label();
            this.txtNombreRP = new System.Windows.Forms.TextBox();
            this.txtStockRP = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelRegistrarPlato.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistrarPlato
            // 
            this.panelRegistrarPlato.BackColor = System.Drawing.Color.Khaki;
            this.panelRegistrarPlato.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.panelRegistrarPlato.Controls.Add(this.labelRegistrarPlato);
            this.panelRegistrarPlato.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistrarPlato.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrarPlato.Name = "panelRegistrarPlato";
            this.panelRegistrarPlato.Size = new System.Drawing.Size(570, 51);
            this.panelRegistrarPlato.TabIndex = 0;
            this.panelRegistrarPlato.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistrarPlato_MouseDown);
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(523, 8);
            this.btnCerrarRegistrarIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarRegistrarIngrediente.TabIndex = 18;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelRegistrarPlato
            // 
            this.labelRegistrarPlato.AutoSize = true;
            this.labelRegistrarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarPlato.Location = new System.Drawing.Point(142, 0);
            this.labelRegistrarPlato.Name = "labelRegistrarPlato";
            this.labelRegistrarPlato.Size = new System.Drawing.Size(227, 43);
            this.labelRegistrarPlato.TabIndex = 17;
            this.labelRegistrarPlato.Text = "REGISTRAR PLATO";
            // 
            // labelNombreRP
            // 
            this.labelNombreRP.AutoSize = true;
            this.labelNombreRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreRP.Location = new System.Drawing.Point(63, 82);
            this.labelNombreRP.Name = "labelNombreRP";
            this.labelNombreRP.Size = new System.Drawing.Size(103, 34);
            this.labelNombreRP.TabIndex = 2;
            this.labelNombreRP.Text = "NOMBRE :";
            // 
            // labelStockRP
            // 
            this.labelStockRP.AutoSize = true;
            this.labelStockRP.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockRP.Location = new System.Drawing.Point(63, 145);
            this.labelStockRP.Name = "labelStockRP";
            this.labelStockRP.Size = new System.Drawing.Size(102, 34);
            this.labelStockRP.TabIndex = 3;
            this.labelStockRP.Text = "STOCK    :";
            // 
            // txtNombreRP
            // 
            this.txtNombreRP.Location = new System.Drawing.Point(172, 90);
            this.txtNombreRP.Name = "txtNombreRP";
            this.txtNombreRP.Size = new System.Drawing.Size(210, 26);
            this.txtNombreRP.TabIndex = 4;
            // 
            // txtStockRP
            // 
            this.txtStockRP.Location = new System.Drawing.Point(171, 153);
            this.txtStockRP.Name = "txtStockRP";
            this.txtStockRP.Size = new System.Drawing.Size(210, 26);
            this.txtStockRP.TabIndex = 5;
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
            this.btnRegistrar.Location = new System.Drawing.Point(138, 226);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(243, 132);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // RegistrarPlato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(570, 414);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtStockRP);
            this.Controls.Add(this.txtNombreRP);
            this.Controls.Add(this.labelStockRP);
            this.Controls.Add(this.labelNombreRP);
            this.Controls.Add(this.panelRegistrarPlato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarPlato";
            this.Text = "RegistrarPlato";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrarPlato_MouseDown);
            this.panelRegistrarPlato.ResumeLayout(false);
            this.panelRegistrarPlato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistrarPlato;
        private System.Windows.Forms.Label labelRegistrarPlato;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.Label labelNombreRP;
        private System.Windows.Forms.Label labelStockRP;
        private System.Windows.Forms.TextBox txtNombreRP;
        private System.Windows.Forms.TextBox txtStockRP;
        private System.Windows.Forms.Button btnRegistrar;
    }
}