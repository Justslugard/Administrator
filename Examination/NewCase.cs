using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class NewCase : Form
    {
        public NewCase()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, System.EventArgs e)
        {
            if (new NewQuestion().ShowDialog() == DialogResult.OK)
            {
                cases_detailsDataGridView.Rows.Add(Question["txt"], Question["a"], Question["b"], Question["c"], Question["d"], Question["ans"]);
            }
        }

        private void cases_detailsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            submit.Enabled = true;

            qQty.Text = (int.Parse(qQty.Text) + 1).ToString();
        }

        private void submit_Click(object sender, System.EventArgs e)
        {
            Regex codeReg = new Regex(@"^CASE[\d]{5}$");

            if (isEmpty(this.Controls)) return;
            else if (!codeReg.IsMatch(codeTextBox.Text)) MessageBox.Show("Invalid code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                @case newCase = new @case()
                {
                    creator_id = User.id,
                    code = codeTextBox.Text,
                    number_of_questions = cases_detailsDataGridView.RowCount,
                    created_at = DateTime.Now,
                    deleted_at = null
                };

                db.cases.Add(newCase);

                for (int i = 0; i < cases_detailsDataGridView.RowCount; i++)
                {
                    cases_details newDetails = new cases_details()
                    {
                        case_id = newCase.id,
                        text = cases_detailsDataGridView.Rows[i].Cells[0].Value.ToString(),
                        option_a = cases_detailsDataGridView.Rows[i].Cells[1].Value.ToString(),
                        option_b = cases_detailsDataGridView.Rows[i].Cells[2].Value.ToString(),
                        option_c = cases_detailsDataGridView.Rows[i].Cells[3].Value.ToString(),
                        option_d = cases_detailsDataGridView.Rows[i].Cells[4].Value.ToString(),
                        correct_answer = cases_detailsDataGridView.Rows[i].Cells[5].Value.ToString(),
                        created_at = DateTime.Now,
                        deleted_at = null
                    };

                    db.cases_details.Add(newDetails);
                }

                db.SaveChanges();

                MessageBox.Show("New case successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cases_detailsDataGridView.Rows.Clear();
                qQty.Text = "0";
                codeTextBox.Text = string.Empty;
            }
        }

        private void cases_detailsDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            qQty.Text = (int.Parse(qQty.Text) - 1).ToString();

            if (cases_detailsDataGridView.Rows.Count == 0) submit.Enabled = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult res = DialogResult.Yes;

            if (cases_detailsDataGridView.Rows.Count != 0) res = MessageBox.Show("Are you sure you want to cancel current operation?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                cases_detailsDataGridView.Rows.Clear();
                qQty.Text = "0";
                codeTextBox.Text = string.Empty;
            } 
        }

        private void cases_detailsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView data = sender as DataGridView;
            if (data.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) cases_detailsDataGridView.Rows.RemoveAt(e.RowIndex);
        }
    }
}
