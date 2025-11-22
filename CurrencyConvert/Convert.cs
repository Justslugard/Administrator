using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConvert
{
    public partial class Convert : Form
    {
        CurrencyEntities db = new CurrencyEntities();
        decimal crossRate;
        decimal? USD = 0;
        int i = 0;
        public Convert()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'currencyConverterDataSet.Currency' table. You can move, or remove it, as needed.
            this.currencyTableAdapter.Fill(this.currencyConverterDataSet.Currency);
            // TODO: This line of code loads data into the 'currencyConverterDataSet.Period' table. You can move, or remove it, as needed.
            this.periodTableAdapter.Fill(this.currencyConverterDataSet.Period);
            oriCb.SelectedIndex = 0;
            convertCb.SelectedIndex = 1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                if (oriCb.SelectedValue == null || periodCb.SelectedValue == null || convertCb.SelectedValue == null) return;

                if (oriCb.Text != "USD" && convertCb.Text != "USD")
                {
                    decimal rate1 = db.USDExchangeRates.Where(x => x.currency_id.Equals((int)oriCb.SelectedValue) && x.period_id.Equals((int)periodCb.SelectedValue)).FirstOrDefault().rate;
                    decimal rate2 = db.USDExchangeRates.Where(x => x.currency_id.Equals((int)convertCb.SelectedValue) && x.period_id.Equals((int)periodCb.SelectedValue)).FirstOrDefault().rate;
                    crossRate = Math.Ceiling((rate2 / rate1) * 1e10M) / 1e10M;
                    USD = null;
                }
                else
                {
                    USD = db.USDExchangeRates.Where(x => (x.currency_id.Equals((int)oriCb.SelectedValue) || x.currency_id.Equals((int)convertCb.SelectedValue)) && x.period_id.Equals((int)periodCb.SelectedValue)).FirstOrDefault().rate;
                }
            }

            decimal res;
            if (string.IsNullOrWhiteSpace(oriTb.Text) || !decimal.TryParse(oriTb.Text, out res)) convertTb.Clear();
            else if (USD == null) convertTb.Text = (Math.Ceiling((res * crossRate) * 1e3M) / 1e3M).ToString();
            else if (USD != null && oriCb.Text == "USD") convertTb.Text = (Math.Ceiling((res * ((decimal)USD)) * 1e3M) / 1e3M).ToString();
            else if (USD != null && convertCb.Text == "USD") convertTb.Text = (Math.Ceiling((res / ((decimal)USD)) * 1e3M) / 1e3M).ToString();
        }

        private void periodBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            oriCb.TextChanged -= textBox1_TextChanged;
            convertCb.TextChanged -= textBox1_TextChanged;
            int x = oriCb.SelectedIndex;
            int y = convertCb.SelectedIndex;

            oriCb.SelectedIndex = y;
            convertCb.SelectedIndex = x;
            oriCb.TextChanged += textBox1_TextChanged;
            convertCb.TextChanged += textBox1_TextChanged;
            textBox1_TextChanged(sender, e);
        }

        private void convertCb_Enter(object sender, EventArgs e)
        {
            i = ((ComboBox)sender).SelectedIndex;
        }

        private void oriCb_DropDownClosed(object sender, EventArgs e)
        {
            oriCb.TextChanged -= textBox1_TextChanged;
            convertCb.TextChanged -= textBox1_TextChanged;
            if (convertCb.Text == oriCb.Text)
            {
                ((ComboBox)sender).SelectedIndex = i;
                MessageBox.Show("Initial and conversion target must be in different currency");
            }
            oriCb.TextChanged += textBox1_TextChanged;
            convertCb.TextChanged += textBox1_TextChanged;
        }
    }
}
