using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Score.Util;

namespace Score
{
    public partial class ViewReport : Form
    {
        public ViewReport()
        {
            InitializeComponent();
            load(studentBindingSource, db.Students);
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {

        }

        private void studentBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Student s = studentBindingSource.Current as Student;
            reportDgv.Rows.Clear();

            if (s == null) return;

            name.Text = s.StudentName;


            foreach (ScoreHeader sh in s.ScoreHeaders)
            {
                foreach (ScoreDetail sd in sh.ScoreDetails)
                {
                    int i = reportDgv.Rows.Add();

                    reportDgv.Rows[i].Cells["scoreDate"].Value = sh.ScoreDate.Date;
                    reportDgv.Rows[i].Cells["evaluator"].Value = sh.Teacher.TeacherName;
                    reportDgv.Rows[i].Cells["subjectName"].Value = sd.Subject.SubjectName;
                    reportDgv.Rows[i].Cells["score"].Value = sd.Score;
                    reportDgv.Rows[i].Cells["status"].Value = sd.Status;
                    reportDgv.Rows[i].Cells["status"].Style.ForeColor = sd.Status == "Pass" ? Color.Green : Color.Red;
                }
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text)) load(studentBindingSource, db.Students.Where(x => x.StudentName.Contains(searchTextBox.Text) || x.StudentClass.Contains(searchTextBox.Text)));
            else load(studentBindingSource, db.Students);
        }
    }
}
