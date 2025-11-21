using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Score.Util;

namespace Score
{
    public partial class MSubject : Form
    {
        int pos = 0;
        Subject table = null;
        public MSubject()
        {
            InitializeComponent();
            load(subjectBindingSource, db.Subjects);
        }

        private void subjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (subjectBindingSource.IsBindingSuspended) return;

            pos = subjectBindingSource.Position;
        }

        private void lB_Click(object sender, EventArgs e)
        {
            subjectBindingSource.SuspendBinding();
            flip(this.Controls);
            subjectIDTextBox.Enabled = false;
            subjectIDTextBox.Text = nextId("Subject");
        }

        private void update_Click(object sender, EventArgs e)
        {
            table = subjectBindingSource.Current as Subject;

            if (table == null) return;
            subjectBindingSource.SuspendBinding();

            flip(this.Controls);
            subjectIDTextBox.Enabled = false;

            subjectIDTextBox.Text = table.SubjectID.ToString();
            subjectNameTextBox.Text = table.SubjectName;
            minimumCriteriaNumericUpDown.Value = table.MinimumCriteria;
            isPracticeCheckBox.Checked = table.IsPractice == "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table = subjectBindingSource.Current as Subject;

            if (table == null) return;

            if (MessageBox.Show("Are you sure you want to delete this subject?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Subjects.Remove(table);
                db.SaveChanges();
                load(subjectBindingSource, db.Subjects);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            subjectBindingSource.ResumeBinding();
            subjectBindingSource.Position = pos;
            table = null;
            flip(this.Controls);
            subjectIDTextBox.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(subjectNameTextBox.Text)) MessageBox.Show("All fields must be filled!");
            else
            {
                if (table == null)
                {
                    db.Subjects.Add(new Subject()
                    {
                        SubjectName = subjectNameTextBox.Text,
                        MinimumCriteria = (int)minimumCriteriaNumericUpDown.Value,
                        IsPractice = ((int)isPracticeCheckBox.CheckState).ToString()
                    });
                } else
                {
                    Subject s = db.Subjects.Find(table.SubjectID);
                    s.SubjectName = subjectNameTextBox.Text;
                    s.MinimumCriteria = (int)minimumCriteriaNumericUpDown.Value;
                    s.IsPractice = ((int)isPracticeCheckBox.CheckState).ToString();
                }
                db.SaveChanges();
                load(subjectBindingSource, db.Subjects);
                flip(this.Controls);
                subjectIDTextBox.Enabled = false;
                subjectBindingSource.Position = pos;
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text)) load(subjectBindingSource, db.Subjects.Where(x => x.SubjectName.Contains(searchTextBox.Text) || SqlFunctions.StringConvert((double)x.MinimumCriteria).Contains(searchTextBox.Text)));
            else load(subjectBindingSource, db.Subjects);
        }
    }
}
