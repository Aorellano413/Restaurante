using Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class InventarioBD
    {    DatosInventario datos = new DatosInventario();

        public DataTable MostrarInventario() 
        {

            return datos.MostrarInventario(); 
         }

        public DataTable BuscarInventarioPorNombre(string nombre)
        {
            return datos.BuscarInventarioPorNombre(nombre);
        }

    }
}
