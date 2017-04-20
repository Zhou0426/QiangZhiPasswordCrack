namespace QiangZhi
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Userlabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.Countlabel = new System.Windows.Forms.Label();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.UserListBox = new System.Windows.Forms.ListBox();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.PassGroupBox = new System.Windows.Forms.GroupBox();
            this.PassListBox = new System.Windows.Forms.ListBox();
            this.SuccessGroupBox = new System.Windows.Forms.GroupBox();
            this.SuccessListBox = new System.Windows.Forms.ListBox();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.InfoProgressBar = new System.Windows.Forms.ProgressBar();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.MainMenuStrip.SuspendLayout();
            this.FileGroupBox.SuspendLayout();
            this.UserGroupBox.SuspendLayout();
            this.PassGroupBox.SuspendLayout();
            this.SuccessGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(1008, 25);
            this.MainMenuStrip.TabIndex = 0;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserToolStripMenuItem,
            this.PassToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.FileToolStripMenuItem.Text = "文件";
            // 
            // UserToolStripMenuItem
            // 
            this.UserToolStripMenuItem.Name = "UserToolStripMenuItem";
            this.UserToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.UserToolStripMenuItem.Text = "用户";
            this.UserToolStripMenuItem.Click += new System.EventHandler(this.UserToolStripMenuItem_Click);
            // 
            // PassToolStripMenuItem
            // 
            this.PassToolStripMenuItem.Name = "PassToolStripMenuItem";
            this.PassToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.PassToolStripMenuItem.Text = "密码";
            this.PassToolStripMenuItem.Click += new System.EventHandler(this.PassToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.AuthorToolStripMenuItem,
            this.WebToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.AboutToolStripMenuItem.Text = "关于";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.HelpToolStripMenuItem.Text = "帮助";
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            this.AuthorToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AuthorToolStripMenuItem.Text = "作者";
            // 
            // WebToolStripMenuItem
            // 
            this.WebToolStripMenuItem.Name = "WebToolStripMenuItem";
            this.WebToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.WebToolStripMenuItem.Text = "网站";
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Userlabel.Location = new System.Drawing.Point(6, 19);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(116, 17);
            this.Userlabel.TabIndex = 1;
            this.Userlabel.Text = "用户文件：未选择！";
            this.Userlabel.Click += new System.EventHandler(this.Userlabel_Click);
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Passlabel.Location = new System.Drawing.Point(6, 49);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(116, 17);
            this.Passlabel.TabIndex = 2;
            this.Passlabel.Text = "密码文件：未选择！";
            this.Passlabel.Click += new System.EventHandler(this.Passlabel_Click);
            // 
            // Countlabel
            // 
            this.Countlabel.AutoSize = true;
            this.Countlabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Countlabel.Location = new System.Drawing.Point(6, 79);
            this.Countlabel.Name = "Countlabel";
            this.Countlabel.Size = new System.Drawing.Size(128, 17);
            this.Countlabel.TabIndex = 3;
            this.Countlabel.Text = "预计次数：无法预测！";
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Controls.Add(this.StartButton);
            this.FileGroupBox.Controls.Add(this.Countlabel);
            this.FileGroupBox.Controls.Add(this.Userlabel);
            this.FileGroupBox.Controls.Add(this.Passlabel);
            this.FileGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileGroupBox.Location = new System.Drawing.Point(8, 28);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(992, 104);
            this.FileGroupBox.TabIndex = 4;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = " 文件信息";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(877, 19);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(109, 77);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "开始破解";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.UserListBox);
            this.UserGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserGroupBox.Location = new System.Drawing.Point(8, 138);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(324, 391);
            this.UserGroupBox.TabIndex = 5;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "用户列表";
            // 
            // UserListBox
            // 
            this.UserListBox.FormattingEnabled = true;
            this.UserListBox.ItemHeight = 17;
            this.UserListBox.Location = new System.Drawing.Point(6, 22);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(312, 361);
            this.UserListBox.TabIndex = 0;
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 839);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.Size = new System.Drawing.Size(1008, 22);
            this.MainStatusStrip.TabIndex = 6;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // PassGroupBox
            // 
            this.PassGroupBox.Controls.Add(this.PassListBox);
            this.PassGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassGroupBox.Location = new System.Drawing.Point(342, 138);
            this.PassGroupBox.Name = "PassGroupBox";
            this.PassGroupBox.Size = new System.Drawing.Size(324, 391);
            this.PassGroupBox.TabIndex = 7;
            this.PassGroupBox.TabStop = false;
            this.PassGroupBox.Text = "密码列表";
            // 
            // PassListBox
            // 
            this.PassListBox.FormattingEnabled = true;
            this.PassListBox.ItemHeight = 17;
            this.PassListBox.Location = new System.Drawing.Point(6, 22);
            this.PassListBox.Name = "PassListBox";
            this.PassListBox.Size = new System.Drawing.Size(312, 361);
            this.PassListBox.TabIndex = 0;
            // 
            // SuccessGroupBox
            // 
            this.SuccessGroupBox.Controls.Add(this.SuccessListBox);
            this.SuccessGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SuccessGroupBox.Location = new System.Drawing.Point(676, 138);
            this.SuccessGroupBox.Name = "SuccessGroupBox";
            this.SuccessGroupBox.Size = new System.Drawing.Size(324, 391);
            this.SuccessGroupBox.TabIndex = 8;
            this.SuccessGroupBox.TabStop = false;
            this.SuccessGroupBox.Text = "成功列表";
            // 
            // SuccessListBox
            // 
            this.SuccessListBox.FormattingEnabled = true;
            this.SuccessListBox.ItemHeight = 17;
            this.SuccessListBox.Location = new System.Drawing.Point(6, 22);
            this.SuccessListBox.Name = "SuccessListBox";
            this.SuccessListBox.Size = new System.Drawing.Size(312, 361);
            this.SuccessListBox.TabIndex = 0;
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.InfoProgressBar);
            this.InfoGroupBox.Controls.Add(this.InfoTextBox);
            this.InfoGroupBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.InfoGroupBox.Location = new System.Drawing.Point(8, 535);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(992, 301);
            this.InfoGroupBox.TabIndex = 9;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "信息输出";
            // 
            // InfoProgressBar
            // 
            this.InfoProgressBar.Location = new System.Drawing.Point(6, 22);
            this.InfoProgressBar.Name = "InfoProgressBar";
            this.InfoProgressBar.Size = new System.Drawing.Size(980, 23);
            this.InfoProgressBar.TabIndex = 5;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoTextBox.Location = new System.Drawing.Point(6, 51);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.InfoTextBox.Size = new System.Drawing.Size(980, 244);
            this.InfoTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 861);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.SuccessGroupBox);
            this.Controls.Add(this.PassGroupBox);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.UserGroupBox);
            this.Controls.Add(this.FileGroupBox);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "强智教务系统密码暴力破解器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.FileGroupBox.ResumeLayout(false);
            this.FileGroupBox.PerformLayout();
            this.UserGroupBox.ResumeLayout(false);
            this.PassGroupBox.ResumeLayout(false);
            this.SuccessGroupBox.ResumeLayout(false);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PassToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WebToolStripMenuItem;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Label Countlabel;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ListBox UserListBox;
        private System.Windows.Forms.GroupBox PassGroupBox;
        private System.Windows.Forms.ListBox PassListBox;
        private System.Windows.Forms.GroupBox SuccessGroupBox;
        private System.Windows.Forms.ListBox SuccessListBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar InfoProgressBar;
    }
}

