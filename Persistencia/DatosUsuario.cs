using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;


namespace Persistencia
{
    public class DatosUsuario
    {
        private ConexionDAL conexionDAL = new ConexionDAL();

        public Administrador ObtenerAdministrador(string usuario, string contra)
        {
            using (var connection = conexionDAL.AbrirConexion())
            {
                string query = "SELECT * FROM ADMINISTRADORES WHERE usuario = @usuario AND contra = @contra";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contra", contra);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Administrador
                        {
                            Id = reader.GetInt32("id_admin"),
                            Usuario = reader.GetString("usuario"),
                            Contra = reader.GetString("contra")
                        };
                    }
                }
            }
            return null;
        }

        public Cajero ObtenerCajero(string usuario, string contra)
        {
            using (var connection = conexionDAL.AbrirConexion())
            {
                string query = "SELECT * FROM CAJEROS WHERE usuario = @usuario AND contra = @contra";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contra", contra);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Cajero
                        {
                            Id = reader.GetInt32("id_cajero"),
                            Usuario = reader.GetString("usuario"),
                            Contra = reader.GetString("contra")
                        };
                    }
                }
            }
            return null;
        }
    }
}
