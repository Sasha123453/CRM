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
            LoginControl.TabPages.Remove(RegistrationPage);
            User slowfix = db.Users.Where(x => x.Login == "login").FirstOrDefault();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string login = loginbox.Text;
            string password = GetHash(passbox.Text);
            User authUser = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
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
            LoginControl.TabPages.Remove(LoginPage);
            LoginControl.TabPages.Add(RegistrationPage);
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void RegistrationPage_Click(object sender, EventArgs e)
        {

        }

        private void registrb_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }
            string login = textBox1.Text;
            string password = GetHash(textBox2.Text);
            string role = "normal";
            User checkRepeat = db.Users.Where(b => b.Login == login).FirstOrDefault();
            if (checkRepeat != null)
            {
                MessageBox.Show("Данный логин занят, выберите другой");
            }
            else
            {
                User user = new User(login, password, role, null, 0, null);
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Вы зарегистрировались");
            }
        }

        private void loginb_Click(object sender, EventArgs e)
        {
            LoginControl.TabPages.Remove(RegistrationPage);
            LoginControl.TabPages.Add(LoginPage);
        }

        private void LoginPage_Click(object sender, EventArgs e)
        {

        }
    }
}
