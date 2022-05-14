using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Task
    {
        public int id { get; set; }

        private string taskname, description, users, solution, author, deadline, commentary;

        private int completed, hidden;

        public string Taskname { get { return taskname; } set { taskname = value; } }
        public string Commentary { get { return commentary; } set { commentary = value; } }
        public string Deadline { get { return deadline; } set { deadline = value; } }
        public int Hidden { get { return hidden; } set { hidden = value; } }

        public string Description { get { return description; } set { description = value; } }

        public int Completed { get { return completed; } set { completed = value; } }

        public string Users { get { return users; } set { users = value; } }
        public string Author { get { return author; } set { author = value; } }

        public string Solution { get { return solution; } set { solution = value; } }
        public Task() { }
        public Task(string taskname, string description, int completed, string users, string solution, string author, string deadline, int hidden, string commentary)
        {
            this.taskname = taskname;
            this.description = description;
            this.completed = completed;
            this.users = users;
            this.solution = solution;
            this.author = author;
            this.deadline = deadline;
            this.hidden = hidden;
            this.commentary = commentary;
        }
        public override string ToString()
        {
            string l = "";
            if (hidden == 1) l = "Скрыта";
            ApplicationContext db = new ApplicationContext();
            User user = db.Users.Where(x => x.id.ToString() == author).FirstOrDefault();
            return $"{l} {user.Login}: {Taskname}";
        }
    }
}
