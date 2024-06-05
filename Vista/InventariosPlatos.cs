using Logica;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class InventariosPlatos : Form
    {
        PlatosBD platosBD = new PlatosBD();

        public InventariosPlatos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            MostrarPlatos();
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
    }
}
