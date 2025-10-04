using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_Login
{
    public partial class Sales : Form
    {
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Merchandise> merchants = data.Merchandises;
        static int dgvRow = -1;
        public Sales()
        {
            InitializeComponent();
        }

        void loadDgv()
        {
            dgv.Rows.Clear();

            foreach (Merchandise merchandise in merchants)
            {
                dgv.Rows.Add(merchandise.Id, merchandise.ModelId, merchandise.Name, merchandise.Model.Name, merchandise.Specification, merchandise.Price, merchandise.Stock, merchandise.ImagePath);
            }
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            loadDgv();
            total.Text = newTotal();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearField();
            dgvRow = e.RowIndex;

            if (dgvRow < 0) 
            {
                modeField(false);
                return;
            }
            name.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
            price.Text = dgv.Rows[dgvRow].Cells[5].Value.ToString();
            pBox.ImageLocation = dgv.Rows[dgvRow].Cells[7].Value.ToString().Contains("\\") ? dgv.Rows[dgvRow].Cells[7].Value.ToString() : $"./Assets/Images/{dgv.Rows[dgvRow].Cells[7].Value.ToString()}";
            add.Text = "Add";
            modeField(true);
        }
        private void vgd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vgdRow = e.RowIndex;
            if (vgdRow > -1 && e.ColumnIndex == vgd.Columns["remove"].Index)
            {
                vgd.Rows.RemoveAt(e.RowIndex);
                total.Text = newTotal();
                clearField();
            } else if (vgdRow > -1)
            {
                name.Text = vgd.Rows[vgdRow].Cells[2].Value.ToString();
                price.Text = vgd.Rows[vgdRow].Cells[5].Value.ToString();
                qty.Text = vgd.Rows[vgdRow].Cells[4].Value.ToString();
                pBox.ImageLocation = vgd.Rows[vgdRow].Cells[7].Value.ToString().Contains("\\") ? dgv.Rows[dgvRow].Cells[7].Value.ToString() : $"./Assets/Images/{vgd.Rows[vgdRow].Cells[7].Value.ToString()}";
                add.Text = "Edit";
                modeField(true);
            } else
            {
                modeField(false);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                for (int i = 0; i < vgd.Rows.Count; i++)
                {
                    if (vgd.Rows[i].Cells[0].Value.ToString() == dgv.Rows[dgvRow].Cells[0].Value.ToString())
                    {
                        if (add.Text == "Add")
                        {
                            int Qty = int.Parse(vgd.Rows[i].Cells[4].Value.ToString());
                            vgd.Rows[i].Cells[4].Value = Qty + int.Parse(qty.Text);
                            vgd.Rows[i].Cells[6].Value = int.Parse(vgd.Rows[i].Cells[4].Value.ToString()) * int.Parse(price.Text);
                            total.Text = newTotal();
                            return;
                        }
                        else if (add.Text == "Edit")
                        {
                            vgd.Rows[i].Cells[4].Value = qty.Text;
                            vgd.Rows[i].Cells[6].Value = (int.Parse(qty.Text) * int.Parse(price.Text)).ToString();
                            total.Text = newTotal();
                            return;
                        }
                    }
                }
                vgd.Rows.Add(dgv.Rows[dgvRow].Cells[0].Value.ToString(),
                    dgv.Rows[dgvRow].Cells[1].Value.ToString(),
                    dgv.Rows[dgvRow].Cells[2].Value.ToString(),
                    dgv.Rows[dgvRow].Cells[3].Value.ToString(),
                    qty.Text, price.Text, (int.Parse(qty.Text) * int.Parse(price.Text)).ToString(),
                    dgv.Rows[dgvRow].Cells[7].Value.ToString());
                total.Text = newTotal();
            }
        }

        
        bool isValid ()
        {
            if (dgvRow < 0) MessageBox.Show("Please select a merchandise!");
            else if (string.IsNullOrWhiteSpace(qty.Text)) MessageBox.Show("Quantity can't be empty!");
            else if (int.Parse(qty.Text) < 1) MessageBox.Show("Quantity must be more than zero!");
            else if (int.Parse(qty.Text) > int.Parse(dgv.Rows[dgvRow].Cells[6].Value.ToString())) MessageBox.Show("Quantity exceeds stock!");
            else return true;
            return false;
        }

        void clearField()
        {
            name.Text = price.Text = qty.Text = pBox.ImageLocation = string.Empty;
        }
        void modeField(bool state)
        {
            add.Enabled = qty.Enabled = state;
        }

        string newTotal()
        {
            int total = 0;
            for (int i = 0; i < vgd.Rows.Count; i++) 
            {
                total += int.Parse(vgd.Rows[i].Cells[6].Value.ToString());
            }
            return total.ToString("C", CultureInfo.GetCultureInfo("id"));
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text))
                merchants = data.Merchandises.Where(x => x.Id.Contains(search.Text) || x.Name.Contains(search.Text) || x.Specification.Contains(search.Text));
            else merchants = data.Merchandises;

            loadDgv();
        }

        private void vgd_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            buy.Enabled = true;
        }

        private void vgd_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            buy.Enabled = false;
        }

        private void buy_Click(object sender, EventArgs e)
        {
            new Payment(vgd.Rows, total.Text).ShowDialog();
        }
    }
}
