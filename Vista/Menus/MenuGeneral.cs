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

        private void btnRegistrarGramos_Click(object sender, EventArgs e)
        {
            RegistoGramos registoGramos = new RegistoGramos(this);
            registoGramos.Show();
            this.Enabled = false;  
            registoGramos.FormClosed += (s, args) => this.Enabled = true;  
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            RegistroProductos registroProductos = new RegistroProductos(this);
            registroProductos.Show();
            this.Enabled = false; 
            registroProductos.FormClosed += (s, args) => this.Enabled = true;  
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            labelHora1.Text = DateTime.Now.ToLongTimeString();
            labelDia.Text = DateTime.Now.ToLongDateString();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario(this);
            inventario.Show();
            this.Enabled = false;  
            inventario.FormClosed += (s, args) => this.Enabled = true;  
        }

        private void btnInventariosPlatos_Click(object sender, EventArgs e)
        {
            InventariosPlatos inventtariosplatos = new InventariosPlatos(this);
            inventtariosplatos.Show();
            this.Enabled = false; 
            inventtariosplatos.FormClosed += (s, args) => this.Enabled = true;  
        }
    }
}


