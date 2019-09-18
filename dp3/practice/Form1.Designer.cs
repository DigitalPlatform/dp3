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
            this.button_Cancel1 = new System.Windows.Forms.Button();
            this.button_cancel2 = new System.Windows.Forms.Button();
            this.button_cancel3 = new System.Windows.Forms.Button();
            this.button_cancel4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage_channel = new System.Windows.Forms.TabPage();
            this.button_viewChannel = new System.Windows.Forms.Button();
            this.button_clearChannel = new System.Windows.Forms.Button();
            this.button_returnChannel = new System.Windows.Forms.Button();
            this.Channel_listView_channels = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_getChannel = new System.Windows.Forms.Button();
            this.Channel_textBox_userName = new System.Windows.Forms.TextBox();
            this.Channel_textBox_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Login = new System.Windows.Forms.TabPage();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_getVersior = new System.Windows.Forms.Button();
            this.Login_textBox_result = new System.Windows.Forms.TextBox();
            this.Login_textBox_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.Login_textBox_userName = new System.Windows.Forms.TextBox();
            this.Login_textBox_url = new System.Windows.Forms.TextBox();
            this.label_login_userName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage_SearchBiblio = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage_channel.SuspendLayout();
            this.tabPage_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Cancel1
            // 
            this.button_Cancel1.Location = new System.Drawing.Point(32, 34);
            this.button_Cancel1.Name = "button_Cancel1";
            this.button_Cancel1.Size = new System.Drawing.Size(372, 36);
            this.button_Cancel1.TabIndex = 1;
            this.button_Cancel1.Text = "1个CancellationToken停止1个线程";
            this.button_Cancel1.UseVisualStyleBackColor = true;
            this.button_Cancel1.Click += new System.EventHandler(this.button_Cancel1_Click);
            // 
            // button_cancel2
            // 
            this.button_cancel2.Location = new System.Drawing.Point(32, 95);
            this.button_cancel2.Name = "button_cancel2";
            this.button_cancel2.Size = new System.Drawing.Size(372, 50);
            this.button_cancel2.TabIndex = 2;
            this.button_cancel2.Text = "多个CancellationToken停止1个线程";
            this.button_cancel2.UseVisualStyleBackColor = true;
            this.button_cancel2.Click += new System.EventHandler(this.button_cancel2_Click);
            // 
            // button_cancel3
            // 
            this.button_cancel3.Location = new System.Drawing.Point(32, 168);
            this.button_cancel3.Name = "button_cancel3";
            this.button_cancel3.Size = new System.Drawing.Size(372, 42);
            this.button_cancel3.TabIndex = 3;
            this.button_cancel3.Text = "等待两个线程";
            this.button_cancel3.UseVisualStyleBackColor = true;
            this.button_cancel3.Click += new System.EventHandler(this.button_cancel3_Click);
            // 
            // button_cancel4
            // 
            this.button_cancel4.Location = new System.Drawing.Point(32, 231);
            this.button_cancel4.Name = "button_cancel4";
            this.button_cancel4.Size = new System.Drawing.Size(392, 92);
            this.button_cancel4.TabIndex = 4;
            this.button_cancel4.Text = "等待两个线程-控制按钮状态写在包裹的线程里\r\n线程函数返回一个对象\r\n浏览器控件";
            this.button_cancel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cancel4.UseVisualStyleBackColor = true;
            this.button_cancel4.Click += new System.EventHandler(this.button_cancel4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 351);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(372, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "回调函数 与 事件";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage_channel);
            this.tabControl1.Controls.Add(this.tabPage_Login);
            this.tabControl1.Controls.Add(this.tabPage_SearchBiblio);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 609);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_Cancel1);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button_cancel2);
            this.tabPage2.Controls.Add(this.button_cancel4);
            this.tabPage2.Controls.Add(this.button_cancel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1024, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "通用练习题";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage_channel
            // 
            this.tabPage_channel.Controls.Add(this.button_viewChannel);
            this.tabPage_channel.Controls.Add(this.button_clearChannel);
            this.tabPage_channel.Controls.Add(this.button_returnChannel);
            this.tabPage_channel.Controls.Add(this.Channel_listView_channels);
            this.tabPage_channel.Controls.Add(this.button_getChannel);
            this.tabPage_channel.Controls.Add(this.Channel_textBox_userName);
            this.tabPage_channel.Controls.Add(this.Channel_textBox_url);
            this.tabPage_channel.Controls.Add(this.label2);
            this.tabPage_channel.Controls.Add(this.label1);
            this.tabPage_channel.Location = new System.Drawing.Point(4, 28);
            this.tabPage_channel.Name = "tabPage_channel";
            this.tabPage_channel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_channel.Size = new System.Drawing.Size(1024, 577);
            this.tabPage_channel.TabIndex = 0;
            this.tabPage_channel.Text = "通道";
            this.tabPage_channel.UseVisualStyleBackColor = true;
            // 
            // button_viewChannel
            // 
            this.button_viewChannel.Location = new System.Drawing.Point(664, 34);
            this.button_viewChannel.Name = "button_viewChannel";
            this.button_viewChannel.Size = new System.Drawing.Size(126, 34);
            this.button_viewChannel.TabIndex = 17;
            this.button_viewChannel.Text = "显示通道";
            this.button_viewChannel.UseVisualStyleBackColor = true;
            this.button_viewChannel.Click += new System.EventHandler(this.button_viewChannel_Click);
            // 
            // button_clearChannel
            // 
            this.button_clearChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_clearChannel.Location = new System.Drawing.Point(279, 501);
            this.button_clearChannel.Name = "button_clearChannel";
            this.button_clearChannel.Size = new System.Drawing.Size(184, 42);
            this.button_clearChannel.TabIndex = 16;
            this.button_clearChannel.Text = "clear channel";
            this.button_clearChannel.UseVisualStyleBackColor = true;
            this.button_clearChannel.Click += new System.EventHandler(this.button_clearChannel_Click);
            // 
            // button_returnChannel
            // 
            this.button_returnChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_returnChannel.Location = new System.Drawing.Point(51, 501);
            this.button_returnChannel.Name = "button_returnChannel";
            this.button_returnChannel.Size = new System.Drawing.Size(184, 42);
            this.button_returnChannel.TabIndex = 15;
            this.button_returnChannel.Text = "return channel";
            this.button_returnChannel.UseVisualStyleBackColor = true;
            this.button_returnChannel.Click += new System.EventHandler(this.button_returnChannel_Click);
            // 
            // Channel_listView_channels
            // 
            this.Channel_listView_channels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Channel_listView_channels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.columnHeader4});
            this.Channel_listView_channels.FullRowSelect = true;
            this.Channel_listView_channels.GridLines = true;
            this.Channel_listView_channels.HideSelection = false;
            this.Channel_listView_channels.Location = new System.Drawing.Point(22, 91);
            this.Channel_listView_channels.Name = "Channel_listView_channels";
            this.Channel_listView_channels.Size = new System.Drawing.Size(888, 377);
            this.Channel_listView_channels.TabIndex = 14;
            this.Channel_listView_channels.UseCompatibleStateImageBehavior = false;
            this.Channel_listView_channels.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "url";
            this.ColumnHeader1.Width = 144;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "userNme";
            this.ColumnHeader2.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "InUsing";
            this.columnHeader4.Width = 117;
            // 
            // button_getChannel
            // 
            this.button_getChannel.Location = new System.Drawing.Point(492, 34);
            this.button_getChannel.Name = "button_getChannel";
            this.button_getChannel.Size = new System.Drawing.Size(126, 34);
            this.button_getChannel.TabIndex = 13;
            this.button_getChannel.Text = "获取通道";
            this.button_getChannel.UseVisualStyleBackColor = true;
            this.button_getChannel.Click += new System.EventHandler(this.button_getChannel_Click);
            // 
            // Channel_textBox_userName
            // 
            this.Channel_textBox_userName.Location = new System.Drawing.Point(105, 40);
            this.Channel_textBox_userName.Name = "Channel_textBox_userName";
            this.Channel_textBox_userName.Size = new System.Drawing.Size(360, 28);
            this.Channel_textBox_userName.TabIndex = 12;
            // 
            // Channel_textBox_url
            // 
            this.Channel_textBox_url.Location = new System.Drawing.Point(105, 6);
            this.Channel_textBox_url.Name = "Channel_textBox_url";
            this.Channel_textBox_url.Size = new System.Drawing.Size(360, 28);
            this.Channel_textBox_url.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "userName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "url";
            // 
            // tabPage_Login
            // 
            this.tabPage_Login.Controls.Add(this.button_logout);
            this.tabPage_Login.Controls.Add(this.button_getVersior);
            this.tabPage_Login.Controls.Add(this.Login_textBox_result);
            this.tabPage_Login.Controls.Add(this.Login_textBox_password);
            this.tabPage_Login.Controls.Add(this.label3);
            this.tabPage_Login.Controls.Add(this.button_login);
            this.tabPage_Login.Controls.Add(this.Login_textBox_userName);
            this.tabPage_Login.Controls.Add(this.Login_textBox_url);
            this.tabPage_Login.Controls.Add(this.label_login_userName);
            this.tabPage_Login.Controls.Add(this.label4);
            this.tabPage_Login.Location = new System.Drawing.Point(4, 28);
            this.tabPage_Login.Name = "tabPage_Login";
            this.tabPage_Login.Size = new System.Drawing.Size(1024, 577);
            this.tabPage_Login.TabIndex = 2;
            this.tabPage_Login.Text = "Login";
            this.tabPage_Login.UseVisualStyleBackColor = true;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(646, 104);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(104, 39);
            this.button_logout.TabIndex = 22;
            this.button_logout.Tag = "";
            this.button_logout.Text = "登出";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_getVersior
            // 
            this.button_getVersior.Location = new System.Drawing.Point(522, 26);
            this.button_getVersior.Name = "button_getVersior";
            this.button_getVersior.Size = new System.Drawing.Size(135, 39);
            this.button_getVersior.TabIndex = 21;
            this.button_getVersior.Tag = "";
            this.button_getVersior.Text = "获取版本号";
            this.button_getVersior.UseVisualStyleBackColor = true;
            this.button_getVersior.Click += new System.EventHandler(this.button_getVersion_Click);
            // 
            // Login_textBox_result
            // 
            this.Login_textBox_result.Location = new System.Drawing.Point(23, 168);
            this.Login_textBox_result.Multiline = true;
            this.Login_textBox_result.Name = "Login_textBox_result";
            this.Login_textBox_result.ReadOnly = true;
            this.Login_textBox_result.Size = new System.Drawing.Size(629, 346);
            this.Login_textBox_result.TabIndex = 20;
            // 
            // Login_textBox_password
            // 
            this.Login_textBox_password.Location = new System.Drawing.Point(139, 115);
            this.Login_textBox_password.Name = "Login_textBox_password";
            this.Login_textBox_password.Size = new System.Drawing.Size(360, 28);
            this.Login_textBox_password.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 18;
            this.label3.Tag = "";
            this.label3.Text = "密码";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(522, 104);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(104, 39);
            this.button_login.TabIndex = 17;
            this.button_login.Tag = "";
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // Login_textBox_userName
            // 
            this.Login_textBox_userName.Location = new System.Drawing.Point(139, 67);
            this.Login_textBox_userName.Name = "Login_textBox_userName";
            this.Login_textBox_userName.Size = new System.Drawing.Size(360, 28);
            this.Login_textBox_userName.TabIndex = 16;
            // 
            // Login_textBox_url
            // 
            this.Login_textBox_url.Location = new System.Drawing.Point(139, 26);
            this.Login_textBox_url.Name = "Login_textBox_url";
            this.Login_textBox_url.Size = new System.Drawing.Size(360, 28);
            this.Login_textBox_url.TabIndex = 15;
            this.Login_textBox_url.Text = "http://dp2003.com/dp2library/demo/rest/";
            // 
            // label_login_userName
            // 
            this.label_login_userName.AutoSize = true;
            this.label_login_userName.Location = new System.Drawing.Point(71, 70);
            this.label_login_userName.Name = "label_login_userName";
            this.label_login_userName.Size = new System.Drawing.Size(62, 18);
            this.label_login_userName.TabIndex = 14;
            this.label_login_userName.Tag = "";
            this.label_login_userName.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "dp2服务器地址";
            // 
            // tabPage_SearchBiblio
            // 
            this.tabPage_SearchBiblio.Location = new System.Drawing.Point(4, 28);
            this.tabPage_SearchBiblio.Name = "tabPage_SearchBiblio";
            this.tabPage_SearchBiblio.Size = new System.Drawing.Size(1024, 577);
            this.tabPage_SearchBiblio.TabIndex = 3;
            this.tabPage_SearchBiblio.Text = "SearchBiblio";
            this.tabPage_SearchBiblio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "练习窗";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage_channel.ResumeLayout(false);
            this.tabPage_channel.PerformLayout();
            this.tabPage_Login.ResumeLayout(false);
            this.tabPage_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Cancel1;
        private System.Windows.Forms.Button button_cancel2;
        private System.Windows.Forms.Button button_cancel3;
        private System.Windows.Forms.Button button_cancel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_channel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_clearChannel;
        private System.Windows.Forms.Button button_returnChannel;
        private System.Windows.Forms.ListView Channel_listView_channels;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.Button button_getChannel;
        private System.Windows.Forms.TextBox Channel_textBox_userName;
        private System.Windows.Forms.TextBox Channel_textBox_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_viewChannel;
        private System.Windows.Forms.TabPage tabPage_Login;
        private System.Windows.Forms.Button button_getVersior;
        private System.Windows.Forms.TextBox Login_textBox_result;
        private System.Windows.Forms.TextBox Login_textBox_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox Login_textBox_userName;
        private System.Windows.Forms.TextBox Login_textBox_url;
        private System.Windows.Forms.Label label_login_userName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.TabPage tabPage_SearchBiblio;
    }
}

