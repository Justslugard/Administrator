using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static void modeField(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button)
                {
                    if (control.Name != "delete") control.Enabled = !control.Enabled;

                } 
                else if (control is TextBox)
                {
                    if (control.Name != "idTextBox" && control.Name != "search") control.Enabled = !control.Enabled;
                }
                else if (control is ComboBox)
                {
                    if (control.Name != "cbFilt") control.Enabled = !control.Enabled;
                }
                else if (control.HasChildren)
                {
                    modeField(control.Controls);
                }
            }
        }
    }
    public partial class user
    {
        public string RoleName { get { return role != null ? role.name : ""; } }
    }
}
