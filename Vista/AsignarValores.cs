using Entidades;
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


namespace Vista
{
    public partial class AsignarValores : Form
    {
        private RegistroProductos registroProductos;
        private PlatosBD platosBD = new PlatosBD();
        private int selectedPlatoId;
        public AsignarValores(RegistroProductos registroProductos)
        {
            InitializeComponent();
            CargarPlatos();
            ConfigurarDataGridView();
            this.registroProductos = registroProductos;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CargarPlatos()
        {
            DataTable dtPlatos = platosBD.MostrarNuevaTabla();
            cmbBuscarPlatoAV.DataSource = dtPlatos;
            cmbBuscarPlatoAV.DisplayMember = "nombre";
            cmbBuscarPlatoAV.ValueMember = "id_plato";
        }

        private void ConfigurarDataGridView()
        {
            dgvAsignarValores.Columns.Clear(); // Limpiar columnas existentes
            dgvAsignarValores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdIngrediente",
                HeaderText = "Id del Ingrediente",
                ReadOnly = true,
                Visible = false
            });

            dgvAsignarValores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreIngrediente",
                HeaderText = "Nombre del Ingrediente",
                ReadOnly = true
            });

            dgvAsignarValores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad"
            });
        }

        private void btnBuscarAV_Click(object sender, EventArgs e)
        {
            string platoNombre = cmbBuscarPlatoAV.Text;
            DataTable dtPlatos = platosBD.BuscarInventarioPlatosNombre(platoNombre);

            if (dtPlatos.Rows.Count > 0)
            {
                selectedPlatoId = Convert.ToInt32(dtPlatos.Rows[0]["id_plato"]);
                List<PlatoIngrediente> ingredientes = platosBD.ObtenerIngredientesDePlato(selectedPlatoId);
                dgvAsignarValores.Rows.Clear();

                foreach (var platoIngrediente in ingredientes)
                {
                    int rowIndex = dgvAsignarValores.Rows.Add();
                    dgvAsignarValores.Rows[rowIndex].Cells["IdIngrediente"].Value = platoIngrediente.IdIngrediente;
                    dgvAsignarValores.Rows[rowIndex].Cells["NombreIngrediente"].Value = platoIngrediente.NombreIngrediente;
                    dgvAsignarValores.Rows[rowIndex].Cells["Cantidad"].Value = platoIngrediente.Cantidad;
                    dgvAsignarValores.Rows[rowIndex].Cells["Cantidad"].ReadOnly = false;
                }
            }
            else
            {
                MessageBox.Show("No se encontraron platos con ese nombre.");
            }
        }

        private void btnAsignarAV_Click(object sender, EventArgs e)
        {
            List<PlatoIngrediente> ingredientes = new List<PlatoIngrediente>();

            foreach (DataGridViewRow row in dgvAsignarValores.Rows)
            {
                // Ignorar filas nuevas o filas con celdas vacías en "NombreIngrediente" y "Cantidad"
                if (row.IsNewRow || string.IsNullOrWhiteSpace(row.Cells["NombreIngrediente"].Value?.ToString()))
                {
                    continue;
                }

                if (row.Cells["Cantidad"].Value == null || string.IsNullOrWhiteSpace(row.Cells["Cantidad"].Value.ToString()))
                {
                    MessageBox.Show("Todas las casillas deben estar llenas.");
                    return;
                }

                int cantidad;
                if (!int.TryParse(row.Cells["Cantidad"].Value.ToString(), out cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número entero positivo.");
                    return;
                }

                PlatoIngrediente platoIngrediente = new PlatoIngrediente
                {
                    IdIngrediente = Convert.ToInt32(row.Cells["IdIngrediente"].Value),
                    NombreIngrediente = row.Cells["NombreIngrediente"].Value.ToString(),
                    Cantidad = cantidad
                };
                ingredientes.Add(platoIngrediente);
            }

            platosBD.AsignarCantidadIngredientes(selectedPlatoId, ingredientes);
            MessageBox.Show("Las cantidades han sido asignadas correctamente.");
            CargarPlatos();
        }

        private void btnCerrarAsignarValores_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AsignarValores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelAsignarValores_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
