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
                string query = "INSERT INTO DETALLE_PEDIDOS (cantidad, precio, id_pedido, id_plato) VALUES (@cantidad, @precio, @idPedido, @idPlato);";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmd.Parameters.AddWithValue("@precio", detalle.Precio);
                    cmd.Parameters.AddWithValue("@idPedido", detalle.IdPedido);
                    cmd.Parameters.AddWithValue("@idPlato", detalle.IdPlato);
                    cmd.ExecuteNonQuery();
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
                string query = "SELECT * FROM DETALLE_PEDIDOS WHERE id_pedido = @idPedido;";
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
