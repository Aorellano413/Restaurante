using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class RegistroProductos : Form
    {
        private MenuGeneral menuGeneral;
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private string imagenSeleccionada = "";

        public RegistroProductos(MenuGeneral menuGeneral)
        {
            InitializeComponent();
            this.menuGeneral = menuGeneral;
            this.CenterToScreen();

            buttonNuevo2.Click += buttonNuevo2_Click;
            buttonBorrar.Click += buttonBorrar_Click;
            buttonGuardar.Click += buttonGuardar_Click;
            buttonSeleccionarJPG.Click += buttonSeleccionarJPG_Click;

            // Asociar eventos de validación a los TextBox
            textId.KeyPress += TextBoxID_KeyPress;
            textNombre.KeyPress += TextBoxNombre_KeyPress;
            textPrecio.KeyPress += TextBoxPrecio_KeyPress;

            // Configurar el DataGridView para manejar imágenes
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            {
                Name = "Foto",
                HeaderText = "Foto",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dataGridView1.Columns.Add(imgColumn);
        }

        private void btnCerrarRegistroProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Evento para validar solo letras en el Nombre
        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
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
            // Validar ID
            if (textId.Text.Length != 3)
            {
                MessageBox.Show("El ID debe tener exactamente 3 dígitos.");
                return;
            }

            // Validar Nombre
            if (textNombre.Text.Length == 0 || textNombre.Text.Length > 30 || !Regex.IsMatch(textNombre.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El Nombre debe tener entre 1 y 30 caracteres y solo puede contener letras y espacios.");
                return;
            }

            // Validar Precio
            if (decimal.TryParse(textPrecio.Text, out decimal precio))
            {
                if (precio <= 0)
                {
                    MessageBox.Show("El Precio debe ser mayor a 0.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("El Precio debe ser un número válido.");
                return;
            }

            // Validar que se haya seleccionado una imagen
            if (string.IsNullOrEmpty(imagenSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione una imagen.");
                return;
            }

            // Cargar la imagen desde la ruta seleccionada
            Image imagen = Image.FromFile(imagenSeleccionada);

            dataGridView1.Rows.Add(textId.Text, textNombre.Text, textPrecio.Text, imagen);

            textId.Clear();
            textNombre.Clear();
            textPrecio.Clear();
            imagenSeleccionada = string.Empty;

            MessageBox.Show("Datos guardados correctamente.");
        }

        private void buttonNuevo2_Click(object sender, EventArgs e)
        {
            textId.Clear();
            textNombre.Clear();
            textPrecio.Clear();
            imagenSeleccionada = string.Empty;
        }

        private void buttonSeleccionarJPG_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagenSeleccionada = openFileDialog.FileName;
                MessageBox.Show("Imagen seleccionada: " + imagenSeleccionada);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menuGeneral.Show();
            this.Close();
        }
    }
}