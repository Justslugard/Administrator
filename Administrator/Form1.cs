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
        static IQueryable<Customer> customers = data.Customers;
        int dgvRow = -1;
        string nama, emal, phone;
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

            foreach (Customer customer in customers)
            {
                dgv.Rows.Add(customer.Id, customer.Name, customer.Email, customer.PhoneNumber);
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

            name.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
            email.Text = dgv.Rows[dgvRow].Cells[1].Value.ToString();
            number.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
            name.ForeColor = email.ForeColor = number.ForeColor = Color.Black;
        }

        private void add_Click(object sender, EventArgs e)
        {
            int res;
            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(emal) || string.IsNullOrEmpty(phone)) MessageBox.Show("Can't be empty!");
            else if (!int.TryParse(phone, out res)) MessageBox.Show("Must be a valid phone number!");
            else
            {
                dgv.Rows.Add(nama, emal, phone);
                nama = emal = phone = string.Empty;
                name_Leave(sender, e);
                email_Leave(sender, e);
                number_Leave(sender, e);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int res;
            if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(number.Text)) MessageBox.Show("Can't be empty!");
            else if (!int.TryParse(number.Text, out res)) MessageBox.Show("Must be a valid phone number!");
            else
            {
                dgv.Rows[dgvRow].Cells[0].Value = nama;
                dgv.Rows[dgvRow].Cells[1].Value = emal;
                dgv.Rows[dgvRow].Cells[2].Value = phone;
            }
        }

        private void rmv_Click(object sender, EventArgs e)
        {
            if (dgvRow < 0) MessageBox.Show("There aren't anymore cells");
            else
            {
                dgv.Rows.RemoveAt(dgvRow);
                dgvRow--;
            }
        }


        private void number_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phone))
            {
                number.Text = string.Empty;
                number.ForeColor = Color.Black;
            }
        }

        private void number_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phone))
            {
                number.Text = "+123456789";
                number.ForeColor = Color.Gray;
                phone = string.Empty;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emal))
            {
                email.Text = string.Empty;
                email.ForeColor = Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emal))
            {
                email.Text = "example@gmail.com";
                email.ForeColor = Color.Gray;
                emal = string.Empty;
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nama))
            {
                name.Text = string.Empty;
                name.ForeColor = Color.Black;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nama))
            {
                name.Text = "Nizam Rizki Syahputra";
                name.ForeColor = Color.Gray;
                nama = string.Empty;
            }
        }
        private void number_TextChanged(object sender, EventArgs e)
        {
            phone = number.Text.Trim();
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
