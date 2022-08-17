using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        double A, B, KQ;
        char Op;

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber.Text;
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber1.Text;
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber2.Text;
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber3.Text;
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber4.Text;
        }
        private void btnNumber5_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber5.Text;
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber6.Text;
        }

        private void btnNumber7_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber7.Text;
        }

        private void btnNumber8_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber8.Text;
        }

        private void btnNumber9_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnNumber9.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            A = 0;
            B = 0;
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            A = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "";
            Op = bt.Text[0];
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            B = Convert.ToDouble(txtResult.Text);
            switch (Op)
            {
                case '+': KQ = A + B; break;
                case '-': KQ = A - B; break;
                case '*': KQ = A * B; break;
                case '/': KQ = A / B; break;
            }
            txtResult.Text = KQ.ToString();
        }
    }
}
