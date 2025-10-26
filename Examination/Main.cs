using System;
using System.Linq;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Util.User.role_id > 1) masterToolStripMenuItem.Visible = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) Application.Exit();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FUser>().Count() >= 1) return;

            new FUser().Show();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FType>().Count() >= 1) return;

            new FType().Show();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FRoom>().Count() >= 1) return;

            new FRoom().Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ViewCase>().Count() >= 1) return;

            new ViewCase().Show();
        }

        private void newCaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<NewCase>().Count() >= 1) return;

            new NewCase().Show();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FSchedule>().Count() >= 1) return;

            new FSchedule().Show();
        }
    }
}
