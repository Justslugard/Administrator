using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            load();
        }

        void load()
        {
            //userBindingSource.ResumeBinding();
            //userBindingSource.ResetBindings(false);
            userBindingSource.DataSource = db.users.ToList();
        }
    }
}
