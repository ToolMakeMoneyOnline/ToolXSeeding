namespace XSeeding
{
    partial class FormConfig
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
            this.backBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.finishBtn = new System.Windows.Forms.Button();
            this.tabConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmtADSCbb = new System.Windows.Forms.ComboBox();
            this.likeADSCbb = new System.Windows.Forms.ComboBox();
            this.runagainADSCbb = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listfileTxb = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmtPointCbb = new System.Windows.Forms.ComboBox();
            this.likePointCbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listpostTxb = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmtNfCbb = new System.Windows.Forms.ComboBox();
            this.likeNfCbb = new System.Windows.Forms.ComboBox();
            this.runagainNfCbb = new System.Windows.Forms.ComboBox();
            this.timestopNmr = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timestopNmr)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(38, 500);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(142, 41);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "QUAY LẠI";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(393, 500);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(142, 41);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "HỦY BỎ";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // finishBtn
            // 
            this.finishBtn.Location = new System.Drawing.Point(620, 500);
            this.finishBtn.Name = "finishBtn";
            this.finishBtn.Size = new System.Drawing.Size(142, 41);
            this.finishBtn.TabIndex = 5;
            this.finishBtn.Text = "HOÀN TẤT";
            this.finishBtn.UseVisualStyleBackColor = true;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.tabPage1);
            this.tabConfig.Controls.Add(this.tabPage2);
            this.tabConfig.Controls.Add(this.tabPage3);
            this.tabConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabConfig.Location = new System.Drawing.Point(12, 34);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Drawing.Point(10, 3);
            this.tabConfig.SelectedIndex = 0;
            this.tabConfig.Size = new System.Drawing.Size(772, 431);
            this.tabConfig.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmtADSCbb);
            this.tabPage1.Controls.Add(this.likeADSCbb);
            this.tabPage1.Controls.Add(this.runagainADSCbb);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listfileTxb);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tương tác quảng cáo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmtADSCbb
            // 
            this.cmtADSCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtADSCbb.FormattingEnabled = true;
            this.cmtADSCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật",
            "Ngẫu nhiên"});
            this.cmtADSCbb.Location = new System.Drawing.Point(276, 306);
            this.cmtADSCbb.Name = "cmtADSCbb";
            this.cmtADSCbb.Size = new System.Drawing.Size(154, 28);
            this.cmtADSCbb.TabIndex = 10;
            // 
            // likeADSCbb
            // 
            this.likeADSCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeADSCbb.FormattingEnabled = true;
            this.likeADSCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật",
            "Ngẫu nhiên"});
            this.likeADSCbb.Location = new System.Drawing.Point(276, 263);
            this.likeADSCbb.Name = "likeADSCbb";
            this.likeADSCbb.Size = new System.Drawing.Size(154, 28);
            this.likeADSCbb.TabIndex = 9;
            // 
            // runagainADSCbb
            // 
            this.runagainADSCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runagainADSCbb.FormattingEnabled = true;
            this.runagainADSCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật"});
            this.runagainADSCbb.Location = new System.Drawing.Point(276, 218);
            this.runagainADSCbb.Name = "runagainADSCbb";
            this.runagainADSCbb.Size = new System.Drawing.Size(154, 28);
            this.runagainADSCbb.TabIndex = 8;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(30, 169);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(271, 29);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Xáo trộn danh sách profiles";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comment bài viết: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Like bài viết:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chạy lại sau khi kết thúc: ";
            // 
            // listfileTxb
            // 
            this.listfileTxb.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listfileTxb.Location = new System.Drawing.Point(17, 16);
            this.listfileTxb.Multiline = true;
            this.listfileTxb.Name = "listfileTxb";
            this.listfileTxb.Size = new System.Drawing.Size(729, 135);
            this.listfileTxb.TabIndex = 0;
            this.listfileTxb.Text = "Danh sách profiles";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmtPointCbb);
            this.tabPage2.Controls.Add(this.likePointCbb);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.listpostTxb);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tương tác chỉ định";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmtPointCbb
            // 
            this.cmtPointCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtPointCbb.FormattingEnabled = true;
            this.cmtPointCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật",
            "Ngẫu nhiên"});
            this.cmtPointCbb.Location = new System.Drawing.Point(273, 279);
            this.cmtPointCbb.Name = "cmtPointCbb";
            this.cmtPointCbb.Size = new System.Drawing.Size(154, 28);
            this.cmtPointCbb.TabIndex = 14;
            // 
            // likePointCbb
            // 
            this.likePointCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likePointCbb.FormattingEnabled = true;
            this.likePointCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật",
            "Ngẫu nhiên"});
            this.likePointCbb.Location = new System.Drawing.Point(273, 232);
            this.likePointCbb.Name = "likePointCbb";
            this.likePointCbb.Size = new System.Drawing.Size(154, 28);
            this.likePointCbb.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(41, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(558, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ví dụ: https://twitter.com/username/status/123456789 | /username/status/123456789" +
    "";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(270, 29);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Xáo trộn danh sách bài viết";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comment bài viết: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Like bài viết:";
            // 
            // listpostTxb
            // 
            this.listpostTxb.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listpostTxb.Location = new System.Drawing.Point(16, 15);
            this.listpostTxb.Multiline = true;
            this.listpostTxb.Name = "listpostTxb";
            this.listpostTxb.Size = new System.Drawing.Size(729, 135);
            this.listpostTxb.TabIndex = 1;
            this.listpostTxb.Text = "Danh sách bài viết (đường dẫn chi tiết)";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmtNfCbb);
            this.tabPage3.Controls.Add(this.likeNfCbb);
            this.tabPage3.Controls.Add(this.runagainNfCbb);
            this.tabPage3.Controls.Add(this.timestopNmr);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(764, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lướt newfeed";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmtNfCbb
            // 
            this.cmtNfCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmtNfCbb.FormattingEnabled = true;
            this.cmtNfCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật",
            "Ngẫu nhiên"});
            this.cmtNfCbb.Location = new System.Drawing.Point(255, 203);
            this.cmtNfCbb.Name = "cmtNfCbb";
            this.cmtNfCbb.Size = new System.Drawing.Size(154, 28);
            this.cmtNfCbb.TabIndex = 18;
            // 
            // likeNfCbb
            // 
            this.likeNfCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeNfCbb.FormattingEnabled = true;
            this.likeNfCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật",
            "Ngẫu nhiên"});
            this.likeNfCbb.Location = new System.Drawing.Point(255, 148);
            this.likeNfCbb.Name = "likeNfCbb";
            this.likeNfCbb.Size = new System.Drawing.Size(154, 28);
            this.likeNfCbb.TabIndex = 17;
            // 
            // runagainNfCbb
            // 
            this.runagainNfCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runagainNfCbb.FormattingEnabled = true;
            this.runagainNfCbb.Items.AddRange(new object[] {
            "Tắt ",
            "Bật"});
            this.runagainNfCbb.Location = new System.Drawing.Point(439, 38);
            this.runagainNfCbb.Name = "runagainNfCbb";
            this.runagainNfCbb.Size = new System.Drawing.Size(179, 28);
            this.runagainNfCbb.TabIndex = 16;
            // 
            // timestopNmr
            // 
            this.timestopNmr.Location = new System.Drawing.Point(439, 93);
            this.timestopNmr.Name = "timestopNmr";
            this.timestopNmr.Size = new System.Drawing.Size(179, 30);
            this.timestopNmr.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(352, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Dừng sau khi lướt trong thời gian (phút):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Comment bài viết: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Like bài viết:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Chạy lại sau khi kết thúc: ";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 577);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.finishBtn);
            this.Controls.Add(this.tabConfig);
            this.Name = "FormConfig";
            this.Text = "FormConfig";
            this.tabConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timestopNmr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button finishBtn;
        private System.Windows.Forms.TabControl tabConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox listfileTxb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox listpostTxb;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown timestopNmr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmtADSCbb;
        private System.Windows.Forms.ComboBox likeADSCbb;
        private System.Windows.Forms.ComboBox runagainADSCbb;
        private System.Windows.Forms.ComboBox cmtPointCbb;
        private System.Windows.Forms.ComboBox likePointCbb;
        private System.Windows.Forms.ComboBox cmtNfCbb;
        private System.Windows.Forms.ComboBox likeNfCbb;
        private System.Windows.Forms.ComboBox runagainNfCbb;
    }
}