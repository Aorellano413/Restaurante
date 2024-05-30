namespace Vista
{
    partial class MenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProductos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNuevo1 = new System.Windows.Forms.Button();
            this.buttonBorrar1 = new System.Windows.Forms.Button();
            this.buttonFactura = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCerrarMenuProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRODUCTO,
            this.CANTIDAD,
            this.PRECIO});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(454, 289);
            this.dataGridView1.TabIndex = 1;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.MinimumWidth = 8;
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.Width = 150;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 8;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 150;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 8;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOTAL A PAGAR :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 20);
            this.textBox1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(472, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(676, 445);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttonNuevo1
            // 
            this.buttonNuevo1.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonNuevo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo1.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo1.Image")));
            this.buttonNuevo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevo1.Location = new System.Drawing.Point(472, 524);
            this.buttonNuevo1.Name = "buttonNuevo1";
            this.buttonNuevo1.Size = new System.Drawing.Size(88, 50);
            this.buttonNuevo1.TabIndex = 6;
            this.buttonNuevo1.Text = "NUEVO";
            this.buttonNuevo1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNuevo1.UseVisualStyleBackColor = true;
            // 
            // buttonBorrar1
            // 
            this.buttonBorrar1.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonBorrar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonBorrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBorrar1.Image = ((System.Drawing.Image)(resources.GetObject("buttonBorrar1.Image")));
            this.buttonBorrar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBorrar1.Location = new System.Drawing.Point(742, 524);
            this.buttonBorrar1.Name = "buttonBorrar1";
            this.buttonBorrar1.Size = new System.Drawing.Size(103, 50);
            this.buttonBorrar1.TabIndex = 7;
            this.buttonBorrar1.Text = "BORRAR";
            this.buttonBorrar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBorrar1.UseVisualStyleBackColor = true;
            // 
            // buttonFactura
            // 
            this.buttonFactura.FlatAppearance.BorderColor = System.Drawing.Color.Khaki;
            this.buttonFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFactura.Image = ((System.Drawing.Image)(resources.GetObject("buttonFactura.Image")));
            this.buttonFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFactura.Location = new System.Drawing.Point(990, 524);
            this.buttonFactura.Name = "buttonFactura";
            this.buttonFactura.Size = new System.Drawing.Size(158, 50);
            this.buttonFactura.TabIndex = 8;
            this.buttonFactura.Text = " FACTURA";
            this.buttonFactura.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "EFECTIVO :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 461);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "DEVOLUCION :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "-";
            // 
            // btnCerrarMenuProductos
            // 
            this.btnCerrarMenuProductos.BackColor = System.Drawing.Color.Red;
            this.btnCerrarMenuProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMenuProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarMenuProductos.Image")));
            this.btnCerrarMenuProductos.Location = new System.Drawing.Point(1115, 3);
            this.btnCerrarMenuProductos.Name = "btnCerrarMenuProductos";
            this.btnCerrarMenuProductos.Size = new System.Drawing.Size(33, 32);
            this.btnCerrarMenuProductos.TabIndex = 15;
            this.btnCerrarMenuProductos.UseVisualStyleBackColor = false;
            this.btnCerrarMenuProductos.Click += new System.EventHandler(this.btnCerrarMenuProductos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCerrarMenuProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 48);
            this.panel1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(492, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "PRODUCTOS AJS";
            // 
            // MenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1160, 600);
            this.Controls.Add(this.buttonFactura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonBorrar1);
            this.Controls.Add(this.buttonNuevo1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProductos";
            this.Text = "MenuProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonNuevo1;
        private System.Windows.Forms.Button buttonBorrar1;
        private System.Windows.Forms.Button buttonFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCerrarMenuProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}