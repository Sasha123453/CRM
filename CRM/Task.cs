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

        private string taskname, description, iscompleted;

        public string Taskname { get { return taskname; } set { taskname = value; } }

        public string Description { get { return description; } set { description = value; } }

        public string Iscompleted { get { return iscompleted; } set { iscompleted = value; } }
        public Task() { }
        public Task(string taskname, string description, string iscompleted)
        {
            this.taskname = taskname;
            this.description = description;
            this.iscompleted = iscompleted;
        }
        public override string ToString()
        {
            return id + " Задача: " + Taskname;
        }
    }
}
