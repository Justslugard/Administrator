using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class Login : Form
    {
        static ExamEntities db = new ExamEntities();
        public Login()
        {
            InitializeComponent();
        }
        bool isValid()
        {
            User = db.users.Where(x => x.username.Equals(username.Text)).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(username.Text)) MessageBox.Show("Username can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(ps.Text)) MessageBox.Show("Password can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (User == null) MessageBox.Show("No such User exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (User.password != encryptMD5(ps.Text)) MessageBox.Show("Password wrong!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private void logkan_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                MessageBox.Show($"Welcome {User.name}!");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "exam")
            {
                username.Text = "participant";
                ps.Text = "participant";
            }
            else if (button.Name == "adm")
            {
                username.Text = "root";
                ps.Text = "admin";
            }
            logkan_Click(sender, e);
        }
    }
}
