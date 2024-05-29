using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Entidades;

namespace Logica
{
    public class ServicioUsuario 
    {
        private DatosUsuario datosUsuario = new DatosUsuario();

        public Usuario Autenticar(string nombreUsuario, string contraseña, string rol)
        {
           // return datosUsuario.ObtenerUsuario(nombreUsuario, contraseña);

            Usuario usuario = datosUsuario.ObtenerUsuario(nombreUsuario, contraseña);

            if (usuario != null && usuario.Rol == rol)
            {
                return usuario;
            }
            return null;


        }
    }
}
