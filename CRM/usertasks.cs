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
    public partial class usertasks : Form
    {
        List<Task> tasks = new List<Task>();
        User user;
        ApplicationContext db;
        int flag = 0;
        public usertasks(User mainuser)
        {
            InitializeComponent();
            user = mainuser;
            db = new ApplicationContext();
            tasks = db.Tasks.Where(x => x.Author == user.Login).ToList();
        }

        private void usertasks_Load(object sender, EventArgs e)
        {

        }
        void Update()
        {
            tasks = db.Tasks.ToList();
            if (flag == 1) tasks = tasks.FindAll(x => x.Iscompleted != 0);
            if (flag == 2) tasks = tasks.FindAll(x => x.Iscompleted == 0);
            listBox1.DataSource = tasks;
        }
    }
}
