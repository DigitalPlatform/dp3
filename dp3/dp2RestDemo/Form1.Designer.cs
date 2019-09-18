namespace dp2RestDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_channel = new System.Windows.Forms.TabPage();
            this.tabPage_login = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_channel_url = new System.Windows.Forms.TextBox();
            this.textBox_channel_userName = new System.Windows.Forms.TextBox();
            this.button_channel_create = new System.Windows.Forms.Button();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_channel = new System.Windows.Forms.ListView();
            this.button_channel_return = new System.Windows.Forms.Button();
            this.button_channel_clear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_channel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_channel);
            this.tabControl1.Controls.Add(this.tabPage_login);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1112, 659);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_channel
            // 
            this.tabPage_channel.Controls.Add(this.button_channel_clear);
            this.tabPage_channel.Controls.Add(this.button_channel_return);
            this.tabPage_channel.Controls.Add(this.listView_channel);
            this.tabPage_channel.Controls.Add(this.button_channel_create);
            this.tabPage_channel.Controls.Add(this.textBox_channel_userName);
            this.tabPage_channel.Controls.Add(this.textBox_channel_url);
            this.tabPage_channel.Controls.Add(this.label2);
            this.tabPage_channel.Controls.Add(this.label1);
            this.tabPage_channel.Location = new System.Drawing.Point(4, 28);
            this.tabPage_channel.Name = "tabPage_channel";
            this.tabPage_channel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_channel.Size = new System.Drawing.Size(1104, 627);
            this.tabPage_channel.TabIndex = 0;
            this.tabPage_channel.Text = "测试通道";
            this.tabPage_channel.UseVisualStyleBackColor = true;
            // 
            // tabPage_login
            // 
            this.tabPage_login.Location = new System.Drawing.Point(4, 28);
            this.tabPage_login.Name = "tabPage_login";
            this.tabPage_login.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_login.Size = new System.Drawing.Size(1104, 627);
            this.tabPage_login.TabIndex = 1;
            this.tabPage_login.Text = "login";
            this.tabPage_login.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "url";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "userName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_channel_url
            // 
            this.textBox_channel_url.Location = new System.Drawing.Point(98, 22);
            this.textBox_channel_url.Name = "textBox_channel_url";
            this.textBox_channel_url.Size = new System.Drawing.Size(360, 28);
            this.textBox_channel_url.TabIndex = 2;
            this.textBox_channel_url.TextChanged += new System.EventHandler(this.textBox_channel_url_TextChanged);
            // 
            // textBox_channel_userName
            // 
            this.textBox_channel_userName.Location = new System.Drawing.Point(98, 56);
            this.textBox_channel_userName.Name = "textBox_channel_userName";
            this.textBox_channel_userName.Size = new System.Drawing.Size(360, 28);
            this.textBox_channel_userName.TabIndex = 3;
            this.textBox_channel_userName.TextChanged += new System.EventHandler(this.textBox_channel_userName_TextChanged);
            // 
            // button_channel_create
            // 
            this.button_channel_create.Location = new System.Drawing.Point(485, 50);
            this.button_channel_create.Name = "button_channel_create";
            this.button_channel_create.Size = new System.Drawing.Size(126, 34);
            this.button_channel_create.TabIndex = 4;
            this.button_channel_create.Text = "创建通道";
            this.button_channel_create.UseVisualStyleBackColor = true;
            this.button_channel_create.Click += new System.EventHandler(this.button_channel_create_Click);
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
            this.listView_channel.Location = new System.Drawing.Point(15, 107);
            this.listView_channel.Name = "listView_channel";
            this.listView_channel.Size = new System.Drawing.Size(596, 377);
            this.listView_channel.TabIndex = 6;
            this.listView_channel.UseCompatibleStateImageBehavior = false;
            this.listView_channel.View = System.Windows.Forms.View.Details;
            this.listView_channel.SelectedIndexChanged += new System.EventHandler(this.listView_channel_SelectedIndexChanged);
            // 
            // button_channel_return
            // 
            this.button_channel_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_channel_return.Location = new System.Drawing.Point(39, 541);
            this.button_channel_return.Name = "button_channel_return";
            this.button_channel_return.Size = new System.Drawing.Size(184, 42);
            this.button_channel_return.TabIndex = 7;
            this.button_channel_return.Text = "return channel";
            this.button_channel_return.UseVisualStyleBackColor = true;
            this.button_channel_return.Click += new System.EventHandler(this.button_channel_return_Click);
            // 
            // button_channel_clear
            // 
            this.button_channel_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_channel_clear.Location = new System.Drawing.Point(267, 541);
            this.button_channel_clear.Name = "button_channel_clear";
            this.button_channel_clear.Size = new System.Drawing.Size(184, 42);
            this.button_channel_clear.TabIndex = 8;
            this.button_channel_clear.Text = "clear channel";
            this.button_channel_clear.UseVisualStyleBackColor = true;
            this.button_channel_clear.Click += new System.EventHandler(this.button_channel_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 659);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_channel.ResumeLayout(false);
            this.tabPage_channel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_channel;
        private System.Windows.Forms.TabPage tabPage_login;
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