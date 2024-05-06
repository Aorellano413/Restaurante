using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Pedido
    {
        public List<Producto> Productos { get; set; }

        public Pedido()
        {
            Productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void EliminarProducto(Producto producto)
        {
            Productos.Remove(producto);
        }

        public double CalcularTotal()
        {
            return Productos.Sum(p => p.Valor);
        }
    }
}
