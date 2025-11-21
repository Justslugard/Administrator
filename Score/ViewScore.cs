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
    public partial class ViewScore : Form
    {
        static Dictionary<int, int> scores = new Dictionary<int, int>();
        public ViewScore()
        {
            InitializeComponent();

            scores = new Dictionary<int, int>();
            foreach (var s in db.Subjects.Select(x => new { x.SubjectID, x.SubjectName }))
            {
                DataGridViewTextBoxColumn tb = new DataGridViewTextBoxColumn();
                tb.HeaderText = s.SubjectName;
                tb.Name = s.SubjectID.ToString();
                scores.Add(s.SubjectID, 0);

                scoreDgv.Columns.Insert(scoreDgv.Columns["tots"].Index, tb);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    load(db.ScoreHeaders.Where(x => x.ScoreDate.Equals(dateTimePicker1.Value.Date)).OrderByDescending(x => x.StudentID));
                    break;
                case 1:
                    load(db.ScoreHeaders.Where(x => x.ScoreDate.Equals(dateTimePicker1.Value.Date)).OrderBy(x => x.StudentID));
                    break;
                case 2:
                    load(db.ScoreHeaders.Where(x => x.ScoreDate.Equals(dateTimePicker1.Value.Date)).OrderByDescending(x => x.ScoreDetails.Sum(y => y.Score)));
                    break;
                case 3:
                    load(db.ScoreHeaders.Where(x => x.ScoreDate.Equals(dateTimePicker1.Value.Date)).OrderBy(x => x.ScoreDetails.Sum(y => y.Score)));
                    break;
            }
        }

        void load(IQueryable<ScoreHeader> sdList)
        {
            scoreDgv.Rows.Clear();

            if (sdList != null)
            {
                foreach (ScoreHeader sc in sdList)
                {
                    int index = scoreDgv.Rows.Add();

                    scoreDgv.Rows[index].Cells["studentID"].Value = sc.StudentID.ToString();
                    scoreDgv.Rows[index].Cells["studentName"].Value = sc.Student.StudentName;
                    scoreDgv.Rows[index].Cells["studentClass"].Value = sc.Student.StudentClass;

                    foreach (ScoreDetail item in sc.ScoreDetails)
                    {
                        scores[item.SubjectID] = item.Score;
                    }

                    foreach (int key in scores.Keys)
                    {
                        scoreDgv.Rows[index].Cells[$"{key}"].Value = scores[key];
                    }

                    scoreDgv.Rows[index].Cells["tots"].Value = sc.ScoreDetails.Sum(x => x.Score);
                }
            }
        }
    }
}
