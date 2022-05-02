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
            List<Task> list = db.Tasks.Where(x => x.Author == user.Login).ToList();
            foreach (Task t in list) t.Author = textBox1.Text;
            user.Login = textBox1.Text;
            user.Password = textBox2.Text;
            db.SaveChanges();
            this.Hide();
            this.Close();
        }
    }
}
