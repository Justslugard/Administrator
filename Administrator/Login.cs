using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Login
{
    public partial class Login : Form
    {
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static public Administrator user;
        public Login()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;
            this.Close();
        }

        private void logkan_Click(object sender, EventArgs e)
        {
            user = data.Administrators.Where(x => x.Email.Equals(email.Text)).FirstOrDefault();

            if (user == null || user.Password != password.Text) MessageBox.Show("Please Try Again, Your Data is not Valid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show($"Login Success! You logged in as a {user.Role.Name}", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (button.Name == "cash")
            {
                email.Text = "kellissen1@vkontakte.ru";
                password.Text = "TZIBmL7IC6O";
            } else if (button.Name == "adm")
            {
                email.Text = "ktoner0@topsy.com";
                password.Text = "lO8LLrrnpmY";
            }
        }
    }
}
