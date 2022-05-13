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
    public partial class usertasks : Form
    {
        List<Task> tasks = new List<Task>();
        User user;
        ApplicationContext db;
        int flag = 0;
        public usertasks(User mainuser)
        {
            InitializeComponent();
            user = mainuser;
            db = new ApplicationContext();
            tasks = db.Tasks.Where(x => x.Author == user.id.ToString()).ToList();
            Update();
        }

        private void usertasks_Load(object sender, EventArgs e)
        {

        }
        void Update()
        {
            tasks = db.Tasks.Where(x => x.Author == user.id.ToString()).ToList();
            if (flag == 0) listBox1.DataSource = tasks;
            if (flag == 1) listBox1.DataSource = tasks.FindAll(x => x.Completed == 1);
            if (flag == 2) listBox1.DataSource = tasks.FindAll(x => x.Completed == 0);

        }

        private void updateall_Click(object sender, EventArgs e)
        {
            flag = 0;
            Update();
        }

        private void updatecompleted_Click(object sender, EventArgs e)
        {
            flag = 1;
            Update();
        }

        private void updatenotcompleted_Click(object sender, EventArgs e)
        {
            flag = 2;
            Update();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Form form = new addedit(-1, user.Login);
            form.ShowDialog();
            Update();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            Task task = listBox1.SelectedItem as Task;
            Form form = new addedit(task.id, user.Login);
            form.ShowDialog();
            Update();
        }
    }
}
