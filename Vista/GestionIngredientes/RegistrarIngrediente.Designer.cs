namespace Vista.GestionIngredientes
{
    partial class RegistrarIngrediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarIngrediente));
            this.panelRegistrarIngrediente = new System.Windows.Forms.Panel();
            this.labelRegistrarIngrediente = new System.Windows.Forms.Label();
            this.btnCerrarRegistrarIngrediente = new System.Windows.Forms.Button();
            this.labelNombreRI = new System.Windows.Forms.Label();
            this.labelStockRI = new System.Windows.Forms.Label();
            this.txtNombreRI = new System.Windows.Forms.TextBox();
            this.txtStockRI = new System.Windows.Forms.TextBox();
            this.btnRegistrarIngrediente = new System.Windows.Forms.Button();
            this.panelRegistrarIngrediente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRegistrarIngrediente
            // 
            this.panelRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.panelRegistrarIngrediente.Controls.Add(this.labelRegistrarIngrediente);
            this.panelRegistrarIngrediente.Controls.Add(this.btnCerrarRegistrarIngrediente);
            this.panelRegistrarIngrediente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistrarIngrediente.Location = new System.Drawing.Point(0, 0);
            this.panelRegistrarIngrediente.Name = "panelRegistrarIngrediente";
            this.panelRegistrarIngrediente.Size = new System.Drawing.Size(570, 51);
            this.panelRegistrarIngrediente.TabIndex = 0;
            this.panelRegistrarIngrediente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistrarIngrediente_MouseDown);
            // 
            // labelRegistrarIngrediente
            // 
            this.labelRegistrarIngrediente.AutoSize = true;
            this.labelRegistrarIngrediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarIngrediente.Location = new System.Drawing.Point(110, 0);
            this.labelRegistrarIngrediente.Name = "labelRegistrarIngrediente";
            this.labelRegistrarIngrediente.Size = new System.Drawing.Size(305, 43);
            this.labelRegistrarIngrediente.TabIndex = 16;
            this.labelRegistrarIngrediente.Text = "REGISTRAR INGREDIENTE";
            // 
            // btnCerrarRegistrarIngrediente
            // 
            this.btnCerrarRegistrarIngrediente.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarRegistrarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnCerrarRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarRegistrarIngrediente.Image")));
            this.btnCerrarRegistrarIngrediente.Location = new System.Drawing.Point(518, 5);
            this.btnCerrarRegistrarIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarRegistrarIngrediente.Name = "btnCerrarRegistrarIngrediente";
            this.btnCerrarRegistrarIngrediente.Size = new System.Drawing.Size(34, 35);
            this.btnCerrarRegistrarIngrediente.TabIndex = 15;
            this.btnCerrarRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnCerrarRegistrarIngrediente.Click += new System.EventHandler(this.btnCerrarRegistrarIngrediente_Click);
            // 
            // labelNombreRI
            // 
            this.labelNombreRI.AutoSize = true;
            this.labelNombreRI.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreRI.Location = new System.Drawing.Point(60, 97);
            this.labelNombreRI.Name = "labelNombreRI";
            this.labelNombreRI.Size = new System.Drawing.Size(103, 34);
            this.labelNombreRI.TabIndex = 1;
            this.labelNombreRI.Text = "NOMBRE :";
            // 
            // labelStockRI
            // 
            this.labelStockRI.AutoSize = true;
            this.labelStockRI.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockRI.Location = new System.Drawing.Point(60, 157);
            this.labelStockRI.Name = "labelStockRI";
            this.labelStockRI.Size = new System.Drawing.Size(102, 34);
            this.labelStockRI.TabIndex = 2;
            this.labelStockRI.Text = "STOCK    :";
            // 
            // txtNombreRI
            // 
            this.txtNombreRI.Location = new System.Drawing.Point(170, 106);
            this.txtNombreRI.Name = "txtNombreRI";
            this.txtNombreRI.Size = new System.Drawing.Size(210, 26);
            this.txtNombreRI.TabIndex = 3;
            // 
            // txtStockRI
            // 
            this.txtStockRI.Location = new System.Drawing.Point(170, 166);
            this.txtStockRI.Name = "txtStockRI";
            this.txtStockRI.Size = new System.Drawing.Size(210, 26);
            this.txtStockRI.TabIndex = 4;
            // 
            // btnRegistrarIngrediente
            // 
            this.btnRegistrarIngrediente.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarIngrediente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarIngrediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarIngrediente.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarIngrediente.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarIngrediente.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarIngrediente.Image")));
            this.btnRegistrarIngrediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarIngrediente.Location = new System.Drawing.Point(138, 226);
            this.btnRegistrarIngrediente.Name = "btnRegistrarIngrediente";
            this.btnRegistrarIngrediente.Size = new System.Drawing.Size(243, 132);
            this.btnRegistrarIngrediente.TabIndex = 5;
            this.btnRegistrarIngrediente.Text = "REGISTRAR";
            this.btnRegistrarIngrediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarIngrediente.UseVisualStyleBackColor = false;
            this.btnRegistrarIngrediente.Click += new System.EventHandler(this.btnRegistrarIngrediente_Click);
            // 
            // RegistrarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(570, 414);
            this.Controls.Add(this.btnRegistrarIngrediente);
            this.Controls.Add(this.txtStockRI);
            this.Controls.Add(this.txtNombreRI);
            this.Controls.Add(this.labelStockRI);
            this.Controls.Add(this.labelNombreRI);
            this.Controls.Add(this.panelRegistrarIngrediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarIngrediente";
            this.Text = "RegistrarIngrediente";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrarIngrediente_MouseDown);
            this.panelRegistrarIngrediente.ResumeLayout(false);
            this.panelRegistrarIngrediente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistrarIngrediente;
        private System.Windows.Forms.Button btnCerrarRegistrarIngrediente;
        private System.Windows.Forms.Label labelRegistrarIngrediente;
        private System.Windows.Forms.Label labelNombreRI;
        private System.Windows.Forms.Label labelStockRI;
        private System.Windows.Forms.TextBox txtNombreRI;
        private System.Windows.Forms.TextBox txtStockRI;
        private System.Windows.Forms.Button btnRegistrarIngrediente;
    }
}