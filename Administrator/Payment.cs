using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Login
{
    public partial class Payment : Form
    {
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Customer> customers = data.Customers;
        DataGridViewRowCollection grid;
        string totaL;
        public Payment(DataGridViewRowCollection grid, string totaL)
        {
            InitializeComponent();
            this.grid = grid;
            this.totaL = totaL;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            total.Text = totaL;
        }

        private void check_Click(object sender, EventArgs e)
        {
            bool customerIsAvaileable = customers.Any(x => x.Id.Equals(id.Text));

            if (customerIsAvaileable) pay.Enabled = true;
            else MessageBox.Show("No such customer exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                SalesHeader newHeader = new SalesHeader();
                newHeader.Id = newHeaderId();
                newHeader.AdministratorId = Main.admin?.Id ?? 1;
                newHeader.CustomerId = id.Text;
                newHeader.Date = DateTime.Now;
                newHeader.PaymentType = card.Checked ? "card" : "cash";
                if (card.Checked) newHeader.CardNumber = cNumber.Text; 

                data.SalesHeaders.InsertOnSubmit(newHeader);
                data.SubmitChanges();

                for (int i = 0; i < grid.Count; i++) 
                {
                    SalesDetail newSales = new SalesDetail();
                    newSales.Id = data.SalesDetails.OrderByDescending(x => x.Id).FirstOrDefault() == null ? 1 : data.SalesDetails.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
                    newSales.SalesHeaderId = newHeader.Id;
                    newSales.MerchandiseId = grid[i].Cells[0].Value.ToString();
                    newSales.Qty = int.Parse(grid[i].Cells[4].Value.ToString());
                    newSales.Price = int.Parse(grid[i].Cells[5].Value.ToString());

                    data.SalesDetails.InsertOnSubmit(newSales);
                    data.SubmitChanges();
                }

                MessageBox.Show("Payment successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void card_CheckedChanged(object sender, EventArgs e)
        {
            if (card.Checked) cNumber.Enabled = true;
            else cNumber.Enabled = false;
        }
        bool isValid ()
        {
            if (cNumber.Enabled && cNumber.Text.Length != 16) MessageBox.Show("Credit Card Must Be 16 Digit long!");
            else return true;
            return false;
        }
        string newHeaderId ()
        {
            string headerID = data.SalesHeaders.OrderByDescending(x => x.Id).FirstOrDefault()?.Id;
            int year = DateTime.Now.Year,
                month = DateTime.Now.Month;
            if (headerID == null || int.Parse(headerID.Substring(1, 4)) != year)
            {
                return $"{year}{month}00001";
            }
            else 
            {
                return $"{year}{month:00}{headerID.Substring(7, 5) + 1:00000}";
            }
        }
    }
}
