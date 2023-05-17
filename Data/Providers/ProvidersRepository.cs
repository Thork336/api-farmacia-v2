using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Data.Providers
{
    public class ProvidersRepository
    {
        public DataSet list()
        {
            Persistence connection = new Persistence();
            DataSet data = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procSelectProvider";
            command.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = command;
            adapter.Fill(data);
            
            connection.CloseConnection();
            return data;
        }

        public bool update(int id_provider, int nit_provider, string name_provider, string city_provider)
        {
            Persistence connection = new Persistence();
            //DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procUpdateProvider";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id_provider", MySqlDbType.Int24).Value = id_provider;
            command.Parameters.Add("nit_provider", MySqlDbType.Int24).Value = nit_provider;
            command.Parameters.Add("name_provider", MySqlDbType.Text).Value = name_provider;
            command.Parameters.Add("city_provider", MySqlDbType.Text).Value = city_provider;
            adapter.SelectCommand = command;
            //adapter.Fill(data);
            row = command.ExecuteNonQuery();
            if (row == 1)
            {
                executed = true;
            }
            
            connection.CloseConnection();
            return executed;
        }

        public bool insert(int nit_provider, string name_provider, string city_provider)
        {
            Persistence connection = new Persistence();
           // DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procInsertProvider";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("nit_provider", MySqlDbType.Int24).Value = nit_provider;
            command.Parameters.Add("name_provider", MySqlDbType.Text).Value = name_provider;
            command.Parameters.Add("city_provider", MySqlDbType.Text).Value = city_provider;
            adapter.SelectCommand = command;
            // adapter.Fill(data);
            try
            {
                row = command.ExecuteNonQuery();

                if (row == 1)
                {
                    executed = true;
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine("Error" + e.ToString());
            }
            
            
            connection.CloseConnection();
            return executed;
        }

        public bool delete(int id_provider)
        {
            Persistence connection = new Persistence();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procDeleteProvider";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id_provider", MySqlDbType.Int24).Value = id_provider;

            adapter.SelectCommand = command;
            adapter.Fill(data);
            row = command.ExecuteNonQuery();
            if (row == 0)
            {
                executed = true;
            }
            
            connection.CloseConnection();
            return executed;
        }
    }
}