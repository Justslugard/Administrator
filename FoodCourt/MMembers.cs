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
using static FoodCourt.Util;

namespace FoodCourt
{
    public partial class MMembers : Form
    {
        static User tb = null;
        static int pos = 0;
        public MMembers()
        {
            InitializeComponent();
        }
        void g()
        {
            load(userBindingSource, db.Users.Where(x => x.RoleID == 2));
        }

        private void MMembers_Load(object sender, EventArgs e)
        {
            g();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userBindingSource.SuspendBinding();
            tb = null;
            flip(this.Controls);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userBindingSource.ResumeBinding();
            flip(this.Controls);
            userBindingSource.Position = pos;
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userBindingSource.IsBindingSuspended) return;

            pos = userBindingSource.Position;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb = userBindingSource.Current as User;

            if (tb == null) return;

            userBindingSource.SuspendBinding();
            flip(this.Controls);

            firstNameTextBox.Text = tb.FirstName;
            lastNameTextBox.Text = tb.LastName;
            emailTextBox.Text = tb.Email;
            phoneNumberTextBox.Text = tb.PhoneNumber;
            passwordTextBox.Text = tb.Password;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb = userBindingSource.Current as User;

            if (tb == null) return;

            if (MessageBox.Show("Are you sure you want to delete this user?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Users.Remove(tb);
                db.SaveChanges();
                g();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = tb?.ID ?? -1;
            if (new[] { firstNameTextBox.Text, lastNameTextBox.Text }.Any(string.IsNullOrWhiteSpace)) MessageBox.Show("All fields must be filled!");
            else if (db.Users.Any(x => x.Email == emailTextBox.Text && x.ID != id)) MessageBox.Show("Email must be unique on the database!");
            else if (!isValidEmail(emailTextBox.Text)) MessageBox.Show("Invalid email format!");
            else if (!Regex.IsMatch(phoneNumberTextBox.Text, @"\d{10,15}")) MessageBox.Show("Phone numbers must be a digits between 10 and 15 digits!");
            else if (!Regex.IsMatch(passwordTextBox.Text, @".{8,}")) MessageBox.Show("Password length must be atleast 8 characters long!");
            else
            {
                if (tb == null)
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
                } else
                {
                    User u = db.Users.Find(tb.ID);
                    u.FirstName = firstNameTextBox.Text;
                    u.LastName = lastNameTextBox.Text;
                    u.Email = emailTextBox.Text;
                    u.PhoneNumber = phoneNumberTextBox.Text;
                    u.Password = passwordTextBox.Text;
                }
                db.SaveChanges();
                g();
                flip(this.Controls);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) load(userBindingSource, db.Users.Where(x => x.RoleID == 2 && x.FirstName.IndexOf(search.Text) >= 0 || x.LastName.IndexOf(search.Text) >= 0 || x.Email.IndexOf(search.Text) >= 0));
            else g();
        }
    }
    public partial class User
    {
        public string MemberSince { get { return $"{DateJoined.ToString("dd/MM/yyyy")} ({DateTime.Now.Year - DateJoined.Year} year(s))"; } }
    }
}
