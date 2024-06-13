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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelRegistroPedido = new System.Windows.Forms.Panel();
            this.btnCerrarPedidos = new System.Windows.Forms.Button();
            this.labelModificarPlato = new System.Windows.Forms.Label();
            this.dgvRegistroPedido = new System.Windows.Forms.DataGridView();
            this.dataTimeRegistroPedido = new System.Windows.Forms.DateTimePicker();
            this.btnRestablecerRegistroPedido = new System.Windows.Forms.Button();
            this.dataTimeRegistroPedido2 = new System.Windows.Forms.DateTimePicker();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelRegistroPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRegistroPedido
            // 
            this.panelRegistroPedido.BackColor = System.Drawing.Color.Khaki;
            this.panelRegistroPedido.Controls.Add(this.btnCerrarPedidos);
            this.panelRegistroPedido.Controls.Add(this.labelModificarPlato);
            this.panelRegistroPedido.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegistroPedido.Location = new System.Drawing.Point(0, 0);
            this.panelRegistroPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRegistroPedido.Name = "panelRegistroPedido";
            this.panelRegistroPedido.Size = new System.Drawing.Size(1107, 41);
            this.panelRegistroPedido.TabIndex = 0;
            this.panelRegistroPedido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegistroPedido_MouseDown);
            // 
            // btnCerrarPedidos
            // 
            this.btnCerrarPedidos.BackColor = System.Drawing.Color.Khaki;
            this.btnCerrarPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPedidos.FlatAppearance.BorderSize = 0;
            this.btnCerrarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarPedidos.Image")));
            this.btnCerrarPedidos.Location = new System.Drawing.Point(1064, 4);
            this.btnCerrarPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarPedidos.Name = "btnCerrarPedidos";
            this.btnCerrarPedidos.Size = new System.Drawing.Size(31, 28);
            this.btnCerrarPedidos.TabIndex = 19;
            this.btnCerrarPedidos.UseVisualStyleBackColor = false;
            this.btnCerrarPedidos.Click += new System.EventHandler(this.btnCerrarPedidos_Click);
            // 
            // labelModificarPlato
            // 
            this.labelModificarPlato.AutoSize = true;
            this.labelModificarPlato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarPlato.Location = new System.Drawing.Point(455, 4);
            this.labelModificarPlato.Name = "labelModificarPlato";
            this.labelModificarPlato.Size = new System.Drawing.Size(227, 36);
            this.labelModificarPlato.TabIndex = 2;
            this.labelModificarPlato.Text = "REGISTRO DE PEDIDOS";
            // 
            // dgvRegistroPedido
            // 
            this.dgvRegistroPedido.AllowUserToAddRows = false;
            this.dgvRegistroPedido.AllowUserToDeleteRows = false;
            this.dgvRegistroPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistroPedido.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvRegistroPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistroPedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRegistroPedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRegistroPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistroPedido.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistroPedido.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRegistroPedido.Location = new System.Drawing.Point(11, 124);
            this.dgvRegistroPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRegistroPedido.Name = "dgvRegistroPedido";
            this.dgvRegistroPedido.ReadOnly = true;
            this.dgvRegistroPedido.RowHeadersVisible = false;
            this.dgvRegistroPedido.RowHeadersWidth = 62;
            this.dgvRegistroPedido.RowTemplate.Height = 28;
            this.dgvRegistroPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistroPedido.Size = new System.Drawing.Size(1085, 286);
            this.dgvRegistroPedido.TabIndex = 1;
            // 
            // dataTimeRegistroPedido
            // 
            this.dataTimeRegistroPedido.Location = new System.Drawing.Point(67, 79);
            this.dataTimeRegistroPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataTimeRegistroPedido.Name = "dataTimeRegistroPedido";
            this.dataTimeRegistroPedido.Size = new System.Drawing.Size(287, 22);
            this.dataTimeRegistroPedido.TabIndex = 2;
            // 
            // btnRestablecerRegistroPedido
            // 
            this.btnRestablecerRegistroPedido.FlatAppearance.BorderSize = 0;
            this.btnRestablecerRegistroPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestablecerRegistroPedido.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestablecerRegistroPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnRestablecerRegistroPedido.Image")));
            this.btnRestablecerRegistroPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestablecerRegistroPedido.Location = new System.Drawing.Point(911, 63);
            this.btnRestablecerRegistroPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestablecerRegistroPedido.Name = "btnRestablecerRegistroPedido";
            this.btnRestablecerRegistroPedido.Size = new System.Drawing.Size(184, 55);
            this.btnRestablecerRegistroPedido.TabIndex = 5;
            this.btnRestablecerRegistroPedido.Text = "RESTABLECER";
            this.btnRestablecerRegistroPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRestablecerRegistroPedido.UseVisualStyleBackColor = true;
            // 
            // dataTimeRegistroPedido2
            // 
            this.dataTimeRegistroPedido2.Location = new System.Drawing.Point(473, 79);
            this.dataTimeRegistroPedido2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataTimeRegistroPedido2.Name = "dataTimeRegistroPedido2";
            this.dataTimeRegistroPedido2.Size = new System.Drawing.Size(287, 22);
            this.dataTimeRegistroPedido2.TabIndex = 6;
            // 
            // btnPDF
            // 
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPDF.Location = new System.Drawing.Point(16, 464);
            this.btnPDF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(175, 55);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "GENERAR FACTURA";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "DESDE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "HASTA:";
            // 
            // RegistroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1107, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.dataTimeRegistroPedido2);
            this.Controls.Add(this.btnRestablecerRegistroPedido);
            this.Controls.Add(this.dataTimeRegistroPedido);
            this.Controls.Add(this.dgvRegistroPedido);
            this.Controls.Add(this.panelRegistroPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegistroPedido";
            this.Text = "RegistroPedido";
            this.Load += new System.EventHandler(this.RegistroPedido_Load);
            this.panelRegistroPedido.ResumeLayout(false);
            this.panelRegistroPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRegistroPedido;
        private System.Windows.Forms.Label labelModificarPlato;
        private System.Windows.Forms.DataGridView dgvRegistroPedido;
        private System.Windows.Forms.DateTimePicker dataTimeRegistroPedido;
        private System.Windows.Forms.Button btnRestablecerRegistroPedido;
        private System.Windows.Forms.Button btnCerrarPedidos;
        private System.Windows.Forms.DateTimePicker dataTimeRegistroPedido2;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}