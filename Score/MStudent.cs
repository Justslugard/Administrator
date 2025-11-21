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
    public partial class MStudent : Form
    {
        int pos = 0;
        Student table = null;
        public MStudent()
        {
            InitializeComponent();
            load(studentBindingSource, db.Students);
        }

        private void MStudent_Load(object sender, EventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            table = studentBindingSource.Current as Student;

            if (table.Gender == "M") mRB.Checked = true;
            else fRB.Checked = true;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text)) load(studentBindingSource, db.Students.Where(x => x.StudentName.Contains(searchTextBox.Text) || x.StudentClass.Contains(searchTextBox.Text)));
            else load(studentBindingSource, db.Students);
        }

        private void lB_Click(object sender, EventArgs e)
        {
            studentBindingSource.SuspendBinding();
            table = null;
            flip(this.Controls);
            studentIDTextBox.Enabled = mRB.Checked = fRB.Checked = false;
            studentIDTextBox.Text = nextId("Student");
        }

        private void update_Click(object sender, EventArgs e)
        {
            studentBindingSource.SuspendBinding();

            if (table == null) return;

            flip(this.Controls);
            studentIDTextBox.Enabled = false;
            studentIDTextBox.Text = table.StudentID.ToString();
            studentNameTextBox.Text = table.StudentName;
            birthDateDateTimePicker.Value = table.BirthDate;
            addressTextBox.Text = table.Address;
            comboBox1.Text = table.StudentClass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (table == null) return;

            if (MessageBox.Show("Are you sure you want to delete this student?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Students.Remove(table);
                db.SaveChanges();
                load(studentBindingSource, db.Students);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flip(this.Controls);
            studentIDTextBox.Enabled = false;
            studentBindingSource.ResumeBinding();
            studentBindingSource.Position = pos;
        }

        private void studentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (studentBindingSource.IsBindingSuspended) return;

            pos = studentBindingSource.Position;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (new[] { studentNameTextBox.Text, addressTextBox.Text, comboBox1.Text }.Any(string.IsNullOrWhiteSpace) || (!mRB.Checked && !fRB.Checked)) MessageBox.Show("All fields must be filled!");
            else
            {
                if (table == null)
                {
                    db.Students.Add(new Student()
                    {
                        StudentName = studentNameTextBox.Text,
                        BirthDate = birthDateDateTimePicker.Value.Date,
                        Gender = mRB.Checked ? "M" : "F",
                        Address = addressTextBox.Text,
                        StudentClass = comboBox1.Text
                    });
                } else
                {
                    Student s = db.Students.Find(table.StudentID);
                    s.StudentName = studentNameTextBox.Text;
                    s.BirthDate = birthDateDateTimePicker.Value.Date;
                    s.Gender = mRB.Checked ? "M" : "F";
                    s.Address = addressTextBox.Text;
                    s.StudentClass = comboBox1.Text;
                }
                db.SaveChanges();
                load(studentBindingSource, db.Students);
                flip(this.Controls);
                studentIDTextBox.Enabled = false;
                table = null;
            }

        }
    }
}
