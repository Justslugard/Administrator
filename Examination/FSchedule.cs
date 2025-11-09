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
            "ID"
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
            flipMode(this.Controls, roomTextBox.Enabled ? doNot : new List<string> { "TextBox", "Par", "DateTimePicker" });
            table = null;

            unSuspend();
        }

        bool isSchValid()
        {
            int ei;
            int.TryParse(examinerIDTextBox.Text, out ei);
            int ri;
            int.TryParse(roomIDTextBox.Text, out ri);
            int iden = table?.id ?? -1; 

            if (isEmpty(sch.Controls)) return false;
            else if (Db.schedules.Any(x => x.examiner_id.Equals(ei) && x.time.Equals(timeDateTimePicker.Value) && !x.id.Equals(iden)))
                MessageBox.Show("The current examiner have another schedules with the same time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (Db.schedules.Any(x => x.room_id.Equals(ri) && x.time.Equals(timeDateTimePicker.Value) && !x.id.Equals(iden)))
                MessageBox.Show("The current room have another schedules with the same time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (timeDateTimePicker.Value < DateTime.Now)
                MessageBox.Show("Time must be greater than the current time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

            return false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            Button d = sender as Button;

            table = scheduleBindingSource.Current as schedule;
            suspend();
            if (d.Name == "update") flipMode(this.Controls, doNot);
            else flipMode(this.Controls, new List<string> { "TextBox", "Par", "DateTimePicker" });

            examinerIDTextBox.Text = table.user.id.ToString();
            examinerTextBox.Text = table.user.name;
            roomIDTextBox.Text = table.room.id.ToString();
            roomTextBox.Text = table.room.code;
            typeTextBox.Text = table.type.code;
            typeIDTextBox.Text = table.type.id.ToString();
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
            int i;
            int.TryParse(roomIDTextBox.Text, out i);

            BindingList<ParView> ls = parDgv.DataSource as BindingList<ParView>;
            bool isExist = ls.Any(x => x.ParName.Equals(participantTextBox.Text));
            room room = Db.rooms.Find(i);

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
            } else
            {
                allCt[$"{s.Name.Replace("TextBox", string.Empty)}IDTextBox"].Text = s.Name == "examinerTextBox" ? examinerID : s.Name == "roomTextBox" ? roomID : s.Name == "typeTextBox" ? tyID : s.Name == "caseTextBox" ? caseID : s.Name == "participantTextBox" ? parID : "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            examinerTextBox.Text = "Agnes Bricket";
            roomTextBox.Text = "A789";
            typeTextBox.Text = "TRY03";
            caseTextBox.Text = "CASE10001";
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!isSchValid()) return;
            else
            {
                schedule su = Db.schedules.Find(table?.id);

                if (table == null && roomTextBox.Enabled)
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
                            schedule_id = (int)row.Cells[0].Value,
                            participant_id = (int)row.Cells[1].Value,
                            created_at = DateTime.Now,
                            deleted_at = null
                        };
                        Db.schedules_participants.Add(sp);
                    }
                } else if (!roomTextBox.Enabled)
                {
                    if (MessageBox.Show("Are you sure you want to delete this schedule?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        su.deleted_at = DateTime.Now;
                        foreach (schedules_participants item in su.schedules_participants)
                        {
                            item.deleted_at = DateTime.Now;
                        }
                        MessageBox.Show("Room successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    su.examiner_id = int.Parse(examinerIDTextBox.Text);
                    su.room_id = int.Parse(roomIDTextBox.Text);
                    su.type_id = int.Parse(typeIDTextBox.Text);
                    su.case_id = int.Parse(caseIDTextBox.Text);
                    su.time = timeDateTimePicker.Value;

                    foreach (schedules_participants sh in su.schedules_participants)
                    {
                        if (!parDgv.Rows.Cast<DataGridViewRow>().Any(x => x.Cells[1].Value.Equals(sh.participant_id))) sh.deleted_at = DateTime.Now;
                    }

                    foreach (DataGridViewRow row in parDgv.Rows)
                    {
                        int i = (int)row.Cells[1].Value;

                        if (!su.schedules_participants.Any(x => x.participant_id.Equals(i)) || su.schedules_participants.Count == 0)
                        {
                            schedules_participants sp = new schedules_participants()
                            {
                                schedule_id = (int)row.Cells[0].Value,
                                participant_id = i,
                                created_at = DateTime.Now,
                                deleted_at = null
                            };
                            Db.schedules_participants.Add(sp);
                        }
                        else if (!su.schedules_participants.Any(x => x.participant_id.Equals(i) && x.deleted_at.Equals(null)))
                        {
                            schedules_participants sp = su.schedules_participants.Where(x => x.participant_id.Equals((int)row.Cells[1].Value)).FirstOrDefault();
                            sp.deleted_at = null;
                        }
                    }

                }
                Db.SaveChanges();
                load(scheduleBindingSource, schedules);
                flipMode(this.Controls, roomTextBox.Enabled ? doNot : new List<string> { "TextBox", "Par", "DateTimePicker" });
                table = null;
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

