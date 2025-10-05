using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Winform_Login
{
    public partial class MAdministrator : Form
    {
        //static SqlConnection conn = new SqlConnection(@"Data Source=SISWA-RPL-003\MSSQLSERVER02;Initial Catalog=week3;Integrated Security=True");
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Administrator> administrator = data.Administrators;
        int dgvRow = -1;
        bool onInsert = false, onUpdate = false;
        public MAdministrator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        void loadDgv()
        {
            dgv.Rows.Clear();


                //openConnection();

                //string query = "SELECT * FROM Customer";
                //SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                //DataTable dt = new DataTable();
                //adapter.Fill(dt);

            foreach (Administrator admin in administrator)
            {
                dgv.Rows.Add(admin.Id, admin.RoleId, admin.Name, admin.Email, admin.Password, admin.PhoneNumber, admin.BirthDate);
            }
        }

        //void openConnection ()
        //{
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed)
        //        {
        //            conn.Open();
        //        }
        //    } catch (Exception e) 
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = e.RowIndex;

            if (dgvRow >= 0 && !onInsert && !onUpdate)
            {
                cbRol.SelectedIndex = Convert.ToInt32(dgv.Rows[dgvRow].Cells[1].Value) - 1;
                id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
                name.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
                email.Text = dgv.Rows[dgvRow].Cells[3].Value.ToString();
                pass.Text = cpass.Text = dgv.Rows[dgvRow].Cells[4].Value.ToString();
                number.Text = dgv.Rows[dgvRow].Cells[5].Value.ToString();
                birth.Value = Convert.ToDateTime(dgv.Rows[dgvRow].Cells[6].Value);
                rmv.Enabled = true;
            } else
            {
                if (!onInsert && !onUpdate) clear();
                rmv.Enabled = false;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            onInsert = true;
            clear();
            modeField(false);
            rmv.Enabled = false;
            id.Text = (data.Administrators.Max(x => x.Id) + 1).ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text)) 
            {
                MessageBox.Show("Please select an Administrator!", "No Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                return;
            }

            onUpdate = true;
            modeField(false);
        }

        private void rmv_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure want to delete this Administrator?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No) return;

            Administrator delAdmin = administrator.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
            data.Administrators.DeleteOnSubmit(delAdmin);

            data.SubmitChanges();

            rmv.Enabled = false;

            MessageBox.Show("Administrator deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDgv();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            modeField(true);
            pass.UseSystemPasswordChar = cpass.UseSystemPasswordChar = true;
            onInsert = onUpdate = false;
        }

        private void spass_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = cpass.UseSystemPasswordChar = !pass.UseSystemPasswordChar;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!validation()) return;
            else
            {
                if (onInsert)
                {
                    Administrator newAdmins = new Administrator
                    {
                        Id = int.Parse(id.Text),
                        RoleId = cbRol.SelectedIndex + 1,
                        Name = name.Text,
                        Email = email.Text,
                        Password = pass.Text,
                        PhoneNumber = number.Text,
                        BirthDate = birth.Value
                    };

                    data.Administrators.InsertOnSubmit(newAdmins);
                    data.SubmitChanges();

                    MessageBox.Show("Administrator inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();
                    clear();
                    id.Text = (data.Administrators.Max(x => x.Id) + 1).ToString();
                }
                else if (onUpdate)
                {
                    Administrator updAdmin = administrator.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                    updAdmin.Name = name.Text;
                    updAdmin.RoleId = cbRol.SelectedIndex + 1;
                    updAdmin.Email = email.Text;
                    updAdmin.Password = pass.Text;
                    updAdmin.PhoneNumber = number.Text;
                    updAdmin.BirthDate = birth.Value;

                    data.SubmitChanges();

                    MessageBox.Show("Administrator updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();
                }
            }
        }


        private void debug_Click(object sender, EventArgs e)
        {
            name.Text = "Nizam Rizki Syahputra";
            email.Text = "bot3445x@gmail.com";
            number.Text = "+6281234567890";
            pass.Text = cpass.Text = "password";
            birth.Value = new DateTime(2000, 1, 1);
            cbRol.SelectedIndex = 0;
        }
        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) administrator = data.Administrators.Where(x => x.Name.Contains(search.Text) || x.Email.Contains(search.Text) || x.PhoneNumber.Contains(search.Text));
            else administrator = data.Administrators;
            
            loadDgv();
        }

        void clear()
        {
            id.Text = name.Text = email.Text = number.Text = pass.Text = cpass.Text = string.Empty;
            cbRol.SelectedIndex = -1;
            birth.Value = DateTime.Now;
        }
        void modeField(bool state)
        {
            name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled =
                cancel.Enabled = cbRol.Enabled = pass.Enabled = cpass.Enabled = spass.Enabled = !state;
            insert.Enabled = update.Enabled = state;
            if (onUpdate) rmv.Enabled = state;
        }

        private void trim_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            this.Controls[tb.Name].Text = tb.Text.Trim();
        }

        bool validation()
        {
            Regex emailReg = new Regex(@"^[\w.]+@[\w.-]+\.\w+"), numberReg = new Regex(@"^\+\d+( \d+)*$");
            if (string.IsNullOrWhiteSpace(name.Text)) MessageBox.Show("Name can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(email.Text)) MessageBox.Show("Email can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(number.Text)) MessageBox.Show("Phone number can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(pass.Text)) MessageBox.Show("Password can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbRol.SelectedIndex == -1) MessageBox.Show("Role must be selected!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DateTime.Now.Year - birth.Value.Year < 18) MessageBox.Show("Age must be at least 18 years old!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!emailReg.IsMatch(email.Text)) MessageBox.Show("Must be a valid email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (administrator.Any(x => x.Email.Equals(email.Text) && !x.Id.Equals(id.Text))) MessageBox.Show("Email already registered!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!numberReg.IsMatch(number.Text)) MessageBox.Show("Must be a valid phone number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pass.Text != cpass.Text) MessageBox.Show("Password and confirm password isn't same!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

            return false;
        }
    }
}
