using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model
{
    public class User1
    {
        private string correo;
        private string contrasena;
        private string salt;
        private string state;
        public string Correo { get => correo; set => correo = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public string Salt { get => salt; set => salt = value; }
        public string State { get => state; set => state = value; }
        public User1(string correo, string contrasena, string salt, string state)
        {
            this.correo = correo;
            this.contrasena = contrasena;
            this.salt = salt;
            this.state = state;
        }
        public User1()
        {
        }
    }
}