using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
