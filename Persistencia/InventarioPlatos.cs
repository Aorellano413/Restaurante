using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Persistencia
{
    public class DatosNuevaTabla
    {
        ConexionDAL conexion = new ConexionDAL();

        public DataTable MostrarNuevaTabla()
        {
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM restaurante.platos;", conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
