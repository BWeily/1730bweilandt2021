using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bweilandt2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.717976";
            txtAmountBhutanese.Text = "0.00";
            txtRateBhutanese.Text = "0.0139831";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.00176122";
            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.15528";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {

        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = 0.00m;
            decimal rateAustralia = 0.717976m;
            decimal USDAustralia = amountAustralia * rateAustralia;

            decimal amountBhutanese = 0.00m;
            decimal rateBhutanese = 0.0139831m;
            decimal USDBhutanese = amountBhutanese * rateBhutanese;

            decimal amountCostaRica = 0.00m;
            decimal rateCostaRica = 0.00176122m;
            decimal USDCostaRica = amountCostaRica * rateCostaRica;

            decimal amountEuro = 0.00m;
            decimal rateEuro = 1.15528m;
            decimal USDEuro = amountEuro * rateEuro;

            decimal TotalUSD = USDAustralia + USDBhutanese + USDCostaRica + USDEuro;


        }
    }
}
