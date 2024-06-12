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
using Vista.Menus;

namespace Vista
{
    public partial class RegistroPedido : Form
    {
        private MenuPedido menuPedido;
        private Logica.PedidosBD pedidosBD;

        public RegistroPedido(MenuPedido menuPedido)
        {
            InitializeComponent();
            this.menuPedido = menuPedido;
            this.pedidosBD = new Logica.PedidosBD();
            CargarPedidosConDetallesEnGrid();

            // Event handler para el DateTimePicker
            dataTimeRegistroPedido.ValueChanged += dataTimeRegistroPedido_ValueChanged_1;

            // Event handler para el botón de restablecer
            btnRestablecerRegistroPedido.Click += btnRestablecerRegistroPedido_Click_1;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CargarPedidosConDetallesEnGrid()
        {
            // Obtener los datos de los pedidos con detalles
            DataTable dtPedidosConDetalles = pedidosBD.ObtenerPedidosConDetalles();

            // Asignar el DataTable al DataGridView
            dgvRegistroPedido.DataSource = dtPedidosConDetalles;

            // Opcional: Ajusta el formato de la tabla, columnas, etc.
            dgvRegistroPedido.AutoResizeColumns();
            dgvRegistroPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FiltrarPedidosPorFecha(DateTime fecha)
        {
            // Obtener los datos filtrados por fecha
            DataTable dtPedidosFiltrados = pedidosBD.ObtenerPedidosPorFecha(fecha);

            // Asignar el DataTable filtrado al DataGridView
            dgvRegistroPedido.DataSource = dtPedidosFiltrados;

            // Opcional: Ajusta el formato de la tabla, columnas, etc.
            dgvRegistroPedido.AutoResizeColumns();
            dgvRegistroPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataTimeRegistroPedido_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dataTimeRegistroPedido.Value;
            FiltrarPedidosPorFecha(fechaSeleccionada);
        }

        private void btnRestablecerRegistroPedido_Click_1(object sender, EventArgs e)
        {
            // Restablecer la vista a todos los pedidos
            CargarPedidosConDetallesEnGrid();
        }

        private void btnCerrarPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRegistroPedido_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RegistroPedido_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
