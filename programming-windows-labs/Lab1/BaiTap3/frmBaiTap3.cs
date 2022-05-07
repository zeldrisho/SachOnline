using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3
{
    public partial class frmBaiTap3 : Form
    {
        public frmBaiTap3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonth.Focus();
                return;
            }
            if (txtYear.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYear.Focus();
                return;
            }
            int day = 0, month, year;
            month = int.Parse(txtMonth.Text);
            year = int.Parse(txtYear.Text);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if (year % 400 == 0)
                    {
                        day = 29;
                        break;
                    }
                    if (year % 4 == 0 && year % 100 != 0)
                    {
                        day = 29;
                        break;
                    }
                    day = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                default:
                    break;
            }
            lblResult.Text = day.ToString() + " ngày";
        }

        private bool isInteger(string numStr)
        {
            int num;
            return int.TryParse(numStr, out num);
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (!isInteger(txtMonth.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonth.Text = "";
                txtMonth.Focus();
            }
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            if (!isInteger(txtYear.Text))
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtYear.Text = "";
                txtYear.Focus();
            }
        }
    }
}
