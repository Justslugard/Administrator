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

namespace Winform_Login
{
    public partial class MCustomer : Form
    {
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Customer> customers = data.Customers;
        static int dgvRow = -1;
        static bool onInsert = false, onUpdate = false;
        public MCustomer()
        {
            InitializeComponent();
        }

        void loadDgv()
        {
            dgv.Rows.Clear();

            foreach (Customer customer in customers)
            {
                dgv.Rows.Add(customer.Id, customer.Name, customer.Email, customer.PhoneNumber);
            }
        }

        private void MCustomer_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            clearField();
            onInsert = true;
            del.Enabled = false;
            modeField(true);
            id.Text = newId();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dgvRow == -1) 
            {
                MessageBox.Show("Please select a Customer!", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            onUpdate = true;
            modeField(true);
        }

        private void del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this Customer?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            Customer delCustomer = data.Customers.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
            data.Customers.DeleteOnSubmit(delCustomer);
            data.SubmitChanges();

            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            del.Enabled = false;
            clearField();
            loadDgv();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {

                if (onInsert)
                {
                    Customer newCustomer = new Customer()
                    {
                        Id = id.Text,
                        Name = name.Text,
                        Email = email.Text,
                        PhoneNumber = pNumber.Text,
                    };
                     
                    DialogResult res = DialogResult.Yes;
                    if (string.IsNullOrWhiteSpace(pNumber.Text))
                        res = MessageBox.Show("Are you sure you want to insert/update a Customer without phone number?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.No) return;

                    data.Customers.InsertOnSubmit(newCustomer);
                    data.SubmitChanges();

                    MessageBox.Show("Customer inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    clearField();
                    loadDgv();
                    id.Text = newId();
                }
                else if (onUpdate)
                {
                    Customer updCustomer = data.Customers.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                    updCustomer.Name = name.Text;
                    updCustomer.Email = email.Text;
                    updCustomer.PhoneNumber = pNumber.Text;

                    data.SubmitChanges();

                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            onInsert = onUpdate = false;
            modeField(false);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text))
                customers = customers.Where(x => x.Name.Contains(search.Text) || x.Email.Contains(search.Text) || x.PhoneNumber.Contains(search.Text));
            else customers = data.Customers;
            loadDgv();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = e.RowIndex;
            if (dgvRow > -1 && !onInsert && !onUpdate)
            {
                id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
                name.Text = dgv.Rows[dgvRow].Cells[1].Value.ToString();
                email.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
                pNumber.Text = dgv.Rows[dgvRow].Cells[3].Value.ToString();
                del.Enabled = true;
            } else
            {
                if (!onInsert && !onUpdate) clearField();
                del.Enabled = false;
            }
        }
        void modeField(bool state)
        {
            name.Enabled = email.Enabled = pNumber.Enabled = save.Enabled = cancel.Enabled = state;
            insert.Enabled = update.Enabled = !state;
        }
        void clearField()
        {
            id.Text = name.Text = email.Text = pNumber.Text = string.Empty;
        }
        string newId()
        {
            string id = data.Customers.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;
            int year = DateTime.Now.Year;

            if (id == null || int.Parse(id.Substring(1, 4)) != year)
            {
                return $"M{year}00001";
            } else
            {
                return $"M{year}{int.Parse(id.Substring(5, 5)) + 1:00000}";
            }
        }

        private void trim_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            this.Controls[tb.Name].Text = tb.Text.Trim();
        }

        bool isValid()
        {
            Regex emailReg = new Regex(@"^[\w.]+@[\w.-]+\.\w+$"), phoneReg = new Regex(@"\+\d+( \d+)*");
            if (string.IsNullOrWhiteSpace(name.Text)) MessageBox.Show("Name can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrWhiteSpace(email.Text)) MessageBox.Show("Email can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!emailReg.IsMatch(email.Text)) MessageBox.Show("Email must be valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (data.Customers.Any(x => x.Email.Equals(email.Text) && !x.Id.Equals(id.Text))) MessageBox.Show("Email already registered!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!phoneReg.IsMatch(pNumber.Text) && !string.IsNullOrWhiteSpace(pNumber.Text)) MessageBox.Show("Phone number must be valid!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;
            return false;
        }
    }
}

