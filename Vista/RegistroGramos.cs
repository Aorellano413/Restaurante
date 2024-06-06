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
            this.StartPosition = FormStartPosition.CenterScreen;
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
