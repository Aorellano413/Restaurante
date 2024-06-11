using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;
using System.Data.SqlClient;

namespace Persistencia
{
    public class InventarioPlatos
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

        public DataTable BuscarInventarioPlatosPorNombre(string nombre)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM restaurante.platos WHERE nombre LIKE @nombre;";
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

        public void InsertarPlato(Plato plato)
        {
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO PLATOS (nombre, descripcion, precio, stock) VALUES (@nombre, @descripcion, @precio, @stock)", conn);
                cmd.Parameters.AddWithValue("@nombre", plato.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", plato.Descripcion);
                cmd.Parameters.AddWithValue("@precio", plato.Precio);
                cmd.Parameters.AddWithValue("@stock", plato.Stock);
                cmd.ExecuteNonQuery();

                plato.Id = (int)cmd.LastInsertedId;

                foreach (var ingrediente in plato.Ingredientes)
                {
                    // Verifica si el ingrediente existe en la tabla INGREDIENTES
                    MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM INGREDIENTES WHERE id_ingrediente = @idIngrediente", conn);
                    cmdCheck.Parameters.AddWithValue("@idIngrediente", ingrediente.Id);
                    int count = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (count > 0)
                    {
                        cmd = new MySqlCommand("INSERT INTO restaurante.ingredientes_platos (id_plato, id_ingrediente, cantidad) VALUES (@id_plato, @id_ingrediente, @cantidad)", conn);
                        cmd.Parameters.AddWithValue("@id_plato", plato.Id);
                        cmd.Parameters.AddWithValue("@id_ingrediente", ingrediente.Id);
                        cmd.Parameters.AddWithValue("@cantidad", ingrediente.Stock);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        throw new Exception($"Ingrediente con id {ingrediente.Id} no existe.");
                    }
                }
            }
        }

        public List<Ingrediente> ObtenerIngredientes()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT id_ingrediente, nombre FROM restaurante.ingredientes;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ingrediente ingrediente = new Ingrediente
                            {
                                Id = reader.GetInt32("id_ingrediente"),
                                Nombre = reader.GetString("nombre")
                            };
                            ingredientes.Add(ingrediente);
                        }
                    }
                }
            }
            return ingredientes;
        }

        public void ModificarPlato(Plato plato)
        {
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE PLATOS SET nombre = @nombre, descripcion = @descripcion, precio = @precio, stock = @stock WHERE id_plato = @idPlato", conn);
                cmd.Parameters.AddWithValue("@nombre", plato.Nombre);
                cmd.Parameters.AddWithValue("@descripcion", plato.Descripcion);
                cmd.Parameters.AddWithValue("@precio", plato.Precio);
                cmd.Parameters.AddWithValue("@stock", plato.Stock);
                cmd.Parameters.AddWithValue("@idPlato", plato.Id);
                cmd.ExecuteNonQuery();

                // Eliminar los ingredientes actuales del plato
                MySqlCommand cmdDeleteIngredientes = new MySqlCommand("DELETE FROM INGREDIENTES_PLATOS WHERE id_plato = @idPlato", conn);
                cmdDeleteIngredientes.Parameters.AddWithValue("@idPlato", plato.Id);
                cmdDeleteIngredientes.ExecuteNonQuery();

                // Insertar los nuevos ingredientes
                foreach (var ingrediente in plato.Ingredientes)
                {
                    MySqlCommand cmdIng = new MySqlCommand("INSERT INTO INGREDIENTES_PLATOS (id_ingrediente, id_plato) VALUES (@idIngrediente, @idPlato)", conn);
                    cmdIng.Parameters.AddWithValue("@idIngrediente", ingrediente.Id);
                    cmdIng.Parameters.AddWithValue("@idPlato", plato.Id);
                    cmdIng.ExecuteNonQuery();
                }
            }
        }

        public void EliminarPlato(int idPlato)
        {
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Eliminar las relaciones de ingredientes con el plato
                        MySqlCommand cmdDeleteIngredientesPlatos = new MySqlCommand("DELETE FROM INGREDIENTES_PLATOS WHERE id_plato = @idPlato", conn, transaction);
                        cmdDeleteIngredientesPlatos.Parameters.AddWithValue("@idPlato", idPlato);
                        cmdDeleteIngredientesPlatos.ExecuteNonQuery();

                        // Eliminar las relaciones en detalle_pedidos
                        MySqlCommand cmdDeleteDetallePedidos = new MySqlCommand("DELETE FROM detalle_pedidos WHERE id_plato = @idPlato", conn, transaction);
                        cmdDeleteDetallePedidos.Parameters.AddWithValue("@idPlato", idPlato);
                        cmdDeleteDetallePedidos.ExecuteNonQuery();

                        // Eliminar el plato
                        MySqlCommand cmdDeletePlato = new MySqlCommand("DELETE FROM PLATOS WHERE id_plato = @idPlato", conn, transaction);
                        cmdDeletePlato.Parameters.AddWithValue("@idPlato", idPlato);
                        cmdDeletePlato.ExecuteNonQuery();

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

        public List<PlatoIngrediente> ObtenerIngredientesDePlato(int idPlato)
        {
            List<PlatoIngrediente> ingredientes = new List<PlatoIngrediente>();
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                string query = "SELECT i.id_ingrediente, i.nombre AS nombre_ingrediente, ip.cantidad FROM Ingredientes i JOIN INGREDIENTES_PLATOS ip ON i.id_ingrediente = ip.id_ingrediente WHERE ip.id_plato = @idPlato";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPlato", idPlato);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ingredientes.Add(new PlatoIngrediente
                            {
                                IdIngrediente = reader.GetInt32(reader.GetOrdinal("id_ingrediente")),
                                NombreIngrediente = reader.GetString(reader.GetOrdinal("nombre_ingrediente")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("cantidad"))
                            });
                        }
                    }
                }
            }
            return ingredientes;
        }

        public void AsignarCantidadIngredientes(int idPlato, List<PlatoIngrediente> ingredientes)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                foreach (var platoIngrediente in ingredientes)
                {
                    string query = @"
                        UPDATE INGREDIENTES_PLATOS 
                        SET cantidad = @cantidad 
                        WHERE id_ingrediente = @idIngrediente AND id_plato = @idPlato;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@cantidad", platoIngrediente.Cantidad);
                        cmd.Parameters.AddWithValue("@idIngrediente", platoIngrediente.IdIngrediente);
                        cmd.Parameters.AddWithValue("@idPlato", idPlato);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<Plato> ObtenerTodosLosPlatos()
        {
            List<Plato> platos = new List<Plato>();
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT id_plato, nombre, descripcion, precio, stock FROM PLATOS", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Plato plato = new Plato
                        {
                            Id = reader.GetInt32("id_plato"),
                            Nombre = reader.GetString("nombre"),
                            Descripcion = reader.GetString("descripcion"),
                            Precio = reader.GetDecimal("precio"),
                            Stock = reader.GetInt32("stock")
                        };
                        platos.Add(plato);
                    }
                }
            }
            return platos;
        }

        public Plato ObtenerPlatoPorId(int idPlato)
        {
            Plato plato = null;
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM PLATOS WHERE id_plato = @idPlato;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idPlato", idPlato);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            plato = new Plato
                            {
                                Id = reader.GetInt32("id_plato"),
                                Nombre = reader.GetString("nombre"),
                                Descripcion = reader.GetString("descripcion"),
                                Precio = reader.GetDecimal("precio"),
                                Stock = reader.GetInt32("stock")
                            };
                        }
                    }
                }
            }
            return plato;
        }

        public void EliminarIngredienteYActualizarPlatos(int idIngrediente)
        {
            using (MySqlConnection conn = conexion.AbrirConexion())
            {
                using (MySqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Obtener el nombre del ingrediente a eliminar
                        string nombreIngrediente = "";
                        string queryGetNombreIngrediente = "SELECT nombre FROM INGREDIENTES WHERE id_ingrediente = @idIngrediente;";
                        using (MySqlCommand cmdGetNombreIngrediente = new MySqlCommand(queryGetNombreIngrediente, conn, transaction))
                        {
                            cmdGetNombreIngrediente.Parameters.AddWithValue("@idIngrediente", idIngrediente);
                            using (MySqlDataReader reader = cmdGetNombreIngrediente.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    nombreIngrediente = reader.GetString("nombre");
                                }
                            }
                        }

                        // Eliminar el ingrediente de INGREDIENTES_PLATOS
                        string queryDeleteFromIngredientesPlatos = "DELETE FROM INGREDIENTES_PLATOS WHERE id_ingrediente = @idIngrediente;";
                        using (MySqlCommand cmdDeleteFromIngredientesPlatos = new MySqlCommand(queryDeleteFromIngredientesPlatos, conn, transaction))
                        {
                            cmdDeleteFromIngredientesPlatos.Parameters.AddWithValue("@idIngrediente", idIngrediente);
                            cmdDeleteFromIngredientesPlatos.ExecuteNonQuery();
                        }

                        // Actualizar las descripciones de los platos que contienen el ingrediente
                        string queryUpdatePlatoDescripcion = "UPDATE PLATOS SET descripcion = REPLACE(descripcion, @nombreIngrediente, '') WHERE descripcion LIKE CONCAT('%', @nombreIngrediente, '%');";
                        using (MySqlCommand cmdUpdatePlatoDescripcion = new MySqlCommand(queryUpdatePlatoDescripcion, conn, transaction))
                        {
                            cmdUpdatePlatoDescripcion.Parameters.AddWithValue("@nombreIngrediente", nombreIngrediente);
                            cmdUpdatePlatoDescripcion.ExecuteNonQuery();
                        }

                        // Eliminar el ingrediente de INGREDIENTES
                        string queryDeleteFromIngredientes = "DELETE FROM INGREDIENTES WHERE id_ingrediente = @idIngrediente;";
                        using (MySqlCommand cmdDeleteFromIngredientes = new MySqlCommand(queryDeleteFromIngredientes, conn, transaction))
                        {
                            cmdDeleteFromIngredientes.Parameters.AddWithValue("@idIngrediente", idIngrediente);
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
    }
}
