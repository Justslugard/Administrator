using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Score.Util;

namespace Score
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            teacher = db.Teachers.Where(x => x.Email.Equals(textBox2.Text) && x.Password.Equals(textBox1.Text)).FirstOrDefault();


            if (!Regex.IsMatch(textBox2.Text, @"^[\w.]+@[\w.-]+\.\w+")) MessageBox.Show("Invalid email format!");
            else if (teacher == null) MessageBox.Show("Please Try Again, Your Data Is Not Valid!");
            else
            {
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                if (new MDI().ShowDialog() == DialogResult.OK) this.Show();
                else this.Close();
            }
        }
    }
}
