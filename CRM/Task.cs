using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Task
    {
        public int id { get; set; }

        private string taskname, description, users, solution;

        private int iscompleted;

        public string Taskname { get { return taskname; } set { taskname = value; } }

        public string Description { get { return description; } set { description = value; } }

        public int Iscompleted { get { return iscompleted; } set { iscompleted = value; } }

        public string Users { get { return users; } set { users = value; } }

        public string Solution { get { return solution; } set { solution = value; } }
        public Task() { }
        public Task(string taskname, string description, int iscompleted, string users, string solution)
        {
            this.taskname = taskname;
            this.description = description;
            this.iscompleted = iscompleted;
            this.users = users;
            this.solution = solution;
        }
        public override string ToString()
        {
            return id + " Задача: " + Taskname;
        }
    }
}
