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

namespace Winform_Login
{
    public partial class Form1 : Form
    {
        //static SqlConnection conn = new SqlConnection(@"Data Source=SISWA-RPL-003\MSSQLSERVER02;Initial Catalog=week3;Integrated Security=True");
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Administrator> administrator = data.Administrators;
        int dgvRow = -1;
        string nama, emal, phone;
        bool onInsert = false, onUpdate = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        void loadDgv ()
        {
            dgv.Rows.Clear();

            //openConnection();

            //string query = "SELECT * FROM Customer";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            foreach (Administrator admin in administrator)
            {
                dgv.Rows.Add(admin.id, admin.Name, admin.Email, admin.Password, admin.PhoneNumber, admin.BirthDate);
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
            if (onInsert) return;

            rmv.Enabled = true;
            dgvRow = e.RowIndex;

            id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
            name.Text = dgv.Rows[dgvRow].Cells[1].Value.ToString();
            email.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
            number.Text = dgv.Rows[dgvRow].Cells[4].Value.ToString();
            birth.Value = Convert.ToDateTime(dgv.Rows[dgvRow].Cells[5].Value);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            onInsert = true;
            name.Text = email.Text = number.Text = string.Empty;
            birth.Value = DateTime.Now;
            name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled =
                cancel.Enabled = pass.Enabled = cpass.Enabled = cbRol.Enabled = true;
            insert.Enabled = update.Enabled = rmv.Enabled = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            onUpdate = true;
            name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled =
                cancel.Enabled = true;
            insert.Enabled = update.Enabled = rmv.Enabled = false;
        }

        private void rmv_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to delete this data?", "Warning", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No) return;

            Administrator delAdmin = data.Administrators.Where(x => x.id.Equals(id.Text)).FirstOrDefault();
            data.Administrators.DeleteOnSubmit(delAdmin);

            data.SubmitChanges();

            rmv.Enabled = false;

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
        private void number_TextChanged(object sender, EventArgs e)
        {
            phone = number.Text.Trim();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled = cancel.Enabled = pass.Enabled = cpass.Enabled = false;
            insert.Enabled = update.Enabled = rmv.Enabled = true;
            onInsert = onUpdate = false;
        }

        private void spass_Click(object sender, EventArgs e)
        {
            pass.UseSystemPasswordChar = cpass.UseSystemPasswordChar = !pass.UseSystemPasswordChar;
        }

        private void save_Click(object sender, EventArgs e)
        {
            //int res;
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(number.Text)) MessageBox.Show("Can't be empty!");
            //else if (!int.TryParse(number.Text, out res)) MessageBox.Show("Must be a valid phone number!");
            else
            {
                if (onInsert)
                {
                    if (pass.Text != cpass.Text)
                    {
                        MessageBox.Show("Password and Confirm Password must be the same!");
                        return;
                    }

                    Administrator newAdmins = new Administrator
                    {
                        id = administrator.Count() + 1,
                        Roleid = 2,
                        Name = nama,
                        Email = emal,
                        Password = pass.Text,
                        PhoneNumber = phone,
                        BirthDate = birth.Value
                    };

                    data.Administrators.InsertOnSubmit(newAdmins);
                    data.SubmitChanges();

                    loadDgv();
                    name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled = cancel.Enabled = false;
                    insert.Enabled = update.Enabled = rmv.Enabled = true;
                    onInsert = false;
                }
                else if (onUpdate)
                {
                    Administrator updAdmin = data.Administrators.Where(x => x.id.Equals(id.Text)).FirstOrDefault();
                    updAdmin.Name = nama;
                    updAdmin.Email = emal;
                    updAdmin.PhoneNumber = phone;
                    updAdmin.BirthDate = birth.Value;

                    data.SubmitChanges();
                    loadDgv();
                    name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled = cancel.Enabled = false;
                    insert.Enabled = update.Enabled = rmv.Enabled = true;
                    onUpdate = false;
                }
            }
        }

        private void name_Changed(object sender, EventArgs e)
        {
            nama = name.Text.Trim();
        }

        private void email_Changed(object sender, EventArgs e)
        {
            emal = email.Text.Trim();
        }
    }
}
