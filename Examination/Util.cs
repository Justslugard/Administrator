using System;
using System.Collections.Generic;
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
    }
    public partial class user
    {
        public string RoleName { get { return role != null ? role.name : ""; } }
    }
}
