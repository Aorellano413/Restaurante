using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Informe : Form
    {
        PedidosBD pedidosBD = new PedidosBD();
        MenuGeneral menuGeneral;

        public Informe(MenuGeneral menuGeneral)
        {
            InitializeComponent();
            this.menuGeneral = menuGeneral;
        }

        private void btnGenerarInforme_Click_1(object sender, EventArgs e)
        {
            int anoSeleccionado = dateTimeInforme.Value.Year;
            DataTable dtPedidosPorAno = pedidosBD.ObtenerPedidosPorAno(anoSeleccionado);
            dgvInforme.DataSource = dtPedidosPorAno;
            dgvInforme.Columns["CantidadPedidos"].Visible = false;
        }

        private void btnCerrarRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            dateTimeInforme.Value = DateTime.Now;
            dgvInforme.DataSource = null;
        }

        
    }
}
