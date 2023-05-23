using Data.User;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.User
{
    public class UserLog
    {
        UserDat objUser = new UserDat();

        public DataSet showUser()
        {
            return objUser.showUser();
        }
        public bool saveUser(string _mail_user, int _password_user, string _type_user)
        {
            return objUser.saveUser(_mail_user, _password_user, _type_user);
        }
        public bool updateUser(int _id_user, string _mail_user, int _password_user, string _type_user)
        {
            return objUser.updateUser(_id_user, _mail_user, _password_user, _type_user);
        }
        public bool deleteUser(int _id_user)
        {
            return objUser.deleteUser(_id_user);
        }
    }
}
