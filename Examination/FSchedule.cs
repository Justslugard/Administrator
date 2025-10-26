using System.Linq;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class FSchedule : Form
    {
        static IQueryable<schedule> schedules = db.schedules
            .Include("user")
            .Include("room")
            .Include("case");

        public FSchedule()
        {
            InitializeComponent();
        }

        private void FSchedule_Load(object sender, System.EventArgs e)
        {
            load(scheduleBindingSource, schedules);
        }
    }
}
