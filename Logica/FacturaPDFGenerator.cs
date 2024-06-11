using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;

namespace Logica
{
    public class FacturaPDFGenerator
    {
        public void GenerarFacturaPDF(Factura factura, string filePath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter writer = new PdfWriter(fs);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                document.Add(new Paragraph("Factura"));
                document.Add(new Paragraph($"Fecha: {factura.FechaFactura}"));
                document.Add(new Paragraph($"Total: {factura.Total}"));

                foreach (var detalle in factura.Detalles)
                {
                    document.Add(new Paragraph($"Plato: {detalle.Plato.Nombre}, Cantidad: {detalle.Cantidad}, Precio: {detalle.Plato.Precio}"));
                }

                document.Close();
            }
        }
    }
}
