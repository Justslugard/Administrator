using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class FSchedule : Form
    {
        static IQueryable<schedule> schedules = Db.schedules;
        static string caseID, roomID, examinerID;
        static List<string> doNot = new List<string>()
        {
            "ID"
        };

        public FSchedule()
        {
            InitializeComponent();

            caseID = caseIDTextBox.Text;
            examinerID = examinerIDTextBox.Text;
            roomID = roomIDTextBox.Text;
        }

        private void FSchedule_Load(object sender, System.EventArgs e)
        {
            //load(scheduleBindingSource, schedules);

            schedule s = Db.schedules.FirstOrDefault();
            s.deleted_at = null;

            Db.SaveChanges();
            load(scheduleBindingSource, schedules);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);

            scheduleBindingSource.SuspendBinding();
            timeDateTimePicker.Value = DateTime.Now;

            examinerIDTextBox.Text = examinerID;
            roomIDTextBox.Text = roomID;
            caseIDTextBox.Text = caseID;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);

            scheduleBindingSource.ResumeBinding();
        }

        bool isValid()
        {
            if (isEmpty(sch.Controls)) return false;
            else 
                return false;
        }

        private void scheduleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            List<schedules_participants> par = ((schedule)scheduleBindingSource.Current)?.schedules_participants?.ToList();

            if (par == null) return;
            foreach (schedules_participants s in par)
            {
                parDgv.Rows.Add(s.schedule_id, s.participant_id, s.user.name);
            }
        }
    }
}

