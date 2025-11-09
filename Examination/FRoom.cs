using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class FRoom : Form
    {
        static IQueryable<room> rooms = Db.rooms;
        static room table = null;
        static List<string> doNot = new List<string>()
        {
            "TextBox"
        };

        public FRoom()
        {
            InitializeComponent();
        }

        private void FRoom_Load(object sender, EventArgs e)
        {
            load(roomBindingSource, rooms);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(search.Text)) rooms = rooms.Where(x => x.code.Contains(search.Text));
            else rooms = Db.rooms;

            load(roomBindingSource, rooms);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls);

            roomBindingSource.SuspendBinding();

            idTextBox.Text = nextId("rooms");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Button s = sender as Button;
            
            if (s.Name == "update") flipMode(this.Controls);
            else flipMode(this.Controls, doNot);

            table = (room)roomBindingSource.Current;

            if (table == null)
            {
                MessageBox.Show("There aren't any data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            roomBindingSource.SuspendBinding();

            idTextBox.Text = table.id.ToString();
            codeTextBox.Text = table.code.ToString();
            capacityTextBox.Text = table.capacity.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, codeTextBox.Enabled ? null : doNot);
            table = null;
            roomBindingSource.ResumeBinding();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            else
            {
                room room = Db.rooms.Find(table?.id);

                if (table  == null && codeTextBox.Enabled)
                {
                    room newRoom = new room()
                    {
                        code = codeTextBox.Text,
                        capacity = int.Parse(capacityTextBox.Text),
                        created_at = DateTime.Now,
                        deleted_at = null
                    };
                    Db.rooms.Add(newRoom);

                    MessageBox.Show("Room successfully inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (!codeTextBox.Enabled)
                {
                    if (MessageBox.Show("Are you sure you want to delete this room?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        room.deleted_at = DateTime.Now;
                        MessageBox.Show("Room successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                } else
                {
                    room.code = codeTextBox.Text;
                    room.capacity = int.Parse(capacityTextBox.Text);

                    MessageBox.Show("Room successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Db.SaveChanges();

                load(roomBindingSource, rooms);
                table = null;
                flipMode(this.Controls, codeTextBox.Enabled ? null : doNot);
            }
        }

        bool isValid()
        {
            Regex codeReg = new Regex(@"^[A-Z]{1}[\d]{3}$");
            long output;

            if (isEmpty(this.Controls)) return false;
            else if (!codeReg.IsMatch(codeTextBox.Text)) MessageBox.Show("Invalid code!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!long.TryParse(capacityTextBox.Text, out output)) MessageBox.Show("Capacity must be a number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (output < 0) MessageBox.Show("Capacity must be greater than 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

            return false;
        }
    }
}
