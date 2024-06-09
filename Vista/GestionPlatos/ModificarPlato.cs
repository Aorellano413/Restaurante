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
using Entidades;

namespace Vista.GestionPlatos
{
    public partial class ModificarPlato : Form
    {
        private RegistroProductos registroProductos;
        PlatosBD platosBD = new PlatosBD();
        public ModificarPlato(RegistroProductos registroProductos)
        {
            InitializeComponent();
            this.registroProductos = registroProductos;
            CargarIngredientes();
        }

        private void CargarIngredientes()
        {
            List<Ingrediente> ingredientes = platosBD.ObtenerIngredientes();
            cmbDescripcionMP.DataSource = ingredientes;
            cmbDescripcionMP.DisplayMember = "Nombre";
            cmbDescripcionMP.ValueMember = "Id";
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ModificarPlato_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelModificarPlato_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBuscarMP_Click(object sender, EventArgs e)
        {
            string nombrePlato = txtBuscarPlatoMP.Text.Trim();
            if (!string.IsNullOrEmpty(nombrePlato))
            {
                DataTable dt = platosBD.BuscarInventarioPlatosNombre(nombrePlato);
                dgvModificarPlato.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el nombre de un plato para buscar.");
            }
        }

        private void dgvModificarPlato_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvModificarPlato.SelectedRows[0];
                txtNombreMP.Text = row.Cells["nombre"].Value.ToString();
                txtPrecioMP.Text = row.Cells["precio"].Value.ToString();
                txtStockMP.Text = row.Cells["stock"].Value.ToString();
                cmbDescripcionMP.Text = row.Cells["descripcion"].Value.ToString();
            }
        }

        private void btnLimpiarNombreMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                dgvModificarPlato.SelectedRows[0].Cells["nombre"].Value = string.Empty;
            }
        }

        private void btnLimpiarDescripcionMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                dgvModificarPlato.SelectedRows[0].Cells["descripcion"].Value = string.Empty;
            }
        }

        private void btnLimpiarPrecioMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                dgvModificarPlato.SelectedRows[0].Cells["precio"].Value = 0.0m;
            }
        }

        private void btnLimpiarStockMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                dgvModificarPlato.SelectedRows[0].Cells["stock"].Value = 0;
            }
        }

        private void btnAñadirNombreMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                dgvModificarPlato.SelectedRows[0].Cells["nombre"].Value = txtNombreMP.Text.Trim();
            }
        }

        private void btnAñadirDescripcionMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0 && cmbDescripcionMP.SelectedItem != null)
            {
                var ingredienteSeleccionado = (Ingrediente)cmbDescripcionMP.SelectedItem;
                // Obtener la descripción actual y agregar el nuevo ingrediente
                string descripcionActual = dgvModificarPlato.SelectedRows[0].Cells["descripcion"].Value.ToString();
                if (!descripcionActual.Contains(ingredienteSeleccionado.Nombre))
                {
                    descripcionActual = string.IsNullOrEmpty(descripcionActual) ? ingredienteSeleccionado.Nombre : $"{descripcionActual}, {ingredienteSeleccionado.Nombre}";
                    dgvModificarPlato.SelectedRows[0].Cells["descripcion"].Value = descripcionActual;
                }
            }
        }

        private void btnAñadirPrecioMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                if (decimal.TryParse(txtPrecioMP.Text.Trim(), out decimal precio))
                {
                    dgvModificarPlato.SelectedRows[0].Cells["precio"].Value = precio;
                }
                else
                {
                    MessageBox.Show("Ingrese un precio válido.");
                }
            }
        }

        private void btnAñadirStockMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                if (int.TryParse(txtStockMP.Text.Trim(), out int stock))
                {
                    dgvModificarPlato.SelectedRows[0].Cells["stock"].Value = stock;
                }
                else
                {
                    MessageBox.Show("Ingrese un stock válido.");
                }
            }
        }

        private void btnModificarMP_Click(object sender, EventArgs e)
        {
            if (dgvModificarPlato.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvModificarPlato.SelectedRows[0];
                string nombre = row.Cells["nombre"].Value.ToString();
                string descripcion = row.Cells["descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(row.Cells["precio"].Value);
                int stock = Convert.ToInt32(row.Cells["stock"].Value);

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(descripcion) && precio > 0 && stock > 0)
                {
                    Plato plato = new Plato
                    {
                        Id = Convert.ToInt32(row.Cells["id_plato"].Value),
                        Nombre = nombre,
                        Descripcion = descripcion,
                        Precio = precio,
                        Stock = stock,
                        Ingredientes = new List<Ingrediente>() // Aquí se deben añadir los ingredientes
                    };

                    platosBD.ModificarPlato(plato);
                    MessageBox.Show("Plato modificado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, asegúrese de que todos los campos estén llenos y sean válidos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un plato para modificar.");
            }
        }
    }
}
