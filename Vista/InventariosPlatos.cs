using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class InventariosPlatos : Form
    {
        PlatosBD platosBD = new PlatosBD();
        private MenuGeneral menuGeneral;

        public InventariosPlatos(MenuGeneral menuGeneral)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MostrarPlatos();
            this.menuGeneral = menuGeneral;
        }

        public void MostrarPlatos()
        {
            dataGridView2.DataSource = platosBD.MostrarNuevaTabla();
        }

        private void buttonEliminar7_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonModificar7_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGuardar7_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegresar5_Click(object sender, EventArgs e)
        {
            menuGeneral.Show();
            this.Close();
        }

        private void btnCerrarInventarioPlatos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
