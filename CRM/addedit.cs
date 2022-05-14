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
        int flag = 0;
        List<User> userlist =  new List<User>(); 
        User user;
        ApplicationContext db;
        Task ss;
        string maintaskusers = "";
        List<User> taskusers = new List<User>();
        string login;
        public addedit(int id, string mainlogin)
        {
            db = new ApplicationContext();
            InitializeComponent();
            login = mainlogin;
            TaskTab.TabPages.Remove(UsersPage);
            user = db.Users.Where(x => x.Login == login).FirstOrDefault();
            if (user.Role == "normal") allusersbutton.Enabled = false;
            if (id == -1)
            {
                button1.Text = "Добавить";
            }
            else
            {
                ss = db.Tasks.Where(b => b.id == id).FirstOrDefault();
                button1.Text = "Сохранить";
                completebox.Text = ss.Commentary;
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
            if (ss == null)
            {
                Task add = new Task(nametextbox.Text, descbox.Text, 0, maintaskusers, null, user.id.ToString(), null, 0, completebox.Text);
                db.Tasks.Add(add);
            }
            else
            {
                ss.Taskname = nametextbox.Text;
                ss.Description = descbox.Text;
                ss.Users = maintaskusers;
                ss.Commentary = completebox.Text;
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
            if (maintaskusers.Split().Contains("everyone"))
            {
                MessageBox.Show("");
                return;
            }
            TaskTab.TabPages.Add(UsersPage);
            TaskTab.TabPages.Remove(TaskAddPage);
            if (ss != null && ss.Users != null && ss.Users != "")
            {
                string[] l = ss.Users.Split();
                foreach (string s in l) taskusers.Add(db.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
            }
            if (user.Role == "normal")
            {
                string[] l = user.Friends.Split();
                foreach (string s in l) userlist.Add(db.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
            }
            Update();
            DeleteButton.Enabled = false;
        }
        public void GetUsers(List<User> users)
        {

            string l = "";
            for (int i = 0; i < users.Count; i++)
            {
                if (i == users.Count - 1) l += users[i].id.ToString();
                else l += users[i].id.ToString() + " ";
            }
            maintaskusers = l;
        }

        private void allusersbutton_Click(object sender, EventArgs e)
        {
            maintaskusers = "everyone";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GetUsers(taskusers);
            TaskTab.TabPages.Remove(UsersPage);
            TaskTab.TabPages.Add(TaskAddPage);
            taskusers.Clear();
            userlist.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedIndex == -1) return;
            User l = UsersListBox.SelectedItem as User;
            taskusers.Remove(l);
            Update();
        }
        void Update()
        {
            UsersListBox.DataSource = null;
            if (flag == 0)
            {
                if (user.Role == "normal")
                {
                    List<User> list = userlist;
                    if (UsersBox.Text != "") list = list.FindAll(x => x.Login.Contains(UsersBox.Text));
                    list.Remove(user);
                    UsersListBox.DataSource = list;
                    return;
                }
                List<User> users = db.Users.ToList();
                users.Remove(user);
                if (UsersBox.Text != "") users = users.FindAll(x => x.Login.Contains(UsersBox.Text));UsersListBox.DataSource = users;
                UsersListBox.DataSource = users;
            }
            else UsersListBox.DataSource = taskusers;
        }

        private void UsersBox_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedIndex == -1) return;
            User tempuser = UsersListBox.SelectedItem as User;
            if (taskusers.Contains(tempuser)) return;
            taskusers.Add(tempuser);
        }

        private void ShowUser_Click(object sender, EventArgs e)
        {
            flag = 1;
            AddButton.Enabled = false;
            DeleteButton.Enabled = true;
            Update();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            flag = 0;
            AddButton.Enabled = true;
            DeleteButton.Enabled = false;
            Update();
        }

        private void CleanAll_Click(object sender, EventArgs e)
        {
            taskusers.Clear();
            Update();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            TaskTab.TabPages.Remove(UsersPage);
            TaskTab.TabPages.Add(TaskAddPage);
            taskusers.Clear();
            userlist.Clear();
        }

        private void UsersPage_Click(object sender, EventArgs e)
        {

        }

        private void CleanAllUsersButton_Click(object sender, EventArgs e)
        {
            maintaskusers = "";
        }
    }
}
