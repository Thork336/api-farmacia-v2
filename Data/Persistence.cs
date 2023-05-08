using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace Data
{
    public class Persistence
    {
        MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public bool OpenConnection()
        {
            try
            {
                this.connection.Open();
                return true;
            } 
            catch (MySqlException exception)
            {
                switch (exception.Number)
                {
                    case 0:
                        Console.WriteLine(" Cannot connect to server. Contact adminustrator.");
                        break;
                    case 1045:
                        Console.WriteLine(" Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                this.connection.Close();
                return true;
            }
            catch (MySqlException exceptino)
            {
                Console.WriteLine(exceptino.Message);
                return false;
            }
        }
    }
}