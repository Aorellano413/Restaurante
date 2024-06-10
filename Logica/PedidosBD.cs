using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class PedidosBD
    {
        DatosPedido datos = new DatosPedido();

        public int CrearPedido(Pedido pedido)
        {
            return datos.InsertarPedido(pedido);
        }

        public void AgregarDetallePedido(DetallePedido detalle)
        {
            datos.InsertarDetallePedido(detalle);
        }

        public DataTable ObtenerPedidos()
        {
            return datos.ObtenerPedidos();
        }

        public DataTable ObtenerDetallesPedido(int idPedido)
        {
            return datos.ObtenerDetallesPedido(idPedido);
        }
    }
}
