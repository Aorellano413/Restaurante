using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DatosInventario
    {
       
        
        ConexionDAL conexion  = new ConexionDAL(); 
        

        public DataTable MostrarInventario()
        {
            DataTable dt = new DataTable();

            
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                
                string query = "SELECT * FROM restaurante.ingredientes;";

               
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt); 
                    }
                }
            }

            return dt;
        }

        public DataTable BuscarInventarioPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM restaurante.ingredientes WHERE nombre LIKE @nombre;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}

