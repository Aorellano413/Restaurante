using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FacturaManager
    {
        DatosFactura datosFactura = new DatosFactura();

        public Factura CrearFactura(int idPedido, string filePath, string logoPath)
        {
            Pedido pedido = datosFactura.ObtenerPedidoPorId(idPedido);
            if (pedido == null)
            {
                throw new Exception("Pedido no encontrado.");
            }

            var detallesPedido = pedido.Detalles.Select(dp => new DetallePedido
            {
                Id = dp.Id,
                Cantidad = dp.Cantidad,
                Precio = dp.Precio,
                IdPedido = dp.IdPedido,
                IdPlato = dp.IdPlato,
                Plato = dp.Plato
            }).ToList();

            Factura factura = new Factura
            {
                FechaFactura = DateTime.Now,
                IdPedido = pedido.Id,
                Detalles = detallesPedido,
                Total = detallesPedido.Sum(d => d.Cantidad * d.Plato.Precio)
            };

            datosFactura.InsertarFactura(factura); // Insertar la factura

            // Generar el PDF de la factura
            FacturaPDFGenerator generator = new FacturaPDFGenerator();
            generator.GenerarFacturaPDF(factura, filePath, logoPath); // Con logoPath

            return factura; // Retornar la factura completa con ID
        }
    }
}
