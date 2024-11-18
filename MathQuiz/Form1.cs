using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int add1;
        int add2;
        int minus1;
        int minus2;
        int times1;
        int times2;
        int div1;
        int div2;

        public void StartQuiz()
        {
            add1 = rng.Next(51);
            add2 = rng.Next(51);

            lblPlusLeft.Text = add1.ToString();
            lblPlusRight.Text = add2.ToString();

            numSum.Value = 0;

            minus1 = rng.Next(1, 101);
            minus2 = rng.Next(1, minus1);

            lblMinusLeft.Text = minus1.ToString();
            lblMinusRight.Text = minus2.ToString();

            numDiff.Value = 0;

            times1 = rng.Next(2, 11);
            times2 = rng.Next(2, 11);

            lblTimesLeft.Text = times1.ToString();
            lblTimesRight.Text = times2.ToString();

            numProd.Value = 0;

            div2 = rng.Next(2, 11);
            int quo = rng.Next(2, 11);
            div1 = quo * div2;

            lblDivLeft.Text = div1.ToString();
            lblDivRight.Text = div2.ToString();

            numQuotient.Value = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartQuiz();
            btnStart.Enabled = false;
        }
    }
}
