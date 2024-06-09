using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
            string nombrePlato = txtBuscarEP.Text.Trim();
            if (!string.IsNullOrEmpty(nombrePlato))
            {
                DataTable dt = platosBD.BuscarInventarioPlatosNombre(nombrePlato);
                dgvEliminarPlato.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre de un plato para buscar.");
            }
        }

        private void btnEliminarEP_Click(object sender, EventArgs e)
        {
            if (dgvEliminarPlato.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEliminarPlato.SelectedRows[0];
                int idPlato = Convert.ToInt32(row.Cells["id_plato"].Value);

                // Esta parte fue para confirmar la eliminacion del plato
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este plato?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    platosBD.EliminarPlato(idPlato);
                    MessageBox.Show("Plato eliminado correctamente.");
                    dgvEliminarPlato.DataSource = null; // Aca se restablace la ventana
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un plato para eliminar.");
            }
        }
    }
}
