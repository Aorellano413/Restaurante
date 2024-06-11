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

        public void EliminarIngrediente(int id)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Obtener el nombre del ingrediente a eliminar
                        string nombreIngrediente = "";
                        string queryGetNombreIngrediente = "SELECT nombre FROM INGREDIENTES WHERE id_ingrediente = @id;";
                        using (MySqlCommand cmdGetNombreIngrediente = new MySqlCommand(queryGetNombreIngrediente, connection, transaction))
                        {
                            cmdGetNombreIngrediente.Parameters.AddWithValue("@id", id);
                            using (MySqlDataReader reader = cmdGetNombreIngrediente.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    nombreIngrediente = reader.GetString("nombre");
                                }
                            }
                        }

                        // Eliminar el ingrediente de INGREDIENTES_PLATOS
                        string queryDeleteFromIngredientesPlatos = "DELETE FROM INGREDIENTES_PLATOS WHERE id_ingrediente = @id;";
                        using (MySqlCommand cmdDeleteFromIngredientesPlatos = new MySqlCommand(queryDeleteFromIngredientesPlatos, connection, transaction))
                        {
                            cmdDeleteFromIngredientesPlatos.Parameters.AddWithValue("@id", id);
                            cmdDeleteFromIngredientesPlatos.ExecuteNonQuery();
                        }

                        // Actualizar las descripciones de los platos que contienen el ingrediente
                        string queryUpdatePlatoDescripcion = "UPDATE PLATOS SET descripcion = REPLACE(descripcion, @nombreIngrediente, '') WHERE descripcion LIKE CONCAT('%', @nombreIngrediente, '%');";
                        using (MySqlCommand cmdUpdatePlatoDescripcion = new MySqlCommand(queryUpdatePlatoDescripcion, connection, transaction))
                        {
                            cmdUpdatePlatoDescripcion.Parameters.AddWithValue("@nombreIngrediente", nombreIngrediente);
                            cmdUpdatePlatoDescripcion.ExecuteNonQuery();
                        }

                        // Eliminar el ingrediente de INGREDIENTES
                        string queryDeleteFromIngredientes = "DELETE FROM INGREDIENTES WHERE id_ingrediente = @id;";
                        using (MySqlCommand cmdDeleteFromIngredientes = new MySqlCommand(queryDeleteFromIngredientes, connection, transaction))
                        {
                            cmdDeleteFromIngredientes.Parameters.AddWithValue("@id", id);
                            cmdDeleteFromIngredientes.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public void DescontarStockIngrediente(int idIngrediente, int cantidad)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "UPDATE INGREDIENTES SET stock = stock - @cantidad WHERE id_ingrediente = @idIngrediente";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idIngrediente", idIngrediente);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

