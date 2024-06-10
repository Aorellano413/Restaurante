using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
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

            CargarInventario();
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
            FiltrarIngredientes();
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
                FiltrarIngredientes();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ingrediente para eliminar.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarIngredientes();
        }

        private void CargarInventario()
        {
            InventarioBD inventarioBD = new InventarioBD();
            DataTable dt = inventarioBD.MostrarInventario();
            dgvEliminarIngrediente.DataSource = dt;
        }

        private void FiltrarIngredientes()
        {
            string nombre = txtBuscar.Text.Trim();
            InventarioBD inventarioBD = new InventarioBD();
            DataTable dt;

            if (!string.IsNullOrEmpty(nombre))
            {
                dt = inventarioBD.BuscarInventarioPorNombre(nombre);
            }
            else
            {
                dt = inventarioBD.MostrarInventario();
            }

            dgvEliminarIngrediente.DataSource = dt;
        }
    }
}
