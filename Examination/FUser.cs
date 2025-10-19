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
        static IQueryable<user> users = db.users;
        static user table;

        public FUser()
        {
            InitializeComponent();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.examDataSet.users);
            // TODO: This line of code loads data into the 'examDataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.examDataSet.roles);

            List<role> filter = db.roles.ToList();
            role alrol = new role() { id = 0, name = "All", created_at = DateTime.Now };

            filter.Insert(0, alrol);

            cbFilt.ValueMember = "id";
            cbFilt.DisplayMember = "name";
            cbFilt.DataSource = filter;

            load();
        }

        void load()
        {
            userBindingSource.ResumeBinding();
            userBindingSource.ResetBindings(false);
            userBindingSource.DataSource = users.ToList();
        }

        private void cbFilt_Leave(object sender, EventArgs e)
        {
            if (cbFilt.Text == "All")
            {
                users = db.users;
            } else
            {
                users = db.users.Where(x => x.role_id.Equals((int) cbFilt.SelectedValue));
            }

            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) 
            { 
                users = users.Where(x => x.name.Contains(search.Text)); 
                load(); 
            }
            else cbFilt_Leave(sender, e);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            modeField(this.Controls);

            userBindingSource.SuspendBinding();

            idTextBox.Text = nextId("users");
            roleComboBox.SelectedIndex = -1;
            table = null;
        }

        private void update_Click(object sender, EventArgs e)
        {
            modeField(this.Controls);

            table = (user)userBindingSource.Current;
            userBindingSource.SuspendBinding();

            idTextBox.Text = table.id.ToString();
            roleComboBox.SelectedIndex = table.role_id - 1;
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            modeField(this.Controls);
            userBindingSource.ResumeBinding();
        }
    }
}
