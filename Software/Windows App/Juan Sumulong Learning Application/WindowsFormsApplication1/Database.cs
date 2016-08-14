using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace juan_sumulong_learning_app
{
    public static class Database
    {
        private static MySqlConnection connection = new MySqlConnection("datasource=localhost; Database=jsla; username=root;");

        public static MySqlConnection Connector
        {
            get
            {
                return connection;
            }
        }

        public static void Open()
        {
            Connector.Open();
        }
        public static void Close()
        {
            Connector.Close();
        }
        public static Boolean IsOpen
        {
            get
            {
                return connection.State == System.Data.ConnectionState.Open;
            }
        }
    }
}
