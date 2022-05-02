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
    public partial class userform : Form
    {
        User user;
        ApplicationContext db;
        List<Task> tasks;
        public userform(User username)
        {
            InitializeComponent();
            label1.Text = username.Login;
            db = new ApplicationContext();
            tasks = new List<Task>();
            user = username;
            listBox1.DataSource = tasks;
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
            tasks = tasks.FindAll(x => x.Iscompleted == 0 && (x.Users.Split().Contains(user.Login) || x.Users.Split().Contains("everyone")));
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
            task.Iscompleted = 1;
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
            Form form = new changepass(user.id);
            form.ShowDialog();
        }

        private void addfriends_Click(object sender, EventArgs e)
        {
            Form form = new friends(user.id);
            form.ShowDialog();
        }
    }
}
