using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static Examination.Util;

namespace Examination
{
    public partial class FSchedule : Form
    {
        static IQueryable<schedule> schedules = Db.schedules;
        static string caseID, roomID, examinerID, parID;
        static List<string> doNot = new List<string>()
        {
            "ID"
        };
        static schedule table = null;
        static int row = -1;
        static bool onInsert = false;

        public FSchedule()
        {
            InitializeComponent();

            caseID = caseIDTextBox.Text;
            examinerID = examinerIDTextBox.Text;
            roomID = roomIDTextBox.Text;
            parID = participantIDTextBox.Text;

            AutoCompleteStringCollection exams = new AutoCompleteStringCollection();
            exams.AddRange(Db.users.Where(x => x.role_id.Equals(2)).Select(x => x.name).ToArray());

            AutoCompleteStringCollection rooms = new AutoCompleteStringCollection();
            rooms.AddRange(Db.rooms.Select(x => x.code).ToArray());

            AutoCompleteStringCollection cases = new AutoCompleteStringCollection();
            cases.AddRange(Db.cases.Select(x => x.code).ToArray());

            AutoCompleteStringCollection pars = new AutoCompleteStringCollection();
            pars.AddRange(Db.users.Where(x => x.role_id.Equals(3)).Select(x => x.name).ToArray());

            examinerTextBox.AutoCompleteCustomSource = exams;
            roomTextBox.AutoCompleteCustomSource = rooms;
            caseTextBox.AutoCompleteCustomSource = cases;
            participantTextBox.AutoCompleteCustomSource = pars;

            parDgv.AutoGenerateColumns = false;
        }

        private void FSchedule_Load(object sender, System.EventArgs e)
        {
            load(scheduleBindingSource, schedules);

            //parBindingSource.DataMember = "schedules_participants";
            //parDgv.AutoGenerateColumns = false;            

            //scheduleBindingSource.ResetBindings(false);

            //BindingList<schedules_participants> ajg = new BindingList<schedules_participants>(((HashSet<schedules_participants>)parBindingSource.List[0]).ToList());
            //parDgv.DataSource = ajg;

            //participantIDTextBox.DataBindings.Add("Text", ajg, "participant_id", true, DataSourceUpdateMode.OnPropertyChanged);
            //participantTextBox.DataBindings.Add("Text", ajg, "GetName", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);

            suspend();
            parDgv.Rows.Clear();
            timeDateTimePicker.Value = DateTime.Now;
            onInsert = true;

            examinerIDTextBox.Text = examinerID;
            roomIDTextBox.Text = roomID;
            caseIDTextBox.Text = caseID;
            participantIDTextBox.Text = parID;
            participantTextBox.Clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);
            onInsert = false;

            unSuspend();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        bool isSchValid()
        {
            if (isEmpty(sch.Controls)) return false;
            else 
                return false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            table = scheduleBindingSource.Current as schedule;
            suspend();
            flipMode(this.Controls, doNot);

            examinerIDTextBox.Text = table.user.id.ToString();
            examinerTextBox.Text = table.user.name;
            roomIDTextBox.Text = table.room.id.ToString();
            roomTextBox.Text = table.room.code;
            caseIDTextBox.Text = table.@case.id.ToString();
            caseTextBox.Text = table.@case.code;
            participantIDTextBox.Text = parID;
            participantTextBox.Clear();
        }

        private void examinerTextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox s = (TextBox)sender;

            user us = Db.users.Where(x => x.name.Equals(s.Text) && x.role_id.Equals(2)).FirstOrDefault();
            room ro = Db.rooms.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            @case ca = Db.cases.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            user su = Db.users.Where(x => x.name.Equals(s.Text) && x.role_id.Equals(3)).FirstOrDefault();

            var allCt = sch.Controls.Cast<Control>().Concat(newPar.Controls.Cast<Control>()).ToDictionary(k => k.Name, v => v);

            if (us != null || ca != null || ro != null || su != null)
                allCt[$"{s.Name.Replace("TextBox", string.Empty)}IDTextBox"].Text = us != null ? us.id.ToString() : ro != null ? ro.id.ToString() : ca != null ? ca.id.ToString() : su != null ? su.id.ToString() : "";
            else if (!string.IsNullOrWhiteSpace(s.Text))
            {
                MessageBox.Show($"No such {s.Name.Replace("TextBox", string.Empty)} exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void parBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(((schedules_participants)parBindingSource.Current).GetName);
        }

        private void addPartici_Click(object sender, EventArgs e)
        {

        }

        private void parDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            Console.WriteLine(row);

            if (row > -1 && !scheduleBindingSource.IsBindingSuspended)
            {
                participantIDTextBox.Text = parDgv.Rows[row].Cells[1].Value.ToString();
                participantTextBox.Text = parDgv.Rows[row].Cells[2].Value.ToString();
            }
        }

        private void delSelPar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete this participant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
             
            if (onInsert) parDgv.Rows.RemoveAt(row);
            else
            {
                schedules_participants rem = Db.schedules_participants.Where(x => x.participant_id.Equals(int.Parse(parDgv.Rows[row].Cells[1].Value.ToString()))).FirstOrDefault();
                rem.deleted_at = DateTime.Now;

                load(scheduleBindingSource, schedules);
            }

            MessageBox.Show($"Successfully deleted participant", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void delAllPar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete all participants?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

            if (onInsert) parDgv.Rows.Clear();
            else
            {
                foreach (schedules_participants item in ((schedule)scheduleBindingSource.Current).schedules_participants)
                {
                    item.deleted_at = DateTime.Now;
                }

                Db.SaveChanges();
                load(scheduleBindingSource, schedules);
            }

            MessageBox.Show($"Successfully deleted all participant", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void scheduleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            List<ParView> bind = ((schedule)scheduleBindingSource.Current)?.schedules_participants?.Where(x => x.deleted_at.Equals(null)).Select(x => new ParView
            {
                SchID = x.schedule_id,
                PartiID = x.participant_id,
                ParName = x.user.name
            }).ToList();

            BindingList<ParView> par = new BindingList<ParView>(bind);

            parDgv.DataSource = par;

            if (par.Count > 0)
            {
                row = 0;
                participantIDTextBox.Text = parDgv.Rows[row].Cells[1].Value.ToString();
                participantTextBox.Text = parDgv.Rows[row].Cells[2].Value.ToString();
            }
        }

        void suspend()
        {
            //parDgv.DataSource = null;
            //scheduleBindingSource.RaiseListChangedEvents = false;
            scheduleBindingSource.SuspendBinding();
            //parBindingSource.SuspendBinding();
        }
        void unSuspend()
        {
            //scheduleBindingSource.RaiseListChangedEvents = true;
            //parDgv.DataSource = parBindingSource;
            scheduleBindingSource.ResumeBinding();
            //parBindingSource.ResumeBinding();

            //BindingList<schedules_participants> ajg = new BindingList<schedules_participants>(((HashSet<schedules_participants>)parBindingSource.List[0]).ToList());
            //parDgv.DataSource = ajg;

            //participantIDTextBox.DataBindings.RemoveAt(0);
            //participantTextBox.DataBindings.RemoveAt(0);

            //participantIDTextBox.DataBindings.Add("Text", ajg, "participant_id", true, DataSourceUpdateMode.OnPropertyChanged);
            //participantTextBox.DataBindings.Add("Text", ajg, "GetName", true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
    public class ParView
    {
        public int SchID { get; set; }
        public int PartiID { get; set; }
        public string ParName { get; set; }
    }
}

