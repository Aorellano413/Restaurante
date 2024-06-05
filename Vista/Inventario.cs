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
        InventarioBD inventario = new InventarioBD();

        public void mostrar()
        {
            dataGridView1.DataSource = inventario.MostrarInventario();
            
        }
        public Inventario()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            mostrar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0];
            dataGridView1.BeginEdit(true);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para modificar.");
            }
        }

        private void buttonEliminar5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para eliminar.");
            }
        }


        private void btnRegresar5_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonClose5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
