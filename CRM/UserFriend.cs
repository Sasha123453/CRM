using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class UserFriend
    {
        public int id { get; set; }

        private int firstuserid, seconduserid;
        public int FirstUserId { get { return firstuserid; } set { seconduserid = value; } }

        public int SecondUserId { get { return seconduserid; } set { seconduserid = value; } }

        public UserFriend() { }
        public UserFriend(int firstuserid, int seconduserid)
        {
            this.firstuserid = firstuserid;
            this.seconduserid = seconduserid;
        }
        public override string ToString()
        {
            ApplicationContext db = new ApplicationContext();
            User user = db.Users.Where(x => x.id == seconduserid).FirstOrDefault();
            string l = "";
            if (user.Banned == 1) l = "Заблокирован";
            return $"{user.id} Логин: {user.Login} Роль: {user.Role} {l}";
        }
    }
}
