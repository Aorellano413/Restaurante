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
        PlatosBD platosBD = new PlatosBD();
        InventarioBD inventarioBD = new InventarioBD();

        public int CrearPedido(Pedido pedido)
        {
            return datos.InsertarPedido(pedido);
        }

        public void AgregarDetallePedido(DetallePedido detalle)
        {
            datos.InsertarDetallePedido(detalle);
            datos.ActualizarStockPlato(detalle.IdPlato, detalle.Cantidad);

            List<PlatoIngrediente> ingredientesDelPlato = platosBD.ObtenerIngredientesDePlato(detalle.IdPlato);

            foreach (var ingredientePlato in ingredientesDelPlato)
            {
                int cantidadTotalADescontar = ingredientePlato.Cantidad * detalle.Cantidad;
                inventarioBD.DescontarStockIngrediente(ingredientePlato.IdIngrediente, cantidadTotalADescontar);
            }
        }

        public DataTable ObtenerPedidos()
        {
            return datos.ObtenerPedidos();
        }

        public DataTable ObtenerDetallesPedido(int idPedido)
        {
            return datos.ObtenerDetallesPedido(idPedido);
        }

        public DataTable ObtenerPedidosConDetalles()
        {
            return datos.ObtenerPedidosConDetalles();
        }



        public DataTable ObtenerPedidosPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return datos.ObtenerPedidosPorRangoFechas(fechaInicio, fechaFin);
        }

        public DataTable ObtenerPedidosPorAno(int ano)
        {
            return datos.ObtenerPedidosPorAno(ano);
        }

    }
}
