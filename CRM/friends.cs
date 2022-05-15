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
        List<User> userfriends = new List<User>();
        List<User> userquerys = new List<User>();
        int flag = 0;
        public friends(int id)
        {
            InitializeComponent();
            db = new ApplicationContext();
            user = db.Users.Where(b => b.id == id).FirstOrDefault();
            deletefriend.Enabled = false;
            if (user.Friends != null && user.Friends != "")
            {
                string[] l = user.Friends.Split();
                foreach (string s in l) userfriends.Add(db.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
            }
            if (user.Querys != null && user.Querys != "")
            {
                string[] l = user.Querys.Split();
                foreach (string s in l) userquerys.Add(db.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
            }
            Update();
        }

        private void friends_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User tempuser = listBox1.SelectedItem as User;
            if (flag == 2)
            {
                if (tempuser.Friends != null && tempuser.Friends != "") tempuser.Friends += " " + user.id.ToString();
                else tempuser.Friends = user.id.ToString(); 
                userquerys.Remove(tempuser);
                userfriends.Add(tempuser);
                AddToFriends(user, userfriends);
                AddToQuerys(user, userquerys);
                return;
            }
            if (tempuser.Querys != null && (tempuser.Querys.Split().Contains(user.Login) || tempuser.Friends.Split().Contains(user.Login)))
            {
                MessageBox.Show("Вы уже отправили запрос этому пользователю или добавили его в друзьяы");
                return;
            }
            if (tempuser.Querys != null && tempuser.Querys != "") tempuser.Querys += " " + user.id.ToString();
            tempuser.Querys += user.id.ToString();
            db.SaveChanges();
            Update();

        }

        private void deletefriend_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            User l = listBox1.SelectedItem as User;
            if (flag == 2)
            {
                userquerys.Remove(l);
                AddToQuerys(user, userquerys);
                return;
            }
            userfriends.Remove(l);
            AddToFriends(user, userfriends);
            List<string> list = l.Friends.Split().ToList();
            list.Remove(user.id.ToString());
            string k = null;
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1) k += list[i];
                else k += list[i] + " ";
            }
            l.Friends = k;
            db.SaveChanges();
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
            listBox1.DataSource = null;
            if (flag == 0)
            {
                List<User> users = db.Users.ToList();
                users.Remove(user);
                if (textBox1.Text != "") users = users.FindAll(x => x.Login.ToString().Contains(textBox1.Text));
                listBox1.DataSource = users;
            }
            if (flag == 1) listBox1.DataSource = userfriends;

            if (flag == 2) listBox1.DataSource = userquerys;
        }

        private void showfriends_Click(object sender, EventArgs e)
        {
            flag = 1;
            addbutton.Enabled = false;
            deletefriend.Enabled = true;
            Update();
        }
        void AddToQuerys(User us, List<User> add)
        {
            string l = null;
            for (int i = 0; i < add.Count; i++)
            {
                if (i == add.Count - 1) l += add[i].id.ToString();
                else l += add[i].id.ToString() + " ";
            }
            us.Querys = l;
            db.SaveChanges();
            Update();
        }
        void AddToFriends(User us, List<User> add)
        {
            string k = null;
            for (int i = 0; i < add.Count; i++)
            {
                if (i == add.Count - 1) k += add[i].id.ToString();
                else k += userfriends[i].id.ToString() + " ";
            }
            us.Friends = k;
            db.SaveChanges();
            Update();
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
