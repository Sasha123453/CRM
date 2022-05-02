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

        private string login, password, role, friends, querys;
        
        private int banned;

        public string Login { get { return login; } set { login = value; } }
        public string Querys { get { return querys; } set { querys = value; } }

        public string Password { get { return password; } set { password = value; } }
        
        public string Role { get { return role; } set { role = value; } }
        public string Friends { get { return friends; } set { friends = value; } }
        public int Banned { get { return banned; } set { banned = value; } }
        public User() { }
        public User(string login, string password, string role, string friends, int banned, string querys)
        {
            this.login = login;
            this.password = password;
            this.role = role;
            this.friends = friends;
            this.banned = banned;
            this.querys = querys;
        }
        public override string ToString()
        {
            string l = "";
            if (banned == 1) l = "Заблокирован";
            return $"{id} Логин: {Login} Роль: {role} {l}";
        }
    }
}
