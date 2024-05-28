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

namespace Vista
{
    public partial class RegistroProductos : Form
    {
        public RegistroProductos()
        {
            InitializeComponent();
            // Asociar eventos de validación a los TextBox
            textBox1.KeyPress += TextBoxID_KeyPress;
            textBox3.KeyPress += TextBoxNombre_KeyPress;
            textBox2.KeyPress += TextBoxPrecio_KeyPress;
            // Asociar eventos de click a los botones
            button2.Click += button2_Click;
            button4.Click += button4_Click;
            button3.Click += button3_Click;
        }
        private void btnCerrarRegistroProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Evento para validar solo dígitos en el ID
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

        // Evento para validar solo dígitos y punto decimal en el Precio
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

        // Evento del botón Guardar
        private void button2_Click(object sender, EventArgs e)
        {
            // Validar ID
            if (textBox1.Text.Length != 3)
            {
                MessageBox.Show("El ID debe tener exactamente 3 dígitos.");
                return;
            }

            // Validar Nombre
            if (textBox3.Text.Length == 0 || textBox3.Text.Length > 30 || !Regex.IsMatch(textBox3.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El Nombre debe tener entre 1 y 30 caracteres y solo puede contener letras y espacios.");
                return;
            }

            // Validar Precio
            if (decimal.TryParse(textBox2.Text, out decimal precio))
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

            // Si todas las validaciones son correctas, se agrega
            dataGridView1.Rows.Add(textBox1.Text, textBox3.Text, textBox2.Text);
            MessageBox.Show("Datos guardados correctamente.");
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        // Evento del botón Nuevo
        private void button4_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
        }

        // Evento del botón Borrar
        private void button3_Click(object sender, EventArgs e)
        {
            // Eliminar la fila seleccionada del DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MessageBox.Show("Fila borrada correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para borrar.");
            }
        }
    }
}
