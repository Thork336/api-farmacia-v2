using MySql.Data.MySqlClient;
using System.Data;

namespace Data.Send {

    public class SendRepository {

        public DataSet list() {
            Persistence connection = new Persistence();
            DataSet data = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procSelectShipping";
            command.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = command;
            adapter.Fill(data);
            
            connection.CloseConnection();
            return data;
        }

        public bool updatde(int id_shipping, int number_shipping, string address_shipping, string phone_shipping, int id_driver) {
            Persistence connection = new Persistence();
            //DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procUpdatetShipping";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id_shipping", MySqlDbType.Int24).Value = id_shipping;
            command.Parameters.Add("number_shipping", MySqlDbType.Int24).Value = number_shipping;
            command.Parameters.Add("address_shipping", MySqlDbType.VarString).Value = address_shipping;
            command.Parameters.Add("phone_shipping", MySqlDbType.VarString).Value = phone_shipping;
            command.Parameters.Add("id_driver", MySqlDbType.Int24).Value = id_driver;
            adapter.SelectCommand = command;
            //adapter.Fill(data);
            row = command.ExecuteNonQuery();
            if (row == 1) { 
                executed = true;
            }
            
            connection.CloseConnection();
            return executed;
        }

        public bool insert(int number_shipping, string address_shipping, string phone_shipping, int id_driver)
        {
            Persistence connection = new Persistence();
            int row = 0;
            bool executed = false;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procInsertShipping";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("number_shipping", MySqlDbType.Int24).Value = number_shipping;
            command.Parameters.Add("address_shipping", MySqlDbType.Text).Value = address_shipping;
            command.Parameters.Add("phone_shipping", MySqlDbType.Text).Value = phone_shipping;
            command.Parameters.Add("id_driver", MySqlDbType.Int24).Value = id_driver;
            adapter.SelectCommand = command;
            row = command.ExecuteNonQuery();
            if (row == 1)
            {
                executed = true;
            }
            
            connection.CloseConnection();
            return executed;
        }

        public bool delete(int id_shipping)
        {
            Persistence connection = new Persistence();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procDeleteShipping";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id_shipping", MySqlDbType.Int24).Value = id_shipping;
               
            adapter.SelectCommand = command;
            adapter.Fill(data);
            row = command.ExecuteNonQuery();
            if (row == 1)
            {
                executed = true;
            }
            
            connection.CloseConnection();
            return executed;
        }
    }
}