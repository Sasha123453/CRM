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
    public partial class friends : Form
    {
        User user;
        ApplicationContext db;
        List<string> userfriends = new List<string>();
        List<string> userquerys = new List<string>();
        int flag = 0;
        public friends(int id)
        {
            InitializeComponent();
            db = new ApplicationContext();
            user = db.Users.Where(b => b.id == id).FirstOrDefault();
            if (user.Friends != null) userfriends = user.Friends.Split().ToList();
            if (user.Querys != null) userquerys = user.Querys.Split().ToList();
            Update();
        }

        private void friends_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            if (flag == 2)
            {
                string k = listBox1.SelectedItem as string;
                User tempuser = db.Users.Where(b => b.Login == k).FirstOrDefault();
                if (tempuser.Friends != null && tempuser.Friends != "") tempuser.Friends += " " + user.Login;
                tempuser.Friends += user.Login;
                userquerys.Remove(k);
                userfriends.Add(k);
                AddToFriends(user, userfriends);
                AddToQuerys(user, userquerys);
                return;
            }
            User tmpuser = listBox1.SelectedItem as User;
            if (tmpuser.Querys != null && tmpuser.Querys.Split().Contains(user.Login) || tmpuser.Friends != null && tmpuser.Friends.Split().Contains(user.Login))
            {
                MessageBox.Show("Вы уже отправили запрос этому пользователю");
                return;
            }
            if (tmpuser.Querys != null && tmpuser.Querys != "") tmpuser.Querys += " " + user.Login;
            tmpuser.Querys += user.Login;
            db.SaveChanges();
            Update();

        }

        private void deletefriend_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            string l = listBox1.SelectedItem as string;
            if (flag == 2)
            {
                userquerys.Remove(l);
                AddToQuerys(user, userquerys);
                return;
            }
            userfriends.Remove(l);
            AddToFriends(user, userfriends);
            User tmpuser = db.Users.Where(x => x.Login == l).FirstOrDefault();
            List<string> list = tmpuser.Friends.Split().ToList();
            list.Remove(user.Login);
            AddToFriends(tmpuser, list);
            Update();
            
        }

        private void showall_Click(object sender, EventArgs e)
        {
            flag = 0;
            deletefriend.Enabled = false;
            addbutton.Enabled = true;
            Update();
        }
        void Update()
        {
            if (flag == 0)
            {
                List<User> users = db.Users.ToList();
                users.Remove(user);
                if (textBox1.Text != "") users = users.FindAll(x => x.Login.Contains(textBox1.Text));
                listBox1.DataSource = users;
            }
            if (flag == 1)
            {
                listBox1.DataSource = userfriends;
            }
            if (flag == 2)
            {
                listBox1.DataSource = userquerys;
            }
        }

        private void showfriends_Click(object sender, EventArgs e)
        {
            flag = 1;
            addbutton.Enabled = false;
            deletefriend.Enabled = true;
            Update();
        }
        void AddToQuerys(User us, List<string> add)
        {
            string l = null;
            for (int i = 0; i < add.Count; i++)
            {
                if (i == add.Count - 1) l += add[i];
                else l += add[i] + " ";
            }
            us.Querys = l;
            db.SaveChanges();
        }
        void AddToFriends(User us, List<string> add)
        {
            string k = null;
            for (int i = 0; i < add.Count; i++)
            {
                if (i == add.Count - 1) k += add[i];
                else k += userfriends[i] + " ";
            }
            us.Friends = k;
            db.SaveChanges();
        }

        private void showquerys_Click(object sender, EventArgs e)
        {
            flag = 2;
            addbutton.Enabled = true;
            deletefriend.Enabled = true;
            Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Update();
        }
    }
}
