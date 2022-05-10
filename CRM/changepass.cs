using System;
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
    public partial class changepass : Form
    {
        User user;
        ApplicationContext db;
        public changepass(int id)
        {
            InitializeComponent();
            db = new ApplicationContext();
            user = db.Users.Where(b => b.id == id).FirstOrDefault();
            textBox1.Text = user.Login;
        }

        private void changepass_Load(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            User checklogin = db.Users.Where(b => b.Login == textBox1.Text).FirstOrDefault();
            if (checklogin != null)
            {
                MessageBox.Show("Этот логин занят");
                return;
            }
            user.Login = textBox1.Text;
            if (textBox2.Text != "") user.Password = GetHash(textBox2.Text);
            db.SaveChanges();
            this.Hide();
            this.Close();
        }
        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
