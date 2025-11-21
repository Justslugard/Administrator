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
    public partial class PopupScore : Form
    {
        Student student = db.Students.Find(1);
        List<string> subjects = new List<string>();

        public PopupScore(Student student)
        {
            InitializeComponent();
            this.student = student;
            name.Text = student.StudentName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (scoreDetailDataGridView.RowCount <= 0) MessageBox.Show("Sorry, please add subject first!");
            else
            {

                ScoreHeader sh = new ScoreHeader()
                {
                    ScoreDate = DateTime.Now.Date,
                    StudentID = student.StudentID,
                    TeacherID = teacher.TeacherID
                };

                db.ScoreHeaders.Add(sh);

                foreach (DataGridViewRow dr in scoreDetailDataGridView.Rows)
                {
                    db.ScoreDetails.Add(new ScoreDetail()
                    {
                        ScoreHeaderID = sh.ScoreHeaderID,
                        SubjectID = int.Parse(dr.Cells[0].Value.ToString()),
                        Score = int.Parse(dr.Cells[2].Value.ToString()),
                        Status = dr.Cells[3].Value.ToString()
                    });
                }

                db.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PopupScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sMKScoreDataSet.Subject' table. You can move, or remove it, as needed.
            this.subjectTableAdapter.Fill(this.sMKScoreDataSet.Subject);

            comboBox1_TextChanged(sender, e);
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1?.SelectedItem == null) return;

            minimumCriteriaTextBox.Text = (((DataRowView)comboBox1.SelectedItem)["MinimumCriteria"]).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (subjects.Contains(comboBox1.Text)) MessageBox.Show("Sorry, this subject has been added!");
            else
            {
                scoreDetailDataGridView.Rows.Add(comboBox1.SelectedValue, comboBox1.Text, numericUpDown1.Value, numericUpDown1.Value > int.Parse(minimumCriteriaTextBox.Text) ? "Pass" : "Remedial");
                subjects.Add(comboBox1.Text);
            }
        }

        private void scoreDetailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex, c = e.ColumnIndex;

                if (scoreDetailDataGridView.Columns["action"].Index == c)
                {
                    subjects.Remove(scoreDetailDataGridView.Rows[i].Cells[1].Value.ToString());
                    scoreDetailDataGridView.Rows.RemoveAt(i);
                }
            }
        }
    }
}
