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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            name.Text = teacher.TeacherName;

            if (teacher.Role == "Admin")
            {
                gbm.Text = "Master Data";
                upB.Text = "Manage Teacher";
                midB.Text = "Manage Student";
                lB.Text = "Manage Subject";
            } else
            {
                gbm.Text = "Menu";
                upB.Text = "Submit Score";
                midB.Text = "View Score";
                lB.Text = "View Report Student";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void upB_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text == "Master Teacher")
            {
                new MTeacher().ShowDialog();
            }
        }
    }
}
