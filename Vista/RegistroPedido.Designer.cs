namespace Vista
{
    partial class RegistroPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroPedido));
            this.panelRegistroPedido = new System.Windows.Forms.Panel();
            this.labelModificarPlato = new System.Windows.Forms.Label();
            this.dgvRegistroPedido = new System.Windows.Forms.DataGridView();
            this.dataTimeRegistroPedido = new System.Windows.Forms.DateTimePicker();
            this.btnRestablecerRegistroPedido = new System.Windows.Forms.Button();
            this.panelRegistroPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistroPedido
            // 
            this.panelRegistroPedido.BackColor = System.Drawing.Color.Khaki;
            this.panelRegistroPedido.Controls.Add(this.labelModificarPlato);
            this.panelRegistroPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistroPedido.Location = new System.Drawing.Point(0, 0);
            this.panelRegistroPedido.Name = "panelRegistroPedido";
            this.panelRegistroPedido.Size = new System.Drawing.Size(1245, 51);
            this.panelRegistroPedido.TabIndex = 0;
            // 
            // labelModificarPlato
            // 
            this.labelModificarPlato.AutoSize = true;
            this.labelModificarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarPlato.Location = new System.Drawing.Point(511, 4);
            this.labelModificarPlato.Name = "labelModificarPlato";
            this.labelModificarPlato.Size = new System.Drawing.Size(275, 43);
            this.labelModificarPlato.TabIndex = 2;
            this.labelModificarPlato.Text = "REGISTRO DE PEDIDOS";
            // 
            // dgvRegistroPedido
            // 
            this.dgvRegistroPedido.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvRegistroPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroPedido.GridColor = System.Drawing.Color.DarkGray;
            this.dgvRegistroPedido.Location = new System.Drawing.Point(12, 156);
            this.dgvRegistroPedido.Name = "dgvRegistroPedido";
            this.dgvRegistroPedido.RowHeadersWidth = 62;
            this.dgvRegistroPedido.RowTemplate.Height = 28;
            this.dgvRegistroPedido.Size = new System.Drawing.Size(1221, 357);
            this.dgvRegistroPedido.TabIndex = 1;
            // 
            // dataTimeRegistroPedido
            // 
            this.dataTimeRegistroPedido.Location = new System.Drawing.Point(12, 103);
            this.dataTimeRegistroPedido.Name = "dataTimeRegistroPedido";
            this.dataTimeRegistroPedido.Size = new System.Drawing.Size(322, 26);
            this.dataTimeRegistroPedido.TabIndex = 2;
            this.dataTimeRegistroPedido.ValueChanged += new System.EventHandler(this.dataTimeRegistroPedido_ValueChanged_1);
            // 
            // btnRestablecerRegistroPedido
            // 
            this.btnRestablecerRegistroPedido.FlatAppearance.BorderSize = 0;
            this.btnRestablecerRegistroPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecerRegistroPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerRegistroPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnRestablecerRegistroPedido.Image")));
            this.btnRestablecerRegistroPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecerRegistroPedido.Location = new System.Drawing.Point(1025, 78);
            this.btnRestablecerRegistroPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestablecerRegistroPedido.Name = "btnRestablecerRegistroPedido";
            this.btnRestablecerRegistroPedido.Size = new System.Drawing.Size(207, 69);
            this.btnRestablecerRegistroPedido.TabIndex = 5;
            this.btnRestablecerRegistroPedido.Text = "RESTABLECER";
            this.btnRestablecerRegistroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestablecerRegistroPedido.UseVisualStyleBackColor = true;
            this.btnRestablecerRegistroPedido.Click += new System.EventHandler(this.btnRestablecerRegistroPedido_Click_1);
            // 
            // RegistroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1245, 892);
            this.Controls.Add(this.btnRestablecerRegistroPedido);
            this.Controls.Add(this.dataTimeRegistroPedido);
            this.Controls.Add(this.dgvRegistroPedido);
            this.Controls.Add(this.panelRegistroPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroPedido";
            this.Text = "RegistroPedido";
            this.panelRegistroPedido.ResumeLayout(false);
            this.panelRegistroPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistroPedido;
        private System.Windows.Forms.Label labelModificarPlato;
        private System.Windows.Forms.DataGridView dgvRegistroPedido;
        private System.Windows.Forms.DateTimePicker dataTimeRegistroPedido;
        private System.Windows.Forms.Button btnRestablecerRegistroPedido;
    }
}