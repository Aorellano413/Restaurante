using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using System.Data;

namespace Logica
{
    public class PlatosBD
    {
        DatosNuevaTabla datos = new DatosNuevaTabla();

        public DataTable MostrarNuevaTabla()
        {
            return datos.MostrarNuevaTabla();
        }
    }
}
