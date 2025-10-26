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
            new NewQuestion().ShowDialog();
        }

        private void cases_detailsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void submit_Click(object sender, System.EventArgs e)
        {
            Regex codeReg = new Regex(@"^CASE[\d]{5}$");

            if (isEmpty(this.Controls)) return;
            else if (!codeReg.IsMatch(codeTextBox.Text)) MessageBox.Show("Invalid code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {

            }
        }
    }
}
