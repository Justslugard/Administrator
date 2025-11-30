using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace FoodCourt
{
    public static class Util
    {
        public static EsemkaFoodcourtEntities db {  get; } = new EsemkaFoodcourtEntities();
        public static User user { get; set; } = db.Users.Where(x => x.RoleID == 1).FirstOrDefault();
        public static Login login { get; } = new Login();
        public static Register register { get; } = new Register();
        public static AdminMain admin { get; } = new AdminMain();
        public static MemberMain member { get; } = new MemberMain();

        public static bool isValidEmail(string mail)
        {
            try
            {
                MailAddress m = new MailAddress(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void load<T>(BindingSource bind, IQueryable<T> que) where T : class
        {
            bind.ResumeBinding();
            bind.ResetBindings(false);
            bind.DataSource = que.ToList();
        }
        public static void flip(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox || control is Button || control is ComboBox || control is DateTimePicker || control is NumericUpDown) control.Enabled = !control.Enabled;
                else if (control.HasChildren) flip(control.Controls);
            }
        }
    }
}
