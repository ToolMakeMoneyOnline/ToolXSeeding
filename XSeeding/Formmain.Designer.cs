namespace XSeeding
{
    partial class Formmain
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.setBtn = new System.Windows.Forms.Button();
            this.configBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.profileDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usernameDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.displaynameDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cookieDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.proxyDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChatGPTKeyDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.noteDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusDLView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // setBtn
            // 
            this.setBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBtn.Location = new System.Drawing.Point(31, 46);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(240, 43);
            this.setBtn.TabIndex = 1;
            this.setBtn.Text = "CÀI ĐẶT ỨNG DỤNG";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // configBtn
            // 
            this.configBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configBtn.Location = new System.Drawing.Point(301, 46);
            this.configBtn.Name = "configBtn";
            this.configBtn.Size = new System.Drawing.Size(299, 43);
            this.configBtn.TabIndex = 2;
            this.configBtn.Text = "CẤU HÌNH CHỨC NĂNG";
            this.configBtn.UseVisualStyleBackColor = true;
            this.configBtn.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.profileDLView,
            this.usernameDLView,
            this.displaynameDLView,
            this.cookieDLView,
            this.proxyDLView,
            this.ChatGPTKeyDLView,
            this.noteDLView,
            this.statusDLView});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup2.Tag = "ưe";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 166);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(980, 366);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // profileDLView
            // 
            this.profileDLView.Tag = "";
            this.profileDLView.Text = "Profiled";
            this.profileDLView.Width = 100;
            // 
            // usernameDLView
            // 
            this.usernameDLView.Text = "Username";
            this.usernameDLView.Width = 100;
            // 
            // displaynameDLView
            // 
            this.displaynameDLView.Text = "Tên hiển thị";
            this.displaynameDLView.Width = 120;
            // 
            // cookieDLView
            // 
            this.cookieDLView.Text = "cookie";
            this.cookieDLView.Width = 100;
            // 
            // proxyDLView
            // 
            this.proxyDLView.Text = "Proxy";
            this.proxyDLView.Width = 100;
            // 
            // ChatGPTKeyDLView
            // 
            this.ChatGPTKeyDLView.Text = "ChatGPTKey";
            this.ChatGPTKeyDLView.Width = 100;
            // 
            // noteDLView
            // 
            this.noteDLView.Text = "Ghi chú";
            this.noteDLView.Width = 130;
            // 
            // statusDLView
            // 
            this.statusDLView.Text = "Trạng thái";
            this.statusDLView.Width = 100;
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 544);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.configBtn);
            this.Controls.Add(this.setBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Formmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XSeeding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Button configBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader profileDLView;
        private System.Windows.Forms.ColumnHeader usernameDLView;
        private System.Windows.Forms.ColumnHeader displaynameDLView;
        private System.Windows.Forms.ColumnHeader cookieDLView;
        private System.Windows.Forms.ColumnHeader proxyDLView;
        private System.Windows.Forms.ColumnHeader ChatGPTKeyDLView;
        private System.Windows.Forms.ColumnHeader noteDLView;
        private System.Windows.Forms.ColumnHeader statusDLView;
    }
}

