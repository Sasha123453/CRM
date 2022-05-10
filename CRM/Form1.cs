using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Form1 : Form
    {
        ApplicationContext db;
        public Form1()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string login = loginbox.Text;
            string password = GetHash(passbox.Text);
            User authUser = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                authUser = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
            }
            if (authUser != null && authUser.Banned == 0)
            {
                if (authUser.Role == "admin" || authUser.Role == "lowadmin")
                {
                    Form form = new adminform(authUser);
                    Hide();
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    Form form = new userform(authUser);
                    Hide();
                    form.ShowDialog();
                    this.Close();
                }
            }
            else if (authUser == null) MessageBox.Show("Неверный логин или пароль");
            else if (authUser.Banned == 1) MessageBox.Show("Данный пользователь заблокирован");
            
        }

        private void registrationbutton_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
