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
        static string caseID, roomID, examinerID, parID, tyID;
        static List<string> doNot = new List<string>()
        {
            "ID",
            //"Par"
        };
        static schedule table = null;
        static int row = -1;
        user us;
        room ro;
        type ty;
        @case ca;
        user su;

        public FSchedule()
        {
            InitializeComponent();

            caseID = caseIDTextBox.Text;
            examinerID = examinerIDTextBox.Text;
            roomID = roomIDTextBox.Text;
            parID = participantIDTextBox.Text;
            tyID = typeIDTextBox.Text;

            AutoCompleteStringCollection exams = new AutoCompleteStringCollection();
            exams.AddRange(Db.users.Where(x => x.role_id.Equals(2)).Select(x => x.name).ToArray());

            AutoCompleteStringCollection rooms = new AutoCompleteStringCollection();
            rooms.AddRange(Db.rooms.Select(x => x.code).ToArray());

            AutoCompleteStringCollection tipes = new AutoCompleteStringCollection();
            tipes.AddRange(Db.types.Select(x => x.code).ToArray());

            AutoCompleteStringCollection cases = new AutoCompleteStringCollection();
            cases.AddRange(Db.cases.Select(x => x.code).ToArray());

            AutoCompleteStringCollection pars = new AutoCompleteStringCollection();
            pars.AddRange(Db.users.Where(x => x.role_id.Equals(3)).Select(x => x.name).ToArray());

            examinerTextBox.AutoCompleteCustomSource = exams;
            roomTextBox.AutoCompleteCustomSource = rooms;
            typeTextBox.AutoCompleteCustomSource = tipes;
            caseTextBox.AutoCompleteCustomSource = cases;
            participantTextBox.AutoCompleteCustomSource = pars;

            parDgv.AutoGenerateColumns = false;
        }

        private void FSchedule_Load(object sender, System.EventArgs e)
        {
            load(scheduleBindingSource, schedules);
        }

        private void insert_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);

            suspend();
            parDgv.Rows.Clear();
            timeDateTimePicker.Value = DateTime.Now;

            examinerIDTextBox.Text = examinerID;
            roomIDTextBox.Text = roomID;
            typeIDTextBox.Text = tyID;
            caseIDTextBox.Text = caseID;
            participantIDTextBox.Text = parID;
            participantTextBox.Clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            flipMode(this.Controls, doNot);

            unSuspend();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        bool isSchValid()
        {
            long ei;
            long.TryParse(examinerIDTextBox.Text, out ei);
            long ri;
            long.TryParse(roomIDTextBox.Text, out ri);

            if (isEmpty(sch.Controls)) return false;
            else if (Db.schedules.Any(x => x.examiner_id.Equals(ei) && x.time == timeDateTimePicker.Value))
                MessageBox.Show("The current examiner have another schedules with the same time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Db.schedules.Any(x => x.room_id.Equals(ri) && x.time == timeDateTimePicker.Value))
                MessageBox.Show("The current room have another schedules with the same time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (timeDateTimePicker.Value < DateTime.Now)
                MessageBox.Show("Time must be greater than the current time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

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
            TextBox s = sender as TextBox;

            us = Db.users.Where(x => x.name.Equals(s.Text) && x.role_id.Equals(2)).FirstOrDefault();
            ro = Db.rooms.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            ty = Db.types.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            ca = Db.cases.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            su = Db.users.Where(x => x.name.Equals(s.Text) && x.role_id.Equals(3)).FirstOrDefault();

            if (!string.IsNullOrWhiteSpace(s.Text) && (su == null && ro == null && ca == null && us == null && ty == null))
            {
                MessageBox.Show($"No such {s.Name.Replace("TextBox", string.Empty)} exist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void addPartici_Click(object sender, EventArgs e)
        {
            long i;
            long.TryParse(roomIDTextBox.Text, out i);

            BindingList<ParView> ls = parDgv.DataSource as BindingList<ParView>;
            bool isExist = ls.Any(x => x.ParName.Equals(participantTextBox.Text));
            room room = Db.rooms.Find(i);

            Console.WriteLine(room.capacity);

            if (room == null)
            {
                MessageBox.Show("Room must be choosen first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrWhiteSpace(participantTextBox.Text))
            {
                MessageBox.Show("Participant can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (isExist)
            {
                MessageBox.Show("Participant already exist on the data grid view!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (parDgv.RowCount >= room.capacity)
            {
                MessageBox.Show("Can't add more participant!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                ls.Add(new ParView { SchID = table != null ? table.id : int.Parse(nextId("schedules")), PartiID = int.Parse(participantIDTextBox.Text), ParName = participantTextBox.Text });
                MessageBox.Show("Successfully added new participants", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                participantTextBox.Clear();
                participantIDTextBox.Text = parID;
            }
        }

        private void parDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;

            if (row > -1 && !scheduleBindingSource.IsBindingSuspended)
            {
                participantIDTextBox.Text = parDgv.Rows[row].Cells[1].Value.ToString();
                participantTextBox.Text = parDgv.Rows[row].Cells[2].Value.ToString();
            }
        }

        private void delSelPar_Click(object sender, EventArgs e)
        {
            if (parDgv.RowCount <= 0) MessageBox.Show("Participants is empty is empty!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show($"Are you sure you want to delete this participant?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            
                parDgv.Rows.RemoveAt(row);
                MessageBox.Show($"Successfully deleted participant", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //if (onInsert) 
            //else
            //{
            //    schedules_participants rem = Db.schedules_participants.Where(x => x.participant_id.Equals(int.Parse(parDgv.Rows[row].Cells[1].Value.ToString()))).FirstOrDefault();
            //    rem.deleted_at = DateTime.Now;

            //    load(scheduleBindingSource, schedules);
            //}

        }

        private void delAllPar_Click(object sender, EventArgs e)
        {
            if (parDgv.RowCount <= 0) MessageBox.Show("Participants is empty is empty!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show($"Are you sure you want to delete all participants?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

                parDgv.Rows.Clear();
                MessageBox.Show($"Successfully deleted all participant", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            //if (onInsert) 
            //else
            //{
            //    foreach (schedules_participants item in ((schedule)scheduleBindingSource.Current).schedules_participants)
            //    {
            //        item.deleted_at = DateTime.Now;
            //    }

            //    Db.SaveChanges();
            //    load(scheduleBindingSource, schedules);
            //}

        }

        private void examinerTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox s = sender as TextBox;

            us = Db.users.Where(x => x.name.Equals(s.Text) && x.role_id.Equals(2)).FirstOrDefault();
            ro = Db.rooms.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            ty = Db.types.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            ca = Db.cases.Where(x => x.code.Equals(s.Text)).FirstOrDefault();
            su = Db.users.Where(x => x.name.Equals(s.Text) && x.role_id.Equals(3)).FirstOrDefault();

            var allCt = sch.Controls.Cast<Control>().Concat(newPar.Controls.Cast<Control>()).ToDictionary(k => k.Name, v => v);

            if (us != null || ca != null || ro != null || su != null || ty != null)
            {
                allCt[$"{s.Name.Replace("TextBox", string.Empty)}IDTextBox"].Text = us != null ? us.id.ToString() : ro != null ? ro.id.ToString() : ca != null ? ca.id.ToString() : su != null ? su.id.ToString() : ty != null ? ty.id.ToString() : "";
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isSchValid()) return;
            else
            {
                if (table == null)
                {
                    schedule s = new schedule()
                    {
                        examiner_id = int.Parse(examinerIDTextBox.Text),
                        room_id = int.Parse(roomIDTextBox.Text),
                        type_id = int.Parse(typeIDTextBox.Text),
                        case_id = int.Parse(caseIDTextBox.Text),
                        time = timeDateTimePicker.Value,
                        created_at = DateTime.Now,
                        deleted_at = null
                    };
                    Db.schedules.Add(s);

                    foreach (DataGridViewRow row in parDgv.Rows)
                    {
                        schedules_participants sp = new schedules_participants()
                        {
                            schedule_id = int.Parse(row.Cells[0].Value.ToString()),
                            participant_id = int.Parse(row.Cells[1].Value.ToString()),
                            created_at = DateTime.Now,
                            deleted_at = null
                        };
                        Db.schedules_participants.Add(sp);
                    }
                }
                else
                {
                    schedule s = Db.schedules.Find(table.id);
                    s.examiner_id = int.Parse(examinerIDTextBox.Text);
                    s.room_id = int.Parse(roomIDTextBox.Text);
                    s.type_id = int.Parse(typeIDTextBox.Text);
                    s.case_id = int.Parse(caseIDTextBox.Text);
                    s.time = timeDateTimePicker.Value;

                    foreach (DataGridViewRow row in parDgv.Rows)
                    {
                        int i = int.Parse(row.Cells[0].Value.ToString());

                        if (!table.schedules_participants.Any(x => x.participant_id.Equals(i)))
                        {
                            schedules_participants sp = new schedules_participants()
                            {
                                schedule_id = int.Parse(row.Cells[0].Value.ToString()),
                                participant_id = int.Parse(row.Cells[1].Value.ToString()),
                                created_at = DateTime.Now,
                                deleted_at = null
                            };
                            Db.schedules_participants.Add(sp);
                        }
                    }

                    foreach (schedules_participants sh in table.schedules_participants)
                    {
                        if (!parDgv.Rows.Cast<DataGridViewRow>().Any(x => x.Cells[1].Equals(sh.participant_id)))
                        {
                            sh.deleted_at = DateTime.Now;
                        }
                    }
                }
                Db.SaveChanges();
                load(scheduleBindingSource, schedules);
            }
        }

        private void scheduleBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            BindingList<ParView> par = new BindingList<ParView>(((schedule)scheduleBindingSource.Current)?.schedules_participants?.Where(x => x.deleted_at.Equals(null)).Select(x => new ParView
            {
                SchID = x.schedule_id,
                PartiID = x.participant_id,
                ParName = x.user.name
            }).ToList());

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
            scheduleBindingSource.SuspendBinding();
        }
        void unSuspend()
        {
            scheduleBindingSource.ResumeBinding();
        }
    }
    public class ParView
    {
        public int SchID { get; set; }
        public int PartiID { get; set; }
        public string ParName { get; set; }
    }
}

