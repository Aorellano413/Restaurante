using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class RegistroProductos : Form
    {
        private MenuGeneral menuGeneral;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public RegistroProductos(MenuGeneral menuGeneral)
        {

            InitializeComponent();
            this.menuGeneral = menuGeneral;
            this.CenterToScreen();

            buttonNuevo2.Click += buttonNuevo2_Click;
            buttonBorrar.Click += buttonBorrar_Click;
            buttonGuardar.Click += buttonGuardar_Click;

        }
        private void btnCerrarRegistroProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                MessageBox.Show("Fila(s) borrada(s) correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para borrar.");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string rutaImagen = "";

            dataGridView1.Rows.Add(textId.Text, textNombre.Text, textPrecio.Text, rutaImagen);

        
            textId.Clear();
            textNombre.Clear();
            textPrecio.Clear();

            MessageBox.Show("Datos guardados correctamente.");

        }


            private void buttonNuevo2_Click(object sender, EventArgs e)
        {
            textId.Clear();
            textPrecio.Clear();
            textNombre.Clear();

        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           

            menuGeneral.Show();
            this.Close();
        }
    }

        
    }

 
   
