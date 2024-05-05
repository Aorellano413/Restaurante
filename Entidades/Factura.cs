using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Factura
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public Factura(int id, Pedido pedido, decimal precio, int cantidad)
        {
            Id = id;
            Pedido = pedido;
            Precio = precio;
            Cantidad = cantidad;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"ID de la Factura: {Id}");
            Console.WriteLine($"Cantidad: {Cantidad}");
            Console.WriteLine($"ID del Pedido: {Pedido.Id}");
            Console.WriteLine($"Monto Total: ${Precio}");
            Console.WriteLine("Detalles del Pedido:");
            Pedido.MostrarDetalles();
        }
    }
}