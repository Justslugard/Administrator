using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using static FoodCourt.Util;

namespace FoodCourt
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new[] { firstNameTextBox.Text, lastNameTextBox.Text }.Any(string.IsNullOrWhiteSpace)) MessageBox.Show("All fields must be filled!");
            else if (db.Users.Any(x => x.Email == emailTextBox.Text)) MessageBox.Show("Email must be unique on the database!");
            else if (!isValidEmail(emailTextBox.Text)) MessageBox.Show("Invalid email format!");
            else if (!Regex.IsMatch(phoneNumberTextBox.Text, @"\d{10,15}")) MessageBox.Show("Phone numbers must be a digits between 10 and 15 digits!");
            else if (!Regex.IsMatch(passwordTextBox.Text, @".{8,}")) MessageBox.Show("Password length must be atleast 8 characters long!");
            else if (passwordTextBox.Text != textBox1.Text) MessageBox.Show("Confirm password isn't the same as password!");
            else
            {
                db.Users.Add(new User()
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Email = emailTextBox.Text,
                    PhoneNumber = phoneNumberTextBox.Text,
                    Password = passwordTextBox.Text,
                    DateJoined = DateTime.Now.Date,
                    RoleID = 2
                });
                db.SaveChanges();
                this.Hide();
                member.Show();
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }
    }
}
