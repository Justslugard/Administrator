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
    public partial class Strator : Form
    {
        //static SqlConnection conn = new SqlConnection(@"Data Source=SISWA-RPL-003\MSSQLSERVER02;Initial Catalog=week3;Integrated Security=True");
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Administrator> administrator = data.Administrators;
        int dgvRow = -1;
        string nama, emal, phone, passs;
        bool onInsert = false, onUpdate = false;
        public Strator()
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

            if (dgvRow >= 0)
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
                rmv.Enabled = false;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            onInsert = true;
            clear();
            enable();
            id.Text = (data.Administrators.Max(x => x.Id) + 1).ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text)) 
            {
                MessageBox.Show("Please choose a grid");
                return;
            }

            onUpdate = true;
            enable();
        }

        private void rmv_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure want to delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No) return;

            Administrator delAdmin = administrator.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
            data.Administrators.DeleteOnSubmit(delAdmin);

            data.SubmitChanges();

            rmv.Enabled = false;

            MessageBox.Show("Data successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDgv();
        }


        //private void number_Enter(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(phone))
        //    {
        //        number.Text = string.Empty;
        //        number.ForeColor = Color.Black;
        //    }
        //}

        //private void number_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(phone))
        //    {
        //        number.Text = "+123456789";
        //        number.ForeColor = Color.Gray;
        //        phone = string.Empty;
        //    }
        //}

        //private void email_Enter(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(emal))
        //    {
        //        email.Text = string.Empty;
        //        email.ForeColor = Color.Black;
        //    }
        //}

        //private void email_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(emal))
        //    {
        //        email.Text = "example@gmail.com";
        //        email.ForeColor = Color.Gray;
        //        emal = string.Empty;
        //    }
        //}

        //private void name_Enter(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(nama))
        //    {
        //        name.Text = string.Empty;
        //        name.ForeColor = Color.Black;
        //    }
        //}

        //private void name_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(nama))
        //    {
        //        name.Text = "Nizam Rizki Syahputra";
        //        name.ForeColor = Color.Gray;
        //        nama = string.Empty;
        //    }
        //}

        private void cancel_Click(object sender, EventArgs e)
        {
            name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled = 
                cancel.Enabled = pass.Enabled = cpass.Enabled = cbRol.Enabled = spass.Enabled = false;
            insert.Enabled = update.Enabled = true;
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
                        Id = Convert.ToInt32(id.Text),
                        RoleId = cbRol.SelectedIndex == 0 ? 1 : 2,
                        Name = nama,
                        Email = emal,
                        Password = passs,
                        PhoneNumber = phone,
                        BirthDate = birth.Value
                    };

                    data.Administrators.InsertOnSubmit(newAdmins);
                    data.SubmitChanges();

                    MessageBox.Show("Data successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();
                    clear();
                }
                else if (onUpdate)
                {
                    if (!pass.Enabled)
                    {
                        pass.Enabled = true; pass.Text = cpass.Text = string.Empty; passs = string.Empty; MessageBox.Show("Password correct"); 
                        return;
                    }
                    Administrator updAdmin = administrator.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                    updAdmin.Name = nama;
                    updAdmin.RoleId = cbRol.SelectedIndex + 1;
                    updAdmin.Email = emal;
                    updAdmin.Password = passs;
                    updAdmin.PhoneNumber = phone;
                    updAdmin.BirthDate = birth.Value;

                    data.SubmitChanges();

                    MessageBox.Show("Data successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();
                }
            }
        }

        private void number_TextChanged(object sender, EventArgs e)
        {
            phone = number.Text.Trim();
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

        private void pass_TextChanged(object sender, EventArgs e)
        {
            passs = pass.Text.Trim();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) administrator = data.Administrators.Where(x => x.Id == Convert.ToInt32(search.Text) || x.Name.Contains(search.Text) || x.Email.Contains(search.Text) || x.PhoneNumber.Contains(search.Text));
            else administrator = data.Administrators;
            
            loadDgv();
        }

        private void name_Changed(object sender, EventArgs e)
        {
            nama = name.Text.Trim();
        }

        private void email_Changed(object sender, EventArgs e)
        {
            emal = email.Text.Trim();
        }
        void clear()
        {
            id.Text = name.Text = email.Text = number.Text = pass.Text = cpass.Text = nama = emal = phone = passs = string.Empty;
            cbRol.SelectedIndex = -1;
            birth.Value = DateTime.Now;
        }
        void enable()
        {
            name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled = 
                cancel.Enabled = cbRol.Enabled = pass.Enabled = cpass.Enabled = spass.Enabled = true;
            insert.Enabled = update.Enabled = rmv.Enabled = false;
        }
        bool validation()
        {
            long res;
            Regex emailReg = new Regex(@"^+.+\@.+$");
            if (string.IsNullOrEmpty(nama)) MessageBox.Show("Name can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(emal)) MessageBox.Show("Email can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(phone)) MessageBox.Show("Phone number can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(passs)) MessageBox.Show("Password can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbRol.SelectedIndex == -1) MessageBox.Show("Role must be selected!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DateTime.Now.Year - birth.Value.Year < 18) MessageBox.Show("Age must be at least 18 years old!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!emailReg.IsMatch(emal)) MessageBox.Show("Must be a valid email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (administrator.Where(x => x.Email.Equals(emal) && (onInsert || !x.Id.Equals(id.Text))).FirstOrDefault() != null) MessageBox.Show("Email already registered!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!long.TryParse(number.Text.Remove(0, 1).Replace(" ", string.Empty).Trim(), out res) || number.Text[0] != '+') MessageBox.Show("Must be a valid phone number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pass.Text != cpass.Text) MessageBox.Show("Password and confirm password isn't same!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

            return false;
        }
    }
}
