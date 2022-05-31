using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class userform : Form
    {
        int flag = 0;
        User user;
        ApplicationContext db;
        List<TaskUser> tasks = new List<TaskUser>();
        List<Task> ManageTasks = new List<Task>();
        public userform(int id)
        {
            InitializeComponent();
            db = new ApplicationContext();
            user = db.Users.Where(x => x.id == id).FirstOrDefault();
            MainPage.TabPages.Remove(ChangeData);
            MainPage.TabPages.Remove(TaskPage);
            listBox1.DataSource = tasks;
            UserPage.Text = user.Login;
            Update();
        }

        private void userform_Load(object sender, EventArgs e)
        {

        }
        void Update()
        {
            listBox1.DataSource = null;
            using (ApplicationContext context = new ApplicationContext()) tasks = context.TaskUsers.ToList();
            tasks = tasks.FindAll(x => x.UserId == user.id || x.UserId == -1);
            List<Task> y = new List<Task>();
            foreach (TaskUser task in tasks)
            {
                MessageBox.Show(task.TaskId.ToString());
                Task task2 = db.Tasks.Where(x => x.id == task.TaskId).FirstOrDefault();
                y.Add(task2);
            }
            y = y.FindAll(x => x.Hidden == 0 && x.Completed == 0);
            listBox1.DataSource = y;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void solutionbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            task.Completed = 1;
            task.Solution = richTextBox1.Text;
            db.SaveChanges();
            Update();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            this.Close();
            this.Hide();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage.TabPages.Remove(UserPage);
            MainPage.TabPages.Add(ChangeData);
            LoginBox.Text = user.Login;
        }

        private void addfriends_Click(object sender, EventArgs e)
        {
            Form form = new friends(user.id);
            form.ShowDialog();
            using (ApplicationContext context = new ApplicationContext()) user = context.Users.Where(x => user.id == x.id).FirstOrDefault();
            UserPage.Text = user.Login;
        }

        private void taskcontrol_Click(object sender, EventArgs e)
        {
            UserFriend checkFriend = db.UserFriends.Where(x => x.FirstUserId == user.id).FirstOrDefault();
            if (checkFriend == null) return;
            MainPage.TabPages.Remove(UserPage);
            MainPage.TabPages.Add(TaskPage);
            ManageTasks = db.Tasks.Where(x => x.Author == user.id.ToString()).ToList();
            TaskSortBox.SelectedIndex = 0;
            UpdateTask();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BackDataButton_Click(object sender, EventArgs e)
        {
            MainPage.TabPages.Remove(ChangeData);
            MainPage.TabPages.Add(UserPage);
        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            User checklogin = db.Users.Where(b => b.Login == LoginBox.Text).FirstOrDefault();
            if (checklogin != null)
            {
                MessageBox.Show("Этот логин занят");
                return;
            }
            user.Login = LoginBox.Text;
            if (PassBox.Text != "") user.Password = GetHash(PassBox.Text);
            db.SaveChanges();
            UserPage.Text = user.Login;
            MainPage.TabPages.Remove(ChangeData);
            MainPage.TabPages.Add(UserPage);

        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        void UpdateTask()
        {
            using (ApplicationContext context = new ApplicationContext()) ManageTasks = context.Tasks.Where(x => x.Author == user.id.ToString()).ToList();
            if (flag == 0) TaskListBox.DataSource = ManageTasks;
            if (flag == 1) TaskListBox.DataSource = ManageTasks.FindAll(x => x.Completed == 1);
            if (flag == 2) TaskListBox.DataSource = ManageTasks.FindAll(x => x.Completed == 0);
        }

        private void TaskListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            if (task.Solution == null) MessageBox.Show("Описание: " + task.Description + "\n Комментарий: " + task.Commentary);
            else MessageBox.Show("Описание: " + task.Description + "\n Комментарий: " + task.Commentary + "\n Решение:" + task.Solution);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form form = new addedit(-1, user.Login);
            form.ShowDialog();
            UpdateTask();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            Form form = new addedit(task.id, user.Login);
            form.ShowDialog();
            UpdateTask();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            task = db.Tasks.Where(x => x.id == task.id).FirstOrDefault();
            if (CheckButton.Text == "Убрать скрытие")
            {
                task.Hidden = 0;
            }
            else task.Hidden = 1;
            db.SaveChanges();
            UpdateTask();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            db.Tasks.Remove(task);
            db.SaveChanges();
            UpdateTask();
        }

        private void UpdateNotCompleted_Click(object sender, EventArgs e)
        {
            flag = 2;
            UpdateTask();
        }

        private void TaskBackButton_Click(object sender, EventArgs e)
        {
            MainPage.TabPages.Remove(TaskPage);
            MainPage.TabPages.Add(UserPage);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            MessageBox.Show("Описание: " + task.Description + "\n Комментарий: " + task.Commentary);
        }

        private void UnhideButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            task.Hidden = 0;
            db.SaveChanges();
            UpdateTask();
        }

        private void TaskPage_Click(object sender, EventArgs e)
        {

        }

        private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            if (task.Hidden == 1) CheckButton.Text = "Убрать скрытие";
            else CheckButton.Text = "Скрыть задачу";
        }

        private void TaskSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = TaskSortBox.SelectedIndex;
            UpdateTask();
        }
    }
}
