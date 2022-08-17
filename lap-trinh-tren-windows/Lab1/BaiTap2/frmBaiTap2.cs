using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2
{
    public partial class frmBaiTap2 : Form
    {
        public frmBaiTap2()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập giá trị a.", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoA.Focus();
                return;
            }
            if (txtSoB.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập giá trị b.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoB.Focus();
                return;
            }
            int a, b;
            a = int.Parse(txtSoA.Text);
            b = int.Parse(txtSoB.Text);
            if (a == 0)
            {
                if (b == 0)
                    lblResult.Text = "Vô số nghiệm";
                else
                    lblResult.Text = "Vô nghiệm";
            }
            else
            {
                float res = (float)(-b) / (float)a;
                lblResult.Text = "Kết quả: " + res;
            }
        }

        private bool isInteger(string numStr)
        {
            int num;
            return int.TryParse(numStr, out num);
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {
            if (!isInteger(txtSoA.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoA.Text = "";
                txtSoA.Focus();
            }
        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {
            if (!isInteger(txtSoB.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoB.Text = "";
                txtSoB.Focus();
            }
        }
    }
}
