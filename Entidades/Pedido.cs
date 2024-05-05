using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<Producto> Productos { get; set; }

        public Pedido(int id, Cliente cliente)
        {
            Id = id;
            Cliente = cliente;
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void CalcularTotal(out int cantidadProductos, out decimal montoTotal)
        {
            cantidadProductos = Productos.Count;
            montoTotal = 0;

            foreach (var producto in Productos)
            {
                montoTotal += producto.Precio;
            }
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"ID del Pedido: {Id}");
            Console.WriteLine($"Cliente: {Cliente.Nombre} {Cliente.Apellido}");
            Console.WriteLine("Productos:");

            foreach (var producto in Productos)
            {
                Console.WriteLine($"- {producto.Nombre} (${producto.Precio})");
            }

            int cantidadProductos;
            decimal montoTotal;
            CalcularTotal(out cantidadProductos, out montoTotal);

            Console.WriteLine($"Cantidad de Productos: {cantidadProductos}");
            Console.WriteLine($"Monto Total: ${montoTotal}");
        }
    }
}
