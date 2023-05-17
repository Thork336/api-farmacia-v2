using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Data.Driver
{
    public class DriverRepository
    {
        public DataSet list()
        {
            Persistence connection = new Persistence();
            DataSet data = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procSelectDriver";
            command.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand = command;
            adapter.Fill(data);
            
            connection.CloseConnection();
            return data;
        }

        public bool update(int id_driver, int identification_driver, string numberLicence_driver,
            string name_driver, string surname_driver, string phone_driver, int age_driver, string gender_driver,
            string type_license)
        {
            Persistence connection = new Persistence();
            //DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
       
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procUpdateDriver";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id_conductor", MySqlDbType.Int24).Value = id_driver;
            command.Parameters.Add("cedula_cond", MySqlDbType.Int24).Value = identification_driver;
            command.Parameters.Add("numLicencia_cond", MySqlDbType.Text).Value = numberLicence_driver;
            command.Parameters.Add("nombre_cond", MySqlDbType.Text).Value = name_driver;
            command.Parameters.Add("apellido_cond", MySqlDbType.Text).Value = surname_driver;
            command.Parameters.Add("telefono_cond", MySqlDbType.Text).Value = phone_driver;
            command.Parameters.Add("edad_cond", MySqlDbType.Int24).Value = age_driver;
            command.Parameters.Add("genero_cond", MySqlDbType.Text).Value = gender_driver;
            command.Parameters.Add("tipoLicencia_cond", MySqlDbType.Text).Value = type_license;
            //adapter.SelectCommand = command;
            //adapter.Fill(data);

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
                Console.WriteLine("Error" + e.ToString()); ;
            }
            
            connection.CloseConnection();
            return executed;
        }

        public bool insert(int identification_driver, string numberLicence_driver,
            string name_driver, string surname_driver, string phone_driver, int age_driver, string gender_driver,
            string type_license)
        {
            Persistence connection = new Persistence();
            //DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procInsertDriver";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("cedula_cond", MySqlDbType.Int24).Value = identification_driver;
            command.Parameters.Add("numLicencia_cond", MySqlDbType.Text).Value = numberLicence_driver;
            command.Parameters.Add("nombre_cond", MySqlDbType.Text).Value = name_driver;
            command.Parameters.Add("apellido_cond", MySqlDbType.Text).Value = surname_driver;
            command.Parameters.Add("telefono_cond", MySqlDbType.Text).Value = phone_driver;
            command.Parameters.Add("edad_cond", MySqlDbType.Int24).Value = age_driver;
            command.Parameters.Add("genero_cond", MySqlDbType.Text).Value = gender_driver;
            command.Parameters.Add("tipoLicencia_cond", MySqlDbType.Text).Value = type_license;
            adapter.SelectCommand = command;
            //adapter.Fill(data);

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

        public bool delete(int id_driver)
        {
            Persistence connection = new Persistence();
            DataSet data = new DataSet();
            int row = 0;
            bool executed = false;
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection.OpenConnection();
            command.CommandText = "procDeleteDriver";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("id_driver", MySqlDbType.Int24).Value = id_driver;

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