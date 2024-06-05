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
            
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEliminar5_Click(object sender, EventArgs e)
        {
            
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
