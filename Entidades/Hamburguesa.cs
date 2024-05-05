using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Hamburguesa : Producto
    {
        // Constructor
        public Hamburguesa(string nombre, int id, string ingredientes, string descripcion, double valor)
            : base(nombre, id, ingredientes, descripcion, valor)
        {
            
        }
    }
}
