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
using Vista.Menus;

namespace Vista
{
    public partial class DisponibilidadPlatos : Form
    {   
        private MenuPedido menuPedido;
        private PlatosBD platosBD;

        public DisponibilidadPlatos(MenuPedido menuPedido)
        {
            InitializeComponent();
            this.menuPedido = menuPedido;
            this.platosBD = new PlatosBD();
            CargarPlatos();
            txtDisponibilidadPlatos.TextChanged += new EventHandler(txtDisponibilidadPlatos_TextChanged);
            this.btnRestablecer.Click += new System.EventHandler(this.btnRestablecer_Click);

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CargarPlatos()
        {
            DataTable dtPlatos = platosBD.MostrarNuevaTabla();
            dgvDisponibilidadPlatos.DataSource = dtPlatos;
            dgvDisponibilidadPlatos.Columns["id_plato"].Visible = false; 
            dgvDisponibilidadPlatos.Columns["nombre"].HeaderText = "Nombre";
            dgvDisponibilidadPlatos.Columns["descripcion"].Visible = false;
            dgvDisponibilidadPlatos.Columns["precio"].HeaderText = "Precio";
            dgvDisponibilidadPlatos.Columns["stock"].HeaderText = "Stock";
        }


        private void btnDisponibilidadPlatos_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void DisponibilidadPlatos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtDisponibilidadPlatos_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtDisponibilidadPlatos.Text;
            DataTable dtPlatos = platosBD.BuscarInventarioPlatosNombre(searchValue);
            dgvDisponibilidadPlatos.DataSource = dtPlatos;
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            txtDisponibilidadPlatos.Clear(); 
            CargarPlatos();
        }
    }
}
