using Entidades;
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
    {   
        
        DatosInventario datos = new DatosInventario();

        public DataTable MostrarInventario() 
        {

            return datos.MostrarInventario(); 
         }

        public DataTable BuscarInventarioPorNombre(string nombre)
        {
            return datos.BuscarInventarioPorNombre(nombre);
        }

        public bool ExisteIngrediente(string nombre)
        {
            return datos.ExisteIngrediente(nombre);
        }

        public void InsertarIngrediente(Ingrediente ingrediente)
        {
            if (!ExisteIngrediente(ingrediente.Nombre))
            {
                datos.InsertarIngrediente(ingrediente);
            }
            else
            {
                throw new Exception("El ingrediente ya existe.");
            }
        }

        public DataTable BuscarIngredientePorNombre(string nombre)
        {
            return datos.BuscarIngredientePorNombre(nombre);
        }

        public void ActualizarIngrediente(Ingrediente ingrediente)
        {
            datos.ActualizarIngrediente(ingrediente);
        }

        public void EliminarIngrediente(int id)
        {
            datos.EliminarIngrediente(id);
        }
    }
}
