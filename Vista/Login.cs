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
            cmbRol.SelectedIndex = -1;
        }

        
        private void buttonContinuar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textUsuario.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.");
                return;
            }

            if (string.IsNullOrEmpty(textContraseña.Text))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return;
            }

            if (cmbRol.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un rol.");
                return;
            }

            string nombreUsuario = textUsuario.Text;
            string contraseña = textContraseña.Text;
            string rolSeleccionado = cmbRol.SelectedItem.ToString();

            Usuario usuario =  servicioUsuario.Autenticar(nombreUsuario, contraseña, rolSeleccionado);


            if (usuario != null)
            {
                if (usuario.Rol == "Administrador")
                {
                    MenuGeneral menuGeneral = new MenuGeneral(this);
                    menuGeneral.Show();
                    this.Hide();

                }
                else if (usuario.Rol == "Cliente")
                {
                    MenuProductos menuProductos = new MenuProductos(this);
                    menuProductos.Show();
                    this.Hide();
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
