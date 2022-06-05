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
        User user;
        ApplicationContext db;
        Task ss;
        string maintaskusers = "";
        List<TaskUser> taskusers = new List<TaskUser>();
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
                db.SaveChanges();
                foreach (TaskUser x in taskusers)
                {
                    x.TaskId = add.id;
                    db.TaskUsers.Add(x);
                }
            }
            else
            {
                ss.Taskname = nametextbox.Text;
                ss.Description = descbox.Text;
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
            TaskSortBox.SelectedIndex = 0;
            if (ss != null)
            {
                TaskUser check = db.TaskUsers.Where(x => x.TaskId == ss.id && x.UserId == -1).FirstOrDefault();
                TaskUser check2 = taskusers.Where(x => x.UserId== -1).FirstOrDefault();
                if (check != null || check2 != null) return;
            }
            flag = 0;
            TaskTab.TabPages.Add(UsersPage);
            TaskTab.TabPages.Remove(TaskAddPage);
            if (ss != null) taskusers = db.TaskUsers.Where(x => x.TaskId == ss.id).ToList();
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
            Clean();
            TaskUser checklist = taskusers.Where(x => x.UserId == -1).FirstOrDefault();
            TaskUser checkdb = null;
            if (ss != null) checkdb = db.TaskUsers.Where(x => x.TaskId == ss.id && x.UserId == -1).FirstOrDefault();
            if (checkdb != null || checklist != null) return;
            TaskUser add = new TaskUser(-1, -1);
            if (ss != null)
            {
                add.TaskId = ss.id;
                db.TaskUsers.Add(add);
            }
            taskusers.Add(add);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TaskTab.TabPages.Remove(UsersPage);
            TaskTab.TabPages.Add(TaskAddPage);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedIndex == -1) return;
            TaskUser l = UsersListBox.SelectedItem as TaskUser;
            if (ss != null) db.TaskUsers.Remove(l);
            taskusers.Remove(l);
            Update();
        }
        void Update()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                UsersListBox.DataSource = null;
                if (flag == 0)
                {
                    if (user.Role == "normal")
                    {
                        List<UserFriend> userFriends = context.UserFriends.Where(x => x.FirstUserId == user.id).ToList();
                        List<User> friends = FindFriends(userFriends);
                        UsersListBox.DataSource = friends;
                    }
                    else
                    {
                        List<User> allUsers = context.Users.ToList();
                        if (UsersBox.Text != "") allUsers = allUsers.FindAll(x => x.Login.Contains(UsersBox.Text));
                        allUsers.Remove(context.Users.Where(x => x.id == user.id).FirstOrDefault());
                        UsersListBox.DataSource = allUsers;
                    }
                }
                else UsersListBox.DataSource = taskusers;
            }
        }
        List<User> FindFriends(List<UserFriend> userFriends)
        {
            List<User> users = new List<User>();
            foreach (UserFriend friend in userFriends)
            {
                User f = db.Users.Where(x => x.id == friend.SecondUserId).FirstOrDefault();
                users.Add(f);
            }
            return users;
        }

        private void UsersBox_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (UsersListBox.SelectedIndex == -1) return;
            User tempuser = UsersListBox.SelectedItem as User;
            if (taskusers.Where(x => x.UserId == tempuser.id).FirstOrDefault() != null) return;
            TaskUser task = new TaskUser(-1, tempuser.id);
            if (ss != null)
            {
                task.TaskId = ss.id;
                db.TaskUsers.Add(task);
            }
            taskusers.Add(task);
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
        }

        private void UsersPage_Click(object sender, EventArgs e)
        {

        }

        private void CleanAllUsersButton_Click(object sender, EventArgs e)
        {
            Clean();
        }
        void Clean()
        {
            if (ss == null) return;
            List<TaskUser> list = db.TaskUsers.Where(x => x.TaskId == ss.id).ToList();
            foreach (TaskUser y in list) db.TaskUsers.Remove(db.TaskUsers.Where(x => x.id == y.id).FirstOrDefault());
            db.SaveChanges();
        }

        private void TaskSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaskSortBox.SelectedIndex == 0)
            {
                flag = 0;
                AddButton.Enabled = true;
                DeleteButton.Enabled = false;
                Update();
            }
            else
            {
                flag = 1;
                AddButton.Enabled = false;
                DeleteButton.Enabled = true;
                Update();
            }
        }
    }
}
