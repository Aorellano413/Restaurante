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
    public partial class MenuProductos : Form
    {
        public MenuProductos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnCerrarMenuProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
