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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_channel_clear = new System.Windows.Forms.Button();
            this.button_channel_return = new System.Windows.Forms.Button();
            this.listView_channel = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_channel_create = new System.Windows.Forms.Button();
            this.textBox_channel_userName = new System.Windows.Forms.TextBox();
            this.textBox_channel_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 609);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_channel_clear);
            this.tabPage1.Controls.Add(this.button_channel_return);
            this.tabPage1.Controls.Add(this.listView_channel);
            this.tabPage1.Controls.Add(this.button_channel_create);
            this.tabPage1.Controls.Add(this.textBox_channel_userName);
            this.tabPage1.Controls.Add(this.textBox_channel_url);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "通道";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // button_channel_clear
            // 
            this.button_channel_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_channel_clear.Location = new System.Drawing.Point(279, 501);
            this.button_channel_clear.Name = "button_channel_clear";
            this.button_channel_clear.Size = new System.Drawing.Size(184, 42);
            this.button_channel_clear.TabIndex = 16;
            this.button_channel_clear.Text = "clear channel";
            this.button_channel_clear.UseVisualStyleBackColor = true;
            // 
            // button_channel_return
            // 
            this.button_channel_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_channel_return.Location = new System.Drawing.Point(51, 501);
            this.button_channel_return.Name = "button_channel_return";
            this.button_channel_return.Size = new System.Drawing.Size(184, 42);
            this.button_channel_return.TabIndex = 15;
            this.button_channel_return.Text = "return channel";
            this.button_channel_return.UseVisualStyleBackColor = true;
            // 
            // listView_channel
            // 
            this.listView_channel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView_channel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.columnHeader3});
            this.listView_channel.FullRowSelect = true;
            this.listView_channel.GridLines = true;
            this.listView_channel.HideSelection = false;
            this.listView_channel.Location = new System.Drawing.Point(22, 91);
            this.listView_channel.Name = "listView_channel";
            this.listView_channel.Size = new System.Drawing.Size(596, 377);
            this.listView_channel.TabIndex = 14;
            this.listView_channel.UseCompatibleStateImageBehavior = false;
            this.listView_channel.View = System.Windows.Forms.View.Details;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "请求数";
            this.columnHeader3.Width = 83;
            // 
            // button_channel_create
            // 
            this.button_channel_create.Location = new System.Drawing.Point(492, 34);
            this.button_channel_create.Name = "button_channel_create";
            this.button_channel_create.Size = new System.Drawing.Size(126, 34);
            this.button_channel_create.TabIndex = 13;
            this.button_channel_create.Text = "创建通道";
            this.button_channel_create.UseVisualStyleBackColor = true;
            this.button_channel_create.Click += new System.EventHandler(this.button_channel_create_Click);
            // 
            // textBox_channel_userName
            // 
            this.textBox_channel_userName.Location = new System.Drawing.Point(105, 40);
            this.textBox_channel_userName.Name = "textBox_channel_userName";
            this.textBox_channel_userName.Size = new System.Drawing.Size(360, 28);
            this.textBox_channel_userName.TabIndex = 12;
            // 
            // textBox_channel_url
            // 
            this.textBox_channel_url.Location = new System.Drawing.Point(105, 6);
            this.textBox_channel_url.Name = "textBox_channel_url";
            this.textBox_channel_url.Size = new System.Drawing.Size(360, 28);
            this.textBox_channel_url.TabIndex = 11;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "练习窗";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Cancel1;
        private System.Windows.Forms.Button button_cancel2;
        private System.Windows.Forms.Button button_cancel3;
        private System.Windows.Forms.Button button_cancel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_channel_clear;
        private System.Windows.Forms.Button button_channel_return;
        private System.Windows.Forms.ListView listView_channel;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_channel_create;
        private System.Windows.Forms.TextBox textBox_channel_userName;
        private System.Windows.Forms.TextBox textBox_channel_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

