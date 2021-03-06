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
    public partial class adminform : Form
    {
        int flag = 0;
        ApplicationContext db;
        List<Task> tasks;
        User User;
        public adminform(int id)
        {
            InitializeComponent();
            db = new ApplicationContext();
            User = db.Users.Where(x => x.id == id).FirstOrDefault();
            AdminPage.Text = User.Login;
            MainPage.TabPages.Remove(UserPage);
            MainPage.TabPages.Remove(ChangeData);
            Update();
            TaskSortBox.SelectedIndex = 0;
        }

        private void userlistbutton_Click(object sender, EventArgs e)
        {
            MainPage.TabPages.Remove(AdminPage);
            MainPage.TabPages.Add(UserPage);
            UpdateUsers();
        }
        void Update()
        {
            listBox1.DataSource = null;
            using (ApplicationContext context = new ApplicationContext()) tasks = context.Tasks.ToList();
            if (flag == 1) tasks = tasks.FindAll(x => x.Completed != 0);
            if (flag == 2) tasks = tasks.FindAll(x => x.Completed == 0);
            listBox1.DataSource= tasks;
        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            if (task.Hidden == 1) deletebutton.Text = "Убрать скрытие";
            else deletebutton.Text = "Скрыть задачу";
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            Form form = new addedit(task.id, User.Login);
            form.ShowDialog();
            Update();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form form = new addedit(-1, User.Login);
            form.ShowDialog();
            Update();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            task = db.Tasks.Where(x => x.id == task.id).FirstOrDefault();
            if (deletebutton.Text == "Убрать скрытие")
            {
                task.Hidden = 0;
            }
            else task.Hidden = 1;
            db.SaveChanges();
            Update();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            if (task.Solution == null) MessageBox.Show("Описание: " + task.Description + "\n Комментарий: " + task.Commentary);
            else MessageBox.Show("Описание: " + task.Description +"\n Комментарий: " + task.Commentary + "\n Решение:" + task.Solution);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            db.Tasks.Remove(db.Tasks.Where(x => x.id == task.id).FirstOrDefault());
            db.SaveChanges();
            Update();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            this.Close();
            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage.TabPages.Remove(AdminPage);
            MainPage.TabPages.Add(ChangeData);
            LoginBox.Text = User.Login;
        }

        private void addfriends_Click(object sender, EventArgs e)
        {
            Form form = new friends(User.id);
            form.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ChangeDataButton_Click(object sender, EventArgs e)
        {
            User checklogin = db.Users.Where(b => b.Login == LoginBox.Text).FirstOrDefault();
            if (checklogin != null)
            {
                MessageBox.Show("Этот логин занят");
                return;
            }
            User.Login = LoginBox.Text;
            if (PassBox.Text != "") User.Password = GetHash(PassBox.Text);
            db.SaveChanges();
            AdminPage.Text = User.Login;
            this.Hide();
            this.Close();
        }

        private void ChangeData_Click(object sender, EventArgs e)
        {

        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainPage.TabPages.Remove(ChangeData);
            MainPage.TabPages.Add(AdminPage);
        }

        private void makeadmin_Click(object sender, EventArgs e)
        {
            if (UsersBox.SelectedIndex == -1) return;
            User user = UsersBox.SelectedItem as User;
            user = db.Users.Where(x => x.id == user.id).FirstOrDefault();
            if (user.Role == "admin" || user.Role == "lowadmin")
            {
                MessageBox.Show("Этот пользователья уже является администратором");
                return;
            }
            user.Role = "lowadmin";
            db.SaveChanges();
            UpdateUsers();
        }

        private void MakeUser_Click(object sender, EventArgs e)
        {
            if (UsersBox.SelectedIndex == -1) return;
            User user = UsersBox.SelectedItem as User;
            user = db.Users.Where(x => x.id == user.id).FirstOrDefault();
            if (User.Role == "lowadmin" && user.Role == "admin")
            {
                MessageBox.Show("Недостаточно прав");
                return;
            }
            user.Role = "normal";
            db.SaveChanges();
            UpdateUsers();
        }

        private void UnbanButton_Click(object sender, EventArgs e)
        {
            if (UsersBox.SelectedIndex == -1) return;
            User user = UsersBox.SelectedItem as User;
            user = db.Users.Where(x => x.id == user.id).FirstOrDefault();
            user.Banned = 0;
            db.SaveChanges();
            UpdateUsers();
        }

        private void BanButton_Click(object sender, EventArgs e)
        {
            if (UsersBox.SelectedIndex == -1) return;
            User user = UsersBox.SelectedItem as User;
            user = db.Users.Where(x => x.id == user.id).FirstOrDefault();
            if (user.Banned == 1)
            {
                MessageBox.Show("Этот пользователь уже забанен");
                return;
            }
            if (user.Role == "admin")
            {
                MessageBox.Show("Вы не можете заблокировать этого пользователя");
                return;
            }
            user.Banned = 1;
            db.SaveChanges();
            UpdateUsers();
        }

        private void UserSearchBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUsers();
        }
        void UpdateUsers()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                List<User> users = context.Users.ToList();
                users.Remove(User);
                if (UserSearchBox.Text != "") users = users.FindAll(x => x.Login.Contains(UserSearchBox.Text));
                if (users.Count > 0) UsersBox.DataSource = users;
            }
        }

        private void UserPage_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainPage.TabPages.Remove(UserPage);
            MainPage.TabPages.Add(AdminPage);
        }

        private void TaskSortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = TaskSortBox.SelectedIndex;
            Update();
        }
    }
}
