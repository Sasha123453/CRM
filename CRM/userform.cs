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
        ApplicationContext db;
        List<Task> tasks;
        public userform(User user)
        {
            InitializeComponent();
            label1.Text = user.Login;
            db = new ApplicationContext();
            tasks = new List<Task>();
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
            tasks = tasks.FindAll(x => x.Iscompleted == null);
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
            task.Iscompleted = richTextBox1.Text;
            Update();
        }
    }
}
