namespace PhanCongGVCN
{
    partial class frmPhanCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTeacher = new System.Windows.Forms.ListBox();
            this.lstClass = new System.Windows.Forms.ListBox();
            this.lstPhanCong = new System.Windows.Forms.ListBox();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(587, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phân công";
            // 
            // lstTeacher
            // 
            this.lstTeacher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTeacher.FormattingEnabled = true;
            this.lstTeacher.ItemHeight = 16;
            this.lstTeacher.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Trần Thị B",
            "Lê Văn C"});
            this.lstTeacher.Location = new System.Drawing.Point(24, 94);
            this.lstTeacher.Name = "lstTeacher";
            this.lstTeacher.Size = new System.Drawing.Size(140, 180);
            this.lstTeacher.TabIndex = 3;
            // 
            // lstClass
            // 
            this.lstClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClass.FormattingEnabled = true;
            this.lstClass.ItemHeight = 16;
            this.lstClass.Items.AddRange(new object[] {
            "10A1",
            "10A2",
            "10A3",
            "11A1",
            "11A2",
            "11A3",
            "12A1",
            "12A2",
            "12A3"});
            this.lstClass.Location = new System.Drawing.Point(206, 94);
            this.lstClass.Name = "lstClass";
            this.lstClass.Size = new System.Drawing.Size(120, 180);
            this.lstClass.TabIndex = 4;
            // 
            // lstPhanCong
            // 
            this.lstPhanCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPhanCong.FormattingEnabled = true;
            this.lstPhanCong.ItemHeight = 16;
            this.lstPhanCong.Location = new System.Drawing.Point(502, 94);
            this.lstPhanCong.Name = "lstPhanCong";
            this.lstPhanCong.Size = new System.Drawing.Size(255, 180);
            this.lstPhanCong.TabIndex = 5;
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCong.Location = new System.Drawing.Point(366, 170);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(96, 35);
            this.btnPhanCong.TabIndex = 6;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.UseVisualStyleBackColor = true;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(661, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 374);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.lstPhanCong);
            this.Controls.Add(this.lstClass);
            this.Controls.Add(this.lstTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công GVCN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTeacher;
        private System.Windows.Forms.ListBox lstClass;
        private System.Windows.Forms.ListBox lstPhanCong;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnClose;
    }
}

