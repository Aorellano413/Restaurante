using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DatosPedido
    {
        ConexionDAL conexion = new ConexionDAL();

        public int InsertarPedido(Pedido pedido)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "INSERT INTO PEDIDOS (fecha_pedido, id_cajero) VALUES (@fechaPedido, @idCajero);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fechaPedido", pedido.FechaPedido);
                    cmd.Parameters.AddWithValue("@idCajero", pedido.IdCajero);
                    cmd.ExecuteNonQuery();
                    return (int)cmd.LastInsertedId;
                }
            }
        }

        public void InsertarDetallePedido(DetallePedido detalle)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                // Primero, verifica si ya existe un detalle con el mismo pedido y plato
                string queryCheck = "SELECT id_detalle, cantidad, precio FROM DETALLE_PEDIDOS WHERE id_pedido = @idPedido AND id_plato = @idPlato;";
                using (MySqlCommand cmdCheck = new MySqlCommand(queryCheck, connection))
                {
                    cmdCheck.Parameters.AddWithValue("@idPedido", detalle.IdPedido);
                    cmdCheck.Parameters.AddWithValue("@idPlato", detalle.IdPlato);

                    using (MySqlDataReader reader = cmdCheck.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Si existe, actualiza la cantidad y el precio
                            int idDetalle = reader.GetInt32("id_detalle");
                            int cantidadExistente = reader.GetInt32("cantidad");
                            decimal precioExistente = reader.GetDecimal("precio");

                            reader.Close();

                            string queryUpdate = "UPDATE DETALLE_PEDIDOS SET cantidad = @cantidad, precio = @precio WHERE id_detalle = @idDetalle;";
                            using (MySqlCommand cmdUpdate = new MySqlCommand(queryUpdate, connection))
                            {
                                cmdUpdate.Parameters.AddWithValue("@cantidad", cantidadExistente + detalle.Cantidad);
                                cmdUpdate.Parameters.AddWithValue("@precio", precioExistente + detalle.Precio * detalle.Cantidad);
                                cmdUpdate.Parameters.AddWithValue("@idDetalle", idDetalle);
                                cmdUpdate.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Si no existe, inserta un nuevo detalle
                            reader.Close();
                            string queryInsert = "INSERT INTO DETALLE_PEDIDOS (cantidad, precio, id_pedido, id_plato) VALUES (@cantidad, @precio, @idPedido, @idPlato);";
                            using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, connection))
                            {
                                cmdInsert.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                                cmdInsert.Parameters.AddWithValue("@precio", detalle.Precio);
                                cmdInsert.Parameters.AddWithValue("@idPedido", detalle.IdPedido);
                                cmdInsert.Parameters.AddWithValue("@idPlato", detalle.IdPlato);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        public DataTable ObtenerPedidos()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM PEDIDOS;";
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

        public DataTable ObtenerDetallesPedido(int idPedido)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT dp.id_detalle, dp.cantidad, dp.precio, p.nombre, p.descripcion, p.precio AS precio_unitario FROM DETALLE_PEDIDOS dp JOIN PLATOS p ON dp.id_plato = p.id_plato WHERE dp.id_pedido = @idPedido;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);
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
