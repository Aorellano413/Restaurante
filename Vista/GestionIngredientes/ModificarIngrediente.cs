using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Vista.GestionIngredientes
{
    public partial class ModificarIngrediente : Form
    {
        private RegistoGramos registoGramos;
        InventarioBD inventario = new InventarioBD();

        public ModificarIngrediente(RegistoGramos registoGramos)
        {
            InitializeComponent();
            this.registoGramos = registoGramos;

            // Cargar datos del inventario al iniciar el formulario
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

        private void ModificarIngrediente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelModificarIngrediente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarIngredientes();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (dgvModificarIngrediente.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvModificarIngrediente.SelectedRows[0];

                int idIngrediente = Convert.ToInt32(selectedRow.Cells["id_ingrediente"].Value);
                string nombre = selectedRow.Cells["nombre"].Value.ToString();
                int stock = Convert.ToInt32(selectedRow.Cells["stock"].Value);

                Ingrediente ingrediente = new Ingrediente
                {
                    Id = idIngrediente,
                    Nombre = nombre,
                    Stock = stock
                };

                inventario.ActualizarIngrediente(ingrediente);
                MessageBox.Show("Ingrediente modificado exitosamente.");

                // Actualizar la vista del inventario
                Inventario inventarioForm = Application.OpenForms["Inventario"] as Inventario;
                if (inventarioForm != null)
                {
                    inventarioForm.ActualizarInventario();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ingrediente para modificar.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarIngredientes();
        }

        private void CargarInventario()
        {
            DataTable dt = inventario.MostrarInventario();
            dgvModificarIngrediente.DataSource = dt;

            // Hacer que la columna id_ingrediente sea de solo lectura para que no se pueda modificar
            if (dgvModificarIngrediente.Columns["id_ingrediente"] != null)
            {
                dgvModificarIngrediente.Columns["id_ingrediente"].ReadOnly = true;
            }
        }

        private void FiltrarIngredientes()
        {
            string nombre = txtBuscar.Text.Trim();
            DataTable dt;

            if (!string.IsNullOrEmpty(nombre))
            {
                dt = inventario.BuscarIngredientePorNombre(nombre);
            }
            else
            {
                dt = inventario.MostrarInventario();
            }

            dgvModificarIngrediente.DataSource = dt;

            // Hacer que la columna id_ingrediente sea de solo lectura para que no se pueda modificar
            if (dgvModificarIngrediente.Columns["id_ingrediente"] != null)
            {
                dgvModificarIngrediente.Columns["id_ingrediente"].ReadOnly = true;
            }
        }
    }
}
