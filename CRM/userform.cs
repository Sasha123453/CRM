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
        User user;
        ApplicationContext db;
        List<Task> tasks;
        public userform(User username)
        {
            InitializeComponent();
            db = new ApplicationContext();
            tasks = new List<Task>();
            user = username;
            MainPage.TabPages.Remove(ChangeData);
            listBox1.DataSource = tasks;
            UserPage.Text = user.Login;
            Update();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Task task = listBox1.SelectedItem as Task;
            MessageBox.Show("Описание: " + task.Description);
        }

        private void userform_Load(object sender, EventArgs e)
        {

        }
        void Update()
        {
            tasks = db.Tasks.ToList();
            tasks = tasks.FindAll(x => x.Completed == 0 && x.Hidden == 0 && x.Users != null && (x.Users.Split().Contains(user.id.ToString()) || x.Users.Split().Contains("everyone")));
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
        }

        private void taskcontrol_Click(object sender, EventArgs e)
        {
            if (user.Friends == "" || user.Friends == null)
            {
                return;
            }
            Form form = new usertasks(user);
            form.ShowDialog();
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
            this.Hide();
            this.Close();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
