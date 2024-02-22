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
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.btnSet = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Profiled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.displayname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cookie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Proxy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChatGPTKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(31, 46);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(240, 43);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "CÀI ĐẶT ỨNG DỤNG";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(301, 46);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(299, 43);
            this.btnConfig.TabIndex = 2;
            this.btnConfig.Text = "CẤU HÌNH CHỨC NĂNG";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
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
            this.Profiled,
            this.Username,
            this.displayname,
            this.cookie,
            this.Proxy,
            this.ChatGPTKey,
            this.note,
            this.Status});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup7.Header = "ListViewGroup";
            listViewGroup7.Name = "listViewGroup1";
            listViewGroup8.Header = "ListViewGroup";
            listViewGroup8.Name = "listViewGroup2";
            listViewGroup8.Tag = "ưe";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup7,
            listViewGroup8});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 166);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(980, 366);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Profiled
            // 
            this.Profiled.Tag = "";
            this.Profiled.Text = "Profiled";
            this.Profiled.Width = 100;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 100;
            // 
            // displayname
            // 
            this.displayname.Text = "Tên hiển thị";
            this.displayname.Width = 120;
            // 
            // cookie
            // 
            this.cookie.Text = "cookie";
            this.cookie.Width = 100;
            // 
            // Proxy
            // 
            this.Proxy.Text = "Proxy";
            this.Proxy.Width = 100;
            // 
            // ChatGPTKey
            // 
            this.ChatGPTKey.Text = "ChatGPTKey";
            this.ChatGPTKey.Width = 100;
            // 
            // note
            // 
            this.note.Text = "Ghi chú";
            this.note.Width = 130;
            // 
            // Status
            // 
            this.Status.Text = "Trạng thái";
            this.Status.Width = 100;
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 544);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnSet);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Formmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XSeeding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Profiled;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader displayname;
        private System.Windows.Forms.ColumnHeader cookie;
        private System.Windows.Forms.ColumnHeader Proxy;
        private System.Windows.Forms.ColumnHeader ChatGPTKey;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.ColumnHeader Status;
    }
}

