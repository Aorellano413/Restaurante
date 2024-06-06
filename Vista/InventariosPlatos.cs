using Logica;
using System;
using System.Data;
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

       

        private void btnRegresar5_Click(object sender, EventArgs e)
        {
            menuGeneral.Show();
            this.Close();
        }

        private void btnCerrarInventarioPlatos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DataTable dt = platosBD.BuscarInventarioPlatosNombre(nombre);
                dataGridView2.DataSource = dt;  
            }
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            DataTable dt = platosBD.MostrarNuevaTabla();
            dataGridView2.DataSource = dt;
        }

        private void buttonRestablecer_Click(object sender, EventArgs e)
        {
            DataTable dt = platosBD.MostrarNuevaTabla();
            dataGridView2.DataSource = dt;
        }
    }
}
