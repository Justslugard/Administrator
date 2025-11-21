using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Score
{
    public static class Util
    {
        public static ScoreEntities db = new ScoreEntities();
        public static Teacher teacher = db.Teachers.Find(5);

        public static void load<T>(BindingSource Binding, IQueryable<T> bs) where T : class
        {
            Binding.ResumeBinding();
            Binding.ResetBindings(false);
            Binding.DataSource = bs.ToList();
        }

        public static string nextId(string table)
        {
            string nextId = db.Database
                .SqlQuery<Decimal>($"SELECT IDENT_CURRENT('{table}') + IDENT_INCR('{table}')")
                .FirstOrDefault()
                .ToString();

            return nextId;
        }

        public static void flip(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is Button 
                    || control is DateTimePicker || control is RadioButton 
                    || control is ComboBox || control is CheckBox
                    || control is NumericUpDown) control.Enabled = !control.Enabled;
                else if (control.HasChildren) flip(control.Controls);
            }
        }
    }
}
