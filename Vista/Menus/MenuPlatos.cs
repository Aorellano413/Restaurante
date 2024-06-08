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
    public partial class MenuPlatos : Form
    {
        private Login login;
        public MenuPlatos(Login login)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.login = login;
        }

        private void btnCerrarMenuProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        
    }
}
