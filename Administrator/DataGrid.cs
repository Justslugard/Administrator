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

namespace Winform_Login
{
    public partial class DataGrid : Form
    {
        //static SqlConnection conn = new SqlConnection(@"Data Source=SISWA-RPL-003\MSSQLSERVER02;Initial Catalog=week3;Integrated Security=True");
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Administrator> administrator = data.Administrators;
        int dgvRow = -1;
        string nama, emal, phone, passs;
        bool onInsert = false, onUpdate = false;
        public DataGrid()
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
            if (onInsert || onUpdate) return;

            rmv.Enabled = true;
            dgvRow = e.RowIndex;

            if (dgvRow < 0) { clear(); return; }

            if (dgv.Rows[dgvRow].Cells[1].Value.ToString() == "1")
            {
                cbRol.SelectedIndex = 0;
            } else
            {
                cbRol.SelectedIndex = 1;
            }

            id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
            name.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
            email.Text = dgv.Rows[dgvRow].Cells[3].Value.ToString();
            pass.Text = cpass.Text = dgv.Rows[dgvRow].Cells[4].Value.ToString();
            number.Text = dgv.Rows[dgvRow].Cells[5].Value.ToString();
            birth.Value = Convert.ToDateTime(dgv.Rows[dgvRow].Cells[6].Value);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            onInsert = true;
            clear();
            enable();
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
            pass.Enabled = false;
            cpass.Text = string.Empty;
        }

        private void rmv_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Are you sure want to delete this data?", "Warning", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No) return;

            Administrator delAdmin = administrator.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
            data.Administrators.DeleteOnSubmit(delAdmin);

            data.SubmitChanges();

            rmv.Enabled = false;

            MessageBox.Show("Data successfully deleted");

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
            if (!onUpdate) pass.UseSystemPasswordChar = !pass.UseSystemPasswordChar;
            cpass.UseSystemPasswordChar = !cpass.UseSystemPasswordChar;
        }

        private void save_Click(object sender, EventArgs e)
        {
            long res;
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(emal) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(passs) || cbRol.SelectedIndex == -1) MessageBox.Show("Can't be empty!");
            else if (emal.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).Length != 2 || !emal.Contains('.')) MessageBox.Show("Must be a valid email!");
            else if (!long.TryParse(number.Text.Remove(0, 1).Replace(" ", string.Empty).Trim(), out res) || number.Text[0] != '+') MessageBox.Show("Must be a valid phone number!");
            else if (pass.Text != cpass.Text) MessageBox.Show("Password and confirm password isn't same!");
            else
            {
                if (onInsert)
                {
                    Administrator newAdmins = new Administrator
                    {
                        RoleId = cbRol.SelectedIndex == 0 ? 1 : 2,
                        Name = nama,
                        Email = emal,
                        Password = passs,
                        PhoneNumber = phone,
                        BirthDate = birth.Value
                    };

                    data.Administrators.InsertOnSubmit(newAdmins);
                    data.SubmitChanges();

                    MessageBox.Show("Data successfully saved");

                    loadDgv();
                    clear();
                }
                else if (onUpdate)
                {
                    if (!pass.Enabled)
                    {
                        pass.Enabled = true; pass.Text = cpass.Text = string.Empty; passs = string.Empty; MessageBox.Show("Password correct"); return;
                    }
                    Administrator updAdmin = administrator.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                    updAdmin.Name = nama;
                    updAdmin.RoleId = cbRol.SelectedIndex == 0 ? 1 : 2;
                    updAdmin.Email = emal;
                    updAdmin.Password = passs;
                    updAdmin.PhoneNumber = phone;
                    updAdmin.BirthDate = birth.Value;

                    data.SubmitChanges();

                    MessageBox.Show("Data successfully updated");

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
            //long res;
            //Console.WriteLine(long.TryParse(number.Text.Remove(0, 1).Replace(" ", string.Empty).Trim(), out res));
            //Console.WriteLine(long.TryParse("123", out res));
            //Console.WriteLine(number.Text.Remove(0, 1).Replace(" ", string.Empty));
            Console.WriteLine("bot@jkjk".Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).Length == 2);
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            passs = pass.Text.Trim();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

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
    }
}
