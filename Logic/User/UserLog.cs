using Data.User;
using Model;
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
        public bool saveUser(string _mail_user, string _password_user, string _salt_user, string _state_user)
        {
            return objUser.saveUser(_mail_user, _password_user, _salt_user, _state_user);
        }
        public bool updateUser(int _id_user, string _mail_user, string _password_user, string _salt_user, string _state_user)
        {
            return objUser.updateUser(_id_user, _mail_user, _password_user, _salt_user, _state_user);
        }
        //Metodo para mostrar el Usuarios pasandole el correo
        public User1 ShowUsersMail(string mail)
        {
            return objUser.ShowUsersMail(mail);
        }
        public bool deleteUser(int _id_user)
        {
            return objUser.deleteUser(_id_user);
        }
    }
}
