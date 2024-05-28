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

        public Usuario Autenticar(string nombreUsuario, string contraseña)
        {
            return datosUsuario.ObtenerUsuario(nombreUsuario, contraseña);
        }
    }
}
