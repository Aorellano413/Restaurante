using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Menus
{
    public partial class MenuPedido : Form
    {
        private Login login;
        public MenuPedido(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnCerrarMP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
