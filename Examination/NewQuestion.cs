using System.Collections.Generic;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class NewQuestion : Form
    {
        public NewQuestion()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, System.EventArgs e)
        {
            if (isEmpty(this.Controls)) return;
            else
            {
                Question.Clear();

                Question.Add("txt", questionTextBox.Text);
                Question.Add("a", optionATextBox.Text);
                Question.Add("b", optionBTextBox.Text);
                Question.Add("c", optionCTextBox.Text);
                Question.Add("d", optionDTextBox.Text);
                Question.Add("ans", answerComboBox.SelectedIndex == 0 ? Question["a"] : answerComboBox.SelectedIndex == 1 ? Question["b"] : answerComboBox.SelectedIndex == 2 ? Question["c"] :
                    answerComboBox.SelectedIndex == 3 ? Question["d"] : "");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
