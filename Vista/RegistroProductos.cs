using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using Vista.GestionPlatos;

namespace Vista
{
    public partial class RegistroProductos : Form
    {
        private MenuGeneral menuGeneral;

        public RegistroProductos(MenuGeneral menuGeneral)
        {
            InitializeComponent();
            this.menuGeneral = menuGeneral;
            this.CenterToScreen();

        }

        private void btnCerrarRegistroProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menuGeneral.Show();
            this.Close();
        }

        private void btnRegistrarPlato_Click(object sender, EventArgs e)
        {
            RegistrarPlato registrarPlato = new RegistrarPlato(this);
            registrarPlato.Show();
        }

        private void btnModificarPlato_Click(object sender, EventArgs e)
        {
            ModificarPlato modificarPlato = new ModificarPlato(this);
            modificarPlato.Show();
        }

        private void btnEliminarPlato_Click(object sender, EventArgs e)
        {
            EliminarPlato eliminarPlato = new EliminarPlato(this);
            eliminarPlato.Show();
        }
    }
}
