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
        public adminform(User user)
        {
            InitializeComponent();
            db = new ApplicationContext();
            label1.Text = user.Login;
            Update();
        }

        private void userlistbutton_Click(object sender, EventArgs e)
        {
            Form form = new Users();
            form.ShowDialog();
        }
        void Update()
        {
            tasks = db.Tasks.ToList();
            if (flag == 1) tasks = tasks.FindAll(x => x.Iscompleted != null);
            if (flag == 2) tasks = tasks.FindAll(x => x.Iscompleted == null);
            listBox1.DataSource = tasks;
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
            Form form = new addedit(task);
            form.ShowDialog();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form form = new addedit(null);
            form.ShowDialog();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            task.Iscompleted = "";
            db.SaveChanges();
            Update();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Task task = listBox1.SelectedItem as Task;
            MessageBox.Show("Описание: " + task.Description);
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
    }
}
