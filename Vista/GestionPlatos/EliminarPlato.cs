using Logica;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Vista.GestionPlatos
{
    public partial class EliminarPlato : Form
    {
        private RegistroProductos registroProductos;
        private PlatosBD platosBD;

        public EliminarPlato(RegistroProductos registroProductos)
        {
            InitializeComponent();
            this.registroProductos = registroProductos;
            platosBD = new PlatosBD();

            // Cargar datos de platos al iniciar el formulario
            CargarPlatos();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarEliminarPlato_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EliminarPlato_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelEliminarPlato_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBuscarEP_Click(object sender, EventArgs e)
        {
            FiltrarPlatos();
        }

        private void btnEliminarEP_Click(object sender, EventArgs e)
        {
            if (dgvEliminarPlato.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEliminarPlato.SelectedRows[0];
                int idPlato = Convert.ToInt32(row.Cells["id_plato"].Value);

                // Confirmar la eliminación del plato
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este plato?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    platosBD.EliminarPlato(idPlato);
                    MessageBox.Show("Plato eliminado correctamente.");
                    FiltrarPlatos(); // Actualizar la tabla después de eliminar
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un plato para eliminar.");
            }
        }

        private void txtBuscarEP_TextChanged(object sender, EventArgs e)
        {
            FiltrarPlatos();
        }

        private void CargarPlatos()
        {
            DataTable dt = platosBD.MostrarNuevaTabla();
            dgvEliminarPlato.DataSource = dt;
        }

        private void FiltrarPlatos()
        {
            string nombrePlato = txtBuscarEP.Text.Trim();
            DataTable dt;

            if (!string.IsNullOrEmpty(nombrePlato))
            {
                dt = platosBD.BuscarInventarioPlatosNombre(nombrePlato);
            }
            else
            {
                dt = platosBD.MostrarNuevaTabla();
            }

            dgvEliminarPlato.DataSource = dt;
        }
    }
}
