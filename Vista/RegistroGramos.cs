using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Vista.GestionIngredientes;

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

        private void btnRegistrarIngrediente_Click(object sender, EventArgs e)
        {
            RegistrarIngrediente registrarIngrediente = new RegistrarIngrediente(this);
            registrarIngrediente.Show();
        }

        private void btnModificarIngrediente_Click_1(object sender, EventArgs e)
        {
            ModificarIngrediente modificarIngrediente = new ModificarIngrediente(this);
            modificarIngrediente.Show();
        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            EliminarIngrediente eliminarIngrediente = new EliminarIngrediente(this);
            eliminarIngrediente.Show();
        }
    }
}
