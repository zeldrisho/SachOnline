using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BienSoXeMay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAllNumber_Click(object sender, EventArgs e)
        {
            lsbNumber.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                lsbNumber.Items.Add(s);
            }
            lblCount.Text = lsbNumber.Items.Count.ToString();
        }

        private void btnNineNode_Click(object sender, EventArgs e)
        {
            lsbNumber.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                string tong = Convert.ToString(s1 + s2 + s3 + s4);
                if (tong.Substring(tong.Length - 1, 1) == "9")
                    lsbNumber.Items.Add(s);
            }
            lblCount.Text = lsbNumber.Items.Count.ToString();
        }

        private void btnPalindromeNumber_Click(object sender, EventArgs e)
        {
            lsbNumber.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if (s1 == s4 && s2 == s3)
                    lsbNumber.Items.Add(s);
            }
            lblCount.Text = lsbNumber.Items.Count.ToString();
        }

        private void btnSoGanh_Click(object sender, EventArgs e)
        {
            lsbNumber.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if ((s1 == s3 || s2 == s4)
                && ((s1 != s2 && s2 != s3) || (s2 != s3 && s3 != s4)))
                    lsbNumber.Items.Add(s);
            }
            lblCount.Text = lsbNumber.Items.Count.ToString();
        }

        private void btnNumberIncrease_Click(object sender, EventArgs e)
        {
            lsbNumber.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if ((s1 <= s2 && s2 < s3 && s3 > s4) ||
                (s2 <= s3 && s3 < s4 && s1 > s2))
                    lsbNumber.Items.Add(s);
            }
            lblCount.Text = lsbNumber.Items.Count.ToString();
        }

        private void btnNumberNonDecrease_Click(object sender, EventArgs e)
        {
            lsbNumber.Items.Clear();
            for (int i = 1; i <= 9999; i++)
            {
                string s = String.Format("{0:0000}", i);
                int s1 = Convert.ToInt16(s.Substring(0, 1));
                int s2 = Convert.ToInt16(s.Substring(1, 1));
                int s3 = Convert.ToInt16(s.Substring(2, 1));
                int s4 = Convert.ToInt16(s.Substring(3, 1));
                if (s1 <= s2 && s2 <= s3 && s3 <= s4)
                    lsbNumber.Items.Add(s);
            }
            lblCount.Text = lsbNumber.Items.Count.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
