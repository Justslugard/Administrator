using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodCourt.Util;

namespace FoodCourt
{
    public partial class ViewReservations : Form
    {
        List<Reservation> reservations = null;
        public ViewReservations()
        {
            InitializeComponent();
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("FIRE IN THE HOLEEEEE");
        }

        private void ViewReservations_Load(object sender, EventArgs e)
        {

        }

        void loadReserve()
        {
            reservations = db.Reservations.Where(x => x.ReservationDate == DateTime.Now).ToList();

            foreach (Reservation item in reservations)
            {
                //tableGroup.Controls[$"table{item.TableID}"].
            }
        }
    }
    public partial class ReservationDetail
    {
        public string MenuName { get { return Menu.Name; } }
        public string Price { get { return Menu.Price.ToString("C", new CultureInfo("id-ID")); } }
        public string TotalPrice { get { return (Menu.Price * Qty).ToString("C", new CultureInfo("id-ID")); } }
    }
}
