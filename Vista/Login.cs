using Entidades;
using Logica;
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
    public partial class Login : Form

    {
        private ServicioUsuario servicioUsuario = new ServicioUsuario();
        
   
        public Login()
        {
            InitializeComponent();
            textContraseña.UseSystemPasswordChar = true;
            this.StartPosition = FormStartPosition.CenterScreen;

        }   

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textUsuario.Text = "";
            textContraseña.Text = "";
        }

        
        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textUsuario.Text;
            string contraseña = textContraseña.Text;
            Usuario usuario =  servicioUsuario.Autenticar(nombreUsuario, contraseña);


            if (usuario != null)
            {
                if (usuario.Rol == "Administrador")
                {
                    RegistroProductos registroProductos = new RegistroProductos();
                    registroProductos.Show();
                }
                else if (usuario.Rol == "Cliente")
                {
                    MenuProductos menuProductos = new MenuProductos();
                    menuProductos.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
           

        private void Horafecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
