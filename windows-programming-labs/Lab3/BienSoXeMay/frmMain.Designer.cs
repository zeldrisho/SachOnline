namespace BienSoXeMay
{
    partial class frmMain
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
            this.lsbNumber = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllNumber = new System.Windows.Forms.Button();
            this.btnNineNode = new System.Windows.Forms.Button();
            this.btnPalindromeNumber = new System.Windows.Forms.Button();
            this.btnSoGanh = new System.Windows.Forms.Button();
            this.btnNumberIncrease = new System.Windows.Forms.Button();
            this.btnNumberNonDecrease = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbNumber
            // 
            this.lsbNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbNumber.FormattingEnabled = true;
            this.lsbNumber.ItemHeight = 21;
            this.lsbNumber.Location = new System.Drawing.Point(0, 0);
            this.lsbNumber.Name = "lsbNumber";
            this.lsbNumber.Size = new System.Drawing.Size(314, 495);
            this.lsbNumber.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnNumberNonDecrease);
            this.panel1.Controls.Add(this.btnNumberIncrease);
            this.panel1.Controls.Add(this.btnSoGanh);
            this.panel1.Controls.Add(this.btnPalindromeNumber);
            this.panel1.Controls.Add(this.btnNineNode);
            this.panel1.Controls.Add(this.btnAllNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(314, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 495);
            this.panel1.TabIndex = 1;
            // 
            // btnAllNumber
            // 
            this.btnAllNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllNumber.Location = new System.Drawing.Point(68, 22);
            this.btnAllNumber.Name = "btnAllNumber";
            this.btnAllNumber.Size = new System.Drawing.Size(225, 45);
            this.btnAllNumber.TabIndex = 0;
            this.btnAllNumber.Text = "Tất cả các bảng số";
            this.btnAllNumber.UseVisualStyleBackColor = true;
            this.btnAllNumber.Click += new System.EventHandler(this.btnAllNumber_Click);
            // 
            // btnNineNode
            // 
            this.btnNineNode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNineNode.Location = new System.Drawing.Point(68, 73);
            this.btnNineNode.Name = "btnNineNode";
            this.btnNineNode.Size = new System.Drawing.Size(225, 45);
            this.btnNineNode.TabIndex = 1;
            this.btnNineNode.Text = "Bảng số 9 nút";
            this.btnNineNode.UseVisualStyleBackColor = true;
            this.btnNineNode.Click += new System.EventHandler(this.btnNineNode_Click);
            // 
            // btnPalindromeNumber
            // 
            this.btnPalindromeNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalindromeNumber.Location = new System.Drawing.Point(68, 124);
            this.btnPalindromeNumber.Name = "btnPalindromeNumber";
            this.btnPalindromeNumber.Size = new System.Drawing.Size(225, 45);
            this.btnPalindromeNumber.TabIndex = 2;
            this.btnPalindromeNumber.Text = "Bảng số đối xứng";
            this.btnPalindromeNumber.UseVisualStyleBackColor = true;
            this.btnPalindromeNumber.Click += new System.EventHandler(this.btnPalindromeNumber_Click);
            // 
            // btnSoGanh
            // 
            this.btnSoGanh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoGanh.Location = new System.Drawing.Point(68, 175);
            this.btnSoGanh.Name = "btnSoGanh";
            this.btnSoGanh.Size = new System.Drawing.Size(225, 45);
            this.btnSoGanh.TabIndex = 3;
            this.btnSoGanh.Text = "Bảng số gánh";
            this.btnSoGanh.UseVisualStyleBackColor = true;
            this.btnSoGanh.Click += new System.EventHandler(this.btnSoGanh_Click);
            // 
            // btnNumberIncrease
            // 
            this.btnNumberIncrease.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberIncrease.Location = new System.Drawing.Point(68, 226);
            this.btnNumberIncrease.Name = "btnNumberIncrease";
            this.btnNumberIncrease.Size = new System.Drawing.Size(225, 45);
            this.btnNumberIncrease.TabIndex = 4;
            this.btnNumberIncrease.Text = "Bảng số có 3 số tăng liên tiếp";
            this.btnNumberIncrease.UseVisualStyleBackColor = true;
            this.btnNumberIncrease.Click += new System.EventHandler(this.btnNumberIncrease_Click);
            // 
            // btnNumberNonDecrease
            // 
            this.btnNumberNonDecrease.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberNonDecrease.Location = new System.Drawing.Point(68, 277);
            this.btnNumberNonDecrease.Name = "btnNumberNonDecrease";
            this.btnNumberNonDecrease.Size = new System.Drawing.Size(225, 45);
            this.btnNumberNonDecrease.TabIndex = 5;
            this.btnNumberNonDecrease.Text = "Bảng số không giảm";
            this.btnNumberNonDecrease.UseVisualStyleBackColor = true;
            this.btnNumberNonDecrease.Click += new System.EventHandler(this.btnNumberNonDecrease_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(68, 328);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(225, 45);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(155, 420);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 21);
            this.lblCount.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsbNumber);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng số xe";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNumberNonDecrease;
        private System.Windows.Forms.Button btnNumberIncrease;
        private System.Windows.Forms.Button btnSoGanh;
        private System.Windows.Forms.Button btnPalindromeNumber;
        private System.Windows.Forms.Button btnNineNode;
        private System.Windows.Forms.Button btnAllNumber;
        private System.Windows.Forms.Label lblCount;
    }
}

