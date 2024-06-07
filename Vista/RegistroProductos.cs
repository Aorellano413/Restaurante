using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace Vista
{
    public partial class RegistroProductos : Form
    {
        private MenuGeneral menuGeneral;

        public RegistroProductos(MenuGeneral menuGeneral)
        {
            InitializeComponent();
            this.menuGeneral = menuGeneral;
            this.CenterToScreen();

        }

        private void btnCerrarRegistroProducto_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            menuGeneral.Show();
            this.Close();
        }
    }
}
