using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Login
{
    public partial class Main : Form
    {
        static public Administrator admin;
        public Main(Administrator admin)
        {
            InitializeComponent();
            Main.admin = admin;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (admin.RoleId == 2)
            {
                adminStrip.Visible = modelStrip.Visible = merchandStrip.Visible = false;
            }
        }

        private void exitStrip_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes) this.Close();
        }

        private void logoutStrip_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (res == DialogResult.Yes) Application.Restart();
        }

        private void customerStrip_Click(object sender, EventArgs e)
        {

        }

        private void adminStrip_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MAdministrator>().Count() >= 1) return;

            new MAdministrator().Show();
        }

        private void modelStrip_Click(object sender, EventArgs e)
        {

        }

        private void merchandStrip_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MMerchandise>().Count() >= 1) return;

            new MMerchandise().Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MSales>().Count() >= 1) return;

            new MSales().Show();

        }
    }
}
