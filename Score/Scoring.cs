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
    public partial class Scoring : Form
    {
        public Scoring()
        {
            InitializeComponent();
            load(studentBindingSource, db.Students);
            scoreDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            evaluatorTextBox.Text = teacher.TeacherName;
        }

        private void Scoring_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in studentDataGridView.Rows)
            {
                Student s = dr.DataBoundItem as Student;
                DateTime now = DateTime.Now.Date;
                bool isInScore = db.ScoreHeaders.Any(x => x.StudentID.Equals(s.StudentID) && x.ScoreDate.Equals(now));

                if (isInScore)
                {
                    DataGridViewButtonCell bc = dr.Cells["action"] as DataGridViewButtonCell;

                    bc.Style.BackColor = bc.Style.SelectionBackColor = Color.White;
                    bc.UseColumnTextForButtonValue = false;
                }
            }
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex;
                int c = e.ColumnIndex;

                if (studentDataGridView.Columns["action"].Index == c && studentDataGridView.Rows[i].Cells["action"].Style.BackColor != Color.White)
                {
                    if (new PopupScore((Student)studentDataGridView.Rows[i].DataBoundItem).ShowDialog() == DialogResult.OK)
                    {
                        DataGridViewButtonCell bc = studentDataGridView.Rows[i].Cells["action"] as DataGridViewButtonCell;
                        bc.Style.BackColor = bc.Style.SelectionBackColor = Color.White;
                        bc.UseColumnTextForButtonValue = false;
                    }

                }
            }
        }
    }
}
