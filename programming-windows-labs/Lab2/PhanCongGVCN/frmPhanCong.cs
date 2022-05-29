using System;
using System.Collections;
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
    public partial class frmPhanCong : Form
    {
        string name, cls;
        ArrayList teachers = new ArrayList();
        ArrayList clss = new ArrayList();
        Teacher tmp, teacher;

        public frmPhanCong()
        {
            InitializeComponent();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            name = lstTeacher.SelectedItem.ToString();
            cls = lstClass.SelectedItem.ToString();
            tmp = new Teacher(name);
            for (int j = 0; j < teachers.Count; j++)
            {
                teacher = (Teacher)teachers[j];
                if (tmp.name.Equals(teacher.name))
                {
                    switch (teacher.cntCls)
                    {
                        case 1:
                            for (int i = 0; i < clss.Count; i++)
                            {
                                if (cls.Equals(clss[i]))
                                {
                                    MessageBox.Show("Lớp này đã phân công chủ nhiệm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            teacher.cntCls++;
                            clss.Add(cls);
                            lstPhanCong.Items.Add("GV " + name + " CN lớp " + cls);
                            break;
                        case 2:
                            for (int i = 0; i < clss.Count; i++)
                            {
                                if (cls.Equals(clss[i]))
                                {
                                    MessageBox.Show("Lớp này đã phân công chủ nhiệm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            teacher.cntCls++;
                            clss.Add(cls);
                            lstPhanCong.Items.Add("GV " + name + " CN lớp " + cls);
                            break;
                        default:
                            MessageBox.Show("Giáo viên này đã chủ nhiệm đủ 3 lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    return;
                }
            }
            for (int i = 0; i < clss.Count; i++)
            {
                if (cls.Equals(clss[i]))
                {
                    MessageBox.Show("Lớp này đã phân công chủ nhiệm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            tmp.cntCls++;
            teachers.Add(tmp);
            clss.Add(cls);
            lstPhanCong.Items.Add("GV " + name + " CN lớp " + cls);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
