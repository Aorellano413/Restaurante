using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }

        public Cliente(int id, string nombre, string apellido, int numeroMesa, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Teléfono: {Telefono}");
        }
    }

}
