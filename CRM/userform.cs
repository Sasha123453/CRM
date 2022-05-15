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
        List<Task> tasks = new List<Task>();
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
            tasks = db.Tasks.ToList();
            tasks = tasks.FindAll(x => x.Completed == 0 && x.Hidden == 0 && x.Users != null);
            tasks = tasks.FindAll(x => x.Users.Split().Contains(user.id.ToString()) || x.Users.Split().Contains("everyone"));
            listBox1.DataSource = tasks;
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
            user = db.Users.Where(x => user.id == x.id).FirstOrDefault();
        }

        private void taskcontrol_Click(object sender, EventArgs e)
        {
            if (user.Friends == "" || user.Friends == null)
            {
                return;
            }
            MainPage.TabPages.Remove(UserPage);
            MainPage.TabPages.Add(TaskPage);
            ManageTasks = db.Tasks.Where(x => x.Author == user.id.ToString()).ToList();
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
            MessageBox.Show(user.Login);
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
            ManageTasks = db.Tasks.Where(x => x.Author == user.id.ToString()).ToList();
            if (flag == 0) TaskListBox.DataSource = ManageTasks;
            if (flag == 1) TaskListBox.DataSource = ManageTasks.FindAll(x => x.Completed == 1);
            if (flag == 2) TaskListBox.DataSource = ManageTasks.FindAll(x => x.Completed == 0);
        }

        private void TaskListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            MessageBox.Show("Описание: " + task.Description + "\n Комментарий: " + task.Commentary);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Form form = new addedit(-1, user.Login);
            form.ShowDialog();
            UpdateTask();
        }

        private void UpdateAll_Click(object sender, EventArgs e)
        {
            flag = 0;
            UpdateTask();
        }

        private void UpdateCompleted_Click(object sender, EventArgs e)
        {
            flag = 1;
            UpdateTask();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            Form form = new addedit(task.id, user.Login);
            form.ShowDialog();
            Update();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            task.Hidden = 1;
            db.SaveChanges();
            UpdateTask();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;
            Task task = TaskListBox.SelectedItem as Task;
            db.Tasks.Remove(task);
            db.SaveChanges();
            Update();
        }

        private void UpdateNotCompleted_Click(object sender, EventArgs e)
        {
            flag = 2;
            Update();
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
            if (CheckButton.Text == "Убрать скрытие")
            {
                task.Hidden = 0;
            }
            else task.Hidden = 1;
            db.SaveChanges();
            Update();
        }
    }
}
