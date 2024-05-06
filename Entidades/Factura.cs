using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Factura
    {
        public int Id_Factura { get; private set; } 
        public Pedido Pedido { get; set; }
        public double Total { get; set; }
        public string CedulaCliente { get; set; }

        public Factura(int idFactura, Pedido pedido, string cedulaCliente)
        {
            Id_Factura = idFactura;
            Pedido = pedido;
            Total = pedido.CalcularTotal();
            CedulaCliente = cedulaCliente;
        }

        public void ImprimirFactura()
        {
            Console.WriteLine("Factura:");
            Console.WriteLine($"ID de Factura: {Id_Factura}");
            Console.WriteLine($"Cédula del Cliente: {CedulaCliente}");
            foreach (var producto in Pedido.Productos)
            {
                Console.WriteLine($"Nombre: {producto.Nombre}, Valor: {producto.Valor}");
            }
            Console.WriteLine($"Total: {Total}");
        }
    }
}
