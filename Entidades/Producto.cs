using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public string Ingredientes { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }

        // Constructor
        public Producto(string nombre, int id, string ingredientes, string descripcion, double valor)
        {
            Nombre = nombre;
            Id = id;
            Ingredientes = ingredientes;
            Descripcion = descripcion;
            Valor = valor;
        }
    }
}
