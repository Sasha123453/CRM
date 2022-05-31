using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class TaskUser
    {
        public int id { get; set; }

        private int taskid, userid;
        public int TaskId { get { return taskid; } set { taskid = value; } }

        public int UserId { get { return userid; } set { userid = value; } }

        public TaskUser() { }
        public TaskUser(int taskid, int userid)
        {
            this.taskid = taskid;
            this.userid = userid;
        }
        public override string ToString()
        {
            ApplicationContext db = new ApplicationContext();
            User user = db.Users.Where(x => x.id == userid).FirstOrDefault();
            string l = "";
            if (user.Banned == 1) l = "Заблокирован";
            return $"{user.id} Логин: {user.Login} Роль: {user.Role} {l}";
        }
    }
}
