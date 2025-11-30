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
            loadReserve();
        }

        private void ViewReservations_Load(object sender, EventArgs e)
        {
            loadReserve();
        }

        void loadReserve()
        {

            reservations = db.Reservations.Where(x => x.ReservationDate == dateTimePicker1.Value.Date).ToList();

            for (int i = 1; i <= 12; i++)
            {
                if (reservations.Any(x => x.TableID == i)) ((PictureBox)tableGroup.Controls[$"table{i}"]).Image = Image.FromFile("./Resources/table_reserved.png");
                else ((PictureBox)tableGroup.Controls[$"table{i}"]).Image = Image.FromFile("./Resources/table_free.png");
            }
        }

        private void table12_Click_1(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            Reservation r = reservations.Where(x => x.TableID == int.Parse(pb.Name.Replace("table", ""))).FirstOrDefault();

            if (r == null) 
            {
                reservationDetailDataGridView.DataSource = null;
                reservationBindingSource.DataSource = new Reservation();
                reservationDetailBindingSource.DataSource = new ReservationDetail();
                return; 
            }

            reservationDetailDataGridView.DataSource = reservationDetailBindingSource;
            reservationBindingSource.DataSource = r;
            reservationDetailBindingSource.DataSource = r.ReservationDetails;
        }
    }
    public partial class ReservationDetail
    {
        public string MenuName { get { return Menu?.Name ?? ""; } }
        public string Price { get { return Menu?.Price.ToString("C", new CultureInfo("id-ID")) ?? ""; } }
        public string TotalPrice { get { return (Menu?.Price * Qty)?.ToString("C", new CultureInfo("id-ID")) ?? ""; } }
    }
}
