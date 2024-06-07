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


namespace Vista.GestionIngredientes
{
    public partial class RegistrarIngrediente : Form
    {
        private RegistoGramos registoGramos;
        InventarioBD inventario = new InventarioBD();
        public RegistrarIngrediente(RegistoGramos registoGramos)
        {
            InitializeComponent();
            this.registoGramos = registoGramos;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrarRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarIngrediente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelRegistrarIngrediente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreRI.Text.Trim();
            int stock;

            if (string.IsNullOrEmpty(nombre) || !int.TryParse(txtStockRI.Text, out stock))
            {
                MessageBox.Show("Por favor, ingrese datos válidos.");
                return;
            }

            try
            {
                Ingrediente ingrediente = new Ingrediente
                {
                    Nombre = nombre,
                    Stock = stock
                };

                inventario.InsertarIngrediente(ingrediente);
                MessageBox.Show("Ingrediente registrado exitosamente.");

                // Actualizar inventario si es necesario
                Inventario inventarioForm = Application.OpenForms["Inventario"] as Inventario;
                if (inventarioForm != null)
                {
                    inventarioForm.ActualizarInventario();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
