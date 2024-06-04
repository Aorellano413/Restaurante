using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Inventario : Form
    {
        
        public Inventario()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            dataGridViewInventario.Rows.Add();
            dataGridViewInventario.CurrentCell =dataGridViewInventario.Rows[dataGridViewInventario.Rows.Count - 1].Cells[0];
            dataGridViewInventario.BeginEdit(true);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventario.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridViewInventario.SelectedRows[0];

                
            }
            else
            {
                MessageBox.Show("Por favor selecciona una fila para modificar.");
            }
        }

        private void buttonEliminar5_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventario.SelectedRows.Count > 0)
            {
                
                dataGridViewInventario.Rows.RemoveAt(dataGridViewInventario.SelectedRows[0].Index);
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
