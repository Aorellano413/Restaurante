using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public List<string> Ingredientes { get; set; }

        public Producto(int id, string nombre, string descripcion, decimal precio, List<string> ingredientes)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Ingredientes = ingredientes;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Precio: ${Precio}");
            Console.WriteLine("Ingredientes:");
            foreach (var ingrediente in Ingredientes)
            {
                Console.WriteLine($"- {ingrediente}");
            }
        }
    }
}