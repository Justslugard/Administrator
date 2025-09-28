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
    partial class Merchant
    {

        void clearField()
        {
            id.Text = name.Text = specific.Text = photo.Text = pBox.ImageLocation = string.Empty;
            stock.Value = price.Value = 1;
            model.SelectedIndex = -1;
        }

        void modeField(bool state)
        {
            name.Enabled = specific.Enabled = model.Enabled = price.Enabled = stock.Enabled = save.Enabled = cancel.Enabled = phButt.Enabled = state;
            insert.Enabled = update.Enabled = !state;
            if (onUpdate) del.Enabled = !state;
        }

        bool isValid()
        {
            if (string.IsNullOrWhiteSpace(name.Text)) MessageBox.Show("Name can't be empty!");
            else if (string.IsNullOrWhiteSpace(specific.Text)) MessageBox.Show("Name can't be empty!");
            else if (model.SelectedIndex == -1) MessageBox.Show("Select a model!");
            else return true;
            return false;
        }
        string newId()
        {
            string ids = data.Merchandises.OrderByDescending(x => x.Id).FirstOrDefault().Id;
            Match regx = Regex.Match(ids, @"([a-zA-Z]+)(\d+)");
            char[] idNums = regx.Groups[2].Value.ToCharArray();
            for (int i = idNums.Length - 1, adder = 1; i >= 0; i--)
            {
                int sum = (idNums[i] - '0') + 1;
                if (adder > 0)
                {
                    if (sum == 10)
                    {
                        adder++;
                        idNums[i] = '0';
                    }
                    else
                    {
                        idNums[i] = (char)(sum + '0');
                    }
                    adder--;
                }
                else break;
            }
            return $"PR{string.Concat(idNums)}";
        }
    }
}
