namespace practice
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_Cancel1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button_cancel2 = new System.Windows.Forms.Button();
            this.button_cancel4 = new System.Windows.Forms.Button();
            this.button_cancel3 = new System.Windows.Forms.Button();
            this.tabPage_SearchBiblio = new System.Windows.Forms.TabPage();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.tabPage_Server = new System.Windows.Forms.TabPage();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.button_getVersion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Server_textBox_password = new System.Windows.Forms.TextBox();
            this.Server_textBox_userName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Server_textBox_url = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage2.SuspendLayout();
            this.tabPage_Server.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Cancel1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button_cancel2);
            this.tabPage2.Controls.Add(this.button_cancel4);
            this.tabPage2.Controls.Add(this.button_cancel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(683, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "通用练习题";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_Cancel1
            // 
            this.button_Cancel1.Location = new System.Drawing.Point(28, 28);
            this.button_Cancel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Cancel1.Name = "button_Cancel1";
            this.button_Cancel1.Size = new System.Drawing.Size(331, 30);
            this.button_Cancel1.TabIndex = 1;
            this.button_Cancel1.Text = "1个CancellationToken停止1个线程";
            this.button_Cancel1.UseVisualStyleBackColor = true;
            this.button_Cancel1.Click += new System.EventHandler(this.button_Cancel1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(28, 292);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(331, 35);
            this.button5.TabIndex = 5;
            this.button5.Text = "回调函数 与 事件";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_cancel2
            // 
            this.button_cancel2.Location = new System.Drawing.Point(28, 79);
            this.button_cancel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel2.Name = "button_cancel2";
            this.button_cancel2.Size = new System.Drawing.Size(331, 42);
            this.button_cancel2.TabIndex = 2;
            this.button_cancel2.Text = "多个CancellationToken停止1个线程";
            this.button_cancel2.UseVisualStyleBackColor = true;
            this.button_cancel2.Click += new System.EventHandler(this.button_cancel2_Click);
            // 
            // button_cancel4
            // 
            this.button_cancel4.Location = new System.Drawing.Point(28, 192);
            this.button_cancel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel4.Name = "button_cancel4";
            this.button_cancel4.Size = new System.Drawing.Size(348, 77);
            this.button_cancel4.TabIndex = 4;
            this.button_cancel4.Text = "等待两个线程-控制按钮状态写在包裹的线程里\r\n线程函数返回一个对象\r\n浏览器控件";
            this.button_cancel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel4.UseVisualStyleBackColor = true;
            this.button_cancel4.Click += new System.EventHandler(this.button_cancel4_Click);
            // 
            // button_cancel3
            // 
            this.button_cancel3.Location = new System.Drawing.Point(28, 140);
            this.button_cancel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_cancel3.Name = "button_cancel3";
            this.button_cancel3.Size = new System.Drawing.Size(331, 35);
            this.button_cancel3.TabIndex = 3;
            this.button_cancel3.Text = "等待两个线程";
            this.button_cancel3.UseVisualStyleBackColor = true;
            this.button_cancel3.Click += new System.EventHandler(this.button_cancel3_Click);
            // 
            // tabPage_SearchBiblio
            // 
            this.tabPage_SearchBiblio.Location = new System.Drawing.Point(4, 25);
            this.tabPage_SearchBiblio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_SearchBiblio.Name = "tabPage_SearchBiblio";
            this.tabPage_SearchBiblio.Size = new System.Drawing.Size(683, 665);
            this.tabPage_SearchBiblio.TabIndex = 3;
            this.tabPage_SearchBiblio.Text = "SearchBiblio";
            this.tabPage_SearchBiblio.UseVisualStyleBackColor = true;
            // 
            // textBox_result
            // 
            this.textBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_result.Location = new System.Drawing.Point(3, 25);
            this.textBox_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(294, 506);
            this.textBox_result.TabIndex = 20;
            // 
            // tabPage_Server
            // 
            this.tabPage_Server.Controls.Add(this.button_logout);
            this.tabPage_Server.Controls.Add(this.button_login);
            this.tabPage_Server.Controls.Add(this.button_getVersion);
            this.tabPage_Server.Controls.Add(this.groupBox1);
            this.tabPage_Server.Controls.Add(this.Server_textBox_url);
            this.tabPage_Server.Controls.Add(this.label4);
            this.tabPage_Server.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Server.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Server.Name = "tabPage_Server";
            this.tabPage_Server.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Server.Size = new System.Drawing.Size(683, 504);
            this.tabPage_Server.TabIndex = 0;
            this.tabPage_Server.Text = "服务器信息";
            this.tabPage_Server.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(275, 254);
            this.button_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(92, 32);
            this.button_logout.TabIndex = 24;
            this.button_logout.Tag = "";
            this.button_logout.Text = "登出";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(165, 254);
            this.button_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(92, 32);
            this.button_login.TabIndex = 23;
            this.button_login.Tag = "";
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_getVersion
            // 
            this.button_getVersion.Location = new System.Drawing.Point(20, 254);
            this.button_getVersion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_getVersion.Name = "button_getVersion";
            this.button_getVersion.Size = new System.Drawing.Size(120, 32);
            this.button_getVersion.TabIndex = 22;
            this.button_getVersion.Tag = "";
            this.button_getVersion.Text = "获取版本号";
            this.button_getVersion.UseVisualStyleBackColor = true;
            this.button_getVersion.Click += new System.EventHandler(this.button_getVersion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Server_textBox_password);
            this.groupBox1.Controls.Add(this.Server_textBox_userName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(570, 125);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "默认帐号";
            // 
            // Server_textBox_password
            // 
            this.Server_textBox_password.Location = new System.Drawing.Point(88, 80);
            this.Server_textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Server_textBox_password.Name = "Server_textBox_password";
            this.Server_textBox_password.Size = new System.Drawing.Size(220, 25);
            this.Server_textBox_password.TabIndex = 20;
            // 
            // Server_textBox_userName
            // 
            this.Server_textBox_userName.Location = new System.Drawing.Point(88, 38);
            this.Server_textBox_userName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Server_textBox_userName.Name = "Server_textBox_userName";
            this.Server_textBox_userName.Size = new System.Drawing.Size(220, 25);
            this.Server_textBox_userName.TabIndex = 19;
            this.Server_textBox_userName.Text = "supervisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "用户名：";
            // 
            // Server_textBox_url
            // 
            this.Server_textBox_url.Location = new System.Drawing.Point(195, 31);
            this.Server_textBox_url.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Server_textBox_url.Name = "Server_textBox_url";
            this.Server_textBox_url.Size = new System.Drawing.Size(395, 25);
            this.Server_textBox_url.TabIndex = 17;
            this.Server_textBox_url.Text = "http://localhost/dp2library/xe/rest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "dp2Library 服务器URL：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Server);
            this.tabControl1.Controls.Add(this.tabPage_SearchBiblio);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(691, 533);
            this.tabControl1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox_result);
            this.splitContainer1.Size = new System.Drawing.Size(995, 533);
            this.splitContainer1.SplitterDistance = 691;
            this.splitContainer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 533);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "练习窗";
            this.tabPage2.ResumeLayout(false);
            this.tabPage_Server.ResumeLayout(false);
            this.tabPage_Server.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_Cancel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_cancel2;
        private System.Windows.Forms.Button button_cancel4;
        private System.Windows.Forms.Button button_cancel3;
        private System.Windows.Forms.TabPage tabPage_SearchBiblio;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TabPage tabPage_Server;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Server_textBox_password;
        private System.Windows.Forms.TextBox Server_textBox_userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Server_textBox_url;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_getVersion;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

