using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Runtime.InteropServices;

namespace Vista.Menus
{
    public partial class MenuPedido : Form
    {
        private Login login;
        private PlatosBD platosBD = new PlatosBD();
        private PedidosBD pedidosBD = new PedidosBD();
        private InventarioBD inventarioBD = new InventarioBD();
        public MenuPedido(Login login)
        {
            InitializeComponent();
            this.login = login;
            CargarPlatosEnComboBox();
            ConfigurarDataGridView();

            dgvMenuPedido.RowsAdded += dgvMenuPedido_RowsAdded;
            dgvMenuPedido.RowsRemoved += dgvMenuPedido_RowsRemoved;
            dgvMenuPedido.CellValueChanged += dgvMenuPedido_CellValueChanged;
            dgvMenuPedido.UserDeletedRow += dgvMenuPedido_UserDeletedRow;
            dgvMenuPedido.CellEndEdit += dgvMenuPedido_CellEndEdit;

            this.txtEfectivoMP.TextChanged += new System.EventHandler(this.txtEfectivoMP_TextChanged);
            this.btnPagarMP.Click += new System.EventHandler(this.btnPagarMP_Click);
            this.btnLimpiarMP.Click += new System.EventHandler(this.btnLimpiarMP_Click);

            btnConfirmarMP.Enabled = false;
            btnPagarMP.Visible = false;
            txtEfectivoMP.Enabled = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ConfigurarDataGridView()
        {
            dgvMenuPedido.Columns.Clear();
            dgvMenuPedido.Columns.Add("Id", "ID");
            dgvMenuPedido.Columns.Add("Nombre", "Nombre");
            dgvMenuPedido.Columns.Add("Descripcion", "Descripción");
            dgvMenuPedido.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvMenuPedido.Columns.Add("Cantidad", "Cantidad");
            dgvMenuPedido.Columns.Add("PrecioTotal", "Precio Total");

            dgvMenuPedido.Columns["Id"].Visible = false;
        }

        private void CargarPlatosEnComboBox()
        {
            List<Plato> platos = platosBD.ObtenerTodosLosPlatos();
            cmbPlatosMP.DataSource = platos;
            cmbPlatosMP.DisplayMember = "Nombre";
            cmbPlatosMP.ValueMember = "Id";
            cmbPlatosMP.SelectedIndex = -1;
        }

        private void btnCerrarMP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadirPlatoMP_Click(object sender, EventArgs e)
        {
            if (cmbPlatosMP.SelectedItem != null)
            {
                Plato plato = cmbPlatosMP.SelectedItem as Plato;
                if (plato != null)
                {
                    AñadirPlatoAlDataGridView(plato);
                    ActualizarTotalPedido();
                    cmbPlatosMP.SelectedIndex = -1;
                }
            }
        }

        private void dgvMenuPedido_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            ActualizarTotalPedido();
        }

        private void AñadirPlatoAlDataGridView(Plato plato)
        {
            if (dgvMenuPedido.Columns.Count == 0)
            {
                ConfigurarDataGridView();
            }

            // Comprobar si el plato ya está en el DataGridView
            foreach (DataGridViewRow row in dgvMenuPedido.Rows)
            {
                if (row.Cells["Id"].Value != null && (int)row.Cells["Id"].Value == plato.Id)
                {
                    int cantidadActual = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    row.Cells["Cantidad"].Value = cantidadActual + 1;
                    row.Cells["PrecioTotal"].Value = (cantidadActual + 1) * plato.Precio;
                    return;
                }
            }

            // Añadir nuevo plato
            dgvMenuPedido.Rows.Add(plato.Id, plato.Nombre, plato.Descripcion, plato.Precio, 1, plato.Precio);
        }

        private void dgvMenuPedido_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMenuPedido.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenuPedido.Rows[e.RowIndex];
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                row.Cells["PrecioTotal"].Value = cantidad * precioUnitario;
                ActualizarTotalPedido();
            }
        }

        private void dgvMenuPedido_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMenuPedido.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMenuPedido.Rows[e.RowIndex];
                if (int.TryParse(row.Cells["Cantidad"].Value.ToString(), out int cantidad) && cantidad > 0)
                {
                    decimal precioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                    row.Cells["PrecioTotal"].Value = cantidad * precioUnitario;
                    ActualizarTotalPedido();
                }
                else
                {
                    row.Cells["Cantidad"].Value = 1;
                    row.Cells["PrecioTotal"].Value = row.Cells["PrecioUnitario"].Value;
                    ActualizarTotalPedido();
                }
            }
        }

        private void btnConfirmarMP_Click(object sender, EventArgs e)
        {
            if (dgvMenuPedido.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un plato al pedido antes de confirmar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pedido pedido = new Pedido
            {
                FechaPedido = DateTime.Now,
                IdCajero = 1 // IdCajero debe ser el Id del cajero autenticado
            };

            int idPedido = pedidosBD.CrearPedido(pedido);

            List<DetallePedido> detallesPedido = new List<DetallePedido>();

            foreach (DataGridViewRow row in dgvMenuPedido.Rows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    DetallePedido detalle = new DetallePedido
                    {
                        Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        Precio = Convert.ToDecimal(row.Cells["PrecioTotal"].Value),
                        IdPedido = idPedido,
                        IdPlato = Convert.ToInt32(row.Cells["Id"].Value)
                    };
                    pedidosBD.AgregarDetallePedido(detalle);
                    detallesPedido.Add(detalle);

                    // Descontar ingredientes del inventario
                    List<PlatoIngrediente> ingredientes = platosBD.ObtenerIngredientesDePlato(detalle.IdPlato);
                    foreach (var ingrediente in ingredientes)
                    {
                        int cantidadTotal = ingrediente.Cantidad * detalle.Cantidad;
                        inventarioBD.DescontarStockIngrediente(ingrediente.IdIngrediente, cantidadTotal);
                    }
                }
            }

            MessageBox.Show("Pedido confirmado con éxito");

            // Generar la factura usando FacturaManager
            FacturaManager facturaManager = new FacturaManager();
            Factura factura = facturaManager.CrearFactura(idPedido); // Creación de la factura

            // Generar el archivo PDF
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Factura_{factura.Id}.pdf");
            FacturaPDFGenerator generator = new FacturaPDFGenerator();
            generator.GenerarFacturaPDF(factura, filePath);

            // Abrir el archivo PDF
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });

            dgvMenuPedido.Rows.Clear();
            labelTotalMP.Text = "0";
            txtEfectivoMP.Clear();
            labelCambioMP.Text = "0";
            btnConfirmarMP.Enabled = false;
        }

        private void ActualizarTotalPedido()
        {
            decimal total = 0m;
            foreach (DataGridViewRow row in dgvMenuPedido.Rows)
            {
                if (row.Cells["PrecioTotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["PrecioTotal"].Value);
                }
            }
            labelTotalMP.Text = total.ToString("C");
            ValidarCondicionesParaConfirmar();
        }

        private void ValidarPagoYCalcularCambio()
        {
            decimal totalPedido = decimal.Parse(labelTotalMP.Text, NumberStyles.Currency);
            decimal efectivo;

            if (decimal.TryParse(txtEfectivoMP.Text, out efectivo))
            {
                if (efectivo >= totalPedido)
                {
                    decimal cambio = efectivo - totalPedido;
                    labelCambioMP.Text = cambio.ToString("C");
                    btnConfirmarMP.Enabled = true;
                }
                else
                {
                    labelCambioMP.Text = "0";
                    btnConfirmarMP.Enabled = false;
                }
            }
            else
            {
                labelCambioMP.Text = "0";
                btnConfirmarMP.Enabled = false;
            }
        }

        private void txtEfectivoMP_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtEfectivoMP.Text, out decimal efectivo))
            {
                labelCambioMP.Text = "Entrada inválida";
                btnConfirmarMP.Enabled = false;
                return;
            }

            ValidarCondicionesParaConfirmar();

            if (decimal.TryParse(labelTotalMP.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalPedido))
            {
                if (efectivo >= totalPedido)
                {
                    decimal cambio = efectivo - totalPedido;
                    labelCambioMP.Text = cambio.ToString("C");
                }
                else
                {
                    labelCambioMP.Text = "Efectivo insuficiente";
                }
            }
            else
            {
                labelCambioMP.Text = "Total inválido";
            }
        }

        private void ValidarCondicionesParaConfirmar()
        {
            bool hayPlatos = dgvMenuPedido.Rows.Count > 0;

            txtEfectivoMP.Enabled = hayPlatos;

            bool efectivoSuficiente = false;
            if (decimal.TryParse(labelTotalMP.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalPedido) &&
                decimal.TryParse(txtEfectivoMP.Text, out decimal efectivo))
            {
                efectivoSuficiente = efectivo >= totalPedido;
            }

            btnConfirmarMP.Enabled = hayPlatos && efectivoSuficiente;
        }



        private void dgvMenuPedido_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ActualizarTotalPedido();
            ValidarCondicionesParaConfirmar();
        }

        private void dgvMenuPedido_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ActualizarTotalPedido();
            ValidarCondicionesParaConfirmar();
        }

        private void btnPagarMP_Click(object sender, EventArgs e)
        {

            if (decimal.TryParse(labelTotalMP.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalPedido) &&
                decimal.TryParse(txtEfectivoMP.Text, out decimal efectivo) && efectivo >= totalPedido)
            {
                decimal cambio = efectivo - totalPedido;
                labelCambioMP.Text = cambio.ToString("C");
                btnConfirmarMP.Enabled = true;
            }
            else
            {
                MessageBox.Show("El efectivo ingresado es insuficiente o no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConfirmarMP.Enabled = false;
            }
        }

        private void btnLimpiarMP_Click(object sender, EventArgs e)
        {
            dgvMenuPedido.Rows.Clear();
            labelTotalMP.Text = "0";
            labelCambioMP.Text = "0";
            txtEfectivoMP.Clear();
            cmbPlatosMP.SelectedIndex = -1;
            txtEfectivoMP.Enabled = false;
            btnConfirmarMP.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void panelMenuPedido_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MenuPedido_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistroPedido_Click(object sender, EventArgs e)
        {
            RegistroPedido registroPedido = new RegistroPedido(this);
            registroPedido.Show();
        }

        
    }
}
