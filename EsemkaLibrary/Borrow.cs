using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsemkaLibrary
{
    public partial class Borrow : Form
    {
        static EsemkaLibraryEntities db = new EsemkaLibraryEntities();
        static IQueryable<Book> books = db.Books;
        static Member member = db.Members.Find(2);

        public Borrow(Form m)
        {
            InitializeComponent();
            member = m;
        }

        void load()
        {
            borrowDgv.Rows.Clear();
            foreach (Book book in books)
            {
                int i = borrowDgv.Rows.Add(book.id, book.title, String.Join(", ", book.BookGenres.Select(x => x.Genre.name).ToArray()), book.author, book.publish_date, book.stock);

                if (int.Parse(borrowDgv.Rows[i].Cells["stock"].Value.ToString()) <= 0)
                {
                    DataGridViewRow row = borrowDgv.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.Red;
                    ((DataGridViewLinkCell)row.Cells["actionColumn"]).UseColumnTextForLinkValue = false;
                }
            }
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            load();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text)) books = db.Books.Where(x => x.title.Contains(nameTextBox.Text));
            else books = db.Books;
            load();
        }

        private void borrowDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int i = e.RowIndex, c = e.ColumnIndex;
                if (borrowDgv.Columns["actionColumn"].Index == c)
                {
                    DataGridViewRow row = borrowDgv.Rows[i];

                    MessageBox.Show($"Success borrow \"{row.Cells["title"].Value}.\"\nDue date is 7 days from today.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    db.Books.Find(int.Parse(row.Cells["id"].Value.ToString())).stock -= 1;
                    db.Borrowings.Add(new Borrowing()
                    {
                        member_id = member.id,
                        book_id = int.Parse(row.Cells["id"].Value.ToString()),
                        borrow_date = DateTime.Now.Date,
                        return_date = null,
                        fine = null,
                        created_at = DateTime.Now,
                        deleted_at = null
                    });
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
