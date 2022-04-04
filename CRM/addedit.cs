using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class addedit : Form
    {
        ApplicationContext db;
        Task ss;
        public addedit(Task task)
        {
            db = new ApplicationContext();
            ss = task;
            InitializeComponent();
            if (task == null)
            {
                button1.Text = "Добавить";
            }
            else
            {
                button1.Text = "Сохранить";
                completebox.Text = task.Iscompleted;
                nametextbox.Text = task.Taskname;
                descbox.Text = task.Description;
            }
        }

        private void addedit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string complete;
            if (completebox.Text == "") complete = null;
            else complete = completebox.Text;
            if (ss == null)
            {
                Task add = new Task(nametextbox.Text, descbox.Text, complete);
                db.Tasks.Add(add);
            }
            else
            {
                ss.Taskname = nametextbox.Text;
                ss.Description = descbox.Text;
                ss.Iscompleted = complete;
            }
            db.SaveChanges();
        }

        private void completebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
