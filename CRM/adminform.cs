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
    public partial class adminform : Form
    {
        int flag = 0;
        ApplicationContext db;
        List<Task> tasks;
        User user;
        public adminform(User mainuser)
        {
            InitializeComponent();
            db = new ApplicationContext();
            user = mainuser;
            label1.Text = user.Login;
            Update();
        }

        private void userlistbutton_Click(object sender, EventArgs e)
        {
            Form form = new Users(null, 0, null, user.Role);
            form.ShowDialog();
        }
        void Update()
        {
            tasks = db.Tasks.ToList();
            if (flag == 1) tasks = tasks.FindAll(x => x.Iscompleted != 0);
            if (flag == 2) tasks = tasks.FindAll(x => x.Iscompleted == 0);
            listBox1.DataSource= tasks;
        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            Form form = new addedit(task.id, user.Login);
            form.ShowDialog();
            Update();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form form = new addedit(-1, user.Login);
            form.ShowDialog();
            Update();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            task.Iscompleted = 1;
            db.SaveChanges();
            Update();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Task task = listBox1.SelectedItem as Task;
            MessageBox.Show("Описание: " + task.Description +"\n Пльзователи: " + task.Users);
        }

        private void buttoncomplete_Click(object sender, EventArgs e)
        {
            flag = 1;
            Update();
        }

        private void buttonnotcomplete_Click(object sender, EventArgs e)
        {
            flag = 2;
            Update();
        }

        private void buttonshowall_Click(object sender, EventArgs e)
        {
            flag = 0;
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            db.Tasks.Remove(task);
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
