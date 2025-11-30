using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodCourt.Util;

namespace FoodCourt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = db.Users.Where(x => x.Email == textBox1.Text).FirstOrDefault();

            if (user == null) MessageBox.Show("User like that doesn't exist, go to register if you're new here");
            else if (user.Password != textBox2.Text) MessageBox.Show("The password is wrong, enter the correct password");
            else
            {
                this.Hide();
                if (user.RoleID == 1) admin.Show();
                else if (user.RoleID == 2) member.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register.Show();
        }
    }
}
