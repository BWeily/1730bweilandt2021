using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bweilandt1e1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAverageScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverageScore.Text = (
                        Convert.ToString(txtTest1Score.Text) +
                        Convert.ToString(txtTest1Score.Text) +
                        Convert.ToString(txtTest1Score.Text)
                     );
            txtAverageScore.Text = (
               Convert.ToInt32(txtTest1Score.Text) + Convert.ToInt32(txtTest2Score.Text)
               + Convert.ToInt32(txtTest3Score.Text)
             ).ToString("0");
            txtAverageScore.Text = (
                Convert.ToInt32(txtAverageScore.Text) / 3
                ).ToString("0");
        }

        private void txtTestScore_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTest1Score.Text = "";
            txtTest2Score.Text = "";
            txtTest3Score.Text = "";
            txtAverageScore.Text = "";
        }

        private void txtTestScoreTextChanged(object sender, EventArgs e)
        {

        }

        private void txtaveragescores(object sender, EventArgs e)
        {
           
        }
    } 
}
