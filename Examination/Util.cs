using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Examination
{
    public static class Util
    {
        public static user LogUser { get; set; } = Db?.users?.First();
        public static ExamEntities Db { get; set; } = new ExamEntities();
        public static Dictionary<string, string> Question { get; set; } = new Dictionary<string, string>();

        public static string nextId(string table)
        {
            string nextId = Db.Database
                .SqlQuery<Decimal>($"SELECT IDENT_CURRENT('{table}') + IDENT_INCR('{table}')")
                .FirstOrDefault()
                .ToString();

            return nextId;
        }

        public static void flipMode(Control.ControlCollection controls, List<string> doNot = null)
        {
            if (doNot == null) doNot = new List<string>() { "idTextBox" };

            foreach (Control control in controls)
            {
                bool contains = !doNot.Any(s => control.Name.Contains(s) && !string.IsNullOrWhiteSpace(control.Name));
                if (control is Button)
                {
                    if (contains) control.Enabled = !control.Enabled;
                }
                else if (control is TextBox)
                {
                    if (contains) control.Enabled = !control.Enabled;
                }
                else if (control is ComboBox)
                {
                    if (contains) control.Enabled = !control.Enabled;
                }
                else if (control is DateTimePicker)
                {
                    if (contains) control.Enabled = !control.Enabled;
                }
                else if (control.HasChildren)
                {
                    flipMode(control.Controls, doNot);
                }
            }
        }
        public static void load<T>(BindingSource binding, IQueryable<T> db) where T : class, IDeletable
        {
            binding.ResumeBinding();
            binding.ResetBindings(false);
            binding.DataSource = db.Where(x => x.deleted_at.Equals(null)).ToList();
            //binding.DataSource = db.ToList();
        }
        public static string encryptMD5(string encrypt)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(encrypt)).Select(s => s.ToString("x2")));
        }
        public static bool isEmpty(Control.ControlCollection controls)
        {
            string[] validC = { "TextBox", "ComboBox", "DateTimePicker" };

            foreach (Control control in controls)
            {
                //Console.WriteLine(control);
                //Console.WriteLine(control.Name);
                //Console.WriteLine(string.IsNullOrWhiteSpace(control.Text) && validC.Any(s => control.Name.Contains(s) && !string.IsNullOrWhiteSpace(control.Name)));
                //Console.WriteLine("====");
                if (string.IsNullOrWhiteSpace(control.Text) && validC.Any(s => control.Name.Contains(s) && !string.IsNullOrWhiteSpace(control.Name))) 
                {
                    string text = char.ToUpper(control.Name[0]) + validC.Aggregate(control.Name, (curr, sub) => curr.Replace(sub, "")).Substring(1);

                    MessageBox.Show($"{text} can't be emty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (control.HasChildren)
                {
                    if (isEmpty(control.Controls))
                    {
                        return true;
                    } else
                    {
                        continue;
                    }
                }
                else continue;

                return true;
            }
            return false;
        }
    }
    public partial class user : IDeletable
    {
        public string RoleName { get { return role != null ? role.name : ""; } }
    }
    public partial class cases_details : IDeletable { }
    public partial class @case : IDeletable
    {
        public static int count = 0;

        public string CreatorName { get { return user != null ? user.name : string.Empty; } }
        public string question { get { return cases_details.ToList()[count].text; } }
        public string optionA { get { return cases_details.ToList()[count].option_a; } }
        public string optionB { get { return cases_details.ToList()[count].option_b; } }
        public string optionC { get { return cases_details.ToList()[count].option_c; } }
        public string optionD { get { return cases_details.ToList()[count].option_d; } }
        public string answer { get { return cases_details.ToList()[count].correct_answer; } }
        public string totalQ { get { return $"{count + 1}/{number_of_questions}"; } }
    }
    public partial class room : IDeletable { }
    public partial class type : IDeletable { }
    public partial class schedule : IDeletable 
    {
        public string Examiner { get { return user?.name ?? ""; } }
        public string Roomate { get { return room?.code ?? ""; } }
        public string Caseoh { get { return @case?.code ?? ""; } }
    }
    public partial class schedules_participants : IDeletable { }

    public interface IDeletable
    {
        DateTime? deleted_at { get; set; }
    }
}
