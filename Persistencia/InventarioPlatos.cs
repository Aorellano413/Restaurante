using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Entidades;

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
                        MySqlCommand cmdIng = new MySqlCommand("INSERT INTO INGREDIENTES_PLATOS (id_ingrediente, id_plato) VALUES (@idIngrediente, @idPlato)", conn);
                        cmdIng.Parameters.AddWithValue("@idIngrediente", ingrediente.Id);
                        cmdIng.Parameters.AddWithValue("@idPlato", plato.Id);
                        cmdIng.ExecuteNonQuery();
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
    }
}
