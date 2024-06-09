using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;
using Entidades;

namespace Logica
{
    public class PlatosBD
    {
        InventarioPlatos datos = new InventarioPlatos();

        public DataTable MostrarNuevaTabla()
        {
            return datos.MostrarNuevaTabla();
        }

        public DataTable BuscarInventarioPlatosNombre(string nombre)
        {
            return datos.BuscarInventarioPlatosPorNombre(nombre);
        }

        public void InsertarPlato(Plato plato)
        {
            datos.InsertarPlato(plato);
        }

        public List<Ingrediente> ObtenerIngredientes()
        {
            return datos.ObtenerIngredientes();
        }

        public void ModificarPlato(Plato plato)
        {
            datos.ModificarPlato(plato);
        }

    }
}
