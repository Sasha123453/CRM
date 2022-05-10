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

        private string taskname, description, users, solution, author, deadline;

        private int iscompleted;

        public string Taskname { get { return taskname; } set { taskname = value; } }
        public string Deadline { get { return deadline; } set { deadline = value; } }

        public string Description { get { return description; } set { description = value; } }

        public int Iscompleted { get { return iscompleted; } set { iscompleted = value; } }

        public string Users { get { return users; } set { users = value; } }
        public string Author { get { return author; } set { author = value; } }

        public string Solution { get { return solution; } set { solution = value; } }
        public Task() { }
        public Task(string taskname, string description, int iscompleted, string users, string solution, string author, string deadline)
        {
            this.taskname = taskname;
            this.description = description;
            this.iscompleted = iscompleted;
            this.users = users;
            this.solution = solution;
            this.author = author;
            this.deadline = deadline;
        }
        public override string ToString()
        {
            return $"{id} {author}: {Taskname}";
        }
    }
}
