using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodCourt.Util;

namespace FoodCourt
{
    public partial class MIngredients : Form
    {
        int pos = 0;
        static Menu menu = null;
        public MIngredients()
        {
            InitializeComponent();
        }

        private void MIngredients_Load(object sender, EventArgs e)
        {
            load(menuBindingSource, db.Menus);
            nameComboBox.DataSource = db.Ingredients.ToList();
            unitComboBox.DataSource = db.Units.ToList();
        }

        private void menuBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            menuIngredientBindingSource.DataSource = new BindingList<MenuIngredient>(((Menu)menuBindingSource.Current).MenuIngredients.ToList());
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) load(menuBindingSource, db.Menus.Where(x => x.Name.IndexOf(search.Text) >= 0));
            else load(menuBindingSource, db.Menus);
        }

        private void menuDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex, c = e.ColumnIndex;

                if (menuDataGridView.Columns["actionColumn"].Index == c && !menuBindingSource.IsBindingSuspended)
                {
                    pos = menuBindingSource.Position;
                    menu = menuBindingSource.Current as Menu;
                    menuBindingSource.SuspendBinding();
                    flip(groupBox1.Controls);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menuBindingSource.ResumeBinding();
            menuBindingSource.Position = pos;
            flip(groupBox1.Controls);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (menuIngredientDataGridView.Rows.Cast<DataGridViewRow>().Any(x => x.Cells[1].Value.ToString() == nameComboBox.Text)) MessageBox.Show("Ingredients already exist on the table!");
            else
            {
                menuIngredientBindingSource.Add(new MenuIngredient()
                {
                    ID = 0,
                    Ingredient = db.Ingredients.Find((int)nameComboBox.SelectedValue),
                    Unit = db.Units.Find((int)unitComboBox.SelectedValue),
                    Menu = menu,
                    Qty = (int)qtyNumericUpDown.Value,
                });
            }

        }

        private void menuIngredientDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex, c = e.ColumnIndex;

                if (menuIngredientDataGridView.Columns["actionColumn2"].Index == c && menuBindingSource.IsBindingSuspended)
                {
                    menuIngredientDataGridView.Rows.RemoveAt(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<MenuIngredient> bs = menuIngredientBindingSource.List.Cast<MenuIngredient>().ToList();
            List<MenuIngredient> dl = db.MenuIngredients.Where(x => x.MenuID == menu.ID).ToList();

            List<MenuIngredient> listDel = dl.Where(x => !bs.Any(y => y.ID == x.ID)).ToList();
            foreach (MenuIngredient item in listDel)
            {
                db.MenuIngredients.Remove(item);
            }

            List<MenuIngredient> listAdd = bs.Where(x => x.ID == 0).ToList();
            foreach (MenuIngredient item in listAdd)
            {
                db.MenuIngredients.Add(item);
            }
            db.SaveChanges();
            menuBindingSource.ResumeBinding();
            flip(groupBox1.Controls);
            menuBindingSource.Position = pos;
        }
    }
    public partial class MenuIngredient
    {
        public string IngredientName { get { return Ingredient?.Name ?? ""; } }
        public string UnitName { get { return Unit?.Name ?? ""; } }
    }
}
