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
        private Login login;
        public MenuGeneral(Login login)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.login = login;
        }

        private void buttonClose2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }


        private void panelGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarGramos_Click(object sender, EventArgs e)
        {
            RegistoGramos registoGramos = new RegistoGramos(this);
            registoGramos.Show();
            this.Hide();
            
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            RegistroProductos registroProductos = new RegistroProductos(this);  
            registroProductos.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
          

            login.Show();
            this.Close();
        }
    }
}
