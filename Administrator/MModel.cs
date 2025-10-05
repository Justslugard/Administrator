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
    public partial class MModel : Form
    {
        static DataClasses1DataContext data = new DataClasses1DataContext();
        static IQueryable<Model> models = data.Models;
        static int dgvRow = -1;
        static bool onInsert = false, onUpdate = false;
        public MModel()
        {
            InitializeComponent();
        }

        void loadDgv()
        {
            dgv.Rows.Clear();

            foreach (Model model in models)
            {
                dgv.Rows.Add(model.Id, model.Name);
            }
        }

        private void MModel_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            onInsert = true;
            modeField(true);
            id.Text = name.Text = string.Empty;
            del.Enabled = false;
            id.Text = newId().ToString();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (dgvRow == -1) 
            {
                MessageBox.Show("Please select a model!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            onUpdate = true;
            modeField(true);
        }

        private void del_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this model?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.No) return;

            Model delModel = data.Models.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
            data.Models.DeleteOnSubmit(delModel);
            data.SubmitChanges();

            MessageBox.Show("Model deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDgv();
            id.Text = name.Text = string.Empty;
            del.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text)) MessageBox.Show("Name can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (onInsert)
                {
                    Model newModel = new Model() 
                    { 
                        Id = int.Parse(id.Text),
                        Name = name.Text
                    };
                    data.Models.InsertOnSubmit(newModel);
                    data.SubmitChanges();

                    MessageBox.Show("Model inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    loadDgv();

                    id.Text = newId().ToString();
                    name.Text = string.Empty;
                } else if (onUpdate)
                {
                    Model updModel = data.Models.Where(x => x.Id.Equals(id.Text)).FirstOrDefault();
                    updModel.Name = name.Text;

                    data.SubmitChanges();
                    MessageBox.Show("Model updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (!string.IsNullOrWhiteSpace(search.Text)) models = data.Models.Where(x => x.Name.Contains(search.Text));
            else models = data.Models;

            loadDgv();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRow = e.RowIndex;

            if (dgvRow > -1 && !onInsert && !onUpdate)
            {
                id.Text = dgv.Rows[dgvRow].Cells[0].Value.ToString();
                name.Text = dgv.Rows[dgvRow].Cells[1].Value.ToString();
                del.Enabled = true;
            } else
            {
                if (!onInsert && !onUpdate) 
                { 
                    id.Text = name.Text = string.Empty;
                }
                del.Enabled = false;
            }
        }
        void modeField(bool state)
        {
            name.Enabled = save.Enabled = cancel.Enabled = state;
            insert.Enabled = update.Enabled = !state;
        }

        private void name_Leave(object sender, EventArgs e)
        {
            name.Text = name.Text.Trim();
        }

        int newId()
        {
            return data.Models.Max(x => x.Id) + 1;
        }
    }
}
