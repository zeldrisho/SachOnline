using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class frmLogin : Form
    {
        List<ClsTaiKhoan> ds = new List<ClsTaiKhoan>();
        public frmLogin()
        {
            InitializeComponent();
            ClsTaiKhoan tk = new ClsTaiKhoan();
            ds.Add(new ClsTaiKhoan("a", "123"));
            ds.Add(new ClsTaiKhoan("b", "456"));
            ds.Add(new ClsTaiKhoan("c", "789"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (ClsTaiKhoan k in ds)
            {
                if (txtName.Text.Equals(k.Username))
                {
                    if (txtPass.Text.Equals(k.Password))
                    {
                        MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập lại mật khẩu!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        txtPass.Text = "";
                        txtPass.Focus();
                    }
                }
            }
            MessageBox.Show("Vui lòng nhập lại tên đăng nhập!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            txtName.Text = "";
            txtPass.Text = "";
            txtName.Focus();
        }
    }
}
