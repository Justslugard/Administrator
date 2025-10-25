using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Examination
{
    public static class Util
    {
        public static user User { get; set; }

        public static ExamEntities db = new ExamEntities();

        public static string nextId(string table)
        {
            string nextId = db.Database
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
        }
        public static string encryptMD5(string encrypt)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(encrypt)).Select(s => s.ToString("x2")));
        }
        public static bool isEmpty(Control.ControlCollection controls)
        {
            string[] validC = { "TextBox", "ComboBox" };

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
    public partial class room : IDeletable { }
    public partial class type : IDeletable { }

    public interface IDeletable
    {
        DateTime? deleted_at { get; set; }
    }
}
