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
        User user = new User();
        string role;
        List<User> userlist = new List<User>();
        List<User> taskusers = new List<User>();
        public Users(Task maintask, int mainmode, string login, string mainrole)
        {
            InitializeComponent();
            db = new ApplicationContext();
            List<User> users = db.Users.ToList();
            task = maintask;
            if (task != null && task.Users != null && task.Users != "")
            {
                string[] l = task.Users.Split();
                foreach (string s in l) taskusers.Add(db.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
            }
            mode = mainmode;
            user = db.Users.Where(x => x.Login == login).FirstOrDefault();
            role = mainrole;
            if (user.Role == "normal" && user.Friends != null && user.Friends != "")
            {
                string[] l = user.Friends.Split();
                foreach (string s in l) userlist.Add(db.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
            }
            delbutton.Enabled = false;
            UpdateEdit();
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
                if (user.Role == "normal")
                {
                    List<User> list = userlist;
                    if (textBox1.Text != "") list = list.FindAll(x => x.Login.Contains(textBox1.Text));
                    list.Remove(user);
                    listBox1.DataSource = list;
                    return;
                }
                users = db.Users.ToList();
                users.Remove(user);
                if (textBox1.Text != "") users = users.FindAll(x => x.Login.Contains(textBox1.Text));
                if (users.Count > 0) listBox1.DataSource = users;
                else listBox1.DataSource = null;
            }
            else if (taskusers.Count > 0) listBox1.DataSource = taskusers;
            else listBox1.DataSource = null;
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
            if (taskusers.Contains(tempuser)) return;
            taskusers.Add(tempuser);

        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User l = listBox1.SelectedItem as User;
            taskusers.Remove(l);
            UpdateEdit();
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
