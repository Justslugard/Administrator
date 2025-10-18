using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination
{
    public partial class Login : Form
    {
        static DataClasses1DataContext db = new DataClasses1DataContext();
        static user resu;
        public Login()
        {
            InitializeComponent();
        }
        bool isValid()
        {
            resu = db.users.Where(x => x.username.Equals(username.Text)).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(username.Text)) MessageBox.Show("Username can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(ps.Text)) MessageBox.Show("Password can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (resu == null) MessageBox.Show("No such User exist!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (resu.password != ps.Text) MessageBox.Show("Password wrong!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                return true;

            return false;
        }

        private void logkan_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                this.DialogResult = DialogResult.OK;
                Util.User = resu;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "exam")
            {
                username.Text = "participant";
                ps.Text = "e42db0f9a183ac066bdec45b0c0cf2c7";
            }
            else if (button.Name == "adm")
            {
                username.Text = "root";
                ps.Text = "21232f297a57a5a743894a0e4a801fc3";
            }
            logkan_Click(sender, e);
        }
    }
}
