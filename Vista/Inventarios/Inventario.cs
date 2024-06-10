using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Inventario : Form
    {
        private MenuGeneral menuGeneral;
        InventarioBD inventario = new InventarioBD();

        public void mostrar()
        {
            dataGridView1.DataSource = inventario.MostrarInventario();
        }

        public Inventario(MenuGeneral menuGeneral)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mostrar();
            this.menuGeneral = menuGeneral;
        }

        private void btnRegresar5_Click(object sender, EventArgs e)
        {
            menuGeneral.Show();
            this.Close();
        }

        private void buttonClose5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DataTable dt = inventario.BuscarInventarioPorNombre(nombre);
                dataGridView1.DataSource = dt;
            }
        }

        private void InventarioForm_Load(object sender, EventArgs e)
        {
            DataTable dt = inventario.MostrarInventario();
            dataGridView1.DataSource = dt;
        }

        private void buttonRestablecer_Click(object sender, EventArgs e)
        {
            DataTable dt = inventario.MostrarInventario();
            dataGridView1.DataSource = dt;
        }

        public void ActualizarInventario()
        {
            DataTable dt = inventario.MostrarInventario();
            dataGridView1.DataSource = dt;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                DataTable dt = inventario.BuscarInventarioPorNombre(nombre);
                dataGridView1.DataSource = dt;
            }
            else
            {
                DataTable dt = inventario.MostrarInventario();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
