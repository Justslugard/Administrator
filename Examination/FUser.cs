using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class FUser : Form
    {
        static IQueryable<user> users = Db.users;
        static user table = null;
        static List<string> doNot = new List<string>()
        {
            "TextBox",
            "ComboBox"
        };
        static int pos = 0;

        public FUser()
        {
            InitializeComponent();
        }

        private void FUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examDataSet.roles' table. You can move, or remove it, as needed.
            this.rolesTableAdapter.Fill(this.examDataSet.roles);

            List<role> filter = Db.roles.ToList();
            role alrol = new role() { id = 0, name = "All", created_at = DateTime.Now };

            filter.Insert(0, alrol);

            cbFilt.ValueMember = "id";
            cbFilt.DisplayMember = "name";
            cbFilt.DataSource = filter;

            load(userBindingSource, users);
        }

        private void cbFilt_Leave(object sender, EventArgs e)
        {
            if (cbFilt.Text == "All")
            {
                users = Db.users;
            }
            else
            {
                users = Db.users.Where(x => x.role_id.Equals((int)cbFilt.SelectedValue));
            }

            load(userBindingSource, users);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text))
            {
                users = users.Where(x => x.name.Contains(search.Text));
                load(userBindingSource, users);
            }
            else cbFilt_Leave(sender, e);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls);

            userBindingSource.SuspendBinding();

            idTextBox.Text = nextId("users");
            roleComboBox.SelectedIndex = -1;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            table = (user)userBindingSource.Current;
            Button b = sender as Button;

            if (table == null)
                MessageBox.Show("There aren't any data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                flipMode(this.Controls, b.Name == "update" ? new List<string>() { "passwordTextBox", "idTextBox" } : doNot);

                userBindingSource.SuspendBinding();
                idTextBox.Text = table.id.ToString();
                roleComboBox.SelectedValue = table.role_id;
                usernameTextBox.Text = table.username.ToString();
                passwordTextBox.Text = table.password.ToString();
                nameTextBox.Text = table.name.ToString();
                emailTextBox.Text = table.email.ToString();
                phoneTextBox.Text = table.phone.ToString();
                genderComboBox.Text = table.gender.ToString();
                addressTextBox.Text = table.address.ToString();

            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                user user = Db.users.Find(table?.id);

                if (table == null && usernameTextBox.Enabled)
                {
                    user newUser = new user()
                    {
                        role_id = (int)roleComboBox.SelectedValue,
                        username = usernameTextBox.Text,
                        password = encryptMD5(passwordTextBox.Text),
                        name = nameTextBox.Text,
                        email = emailTextBox.Text,
                        phone = phoneTextBox.Text,
                        gender = genderComboBox.Text,
                        address = addressTextBox.Text,
                        created_at = DateTime.Now,
                        deleted_at = null
                    };
                    Db.users.Add(newUser);

                    MessageBox.Show("New user successfully inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!usernameTextBox.Enabled)
                {
                    if (MessageBox.Show("Are you sure you want to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        user.deleted_at = DateTime.Now;
                    }
                    MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    user.role = Db.roles.Find(roleComboBox.SelectedValue);
                    user.username = usernameTextBox.Text;
                    user.password = passwordTextBox.Text;
                    user.name = nameTextBox.Text;
                    user.email = emailTextBox.Text;
                    user.phone = phoneTextBox.Text;
                    user.gender = genderComboBox.Text;
                    user.address = addressTextBox.Text;
                    user.created_at = table.created_at;
                    user.deleted_at = table.deleted_at;

                    MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Db.SaveChanges();

                load(userBindingSource, users);

                flipMode(this.Controls, usernameTextBox.Enabled ? null : doNot);
                passwordTextBox.Enabled = false;
                userBindingSource.Position = pos;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, usernameTextBox.Enabled ? null : doNot);
            passwordTextBox.Enabled = false;
            table = null;

            userBindingSource.ResumeBinding();
            userBindingSource.Position = pos;
        }
        bool isValid()
        {
            int id = int.Parse(idTextBox.Text);
            long output;
            Regex emailReg = new Regex(@"^[\w.]+@[\w.-]+\.\w+");
            if (isEmpty(this.Controls)) return false;
            else if (usernameTextBox.Text.Length <= 3) MessageBox.Show("Username must be more than 3 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Db.users.Any(x => x.username.Equals(usernameTextBox.Text) && !x.id.Equals(id))) MessageBox.Show("Username must be unique!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if ((passwordTextBox.Text.Length <= 5 || passwordTextBox.Text.Length >= 12) && (table?.password?.Equals(passwordTextBox) ?? true)) MessageBox.Show("Password must be between 5 and 12 characters!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!emailReg.IsMatch(emailTextBox.Text)) MessageBox.Show("Email must be valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!long.TryParse(phoneTextBox.Text, out output)) MessageBox.Show("Phone must be number only!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;
            return false;
        }

        private void userDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (userBindingSource.IsBindingSuspended) return;

            pos = userBindingSource.Position;
        }
    }
}
