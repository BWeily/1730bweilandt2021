﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bweilandt2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            // #1: if
            result1TextBox.Text = Ex2fCalculations.Calc01(input1ATextBox.Text);

            // #2: if {block}
            result2TextBox.Text = Ex2fCalculations.Calc02(input2ATextBox.Text);

            // #3: if else
            result3TextBox.Text = Ex2fCalculations.Calc03(input3ATextBox.Text);

            // #4: if else if
            result4TextBox.Text = Ex2fCalculations.Calc04(input4ATextBox.Text);

            // #5: Better Range Test
            result5TextBox.Text = Ex2fCalculations.Calc05(input5ATextBox.Text);

            // #6: nested if statements
            result6TextBox.Text = Ex2fCalculations.Calc06(input6ATextBox.Text, input6BTextBox.Text);

            // #7: input validation
            result7TextBox.Text = Ex2fCalculations.Calc07(input7ATextBox.Text);

            // #8: Price * quant,ship
            result8TextBox.Text = Ex2fCalculations.Calc08(input8ATextBox.Text, input8BTextBox.Text);

            // #9: Difference * rate
            result9TextBox.Text = Ex2fCalculations.Calc09(input9ATextBox.Text, input9BTextBox.Text);

            // #10: Divide large
            result10TextBox.Text = Ex2fCalculations.Calc10(input10ATextBox.Text, input10BTextBox.Text);
        }
    }
}
