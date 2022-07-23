
namespace WindowsFormsApp_SQLServer
{
    partial class Form1
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
            this.pnlThongtin = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.lblsdt = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbnNam = new System.Windows.Forms.RadioButton();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.pnlExcel = new System.Windows.Forms.Panel();
            this.dtgvExcel = new System.Windows.Forms.DataGridView();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlThongtin.SuspendLayout();
            this.pnlExcel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExcel)).BeginInit();
            this.grbThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlThongtin
            // 
            this.pnlThongtin.Controls.Add(this.btnImport);
            this.pnlThongtin.Controls.Add(this.btnExport);
            this.pnlThongtin.Controls.Add(this.btnReport);
            this.pnlThongtin.Controls.Add(this.webBrowser1);
            this.pnlThongtin.Controls.Add(this.btnSua);
            this.pnlThongtin.Controls.Add(this.btnXoa);
            this.pnlThongtin.Controls.Add(this.btnThem);
            this.pnlThongtin.Controls.Add(this.txtsdt);
            this.pnlThongtin.Controls.Add(this.lblsdt);
            this.pnlThongtin.Controls.Add(this.lblDiachi);
            this.pnlThongtin.Controls.Add(this.dtpNgaysinh);
            this.pnlThongtin.Controls.Add(this.lblNgaysinh);
            this.pnlThongtin.Controls.Add(this.rbNu);
            this.pnlThongtin.Controls.Add(this.rbnNam);
            this.pnlThongtin.Controls.Add(this.lblGioitinh);
            this.pnlThongtin.Controls.Add(this.txtTenNV);
            this.pnlThongtin.Controls.Add(this.txtMaNV);
            this.pnlThongtin.Controls.Add(this.lblTenNV);
            this.pnlThongtin.Controls.Add(this.lblMaNV);
            this.pnlThongtin.Location = new System.Drawing.Point(16, 23);
            this.pnlThongtin.Name = "pnlThongtin";
            this.pnlThongtin.Size = new System.Drawing.Size(870, 197);
            this.pnlThongtin.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(615, 147);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 41);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(615, 88);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 41);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(615, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 41);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(383, 148);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(170, 22);
            this.txtsdt.TabIndex = 11;
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(286, 153);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(91, 17);
            this.lblsdt.TabIndex = 10;
            this.lblsdt.Text = "Số điện thoại";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(297, 68);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(51, 17);
            this.lblDiachi.TabIndex = 9;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(374, 22);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtpNgaysinh.TabIndex = 8;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Location = new System.Drawing.Point(297, 23);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(71, 17);
            this.lblNgaysinh.TabIndex = 7;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(176, 123);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 6;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbnNam
            // 
            this.rbnNam.AutoSize = true;
            this.rbnNam.Location = new System.Drawing.Point(100, 123);
            this.rbnNam.Name = "rbnNam";
            this.rbnNam.Size = new System.Drawing.Size(58, 21);
            this.rbnNam.TabIndex = 5;
            this.rbnNam.TabStop = true;
            this.rbnNam.Text = "Nam";
            this.rbnNam.UseVisualStyleBackColor = true;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(27, 123);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(60, 17);
            this.lblGioitinh.TabIndex = 4;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(100, 65);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(131, 22);
            this.txtTenNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(100, 24);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(27, 65);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(56, 17);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Tên NV";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(27, 24);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(50, 17);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã NV";
            // 
            // pnlExcel
            // 
            this.pnlExcel.Controls.Add(this.dtgvExcel);
            this.pnlExcel.Location = new System.Drawing.Point(6, 21);
            this.pnlExcel.Name = "pnlExcel";
            this.pnlExcel.Size = new System.Drawing.Size(872, 326);
            this.pnlExcel.TabIndex = 1;
            // 
            // dtgvExcel
            // 
            this.dtgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExcel.Location = new System.Drawing.Point(0, -2);
            this.dtgvExcel.Name = "dtgvExcel";
            this.dtgvExcel.RowHeadersWidth = 51;
            this.dtgvExcel.RowTemplate.Height = 24;
            this.dtgvExcel.Size = new System.Drawing.Size(872, 335);
            this.dtgvExcel.TabIndex = 0;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.pnlExcel);
            this.grbThongtin.Location = new System.Drawing.Point(2, 226);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Size = new System.Drawing.Size(884, 362);
            this.grbThongtin.TabIndex = 2;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(354, 56);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(220, 86);
            this.webBrowser1.TabIndex = 15;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(742, 22);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(116, 42);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(742, 87);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(116, 42);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(742, 146);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(116, 42);
            this.btnImport.TabIndex = 18;
            this.btnImport.Text = "Import Report";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 592);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.pnlThongtin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlThongtin.ResumeLayout(false);
            this.pnlThongtin.PerformLayout();
            this.pnlExcel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExcel)).EndInit();
            this.grbThongtin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlThongtin;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Panel pnlExcel;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbnNam;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.DataGridView dtgvExcel;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReport;
    }
}

