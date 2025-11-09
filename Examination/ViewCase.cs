using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Examination.Util;
using static Examination.@case;

namespace Examination
{
    public partial class ViewCase : Form
    {
        static IQueryable<@case> cases = Db.cases;
        static List<cases_details> table = null;
        static @case caseoh = null;
        static int pos = -1;
        static List<string> doNot = new List<string>()
        {
            "orward",
            "ackward"
        };

        public ViewCase()
        {
            InitializeComponent();
        }

        private void ViewCase_Load(object sender, EventArgs e)
        {
            load(caseBindingSource, cases);

            caseoh = caseBindingSource.Current as @case;
            table = caseoh.cases_details.ToList();

            reset();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (count <= table.Count)
            {
                count++;
                backward.Enabled = fastBackward.Enabled = true;
            }

            if (count == table.Count - 1) forward.Enabled = fastForward.Enabled = false;

            reset();
        }

        private void backward_Click(object sender, EventArgs e)
        {
            if (count >= 1) 
            {
                count--;
                forward.Enabled = fastForward.Enabled = true;
            }

            if (count == 0) backward.Enabled = fastBackward.Enabled = false;

            reset();
        }

        private void caseDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (caseBindingSource.IsBindingSuspended) return;

            count = 0;
            caseoh = caseBindingSource.Current as @case;
            table = caseoh.cases_details.ToList();

            backward.Enabled = fastBackward.Enabled = false;
            forward.Enabled = fastForward.Enabled = true;
            pos = caseBindingSource.Position;

            reset();
        }

        private void fastBackward_Click(object sender, EventArgs e)
        {
            count = 0;
            fastBackward.Enabled = backward.Enabled = false;
            fastForward.Enabled = forward.Enabled = true;

            reset();
        }

        private void fastForward_Click(object sender, EventArgs e)
        {
            count = table.Count - 1;
            fastBackward.Enabled = backward.Enabled = true;
            fastForward.Enabled = forward.Enabled = false;

            reset();
        }

        private void update_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);
            fastBackward.Enabled = backward.Enabled = forward.Enabled = fastForward.Enabled = false;

            caseBindingSource.SuspendBinding();

            qQty.Text = caseoh.totalQ;
            questionTextBox.Text = table[count].text;
            optionATextBox.Text = table[count].option_a;
            optionBTextBox.Text = table[count].option_b;
            optionCTextBox.Text = table[count].option_c;
            optionDTextBox.Text = table[count].option_d;
            answerComboBox.Text = table[count].correct_answer;

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);
            int temp = count;
            count = 0;
            caseBindingSource.ResumeBinding();
            caseBindingSource.Position = pos;
            count = temp;

            Console.WriteLine($"{count} CANCEL");
            table = ((@case)caseBindingSource.Current).cases_details.ToList();
            reset();

            if (count == 0) forward.Enabled = fastForward.Enabled = true;
            else if (count == table.Count - 1) backward.Enabled = fastBackward.Enabled = true;
            else fastBackward.Enabled = backward.Enabled = forward.Enabled = fastForward.Enabled = true;

        }

        void reset()
        {
            caseBindingSource.ResetBindings(false);

            cases_details curr = table[count];

            if (curr.option_a == curr.correct_answer) answerComboBox.SelectedIndex = 0;
            else if (curr.option_b == curr.correct_answer) answerComboBox.SelectedIndex = 1;
            else if (curr.option_c == curr.correct_answer) answerComboBox.SelectedIndex = 2;
            else if (curr.option_d == curr.correct_answer) answerComboBox.SelectedIndex = 3;
            else answerComboBox.SelectedIndex = -1;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (isEmpty(this.Controls)) return;
            else
            {
                cases_details details = table[count];

                details.text = questionTextBox.Text;
                details.option_a = optionATextBox.Text;
                details.option_b = optionBTextBox.Text;
                details.option_c = optionCTextBox.Text;
                details.option_d = optionDTextBox.Text;
                details.correct_answer = answerComboBox.SelectedIndex == 0 ? optionATextBox.Text : answerComboBox.SelectedIndex == 1 ? optionBTextBox.Text :
                    answerComboBox.SelectedIndex == 2 ? optionCTextBox.Text : answerComboBox.SelectedIndex == 3 ? optionDTextBox.Text : "";

                Db.SaveChanges();

                load(caseBindingSource, cases);
                flipMode(this.Controls);
                reset();

                MessageBox.Show("Question successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) cases = Db.cases.Where(x => x.user.name.Contains(search.Text));
            else cases = Db.cases;

            load(caseBindingSource, cases);
        }

        private void caseBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            Console.WriteLine($"{DateTime.Now}");

        }

        private void caseBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
        }

        private void caseBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {

            Console.WriteLine($"{DateTime.Now}");
        }
    }
}
