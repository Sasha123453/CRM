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
    public partial class Users : Form
    {
        Task task;
        ApplicationContext db;
        int flag = 0;
        List<User> users;
        public int mode;
        string role;
        List<string> taskusers = new List<string>();
        public Users(Task maintask, int mainmode, string us, string mainrole)
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            listBox1.DataSource = users;
            task = maintask;
            if (task != null && task.Users != null && task.Users != "") taskusers = task.Users.Split().ToList();
            mode = mainmode;
            role = mainrole;
            delbutton.Enabled = false;
            if (mode == 0)
            {
                showall.Enabled = false;
                showall.Hide();
                showuser.Enabled = false;
                showuser.Hide();
                addbutton.Enabled = false;
                addbutton.Hide();
                delbutton.Enabled = false;
                delbutton.Hide();
                savebutton.Enabled = false;
                savebutton.Hide();
                cleanusers.Enabled = false;
                cleanusers.Hide();
            }
            else
            {
                makeadmin.Enabled = false;
                makeadmin.Hide();
                makeuser.Enabled = false;
                makeuser.Hide();
                banbutton.Enabled = false;
                banbutton.Hide();
                unbanbutton.Enabled = false;
                unbanbutton.Hide();

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void UpdateEdit()
        {
            if (flag == 0)
            {
                users = db.Users.ToList();
                if (textBox1.Text != "") users = users.FindAll(x => x.Login.Contains(textBox1.Text));
                listBox1.DataSource = users;
            }
            else listBox1.DataSource = taskusers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateEdit();
        }

        private void showall_Click(object sender, EventArgs e)
        {
            flag = 0;
            UpdateEdit();
            addbutton.Enabled = true;
            delbutton.Enabled = false;
        }

        private void showuser_Click(object sender, EventArgs e)
        {
            flag = 1;
            UpdateEdit();
            addbutton.Enabled = false;
            delbutton.Enabled = true;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User tempuser = listBox1.SelectedItem as User;
            if (taskusers.Contains(tempuser.Login)) return;
            taskusers.Add(tempuser.Login);
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            string l = listBox1.SelectedItem as string;
            taskusers.Remove(l);
            listBox1.DataSource = taskusers;
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            addedit frm = (addedit)this.Owner;
            frm.GetUsers(taskusers);
            this.Close();
            this.Visible = false;
        }

        private void banbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User user = listBox1.SelectedItem as User;
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
        }

        private void makeuser_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User user = listBox1.SelectedItem as User;
            if (role == "lowadmin" && user.Role == "admin")
            {
                MessageBox.Show("");
                return;
            }
            user.Role = "normal";
            db.SaveChanges();
        }
        void UpdateAdd()
        {

        }

        private void makeadmin_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User user = listBox1.SelectedItem as User;
            if (user.Role == "admin" || user.Role == "lowadmin")
            {
                MessageBox.Show("Этот пользователья уже является администратором");
                return;
            }
            user.Role = "lowadmin";
            db.SaveChanges();
        }

        private void unbanbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User user = listBox1.SelectedItem as User;
            user.Banned = 0;
            db.SaveChanges();
        }

        private void cleanusers_Click(object sender, EventArgs e)
        {
            taskusers.Clear();
            UpdateEdit();
        }
    }
}
