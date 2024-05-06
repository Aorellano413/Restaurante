using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Factura
    {
        public Pedido Pedido { get; set; }
        public double Total { get; set; }
        public string CedulaCliente { get; set; } 

        public Factura(Pedido pedido, string cedulaCliente)
        {
            Pedido = pedido;
            Total = pedido.CalcularTotal();
            CedulaCliente = cedulaCliente;
        }

        public void ImprimirFactura()
        {
            Console.WriteLine("Factura:");
            Console.WriteLine($"Cédula del Cliente: {CedulaCliente}");
            foreach (var producto in Pedido.Productos)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, Valor: {producto.Valor}");
            }
            Console.WriteLine($"Total: {Total}");
        }
    }
}

