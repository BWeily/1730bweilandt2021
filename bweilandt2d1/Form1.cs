using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bweilandt2d1
{
    public partial class textBox9ResultB : Form
    {
        public textBox9ResultB()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSetPassValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "3";
            textBox10InputB.Text = "3";

        }

        private void btnSetFailValues_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox4Input.Text = "2.4";
            textBox5InputA.Text = "true";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "3";
            textBox7Input.Text = "Jones";
            textBox8InputA.Text = "0";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "1";
            textBox10InputA.Text = "499";
            textBox10InputB.Text = "4";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            textBox1ResultA.Text = "Success";
            textBox2ResultA.Text = "Success";
            textBox3ResultA.Text = "Success";
            textBox4ResultA.Text = "Success";
            textBox5ResultA.Text = "Success";
            textBox6ResultA.Text = "Success";
            textBox7ResultA.Text = "Success";
            textBox8ResultA.Text = "Success";
            textBox9ResultA.Text = "Success";
            textBox10ResultA.Text = "Success";

            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "Success";
            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "Fail";

            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultB.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";

            if (textBox4Input.Text == "false")
                textBox4ResultA.Text = "Success";
            if (textBox4Input.Text != "false")
                textBox4ResultB.Text = "Fail";

            decimal val5A = Convert.ToDecimal(textBox5InputA.Text);
            if (val5A == 2m)
                textBox5ResultA.Text = "Success";
            if (val5A != 2m)
                textBox5ResultA.Text = "Fail";

            decimal val5B = Convert.ToDecimal(textBox5InputB.Text);
            if (val5B == 2m)
                textBox5ResultB.Text = "Success";
            if (val5B != 2m)
                textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text == "xyz")
                textBox6ResultA.Text = "Success";
            if (textBox6Input.Text != "xyz")
                textBox6ResultB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 == 1m)
                textBox7ResultB.Text = "Success";
            if (val7 != 1m)
                textBox7ResultB.Text = "Fail";

            decimal val8A = Convert.ToDecimal(textBox8InputA.Text);
            if (val8A == 1m)
                textBox8ResultA.Text = "Success";
            if (val8A != 1m)
                textBox8ResultA.Text = "Fail";

            decimal val8B = Convert.ToDecimal(textBox8InputB.Text);
            if (val8B == 2m)
                textBox8ResultB.Text = "Success";
            if (val8B != 2m)
                textBox8ResultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 == 500m)
                textBox9ResultA.Text = "Success";
            if (val9 != 500m)
                textBox9xResultB.Text = "Fail";

            decimal val10A = Convert.ToDecimal(textBox10InputA.Text);
            if (val10A == 3m)
                textBox10ResultA.Text = "Success";
            if (val10A != 3m)
                textBox10ResultA.Text = "Fail";

            decimal val10B = Convert.ToDecimal(textBox10InputB.Text);
            if (val10B == 3m)
                textBox10ResultB.Text = "Success";
            if (val10B != 3m)
                textBox10ResultB.Text = "Fail";


        }
    }
}
