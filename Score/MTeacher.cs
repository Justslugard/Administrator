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
using static Score.Util;

namespace Score
{
    public partial class MTeacher : Form
    {
        int pos = 0;
        static Teacher table = null;

        public MTeacher()
        {
            InitializeComponent();
            load(teacherBindingSource, db.Teachers);
        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderLabel_Click(object sender, EventArgs e)
        {

        }

        private void lB_Click(object sender, EventArgs e)
        {
            teacherBindingSource.SuspendBinding();
            flip(this.Controls);
            teacherIDTextBox.Enabled = mRB.Checked = fRB.Checked = false;
            teacherIDTextBox.Text = nextId("Teacher");
        }

        private void teacherBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Teacher t = teacherBindingSource.Current as Teacher;

            if (t.Gender == "M") mRB.Checked = true;
            else fRB.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flip(this.Controls);
            teacherIDTextBox.Enabled = false;
            table = null;
            teacherBindingSource.ResumeBinding();
            teacherBindingSource.Position = pos;
        }

        private void update_Click(object sender, EventArgs e)
        {
            table = teacherBindingSource.Current as Teacher;

            if (table == null) return;
            teacherBindingSource.SuspendBinding();
            flip(this.Controls);
            teacherIDTextBox.Enabled = false;

            teacherIDTextBox.Text = table.TeacherID.ToString();
            teacherNameTextBox.Text = table.TeacherName.ToString();
            phoneNumberTextBox.Text = table.PhoneNumber.ToString();
            birthDateDateTimePicker.Value = table.BirthDate;
            emailTextBox.Text = table.Email.ToString();
            passwordTextBox.Text = table.Password.ToString();
            comboBox1.Text = table.Role.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table = teacherBindingSource.Current as Teacher;

            if (table == null) return;

            if (MessageBox.Show("Are you sure you want to delete this Teacher?", "Warning", MessageBoxButtons.YesNo)  == DialogResult.Yes)
            {
                db.Teachers.Remove(table);
                db.SaveChanges();
                load(teacherBindingSource, db.Teachers);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                if (table == null)
                {
                    db.Teachers.Add(new Teacher()
                    {
                        TeacherName = teacherNameTextBox.Text,
                        PhoneNumber = phoneNumberTextBox.Text,
                        BirthDate = birthDateDateTimePicker.Value.Date,
                        Gender = mRB.Checked ? "M" : "F",
                        Email = emailTextBox.Text,
                        Password = passwordTextBox.Text,
                        Role = comboBox1.Text
                    });
                }
                else
                {
                    Teacher t = db.Teachers.Find(table.TeacherID);
                    t.TeacherName = teacherNameTextBox.Text;
                    t.PhoneNumber = phoneNumberTextBox.Text;
                    t.BirthDate = birthDateDateTimePicker.Value.Date;
                    t.Gender = mRB.Checked ? "M" : "F";
                    t.Email = emailTextBox.Text;
                    t.Password = passwordTextBox.Text;
                    t.Role = comboBox1.Text;
                }

                db.SaveChanges();
                load(teacherBindingSource, db.Teachers);
                table = null;
                flip(this.Controls);
                teacherBindingSource.Position = pos;
                teacherIDTextBox.Enabled = false;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text)) load(teacherBindingSource, db.Teachers.Where(x => x.TeacherName.Contains(searchTextBox.Text) || x.Email.Contains(searchTextBox.Text) || x.PhoneNumber.Contains(searchTextBox.Text)));
            else load(teacherBindingSource, db.Teachers);
        }

        bool isValid()
        {
            if (new[] { teacherNameTextBox.Text, phoneNumberTextBox.Text, emailTextBox.Text, passwordTextBox.Text }.Any(string.IsNullOrWhiteSpace)
                || (!fRB.Checked && !mRB.Checked)) MessageBox.Show("All fields must be filled");
            else if (!Regex.IsMatch(emailTextBox.Text, @"^[\w.]+@[\w-.]+\.\w+$")) MessageBox.Show("Email must be valid format!");
            else if (!Regex.IsMatch(phoneNumberTextBox.Text, @"^08\d+$")) MessageBox.Show("Phone must start with \"08\" and another with digits!");
            else if (!Regex.IsMatch(passwordTextBox.Text, @"[A-Z]+\w.\d{4,}")) MessageBox.Show("Password must start with capital, number and minimum length 5 characters!");
            else return true;

            return false;
        }

        private void teacherDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (teacherBindingSource.IsBindingSuspended) return;

            pos = teacherBindingSource.Position;
        }

        private void birthDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
