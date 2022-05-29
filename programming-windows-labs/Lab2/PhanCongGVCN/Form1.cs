using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanCongGVCN
{
    public partial class Form1 : Form
    {
        string teacher, cls;
        int cntTeacher, cntCls;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            teacher = lstTeacher.SelectedItem.ToString();
            cls = lstClass.SelectedItem.ToString();
            lstPhanCong.Items.Add("GV" + teacher  + " CN lớp " + cls);
            cnt++;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
