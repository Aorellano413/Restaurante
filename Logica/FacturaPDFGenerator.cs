using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.Kernel.Geom;
using iText.IO.Image;
using Entidades;
using System;

namespace Logica
{
    public class FacturaPDFGenerator
    {
        public void GenerarFacturaPDF(Factura factura, string filePath, string logoPath)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter writer = new PdfWriter(fs);
                PdfDocument pdf = new PdfDocument(writer);

                // Definir tamaño de página personalizado
                PageSize pageSize = new PageSize(8.5f * 72, 5.5f * 72); // Tamaño de factura comercial 8.5 x 5.5 pulgadas
                Document document = new Document(pdf, pageSize);
                document.SetMargins(20, 20, 20, 20);

                // Agregar el logo al documento
                try
                {
                    if (File.Exists(logoPath))
                    {
                        ImageData imageData = ImageDataFactory.Create(logoPath);
                        Image logo = new Image(imageData);
                        logo.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                        logo.ScaleToFit(100, 100); // Ajustar el tamaño según sea necesario
                        document.Add(logo);
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la imagen en la ruta especificada.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al cargar la imagen: " + ex.Message);
                }

                // Centrar el título y agregar un estilo más destacado
                Paragraph titulo = new Paragraph("Factura")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(20)
                    .SetBold();
                document.Add(titulo);

                // Agregar las siglas centradas debajo del título
                Paragraph siglas = new Paragraph("AJS")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(16)
                    .SetItalic();
                document.Add(siglas);

                // Centrar y agregar detalles de la factura
                Paragraph fecha = new Paragraph($"Fecha: {factura.FechaFactura}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12);
                document.Add(fecha);

                Paragraph total = new Paragraph($"Total: {factura.Total:C}")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(12);
                document.Add(total);

                // Agregar un espacio entre los detalles y los productos
                document.Add(new Paragraph("\n"));

                // Centrar y dar formato a los detalles de los productos
                foreach (var detalle in factura.Detalles)
                {
                    Paragraph detallePlato = new Paragraph($"Plato: {detalle.Plato.Nombre}, Cantidad: {detalle.Cantidad}, Precio: {detalle.Plato.Precio:C}")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(10);
                    document.Add(detallePlato);
                }

                document.Close();
            }
        }
    }
}
