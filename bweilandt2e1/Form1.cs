using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bweilandt2e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            SideEffect03TextBox.Text = "";
            result04TextBox.Text = "";
            SideEffect04TextBox.Text = "";
            result05TextBox.Text = "";
            SideEffect05TextBox.Text = "";
            result06TextBox.Text = "";
            SideEffect06TextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result09TextBox.Text = "";
            SideEffect09TextBox.Text = "";
            result10TextBox.Text = "";

            // 01
            decimal subtotal = Convert.ToDecimal(input01ATextBox.Text);
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();

            // 02
            int timeInService = Convert.ToInt32(input02ATextBox.Text);
            result02TextBox.Text = (LogicalOperations.q02(timeInService)).ToString();

            // 03 - 06 initialization
            bool isValid = Convert.ToBoolean(input03ATextBox.Text);
            int years = Convert.ToInt32(input03CTextBox.Text);

            // 03
            int counter = Convert.ToInt32(input03BTextBox.Text);
            result03TextBox.Text = (LogicalOperations.q03(isValid, years, counter)).ToString();
            SideEffect03TextBox.Text = counter.ToString();

            // 04
            counter = Convert.ToInt32(input03BTextBox.Text);
            result04TextBox.Text = (LogicalOperations.q04(isValid, years, counter)).ToString();
            SideEffect04TextBox.Text = counter.ToString();

            // 05
            counter = Convert.ToInt32(input03BTextBox.Text);
            result05TextBox.Text = (LogicalOperations.q05(isValid, years, counter)).ToString();
            SideEffect05TextBox.Text = counter.ToString();

            // 06
            counter = Convert.ToInt32(input03BTextBox.Text);
            result06TextBox.Text = (LogicalOperations.q06(isValid, years, counter)).ToString();
            SideEffect06TextBox.Text = counter.ToString();

            //07
            DateTime startDate = Convert.ToDateTime(input07ATextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07BTextBox.Text);
            DateTime date = Convert.ToDateTime(input07CTextBox.Text);
            isValid = Convert.ToBoolean(input07DTextBox.Text);
            result07TextBox.Text = (
            (LogicalOperations.q07(startDate, expirationDate, date, isValid)).ToString());

            //08
            decimal thisYTD = Convert.ToDecimal(input08ATextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08BTextBox.Text);
            string empType = input08CTextBox.Text;
            int startYear = Convert.ToInt32(input08DTextBox.Text);
            int currentYear = Convert.ToInt32(input08ETextBox.Text);
            result08TextBox.Text = (
            LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear)).ToString();

            //09
            counter = Convert.ToInt32(input09ATextBox.Text);
            years = Convert.ToInt32(input09BTextBox.Text);
            result09TextBox.Text = (LogicalOperations.q09(counter, years)).ToString();
            SideEffect09TextBox.Text = counter.ToString();

            //10
            int a = Convert.ToInt32(input10ATextBox.Text);
            int b = Convert.ToInt32(input10BTextBox.Text);
            int c = Convert.ToInt32(input10CTextBox.Text);
            int d = Convert.ToInt32(input10DTextBox.Text);
            result10TextBox.Text = (LogicalOperations.q10(a, b, c, d)).ToString();
            // bool v = a > b;
            // bool w = b < c:
            // bool x = c < d;
            // bool y = v && w;
            // bool z = y || x;
            // result10TextBox.Text = z.ToString();

        }
    } } 
