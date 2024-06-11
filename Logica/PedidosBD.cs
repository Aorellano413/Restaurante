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
        PlatosBD platosBD = new PlatosBD(); // Añadimos esto para obtener información de los platos
        InventarioBD inventarioBD = new InventarioBD();

        public int CrearPedido(Pedido pedido)
        {
            return datos.InsertarPedido(pedido);
        }

        public void AgregarDetallePedido(DetallePedido detalle)
        {
            datos.InsertarDetallePedido(detalle);
            datos.ActualizarStockPlato(detalle.IdPlato, detalle.Cantidad);

            // Obtener los ingredientes del plato
            List<PlatoIngrediente> ingredientesDelPlato = platosBD.ObtenerIngredientesDePlato(detalle.IdPlato);

            // Descontar los ingredientes utilizados en el plato
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


    }
}
