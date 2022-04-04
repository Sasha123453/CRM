using System;
using System.Data.SQLite;
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
            string password = passbox.Text;
            User authUser = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                authUser = db.Users.Where(b => b.Login == login && b.Password == password).FirstOrDefault();
            }
            if (authUser != null)
            {
                MessageBox.Show("Вы вошли!");
                if (authUser.Role == "admin")
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
                }
            }
            else MessageBox.Show("Неверный логин или пароль");
            
        }

        private void registrationbutton_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }
    }
}
