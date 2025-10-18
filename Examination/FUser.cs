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
    public partial class FUser : Form
    {
        public FUser()
        {
            InitializeComponent();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examinationDataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.examinationDataSet.roles);
            cbRol.SelectedIndex = -1;
        }
    }
}
