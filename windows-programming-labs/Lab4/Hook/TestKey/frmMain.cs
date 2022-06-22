using System;
using System.Windows.Forms;
using Helper;

namespace TestKey
{
    public partial class frmMain : Form
    {
        KeyHelper kh = new KeyHelper();
        bool ctrl, shift;
        private bool isHook;
        public frmMain()
        {
            InitializeComponent();
            kh.KeyDown += Kh_KeyDown;
            kh.KeyUp += Kh_KeyUp;
        }

        private void Kh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.RControlKey || e.KeyCode == Keys.RControlKey)
            {
                ctrl = false;
            }
            if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey)
            {
                shift = false;
            }
        }

        private void Kh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.LControlKey || e.KeyCode == Keys.RControlKey)
            {
                ctrl = true;
            }
            if (e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey)
            {
                shift = true;
            }
            if (e.KeyCode == Keys.T && ctrl && shift)
            {
                keyPress.Text = "Trạng thái: Đã chặn bàn phím";
                isHook = true;
            }
            if (e.KeyCode == Keys.R && ctrl && shift)
            {
                keyPress.Text = "Trạng thái: Bình thường";
                isHook = false;
            }
            e.Handled = isHook;
        }
    }
}
