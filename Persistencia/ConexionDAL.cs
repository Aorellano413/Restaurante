﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class ConexionDAL
    {
        private string connectionString;

        public ConexionDAL()
        {
            connectionString = "server=localhost;database=restaurante;uid=root;pwd=andres0509;";
        }

        public MySqlConnection AbrirConexion()
        {
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void CerrarConexion(MySqlConnection connection)
        {
            connection.Close();
        }
    }
}
