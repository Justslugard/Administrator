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
        static IQueryable<type> types = db.types;
        static List<string> doNot = new List<string>()
        {
            "TextBox"
        };
        static type table = null;

        public FType()
        {
            InitializeComponent();
        }

        private void FType_Load(object sender, EventArgs e)
        {
            load(typeBindingSource, types);

            foreach (Control control in this.Controls)
            {
                Console.WriteLine(control);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls);
            typeBindingSource.SuspendBinding();
            idTextBox.Text = nextId("types");
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) types = db.types.Where(x => x.name.Contains(search.Text));
            else types = db.types;

            load(typeBindingSource, types);
        }

        private void update_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls);

            table = (type)typeBindingSource.Current;
            typeBindingSource.SuspendBinding();

            idTextBox.Text = table.id.ToString();
            codeTextBox.Text = table.code.ToString();
            nameTextBox.Text = table.name.ToString();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);

            table = (type)typeBindingSource.Current;
            typeBindingSource.SuspendBinding();

            idTextBox.Text = table.id.ToString();
            codeTextBox.Text = table.code.ToString();
            nameTextBox.Text = table.name.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                type type = db.types.Find(table?.id);

                if (table == null && codeTextBox.Enabled)
                {
                    type newType = new type()
                    {
                        code = codeTextBox.Text,
                        name = nameTextBox.Text,
                        created_at = DateTime.Now,
                        deleted_at = null
                    };
                    db.types.Add(newType);
                } else if (!codeTextBox.Enabled) 
                {
                    if (MessageBox.Show("Are you sure you want to delete this data?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        type.deleted_at = DateTime.Now;
                    }
                } else
                {
                    type.code = codeTextBox.Text;
                    type.name = nameTextBox.Text;
                }

                db.SaveChanges();
                load(typeBindingSource, types);
                flipMode(this.Controls, nameTextBox.Enabled ? null : doNot);
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, nameTextBox.Enabled ? null : doNot);
            typeBindingSource.ResumeBinding();
        }

        bool isValid()
        {
            Regex codeReg = new Regex(@"^[A-Z]{3}[\d]{0,2}$");
            if (isEmpty(this.Controls)) return false;
            else if (!codeReg.IsMatch(codeTextBox.Text)) MessageBox.Show("Invalid code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

            return false;
        }
    }
}
