using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class User
    {
        public int id { get; set; }

        private string login, password, role;

        public string Login { get { return login; } set { login = value; } }

        public string Password { get { return password; } set { password = value; } }
        
        public string Role { get { return role; } set { role = value; } }
        public User() { }
        public User(string login, string password, string role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
        }
        public override string ToString()
        {
            return id + " Логин: " + Login;
        }
    }
}
