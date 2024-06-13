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
using Vista.Menus;

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


            labelHora.Visible = false;
            labelfecha.Visible = false; 
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

            var usuario = servicioUsuario.Autenticar(nombreUsuario, contraseña, rolSeleccionado);

            if (usuario != null)
            {
                if (rolSeleccionado == "Administrador")
                {
                    MenuGeneral menuGeneral = new MenuGeneral(this);
                    menuGeneral.Show();
                    this.Hide();
                }
                else if (rolSeleccionado == "Cajero")
                {
                    MenuPedido menuPedido = new MenuPedido(this);
                    menuPedido.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
           

        private void Horafecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelfecha.Text = DateTime.Now.ToLongDateString();
        }


    }
}
