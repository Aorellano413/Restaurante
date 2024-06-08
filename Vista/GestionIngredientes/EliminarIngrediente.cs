using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Logica;

namespace Vista.GestionIngredientes
{
    public partial class EliminarIngrediente : Form
    {
        private RegistoGramos registoGramos;
        public EliminarIngrediente(RegistoGramos registoGramos)
        {
            InitializeComponent();
            this.registoGramos = registoGramos;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelEliminarIngrediente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EliminarIngrediente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();
            if (!string.IsNullOrEmpty(nombre))
            {
                InventarioBD inventarioBD = new InventarioBD();
                DataTable dt = inventarioBD.BuscarInventarioPorNombre(nombre);
                dgvEliminarIngrediente.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre para buscar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEliminarIngrediente.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEliminarIngrediente.SelectedRows[0].Cells["id_ingrediente"].Value);
                InventarioBD inventarioBD = new InventarioBD();
                inventarioBD.EliminarIngrediente(id);
                MessageBox.Show("Ingrediente eliminado correctamente.");

                // Actualizar el DataGridView después de eliminar
                string nombre = txtBuscar.Text.Trim();
                DataTable dt = inventarioBD.BuscarInventarioPorNombre(nombre);
                dgvEliminarIngrediente.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ingrediente para eliminar.");
            }
        }
    }
}
