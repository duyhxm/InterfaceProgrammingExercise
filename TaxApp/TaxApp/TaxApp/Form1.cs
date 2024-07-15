using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxApp
{
    public partial class TaxApp : Form
    {
        public TaxApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtb_TAm_TextChanged(object sender, EventArgs e)
        {
            txtb_TDu.Text = "";
        }

        private void btn_Com_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtb_TAm.Text, out decimal totalAmount))
            {
                decimal taxPercentage = 7.5m; // Assuming a fixed tax rate of 7.5%
                decimal taxAmount = totalAmount * taxPercentage / 100;
                decimal totalDue = totalAmount + taxAmount;

                lbl_taxper.Text = taxPercentage.ToString("F1") + "%";
                txtb_TDu.Text = totalDue.ToString("F2");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid total amount.");
            }

        }
    }
}
