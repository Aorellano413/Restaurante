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
using Entidades;
using Logica;

namespace Vista.GestionPlatos
{
    public partial class RegistrarPlato : Form
    {
        private RegistroProductos registroProductos;
        PlatosBD platosBD = new PlatosBD();
        List<Ingrediente> ingredientesSeleccionados = new List<Ingrediente>();
        DataTable dt = new DataTable();
        public RegistrarPlato(RegistroProductos registroProductos)
        {
            InitializeComponent();
            this.registroProductos = registroProductos;
            InicializarDataTable();
            CargarIngredientes();
            btnAñadirNombreRP.Click += new EventHandler(btnAñadirNombreRP_Click);
            btnAñadirDescripcionRP.Click += new EventHandler(btnAñadirDescripcionRP_Click);
            btnAñadirPrecioRP.Click += new EventHandler(btnAñadirPrecioRP_Click);
            btnAñadirStockRP.Click += new EventHandler(btnAñadirStockRP_Click);
            btnRegistrarRP.Click += new EventHandler(btnRegistrarRP_Click);
            btnLimpiarRP.Click += new EventHandler(btnLimpiarRP_Click);
        }

        private void InicializarDataTable()
        {
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Stock");
            dgvRegistrarPlato.DataSource = dt;
        }

        private void CargarIngredientes()
        {
            var ingredientes = platosBD.ObtenerIngredientes();
            cmbDescripcionRP.DataSource = ingredientes;
            cmbDescripcionRP.DisplayMember = "Nombre";
            cmbDescripcionRP.ValueMember = "Id";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarPlato_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegistrarPlato_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAñadirNombreRP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombreRP.Text))
            {
                if (dt.Rows.Count == 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["Nombre"] = txtNombreRP.Text;
                    dt.Rows.Add(dr);
                }
                else
                {
                    dt.Rows[dt.Rows.Count - 1]["Nombre"] = txtNombreRP.Text;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
            }
        }

        private void btnAñadirDescripcionRP_Click(object sender, EventArgs e)
        {
            if (cmbDescripcionRP.SelectedItem != null)
            {
                var ingredienteSeleccionado = (Ingrediente)cmbDescripcionRP.SelectedItem;
                // Añadir ingrediente a la lista si no existe
                if (!ingredientesSeleccionados.Any(i => i.Id == ingredienteSeleccionado.Id))
                {
                    ingredientesSeleccionados.Add(ingredienteSeleccionado);
                }

                // Actualizar la descripción concatenando ingredientes sin duplicados
                string descripcionConcatenada = string.Join(", ", ingredientesSeleccionados.Select(i => i.Nombre).Distinct());

                if (dt.Rows.Count == 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["Descripcion"] = descripcionConcatenada;
                    dt.Rows.Add(dr);
                }
                else
                {
                    dt.Rows[0]["Descripcion"] = descripcionConcatenada; // Actualizar la primera fila
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una descripción.");
            }
        }

        private void ActualizarIngredientes()
        {
            string ingredientes = string.Join(", ", ingredientesSeleccionados.Select(i => i.Nombre));
            if (dt.Rows.Count > 0)
            {
                dt.Rows[dt.Rows.Count - 1]["Descripcion"] = ingredientes;
            }
        }

        private void btnAñadirPrecioRP_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecioRP.Text, out decimal precio))
            {
                if (dt.Rows.Count == 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["Precio"] = precio;
                    dt.Rows.Add(dr);
                }
                else
                {
                    dt.Rows[0]["Precio"] = precio; // Siempre actualizar la primera fila
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
            }
        }

        private void btnAñadirStockRP_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStockRP.Text, out int stock))
            {
                if (dt.Rows.Count == 0)
                {
                    DataRow dr = dt.NewRow();
                    dr["Stock"] = stock;
                    dt.Rows.Add(dr);
                }
                else
                {
                    dt.Rows[0]["Stock"] = stock; // Siempre actualizar la primera fila
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un stock válido.");
            }
        }

        private void btnRegistrarRP_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                if (!string.IsNullOrEmpty(row["Nombre"].ToString()) &&
                    !string.IsNullOrEmpty(row["Descripcion"].ToString()) &&
                    !string.IsNullOrEmpty(row["Precio"].ToString()) &&
                    !string.IsNullOrEmpty(row["Stock"].ToString()))
                {
                    Plato plato = new Plato
                    {
                        Nombre = row["Nombre"].ToString(),
                        Descripcion = row["Descripcion"].ToString(),
                        Precio = Convert.ToDecimal(row["Precio"]),
                        Stock = Convert.ToInt32(row["Stock"]),
                        Ingredientes = ingredientesSeleccionados.ToList() // Asignar los ingredientes seleccionados
                    };

                    platosBD.InsertarPlato(plato);
                    MessageBox.Show("Plato registrado exitosamente.");
                    LimpiarDataTable();
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de registrar el plato.");
                }
            }
            else
            {
                MessageBox.Show("No hay datos para registrar.");
            }
        }

        private void btnLimpiarRP_Click(object sender, EventArgs e)
        {
            LimpiarDataTable();
            txtNombreRP.Clear();
            txtPrecioRP.Clear();
            txtStockRP.Clear();
        }

        private void LimpiarDataTable()
        {
            dt.Clear();
        }

   
    }
}
