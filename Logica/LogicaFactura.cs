using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class LogicaFactura
    {
        private DatosFactura datosFactura = new DatosFactura();

        public Pedido ObtenerPedidoPorId(int idPedido)
        {
            return datosFactura.ObtenerPedidoPorId(idPedido);
        }

        public List<Pedido> ObtenerPedidosPorRangoFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return datosFactura.ObtenerPedidosPorRangoFecha(fechaInicio, fechaFin);
        }

        public void InsertarFactura(Factura factura)
        {
            datosFactura.InsertarFactura(factura);
        }
    }
}
