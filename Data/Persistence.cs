using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace Data
{
    public class Persistence
    {
        MySqlConnection _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public MySqlConnection OpenConnection()
        {

            try
            {
                _connection.Open();
                return _connection;
            }
            catch (Exception e)
            {
                e.ToString();
                return null;
            }
        }

        public void CloseConnection()
        {
            _connection.Close();
        }
    }
}