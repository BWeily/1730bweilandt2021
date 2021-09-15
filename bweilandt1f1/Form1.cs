using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bweilandt1f1
{
    public partial class txtRate : Form
    {
        public txtRate()
        {
            InitializeComponent();
        }

        private void picAustraliaDim_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutanese.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRates.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            label3.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutanese.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRates.Text = "0.717976";
            label3.Text = btnAustralia.Text + ": ";
        }

        private void btnBhutanese_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutanese.BackgroundImage = picBhutanese.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRates.Text = "0.0139831";
            label3.Text = btnBhutanese.Text + ": ";
        }

        private void btnCostaRica_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutanese.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRates.Text = "0.00176122";
            label3.Text = btnCostaRica.Text + ": ";
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutanese.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuro.Image;
            txtRates.Text = "1.15528";
            label3.Text = btnEuro.Text + ": ";
        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutanese.BackgroundImage = picBhutaneseDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRates.Text = "0.717976";
            txtCurrency.Text = "0.00";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            label3.Text = btnAustralia.Text + ": ";
            label2.Text = " ";
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
            Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRates.Text)
                ).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + " + " + txtUSDollars.Text; 
                     
            txtTotalUSD.Text = (
               Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)
             ).ToString("0.00");
        
        }
    }
}
