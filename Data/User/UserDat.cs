using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using MySql.Data.MySqlClient;

namespace Data.User
{
    public class UserDat
    {
        Persistence objPer = new Persistence();
        public DataSet showUser()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procSelectUser";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.CloseConnection();
            return objData;
        }

        public bool saveUser(string _mail_user, int _password_user, string _type_user)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procInsertUser"; //Nombre del procedimiento almacenado.
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("mail_user", MySqlDbType.VarString).Value = _mail_user;
            objSelectCmd.Parameters.Add("password_user", MySqlDbType.Int32).Value = _password_user;
            objSelectCmd.Parameters.Add("type_user", MySqlDbType.VarString).Value = _type_user;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.CloseConnection();
            return executed;
        }

        public bool updateUser(int _id_user, string _mail_user, int _password_user, string _type_user)
        {
            bool execute = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procUpdateUser";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_user", MySqlDbType.Int32).Value = _id_user;
            objSelectCmd.Parameters.Add("mail_user", MySqlDbType.VarString).Value = _mail_user;
            objSelectCmd.Parameters.Add("password_user", MySqlDbType.Int32).Value = _password_user;
            objSelectCmd.Parameters.Add("type_user", MySqlDbType.VarString).Value = _type_user;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    execute = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.CloseConnection();
            return execute;
        }

        public bool deleteUser(int _id_user)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procDeleteUser";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("p_id_country", MySqlDbType.Int32).Value = _id_user;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.CloseConnection();
            return executed;
        }

    }
}
