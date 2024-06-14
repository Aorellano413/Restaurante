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

        public DataTable ObtenerPedidosConDetalles()
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
            SELECT 
                p.id_pedido AS 'ID Pedido', 
                p.fecha_pedido AS 'Fecha Pedido', 
                p.id_cajero AS 'ID Cajero', 
                dp.cantidad AS 'Cantidad', 
                dp.precio AS 'Precio', 
                pl.nombre AS 'Nombre Plato'
            FROM PEDIDOS p
            JOIN DETALLE_PEDIDOS dp ON p.id_pedido = dp.id_pedido
            JOIN PLATOS pl ON dp.id_plato = pl.id_plato;
        ";
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



        public void ActualizarStockPlato(int idPlato, int cantidad)
        {
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = "UPDATE PLATOS SET stock = stock - @cantidad WHERE id_plato = @idPlato";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idPlato", idPlato);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObtenerPedidosPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
        SELECT 
            p.id_pedido AS 'ID Pedido', 
            p.fecha_pedido AS 'Fecha Pedido', 
            p.id_cajero AS 'ID Cajero', 
            dp.cantidad AS 'Cantidad', 
            dp.precio AS 'Precio', 
            pl.nombre AS 'Nombre Plato'
        FROM PEDIDOS p
        JOIN DETALLE_PEDIDOS dp ON p.id_pedido = dp.id_pedido
        JOIN PLATOS pl ON dp.id_plato = pl.id_plato
        WHERE p.fecha_pedido BETWEEN @fechaInicio AND @fechaFin;
        ";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Date);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Date);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable ObtenerPedidosPorAno(int ano)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection connection = conexion.AbrirConexion())
            {
                string query = @"
                SELECT 
                m.Mes,
                COALESCE(COUNT(p.id_pedido), 0) AS CantidadPedidos,
                COALESCE(SUM(dp.precio), 0) AS TotalDinero
                FROM (
                SELECT 1 AS Mes UNION ALL SELECT 2 UNION ALL SELECT 3 UNION ALL
                SELECT 4 UNION ALL SELECT 5 UNION ALL SELECT 6 UNION ALL
                SELECT 7 UNION ALL SELECT 8 UNION ALL SELECT 9 UNION ALL
                SELECT 10 UNION ALL SELECT 11 UNION ALL SELECT 12
                ) AS m
                LEFT JOIN PEDIDOS p ON m.Mes = MONTH(p.fecha_pedido) AND YEAR(p.fecha_pedido) = @ano
                LEFT JOIN DETALLE_PEDIDOS dp ON p.id_pedido = dp.id_pedido
                GROUP BY m.Mes
                ORDER BY m.Mes;
                ";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ano", ano);
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

