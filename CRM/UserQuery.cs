using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class UserQuery
    {
        public int id { get; set; }

        private int senderid, targetid;
        public int SenderId { get { return senderid; } set { senderid = value; } }

        public int TargetId { get { return targetid; } set { targetid = value; } }

        public UserQuery() { }
        public UserQuery(int senderid, int targetid)
        {
            this.senderid = senderid;
            this.targetid = targetid;
        }
        public override string ToString()
        {
            ApplicationContext db = new ApplicationContext();
            User user = db.Users.Where(x => x.id == senderid).FirstOrDefault();
            string l = "";
            if (user.Banned == 1) l = "Заблокирован";
            return $"{user.id} Логин: {user.Login} Роль: {user.Role} {l}";
        }
    }
}
