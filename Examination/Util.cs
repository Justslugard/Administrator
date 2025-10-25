using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


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

        public static void flipMode(Control.ControlCollection controls, string[] doNot = null, string[] Do = null)
        {
            foreach (Control control in controls)
            {
                bool contains = (!doNot?.Contains(control.Name) ?? false) || (Do?.Contains(control.Name) ?? false);
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
    }
    public partial class user : IDeletable
    {
        public string RoleName { get { return role != null ? role.name : ""; } }
    }
    public partial class cases_details : IDeletable { }
    public partial class room : IDeletable { }
    public partial class room : IDeletable { }

    public interface IDeletable
    {
        DateTime? deleted_at { get; set; }
    }
}
