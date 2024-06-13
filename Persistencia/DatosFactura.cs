using Entidades; 
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Persistencia
{
    public class DatosFactura
    {
        ConexionDAL conexion = new ConexionDAL();

        // Método para obtener un pedido por su ID
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


        public void InsertarFactura(Factura factura)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"INSERT INTO FACTURAS (fecha_factura, total, id_pedido) 
                                 VALUES (@fechaFactura, @total, @idPedido);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fechaFactura", factura.FechaFactura);
                    cmd.Parameters.AddWithValue("@total", factura.Total);
                    cmd.Parameters.AddWithValue("@idPedido", factura.IdPedido);
                    cmd.ExecuteNonQuery();

                    factura.Id = (int)cmd.LastInsertedId; // Obtener el ID autogenerado
                }
            }
        }


        public List<Pedido> ObtenerPedidosPorRangoFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
                    SELECT * 
                    FROM PEDIDOS 
                    WHERE fecha_pedido BETWEEN @fechaInicio AND @fechaFin;";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pedido pedido = new Pedido
                            {
                                Id = reader.GetInt32("id_pedido"),
                                FechaPedido = reader.GetDateTime("fecha_pedido"),
                                IdCajero = reader.GetInt32("id_cajero")
                            };


                            // pedido.Detalles = ObtenerDetallesPedido(pedido.Id);

                            pedidos.Add(pedido);
                        }
                    }
                }
            }

            return pedidos;
        }
    }
}
