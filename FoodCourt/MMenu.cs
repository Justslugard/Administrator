using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodCourt.Util;

namespace FoodCourt
{
    public partial class MMenu : Form
    {
        static Menu tb = null;
        static int pos = 0;
        public MMenu()
        {
            InitializeComponent();
        }
        void g()
        {
            load(menuBindingSource, db.Menus);
        }

        private void MMenu_Load(object sender, EventArgs e)
        {
            g();
            db.Categories.Load();
            comboBox1.DataSource = db.Categories.Local.ToBindingList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tb = null;
            menuBindingSource.SuspendBinding();
            flip(this.Controls);
        }

        private void menuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (menuBindingSource.IsBindingSuspended) return;

            pos = menuBindingSource.Position;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb = menuBindingSource.Current as Menu;

            if (tb == null) return;

            menuBindingSource.SuspendBinding();
            flip(this.Controls);
            nameTextBox.Text = tb.Name;
            comboBox1.Text = tb.Category.Name;
            descriptionTextBox.Text = tb.Description;
            priceNumericUpDown.Value = (decimal)tb.Price;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb = menuBindingSource.Current as Menu;

            if (tb == null) return;

            if (MessageBox.Show("Are you sure you want to delete this menu?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Menus.Remove(tb);
                db.SaveChanges();
                g();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flip(this.Controls);
            menuBindingSource.ResumeBinding();
            menuBindingSource.Position = pos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new[] { nameTextBox.Text, comboBox1.Text, descriptionTextBox.Text }.Any(string.IsNullOrWhiteSpace)) MessageBox.Show("All fields must be filled!");
            else
            {
                if (tb == null)
                {
                    db.Menus.Add(new Menu()
                    {
                        Name = nameTextBox.Text,
                        Category = db.Categories.Find((int)comboBox1.SelectedValue),
                        Description = descriptionTextBox.Text,
                        Price = (double)priceNumericUpDown.Value
                    });
                }
                else
                {
                    Menu m = db.Menus.Find(tb.ID);
                    m.Name = nameTextBox.Text;
                    m.Category = db.Categories.Find((int)comboBox1.SelectedValue);
                    m.Description = descriptionTextBox.Text;
                    m.Price = (double)priceNumericUpDown.Value;
                }
                db.SaveChanges();
                g();
                flip(this.Controls);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) load(menuBindingSource, db.Menus.Where(x => x.Name.IndexOf(search.Text) >= 0 || x.Category.Name.IndexOf(search.Text) >= 0));
            else g();
        }
    }
    public partial class Menu
    {
        public string FormattedPrice { get { return Price.ToString("C", new CultureInfo("id-ID")); } }
        public string CategoryName { get { return Category?.Name ?? ""; } }
    }
}
