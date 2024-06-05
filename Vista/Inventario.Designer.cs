namespace Vista
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose5 = new System.Windows.Forms.Button();
            this.btnRegresar5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.buttonClose5);
            this.panel1.Controls.Add(this.btnRegresar5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 0;
            // 
            // buttonClose5
            // 
            this.buttonClose5.BackColor = System.Drawing.Color.Red;
            this.buttonClose5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose5.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose5.Image")));
            this.buttonClose5.Location = new System.Drawing.Point(765, 5);
            this.buttonClose5.Name = "buttonClose5";
            this.buttonClose5.Size = new System.Drawing.Size(23, 23);
            this.buttonClose5.TabIndex = 29;
            this.buttonClose5.UseVisualStyleBackColor = false;
            this.buttonClose5.Click += new System.EventHandler(this.buttonClose5_Click);
            // 
            // btnRegresar5
            // 
            this.btnRegresar5.BackColor = System.Drawing.Color.Khaki;
            this.btnRegresar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar5.FlatAppearance.BorderSize = 0;
            this.btnRegresar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar5.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar5.Image")));
            this.btnRegresar5.Location = new System.Drawing.Point(720, 3);
            this.btnRegresar5.Name = "btnRegresar5";
            this.btnRegresar5.Size = new System.Drawing.Size(31, 31);
            this.btnRegresar5.TabIndex = 28;
            this.btnRegresar5.UseVisualStyleBackColor = false;
            this.btnRegresar5.Click += new System.EventHandler(this.btnRegresar5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTARIO";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.Location = new System.Drawing.Point(12, 90);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(104, 45);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "AGREGAR";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.FlatAppearance.BorderSize = 0;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.Image = ((System.Drawing.Image)(resources.GetObject("buttonModificar.Image")));
            this.buttonModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModificar.Location = new System.Drawing.Point(148, 90);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(114, 45);
            this.buttonModificar.TabIndex = 3;
            this.buttonModificar.Text = "MODIFICAR";
            this.buttonModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar5
            // 
            this.buttonEliminar5.FlatAppearance.BorderSize = 0;
            this.buttonEliminar5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar5.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar5.Image")));
            this.buttonEliminar5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEliminar5.Location = new System.Drawing.Point(291, 90);
            this.buttonEliminar5.Name = "buttonEliminar5";
            this.buttonEliminar5.Size = new System.Drawing.Size(112, 45);
            this.buttonEliminar5.TabIndex = 4;
            this.buttonEliminar5.Text = "ELIMINAR";
            this.buttonEliminar5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEliminar5.UseVisualStyleBackColor = true;
            this.buttonEliminar5.Click += new System.EventHandler(this.buttonEliminar5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 237);
            this.dataGridView1.TabIndex = 5;

            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEliminar5);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar5;
        private System.Windows.Forms.Button btnRegresar5;
        private System.Windows.Forms.Button buttonClose5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}