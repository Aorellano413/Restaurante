using Entidades;
using Persistencia;
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

        public bool ExisteIngrediente(string nombre)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT COUNT(*) FROM restaurante.ingredientes WHERE nombre = @nombre;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void InsertarIngrediente(Ingrediente ingrediente)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "INSERT INTO restaurante.ingredientes (nombre, stock) VALUES (@nombre, @stock);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@nombre", ingrediente.Nombre);
                    cmd.Parameters.AddWithValue("@stock", ingrediente.Stock);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable BuscarIngredientePorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_ingrediente, nombre, stock FROM restaurante.ingredientes WHERE nombre LIKE @nombre;";
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

        public void ActualizarIngrediente(Ingrediente ingrediente)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "UPDATE restaurante.ingredientes SET Nombre = @nombre, Stock = @stock WHERE id_ingrediente = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", ingrediente.Id);
                    cmd.Parameters.AddWithValue("@nombre", ingrediente.Nombre);
                    cmd.Parameters.AddWithValue("@stock", ingrediente.Stock);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

