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
            Update();
        }

        private void friends_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            if (flag == 0)
            {
                UserQuery check = db.UserQuerys.Where(x => x.TargetId == user.id || x.SenderId == user.id).FirstOrDefault();
                User adduser = listBox1.SelectedItem as User;
                UserFriend check1 = db.UserFriends.Where(x => x.FirstUserId == user.id && x.SecondUserId == adduser.id).FirstOrDefault();
                if (check != null || check1 != null) return;
                UserQuery addquery = new UserQuery(user.id, adduser.id);
                db.UserQuerys.Add(addquery);                
            }
            if (flag == 2)
            {
                UserQuery addfriend = listBox1.SelectedItem as UserQuery;
                UserFriend firstrecord = new UserFriend(addfriend.TargetId, addfriend.SenderId);
                UserFriend secondrecord = new UserFriend(addfriend.SenderId, addfriend.TargetId);
                db.UserFriends.Add(firstrecord);
                db.UserFriends.Add(secondrecord);
                db.UserQuerys.Remove(db.UserQuerys.Where(x => x.id == addfriend.id).FirstOrDefault());
            }
            db.SaveChanges();
            Update();
        }

        private void deletefriend_Click(object sender, EventArgs e)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                if (flag == 1)
                {
                    UserFriend firstrecord = listBox1.SelectedItem as UserFriend;
                    int id = firstrecord.SecondUserId;
                    UserFriend secondrecord = db.UserFriends.Where(x => x.FirstUserId == id && x.SecondUserId == user.id).FirstOrDefault();
                    firstrecord = db.UserFriends.Where(x => x.id == firstrecord.id).FirstOrDefault();
                    db.UserFriends.Remove(firstrecord);
                    db.UserFriends.Remove(secondrecord);
                    db.SaveChanges();
                }
                if (flag == 2)
                {
                    UserQuery delete = listBox1.SelectedItem as UserQuery;
                    db.UserQuerys.Remove(db.UserQuerys.Where(x => x.id == delete.id).FirstOrDefault());
                    db.SaveChanges();
                }
            }
            Update();
        }

        private void showall_Click(object sender, EventArgs e)
        {
            flag = 0;
            deletefriend.Enabled = false;
            addbutton.Enabled = true;
            Update();
        }
        void OldUpdate()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                user = context.Users.Where(x => x.id == user.id).FirstOrDefault();
                listBox1.DataSource = null;
                if (flag == 0)
                {
                    List<User> users = context.Users.ToList();
                    users.Remove(user);
                    if (textBox1.Text != "") users = users.FindAll(x => x.Login.ToString().Contains(textBox1.Text));
                    listBox1.DataSource = users;
                }
                if (flag == 1) 
                {
                    if (user.Friends != null && user.Friends != "" && false)
                    {
                        userfriends.Clear();
                        string[] l = user.Friends.Split();
                        foreach (string s in l) userfriends.Add(db.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
                        listBox1.DataSource = userfriends;
                    }
                    
                }

                if (flag == 2)
                {
                    if (user.Querys != null && user.Querys != "" && false)
                    {
                        userquerys.Clear();
                        string[] l = user.Querys.Split();
                        foreach (string s in l) userquerys.Add(context.Users.Where(x => x.id.ToString() == s).FirstOrDefault());
                        listBox1.DataSource = userquerys;
                    }
                }
            }
        }
        void Update()
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                listBox1.DataSource = null;
                if (flag == 0)
                {
                    List<User> users = context.Users.ToList();
                    users.Remove(context.Users.Where(x => x.id == user.id).FirstOrDefault());
                    if (textBox1.Text != "") users = users.FindAll(x => x.Login.ToString().Contains(textBox1.Text));
                    listBox1.DataSource = users;
                }
                if (flag == 1)
                {
                    List<UserFriend> userFriends = context.UserFriends.Where(x => x.FirstUserId == user.id).ToList();
                    listBox1.DataSource = userFriends;
                }
                if (flag == 2)
                {
                    List<UserQuery> userQuerys = context.UserQuerys.Where(x => x.TargetId == user.id).ToList();
                    listBox1.DataSource = userQuerys;
                }
            }
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
            using (ApplicationContext context = new ApplicationContext())
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
        }
        void AddToFriends(User us, List<User> add)
        {
            using (ApplicationContext context = new ApplicationContext())
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
