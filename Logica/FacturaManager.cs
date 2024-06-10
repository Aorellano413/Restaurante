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

        public void CrearFactura(int idPedido)
        {
            // Obtener detalles del pedido
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

            // Obtener nombre del cajero
            string nombreCajero = datosFactura.ObtenerNombreCajeroPorId(pedido.IdCajero);

            // Crear factura
            Factura factura = new Factura
            {
                FechaFactura = DateTime.Now,
                IdPedido = pedido.Id,
                NombreCajero = nombreCajero,
                Detalles = detallesPedido,
                Total = detallesPedido.Sum(d => d.Cantidad * d.Plato.Precio)
            };

            // Insertar factura en la base de datos
            datosFactura.InsertarFactura(factura);

            // Generar el PDF
            FacturaPDFGenerator generadorPDF = new FacturaPDFGenerator();
            string filePath = $"factura_{factura.Id}.pdf";
            generadorPDF.GenerarFacturaPDF(factura, filePath);
        }
    }
}
