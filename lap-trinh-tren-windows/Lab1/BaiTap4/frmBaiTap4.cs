using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class frmBaiTap4 : Form
    {
        public frmBaiTap4()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (txtNumN.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập số n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumN.Focus();
                return;
            }
            int n = int.Parse(txtNumN.Text);
            double res = 1;
            for (double i = 2; i <= n; i++)
            {
                res += 1 / i;
            }
            lblResult.Text = res.ToString();
        }

        private bool isInteger(string numStr)
        {
            int num;
            return int.TryParse(numStr, out num);
        }

        private void txtNumN_TextChanged(object sender, EventArgs e)
        {
            if (!isInteger(txtNumN.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumN.Text = "";
                txtNumN.Focus();
            }
        }
    }
}
