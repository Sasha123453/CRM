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
    public partial class Form2 : Form
    {
        ApplicationContext db;
        public Form2()
        {
            InitializeComponent();
            db = new ApplicationContext();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            string login = loginbox.Text;
            string password = passbox.Text;
            string role = "normal";

            User checkRepeat = new User(login, password, role, null, 0, null);
            using (ApplicationContext db = new ApplicationContext())
            {
                checkRepeat = db.Users.Where(b => b.Login == login).FirstOrDefault();
            }
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
                Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
