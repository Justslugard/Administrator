using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodCourt.Util;

namespace FoodCourt
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }

        private void AdminMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            welcome.Text = $"Welcome, {user.FirstName} {user.LastName}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MMembers().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MMenu().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MIngredients().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new ViewReservations().Show();
        }
    }
}
