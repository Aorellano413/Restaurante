using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class MenuGeneral : Form
    {
        public MenuGeneral()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void mENUDEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
            panelGeneral.Controls.Clear();


            MenuProductos menuProductos = new MenuProductos();
            menuProductos.TopLevel = false;
            menuProductos.FormBorderStyle = FormBorderStyle.None;
            menuProductos.Dock = DockStyle.Fill;


            panelGeneral.Controls.Add(menuProductos);


            menuProductos.Show();
        }

        private void rEGISTRODEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            panelGeneral.Controls.Clear();


            RegistroProductos registroProductosForm = new RegistroProductos();
            registroProductosForm.TopLevel = false;
            registroProductosForm.FormBorderStyle = FormBorderStyle.None;
            registroProductosForm.Dock = DockStyle.Fill;

            panelGeneral.Controls.Add(registroProductosForm);


            registroProductosForm.Show();
        }

        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
