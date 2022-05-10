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
        User user;
        ApplicationContext db;
        Task ss;
        string taskusers;
        string login;
        public addedit(int id, string mainlogin)
        {
            db = new ApplicationContext();
            InitializeComponent();
            login = mainlogin;
            user = db.Users.Where(x => x.Login == login).FirstOrDefault();
            if (id == -1)
            {
                button1.Text = "Добавить";
            }
            else
            {
                ss = db.Tasks.Where(b => b.id == id).FirstOrDefault();
                button1.Text = "Сохранить";
                completebox.Text = ss.Solution;
                nametextbox.Text = ss.Taskname;
                descbox.Text = ss.Description;
            }
        }

        private void addedit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int complete;
            string solution = null;
            if (completebox.Text == "") complete = 0;
            else
            {
                solution = completebox.Text;
                complete = 1;
            }
            if (ss == null)
            {
                Task add = new Task(nametextbox.Text, descbox.Text, complete, taskusers, solution, user.id.ToString(), null);
                db.Tasks.Add(add);
            }
            else
            {
                ss.Taskname = nametextbox.Text;
                ss.Description = descbox.Text;
                ss.Users = taskusers;
                ss.Iscompleted = complete;
                ss.Solution = solution;
            }
            db.SaveChanges();
            this.Hide();
            this.Close();
        }

        private void completebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addusers_Click(object sender, EventArgs e)
        {
            Form form = new Users(ss, 1, login, "");
            form.Owner = this;
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK);
        }
        public void GetUsers(List<User> users)
        {

            string l = "";
            for (int i = 0; i < users.Count; i++)
            {
                if (i == users.Count - 1) l += users[i].id.ToString();
                else l += users[i].id.ToString() + " ";
            }
            taskusers = l;
        }

        private void allusersbutton_Click(object sender, EventArgs e)
        {
            taskusers = "everyone";
        }
    }
}
