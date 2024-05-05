using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        // Constructor
        public Usuario(string cliente, string contraseña)
        {
            NombreUsuario = cliente;
            Contraseña = contraseña;
        }

        // Método para validar las credenciales
        public bool ValidarCredenciales(string cliente, string contraseña)
        {
            return NombreUsuario == cliente && Contraseña == contraseña;
        }
    }
}
