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
        int admin;
        public Main(int admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (admin == 2)
            {
                ToolStripItem menu = menuStrip1.Items["Manage"];
            }
        }
    }
}
