﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableSamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "0";
            txtHamburgersSubtotal.Text = "0";

            txtHotDogs.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // txtHotDogsSubtotal.Text = (
            //     4.0m * Convert.ToDecimal(txtHotDogs.Text)
            //   ).ToString("0.00");
            int hotdog = Convert.ToInt32(txtHotDogs.Text);
            decimal hotdogPrice = 4.0m;
            decimal hotdogSubtotal = hotdog * hotdogPrice;
            txtHotDogsSubtotal.Text = hotdogSubtotal.ToString("0.00");

            //  txtHamburgersSubtotal.Text = (
            //       5.0m * Convert.ToDecimal(txtHamburgers.Text)
            //    ).ToString("0.00");
            int hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal hamburgerPrice = 5.0m;
            decimal hamburgerSubtotal = hamburgers * hamburgerPrice;
            txtHamburgersSubtotal.Text = hamburgerSubtotal.ToString("0.00");

            //  txtPretaxTotal.Text = (
            //        Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            //    ).ToString("0.00");
            decimal pretaxTotal = hotdogSubtotal + hamburgerSubtotal;
                txtPretaxTotal.Text = pretaxTotal.ToString("0.00");
            // txtTax.Text = (
            //       .06875m * Convert.ToDecimal(txtPretaxTotal.Text)
            //    ).ToString("0.00");
            decimal tax = 6.875m * pretaxTotal / 100;
            txtTax.Text = tax.ToString("0.00");

            // txtTotal.Text =
            //    (Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)).ToString("0.00");
            decimal total = pretaxTotal + tax;
            txtTotal.Text = total.ToString("0.00");

            btnClear.Focus();
        }
    }
}
