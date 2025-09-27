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
    public partial class Merchant : Form
    {
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Merchandise> merchants = data.Merchandises;
        int dgvRow = -1;
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = e.RowIndex;

            if (dgvRow >= 0)
            {
                id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
                name.Text = dgv.Rows[dgvRow].Cells[2].Value.ToString();
                specific.Text = dgv.Rows[dgvRow].Cells[4].Value.ToString();
                model.SelectedIndex = Convert.ToInt32(dgv.Rows[dgvRow].Cells[1].Value) - 1;
                price.Text = dgv.Rows[dgvRow].Cells[5].Value.ToString();
                stock.Text = dgv.Rows[dgvRow].Cells[6].Value.ToString();
                photo.Text = dgv.Rows[dgvRow].Cells[7].Value.ToString();
            }
        }
    }
}
