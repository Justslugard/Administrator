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

namespace EsemkaLibrary
{
    public partial class Manage : Form
    {
        EsemkaLibraryEntities db = new EsemkaLibraryEntities();
        Member member = null;
        public Manage()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        }

        void load()
        {
            member = db.Members.Where(x => x.name.Equals(nameTextBox.Text) && x.deleted_at == null).FirstOrDefault();

            borrowDgv.Rows.Clear();
            foreach (Borrowing item in member.Borrowings)
            {
                if (item.fine != null) continue;

                int pass = (DateTime.Now - item.borrow_date.AddDays(7)).Days;

                int i = borrowDgv.Rows.Add(item.id, item.Book.title, item.borrow_date.ToString("dd MMMM yyyy"), item.borrow_date.AddDays(7).ToString("dd MMMM yyyy"), pass < 0 ? 0 : pass);
                ((DataGridViewLinkCell)borrowDgv.Rows[i].Cells["actionColumn"]).UseColumnTextForLinkValue = (item.fine == null || item.return_date == null) ? true : false;
                borrowDgv.Rows[i].DefaultCellStyle.BackColor = pass > 0 ? Color.Red : (pass == 0) ? Color.Yellow : Color.White;
            }
            if (borrowDgv.RowCount < 3) nbButton.Enabled = true;
            else nbButton.Enabled = false;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            member = db.Members.Where(x => x.name.Equals(nameTextBox.Text) && x.deleted_at == null).FirstOrDefault();

            if (member == null)
            {
                nbButton.Enabled = false;
                MessageBox.Show("Error! Reference source not found...", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                load();
            }
        }

        private void borrowDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex, c = e.ColumnIndex;

                if (borrowDgv.Columns["actionColumn"].Index == c)
                {
                    string bookTitle = borrowDgv.Rows[i].Cells["titleColumn"].Value.ToString();
                    decimal fine = 2000 * decimal.Parse(borrowDgv.Rows[i].Cells["overColumn"].Value.ToString());

                    MessageBox.Show($"Success return \"{bookTitle}\"\nMember needs to pay fine: {fine} IDR.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Borrowing b = db.Borrowings.Find(int.Parse(borrowDgv.Rows[i].Cells["IDColumn"].Value.ToString()));
                    b.fine = fine;
                    b.return_date = DateTime.Now.Date;
                    db.Books.Find(b.book_id).stock += 1;
                    
                    db.SaveChanges();
                    
                    ((DataGridViewLinkCell)borrowDgv.Rows[i].Cells["actionColumn"]).UseColumnTextForLinkValue = false;

                    load();
                }
            }
        }

        private void nbButton_Click(object sender, EventArgs e)
        {
            new Borrow(member).ShowDialog();
            db.Borrowings.Load();
            load();
        }
    }
}
