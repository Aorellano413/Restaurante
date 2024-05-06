namespace Vista
{
    partial class MenuGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGeneral));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUDEPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRODEPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.buttonClose2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.rEGISTROToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUDEPRODUCTOSToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.mENUToolStripMenuItem.Text = "MENU";
            // 
            // mENUDEPRODUCTOSToolStripMenuItem
            // 
            this.mENUDEPRODUCTOSToolStripMenuItem.Name = "mENUDEPRODUCTOSToolStripMenuItem";
            this.mENUDEPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.mENUDEPRODUCTOSToolStripMenuItem.Text = "MENU DE PRODUCTOS";
            this.mENUDEPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.mENUDEPRODUCTOSToolStripMenuItem_Click);
            // 
            // rEGISTROToolStripMenuItem
            // 
            this.rEGISTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRODEPRODUCTOSToolStripMenuItem});
            this.rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            this.rEGISTROToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.rEGISTROToolStripMenuItem.Text = "REGISTRO";
            // 
            // rEGISTRODEPRODUCTOSToolStripMenuItem
            // 
            this.rEGISTRODEPRODUCTOSToolStripMenuItem.Name = "rEGISTRODEPRODUCTOSToolStripMenuItem";
            this.rEGISTRODEPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.rEGISTRODEPRODUCTOSToolStripMenuItem.Text = "REGISTRO DE PRODUCTOS";
            this.rEGISTRODEPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRODEPRODUCTOSToolStripMenuItem_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.pictureBox2);
            this.panelGeneral.Location = new System.Drawing.Point(0, 27);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(825, 472);
            this.panelGeneral.TabIndex = 1;
            this.panelGeneral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGeneral_Paint);
            // 
            // buttonClose2
            // 
            this.buttonClose2.BackColor = System.Drawing.Color.Red;
            this.buttonClose2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose2.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose2.Image")));
            this.buttonClose2.Location = new System.Drawing.Point(799, 1);
            this.buttonClose2.Name = "buttonClose2";
            this.buttonClose2.Size = new System.Drawing.Size(23, 23);
            this.buttonClose2.TabIndex = 2;
            this.buttonClose2.UseVisualStyleBackColor = false;
            this.buttonClose2.Click += new System.EventHandler(this.buttonClose2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(172, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(475, 338);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MenuGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.buttonClose2);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuGeneral";
            this.Text = "MenuGeneral";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENUDEPRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODEPRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.Button buttonClose2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}