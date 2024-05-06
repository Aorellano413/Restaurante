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
        
   
        private readonly Dictionary<string, string> usuarios = new Dictionary<string, string>()
        {
            { "admin", "12345" },

        };
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
            string usuario = textUsuario.Text;
            string contraseña = textContraseña.Text;

           
            if (usuarios.ContainsKey(usuario) && usuarios[usuario] == contraseña)
            {
                MessageBox.Show("Inicio de sesión exitoso");


                MenuGeneral menuPrincipal = new MenuGeneral();
                menuPrincipal.Show();

       
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

       
    }
}
