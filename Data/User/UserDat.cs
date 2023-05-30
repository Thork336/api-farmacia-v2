using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using MySql.Data.MySqlClient;
using Model;

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

        public bool saveUser(string _mail_user, string _password_user, string _salt_user, string _state_user)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procInsertUser"; //Nombre del procedimiento almacenado.
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("mail_user", MySqlDbType.VarString).Value = _mail_user;
            objSelectCmd.Parameters.Add("password_user", MySqlDbType.VarString).Value = _password_user;
            objSelectCmd.Parameters.Add("salt_user", MySqlDbType.VarString).Value = _salt_user;
            objSelectCmd.Parameters.Add("state_user", MySqlDbType.VarString).Value = _state_user;

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

        public bool updateUser(int _id_user, string _mail_user, string _password_user, string _salt_user, string _state_user)
        {
            bool execute = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procUpdateUser";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_user", MySqlDbType.Int32).Value = _id_user;
            objSelectCmd.Parameters.Add("mail_user", MySqlDbType.VarString).Value = _mail_user;
            objSelectCmd.Parameters.Add("password_user", MySqlDbType.VarString).Value = _password_user;
            objSelectCmd.Parameters.Add("salt_user", MySqlDbType.VarString).Value = _salt_user;
            objSelectCmd.Parameters.Add("state_user", MySqlDbType.VarString).Value = _state_user;

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
        public User1 ShowUsersMail(string mail)
        {
            User1 objUser = null;
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "spSelectUsersMail";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("p_mail", MySqlDbType.VarString).Value = mail;
            MySqlDataReader reader = objSelectCmd.ExecuteReader();
            if (!reader.HasRows)
            {
                return objUser;
            }
            else
            {
                while (reader.Read())
                {
                    objUser = new User1(reader["correo_us"].ToString(),
                    reader["contrasena_us"].ToString(), reader["salt_us"].ToString(),
                    reader["estado_us"].ToString());
                }
            }
            objPer.CloseConnection();
            return objUser;
        }
        //Metodo para mostrar el Usuarios por correo
        
        public bool deleteUser(int _id_user)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.OpenConnection();
            objSelectCmd.CommandText = "procDeleteUser";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("id_user", MySqlDbType.Int32).Value = _id_user;

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
