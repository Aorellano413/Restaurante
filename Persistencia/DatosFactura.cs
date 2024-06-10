using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class DatosFactura
    {
        ConexionDAL conexion = new ConexionDAL();

        public Pedido ObtenerPedidoPorId(int idPedido)
        {
            Pedido pedido = null;

            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT * FROM PEDIDOS WHERE id_pedido = @idPedido;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            pedido = new Pedido
                            {
                                Id = reader.GetInt32("id_pedido"),
                                FechaPedido = reader.GetDateTime("fecha_pedido"),
                                IdCajero = reader.GetInt32("id_cajero")
                            };
                        }
                    }
                }
            }

            if (pedido != null)
            {
                pedido.Detalles = ObtenerDetallesPedido(pedido.Id);
            }

            return pedido;
        }

        public List<DetallePedido> ObtenerDetallesPedido(int idPedido)
        {
            List<DetallePedido> detalles = new List<DetallePedido>();

            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT dp.*, p.nombre, p.descripcion, p.precio AS precio_unitario 
                    FROM DETALLE_PEDIDOS dp 
                    JOIN PLATOS p ON dp.id_plato = p.id_plato 
                    WHERE dp.id_pedido = @idPedido;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idPedido", idPedido);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            detalles.Add(new DetallePedido
                            {
                                Id = reader.GetInt32("id_detalle"),
                                Cantidad = reader.GetInt32("cantidad"),
                                Precio = reader.GetDecimal("precio"),
                                IdPedido = reader.GetInt32("id_pedido"),
                                IdPlato = reader.GetInt32("id_plato"),
                                Plato = new Plato
                                {
                                    Id = reader.GetInt32("id_plato"),
                                    Nombre = reader.GetString("nombre"),
                                    Descripcion = reader.GetString("descripcion"),
                                    Precio = reader.GetDecimal("precio_unitario")
                                }
                            });
                        }
                    }
                }
            }

            return detalles;
        }

        public string ObtenerNombreCajeroPorId(int idCajero)
        {
            string nombreCajero = null;

            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "SELECT nombre FROM CAJEROS WHERE id_cajero = @idCajero;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idCajero", idCajero);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            nombreCajero = reader.GetString("nombre");
                        }
                    }
                }
            }

            return nombreCajero;
        }

        public void InsertarFactura(Factura factura)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "INSERT INTO FACTURAS (total, id_pedido) VALUES (@total, @idPedido);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@total", factura.Total);
                    cmd.Parameters.AddWithValue("@idPedido", factura.IdPedido);
                    cmd.ExecuteNonQuery();

                    factura.Id = (int)cmd.LastInsertedId;
                }
            }
        }
    }
}
