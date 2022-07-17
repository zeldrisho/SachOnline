namespace YouTubeAPIStream
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
            this.txtLog = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVideoPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUploadVideo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnVideoPath = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLog.DefaultText = "";
            this.txtLog.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLog.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLog.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLog.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLog.Location = new System.Drawing.Point(21, 72);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.PlaceholderText = "";
            this.txtLog.SelectedText = "";
            this.txtLog.Size = new System.Drawing.Size(630, 310);
            this.txtLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link video:";
            // 
            // txtVideoPath
            // 
            this.txtVideoPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVideoPath.DefaultText = "";
            this.txtVideoPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVideoPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVideoPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVideoPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVideoPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVideoPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVideoPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVideoPath.Location = new System.Drawing.Point(83, 25);
            this.txtVideoPath.Name = "txtVideoPath";
            this.txtVideoPath.PasswordChar = '\0';
            this.txtVideoPath.PlaceholderText = "";
            this.txtVideoPath.SelectedText = "";
            this.txtVideoPath.Size = new System.Drawing.Size(362, 36);
            this.txtVideoPath.TabIndex = 3;
            // 
            // btnUploadVideo
            // 
            this.btnUploadVideo.Animated = true;
            this.btnUploadVideo.AutoRoundedCorners = true;
            this.btnUploadVideo.BorderRadius = 21;
            this.btnUploadVideo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadVideo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUploadVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadVideo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUploadVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUploadVideo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUploadVideo.ForeColor = System.Drawing.Color.White;
            this.btnUploadVideo.Location = new System.Drawing.Point(516, 21);
            this.btnUploadVideo.Name = "btnUploadVideo";
            this.btnUploadVideo.Size = new System.Drawing.Size(135, 45);
            this.btnUploadVideo.TabIndex = 4;
            this.btnUploadVideo.Text = "Upload";
            this.btnUploadVideo.Click += new System.EventHandler(this.btnUploadVideo_Click);
            // 
            // btnVideoPath
            // 
            this.btnVideoPath.Animated = true;
            this.btnVideoPath.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVideoPath.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVideoPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVideoPath.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVideoPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVideoPath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVideoPath.ForeColor = System.Drawing.Color.White;
            this.btnVideoPath.Location = new System.Drawing.Point(451, 25);
            this.btnVideoPath.Name = "btnVideoPath";
            this.btnVideoPath.Size = new System.Drawing.Size(46, 36);
            this.btnVideoPath.TabIndex = 5;
            this.btnVideoPath.Text = "...";
            this.btnVideoPath.Click += new System.EventHandler(this.btnVideoPath_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtLog);
            this.pnlContainer.Controls.Add(this.btnVideoPath);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.btnUploadVideo);
            this.pnlContainer.Controls.Add(this.txtVideoPath);
            this.pnlContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(665, 395);
            this.pnlContainer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 416);
            this.Controls.Add(this.pnlContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtVideoPath;
        private Guna.UI2.WinForms.Guna2GradientButton btnUploadVideo;
        private Guna.UI2.WinForms.Guna2GradientButton btnVideoPath;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
    }
}

