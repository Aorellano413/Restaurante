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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iText.Kernel.Pdf;

namespace Vista
{
    public partial class RegistroPedido : Form
    {
        private MenuPedido menuPedido;
        private Logica.PedidosBD pedidosBD;

        public RegistroPedido(MenuPedido menuPedido)
        {
            InitializeComponent();
            this.menuPedido = menuPedido;
            this.pedidosBD = new Logica.PedidosBD();
            CargarPedidosConDetallesEnGrid();

            // Event handler para el DateTimePicker
            dataTimeRegistroPedido.ValueChanged += dataTimeRegistroPedido_ValueChanged_1;

            // Event handler para el botón de restablecer
            btnRestablecerRegistroPedido.Click += btnRestablecerRegistroPedido_Click_1;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void CargarPedidosConDetallesEnGrid()
        {
            DataTable dtPedidosConDetalles = pedidosBD.ObtenerPedidosConDetalles();
            dgvRegistroPedido.DataSource = dtPedidosConDetalles;
            dgvRegistroPedido.AutoResizeColumns();
            dgvRegistroPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void FiltrarPedidosPorFecha(DateTime fecha)
        {
            DataTable dtPedidosFiltrados = pedidosBD.ObtenerPedidosPorFecha(fecha);
            dgvRegistroPedido.DataSource = dtPedidosFiltrados;
            dgvRegistroPedido.AutoResizeColumns();
            dgvRegistroPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataTimeRegistroPedido_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dataTimeRegistroPedido.Value;
            FiltrarPedidosPorFecha(fechaSeleccionada);
        }
        private void dataTimeRegistroPedido2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRestablecerRegistroPedido_Click_1(object sender, EventArgs e)
        {
            CargarPedidosConDetallesEnGrid();
        }

        private void btnCerrarPedidos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelRegistroPedido_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RegistroPedido_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar archivo PDF";
                saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    string filePath = saveFileDialog.FileName;


                    try
                    {
                        GenerarPDFDesdeDataGridView(filePath);
                        MessageBox.Show("PDF generado correctamente en: " + filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error al generar el PDF: " + ex.Message);
                    }
                }
            }
        }

        private void GenerarPDFDesdeDataGridView(string filePath)
        {
            Document document = new Document();
            try
            {
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();


                PdfPTable pdfTable = new PdfPTable(dgvRegistroPedido.ColumnCount);


                foreach (DataGridViewColumn column in dgvRegistroPedido.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    pdfTable.AddCell(cell);
                }


                foreach (DataGridViewRow row in dgvRegistroPedido.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            string cellValue = cell.Value.ToString();

                            if (cell.Value is DateTime dateTimeValue)
                            {
                                cellValue = dateTimeValue.ToString("dd/MM/yyyy"); 
                            }
                            pdfTable.AddCell(cellValue);
                        }
                        else
                        {
                            pdfTable.AddCell(string.Empty);
                        }
                    }
                }

                document.Add(pdfTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el PDF: " + ex.Message);
            }
            finally
            {
                if (document.IsOpen())
                {
                    document.Close();
                }
            }
        }




    }
}
