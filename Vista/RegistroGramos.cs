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
    public partial class RegistoGramos : Form
    {
        private MenuGeneral menuGeneral;
        public RegistoGramos(MenuGeneral menuGeneral)
        {
            InitializeComponent();
            this.menuGeneral = menuGeneral;
            comboRegistro.Items.AddRange(new object[] { });
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        private void buttonGuardar3_Click(object sender, EventArgs e)
        {
            if (comboRegistro.SelectedItem != null && !string.IsNullOrWhiteSpace(textGramos.Text))
            {

                string item = comboRegistro.SelectedItem.ToString();
                string gramos = textGramos.Text;


                dataGridView3.Rows.Add(item, gramos);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un item y ingrese un valor en gramos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonBorrar3_Click(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {

                dataGridView3.Rows.RemoveAt(dataGridView3.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCerraGramos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menuGeneral.Show();
            this.Close();
        }

        private void dataGridViewGramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistoGramos_Load(object sender, EventArgs e)
        {

        }
    }
}
