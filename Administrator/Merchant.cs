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
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;

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
            // TODO: This line of code loads data into the 'asusDataSet1.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.asusDataSet1.Model);
            model.SelectedIndex = -1;
            loadDgv();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            onInsert = true;
            modeField(true);
            clearField();
            id.Text = newId();
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

            clearField();
            loadDgv();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = e.RowIndex;

            if (dgvRow >= 0 && !onInsert && !onUpdate)
            {
                del.Enabled = true;
                id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
                name.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
                specific.Text = dgv.Rows[dgvRow].Cells[4].Value.ToString();
                model.SelectedIndex = Convert.ToInt32(dgv.Rows[dgvRow].Cells[1].Value) - 1;
                price.Text = dgv.Rows[dgvRow].Cells[5].Value.ToString();
                stock.Text = dgv.Rows[dgvRow].Cells[6].Value.ToString();
                photo.Text = dgv.Rows[dgvRow].Cells[7].Value.ToString().Split('\\').Last();
                pBox.ImageLocation = dgv.Rows[dgvRow].Cells[7].Value.ToString().Contains("\\") ? dgv.Rows[dgvRow].Cells[7].Value.ToString() : $"./Assets/Images/{photo.Text}";
            }
            else
            {
                del.Enabled = false;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) 
                merchants = data.Merchandises.Where(x => x.Id.Contains(search.Text) || x.Name.Contains(search.Text) || x.Specification.Contains(search.Text));
            else merchants = data.Merchandises;

            loadDgv();
        }

        private void phButt_Click(object sender, EventArgs e)
        {
            pictureDialog.Filter = "Image Files(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg|All Files(*.*)|*.*";
            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = pictureDialog.SafeFileName;

                pBox.ImageLocation = pictureDialog.FileName;
                photo.Text = filePath;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            modeField(false);
            if (onInsert) clearField();
            onInsert = onUpdate = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                if (onInsert)
                {
                    Merchandise merchandise = new Merchandise()
                    {
                        Id = newId(),
                        ModelId = (int) model.SelectedValue,
                        Name = name.Text.Trim(),
                        Specification = specific.Text.Trim(),
                        Price = (int) price.Value,
                        Stock = (int) stock.Value,
                        ImagePath = pictureDialog.FileName
                    };

                    DialogResult res = DialogResult.Yes;
                    if (string.IsNullOrWhiteSpace(photo.Text))
                    {
                        res = MessageBox.Show("Are you sure you want to insert a merchandise without a photo?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }

                    if (res == DialogResult.No) return;

                    data.Merchandises.InsertOnSubmit(merchandise);
                    data.SubmitChanges();

                    MessageBox.Show("Successfully insert a new merchandise", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();
                    clearField();
                    id.Text = newId();
                }
                else if (onUpdate)
                {
                    Merchandise merchandise = data.Merchandises.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                    merchandise.Name = name.Text.Trim();
                    merchandise.Model = data.Models.Single(x => x.Id.Equals((int)model.SelectedValue));
                    merchandise.Specification = specific.Text.Trim();
                    merchandise.Price = (int)price.Value;
                    merchandise.Stock = (int)stock.Value;
                    merchandise.ImagePath = pictureDialog.FileName;

                    data.SubmitChanges();

                    MessageBox.Show("Successfully update a merchandise", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();
                }
            }
        }

        private void debug_Click(object sender, EventArgs e)
        {
            name.Text = "Seg";
            specific.Text = "100kg";
            model.SelectedIndex = 5;
            price.Value = 8000;
            stock.Value = 70;

            Console.WriteLine(pBox.ImageLocation);
            //photo.Text = "dummy.png";
        }
    }
}
