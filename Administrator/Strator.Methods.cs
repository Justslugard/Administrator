using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;

namespace Winform_Login
{
    partial class Strator
    {
        void clear()
        {
            id.Text = name.Text = email.Text = number.Text = pass.Text = cpass.Text = nama = emal = phone = passs = string.Empty;
            cbRol.SelectedIndex = -1;
            birth.Value = DateTime.Now;
        }
        void enable()
        {
            name.Enabled = email.Enabled = number.Enabled = birth.Enabled = save.Enabled =
                cancel.Enabled = cbRol.Enabled = pass.Enabled = cpass.Enabled = spass.Enabled = true;
            insert.Enabled = update.Enabled = rmv.Enabled = false;
        }
        bool validation()
        {
            long res;
            Regex emailReg = new Regex(@"^+.+\@.+$");
            if (string.IsNullOrEmpty(nama)) MessageBox.Show("Name can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(emal)) MessageBox.Show("Email can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(phone)) MessageBox.Show("Phone number can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (string.IsNullOrEmpty(passs)) MessageBox.Show("Password can't be empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbRol.SelectedIndex == -1) MessageBox.Show("Role must be selected!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (DateTime.Now.Year - birth.Value.Year < 18) MessageBox.Show("Age must be at least 18 years old!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!emailReg.IsMatch(emal)) MessageBox.Show("Must be a valid email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (administrator.Where(x => x.Email.Equals(emal) && (onInsert || !x.Id.Equals(id.Text))).FirstOrDefault() != null) MessageBox.Show("Email already registered!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!long.TryParse(number.Text.Remove(0, 1).Replace(" ", string.Empty).Trim(), out res) || number.Text[0] != '+') MessageBox.Show("Must be a valid phone number!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pass.Text != cpass.Text) MessageBox.Show("Password and confirm password isn't same!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else return true;

            return false;
        }

    }
}
