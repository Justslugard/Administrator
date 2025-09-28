using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Winform_Login
{
    public partial class Merchant : Form
    {
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Merchandise> merchants = data.Merchandises;
        int dgvRow = -1;
        bool onInsert = false, onUpdate = false;
        public Merchant()
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

        private void Merchant_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            onInsert = true;
            modeField(true);
            clearField();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dgvRow < 0)
            {
                MessageBox.Show("Please select a data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            onUpdate = true;
            modeField(true);
        }

        private void del_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.No) return;

            Merchandise delMerch = merchants.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
            data.Merchandises.DeleteOnSubmit(delMerch);

            data.SubmitChanges();

            del.Enabled = false;

            MessageBox.Show("Data successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDgv();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = e.RowIndex;

            if (dgvRow >= 0)
            {
                del.Enabled = true;
                id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
                name.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
                specific.Text = dgv.Rows[dgvRow].Cells[4].Value.ToString();
                model.SelectedIndex = Convert.ToInt32(dgv.Rows[dgvRow].Cells[1].Value) - 1;
                price.Text = dgv.Rows[dgvRow].Cells[5].Value.ToString();
                stock.Text = dgv.Rows[dgvRow].Cells[6].Value.ToString();
                photo.Text = dgv.Rows[dgvRow].Cells[7].Value.ToString();
                pBox.ImageLocation = $"./Resources/{photo.Text}";
            }
            else
            {
                clearField();
                del.Enabled = false;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }

        private void phButt_Click(object sender, EventArgs e)
        {
            pictureDialog.Filter = "Image Files(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg|All Files(*.*)|*.*";
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                pBox.ImageLocation = pictureDialog.FileName;
                photo.Text = pictureDialog.SafeFileName;
            }
        }

        private void debug_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"{string.IsNullOrWhiteSpace("   rambut mera mera   ")}");
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            modeField(false);
        }
        void clearField()
        {
            id.Text = name.Text = specific.Text = price.Text = stock.Text = photo.Text = pBox.ImageLocation = string.Empty;
            model.SelectedIndex = -1;
        }

        void modeField(bool state)
        {
            name.Enabled = specific.Enabled = model.Enabled = price.Enabled = stock.Enabled = save.Enabled = cancel.Enabled = phButt.Enabled = state;
            insert.Enabled = update.Enabled = dgv.Enabled = !state;
        }
        bool validation()
        {
            if (string.IsNullOrWhiteSpace(name.Text)) MessageBox.Show("Name can't be empty!");
            else if (string.IsNullOrWhiteSpace(specific.Text)) MessageBox.Show("Name can't be empty!");
            else if (model.SelectedIndex == -1) MessageBox.Show("Select a model!");
            else if (string.IsNullOrWhiteSpace(photo.Text)) MessageBox.Show("Choose a photo");
            else return true;
                return false;
        }
    }
}
