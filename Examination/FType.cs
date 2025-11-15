using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class FType : Form
    {
        static IQueryable<type> types = Db.types;
        static List<string> doNot = new List<string>()
        {
            "TextBox"
        };
        static type table = null;
        static int pos = 0;

        public FType()
        {
            InitializeComponent();
        }

        private void FType_Load(object sender, EventArgs e)
        {
            load(typeBindingSource, types);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls);
            typeBindingSource.SuspendBinding();
            idTextBox.Text = nextId("types");
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) types = Db.types.Where(x => x.name.Contains(search.Text));
            else types = Db.types;

            load(typeBindingSource, types);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            table = (type)typeBindingSource.Current;

            if (table == null)
                MessageBox.Show("There aren't any data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                flipMode(this.Controls, b.Name == "update" ? null : doNot);
                typeBindingSource.SuspendBinding();

                idTextBox.Text = table.id.ToString();
                codeTextBox.Text = table.code.ToString();
                nameTextBox.Text = table.name.ToString();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                type type = Db.types.Find(table?.id);

                if (table == null && codeTextBox.Enabled)
                {
                    type newType = new type()
                    {
                        code = codeTextBox.Text,
                        name = nameTextBox.Text,
                        created_at = DateTime.Now,
                        deleted_at = null
                    };
                    Db.types.Add(newType);

                    MessageBox.Show("New type successfully inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (!codeTextBox.Enabled) 
                {
                    if (MessageBox.Show("Are you sure you want to delete this type?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        type.deleted_at = DateTime.Now;
                        MessageBox.Show("Type successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    type.code = codeTextBox.Text;
                    type.name = nameTextBox.Text;

                    MessageBox.Show("Type successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Db.SaveChanges();
                load(typeBindingSource, types);
                flipMode(this.Controls, nameTextBox.Enabled ? null : doNot);
                table = null;
                typeBindingSource.Position = pos;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, nameTextBox.Enabled ? null : doNot);
            typeBindingSource.ResumeBinding();
            table = null;
            typeBindingSource.Position = pos;
        }

        bool isValid()
        {
            Regex codeReg = new Regex(@"^[A-Z]{3}[\d]{0,2}$");
            if (isEmpty(this.Controls)) return false;
            else if (!codeReg.IsMatch(codeTextBox.Text)) MessageBox.Show("Invalid code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

            return false;
        }

        private void typeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (typeBindingSource.IsBindingSuspended) return;

            pos = typeBindingSource.Position;
        }
    }
}
