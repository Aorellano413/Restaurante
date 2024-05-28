using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Persistencia
{
    public class DatosUsuario
    {
        private List<Usuario> usuarios = new List<Usuario>
    {
        new Usuario { NombreUsuario = "admin", Contraseña = "admin123", Rol = "Administrador" },
        new Usuario { NombreUsuario = "cliente", Contraseña = "cliente123", Rol = "Cliente" }
    };

        public Usuario ObtenerUsuario(string nombreUsuario, string contraseña)
        {
            return usuarios.Find(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);
        }
    }
}
