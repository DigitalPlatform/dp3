namespace dp2RestDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_login = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_verify = new System.Windows.Forms.Button();
            this.textBox_dp2password = new System.Windows.Forms.TextBox();
            this.textBox_dp2username = new System.Windows.Forms.TextBox();
            this.textBox_dp2serverUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_login.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_login);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_login
            // 
            this.tabPage_login.Controls.Add(this.groupBox4);
            this.tabPage_login.Location = new System.Drawing.Point(4, 28);
            this.tabPage_login.Name = "tabPage_login";
            this.tabPage_login.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_login.Size = new System.Drawing.Size(820, 489);
            this.tabPage_login.TabIndex = 1;
            this.tabPage_login.Text = "login";
            this.tabPage_login.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button_verify);
            this.groupBox4.Controls.Add(this.textBox_dp2password);
            this.groupBox4.Controls.Add(this.textBox_dp2username);
            this.groupBox4.Controls.Add(this.textBox_dp2serverUrl);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(57, 209);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(671, 209);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "图书馆应用服务器配置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(485, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "(注意填rest协议地址,\r\n且把开头的rest.去掉)";
            // 
            // button_verify
            // 
            this.button_verify.Location = new System.Drawing.Point(134, 154);
            this.button_verify.Margin = new System.Windows.Forms.Padding(2);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(101, 34);
            this.button_verify.TabIndex = 6;
            this.button_verify.Text = "登录";
            this.button_verify.UseVisualStyleBackColor = true;
            // 
            // textBox_dp2password
            // 
            this.textBox_dp2password.Location = new System.Drawing.Point(134, 112);
            this.textBox_dp2password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dp2password.Name = "textBox_dp2password";
            this.textBox_dp2password.PasswordChar = '*';
            this.textBox_dp2password.Size = new System.Drawing.Size(224, 28);
            this.textBox_dp2password.TabIndex = 5;
            // 
            // textBox_dp2username
            // 
            this.textBox_dp2username.Location = new System.Drawing.Point(134, 72);
            this.textBox_dp2username.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dp2username.Name = "textBox_dp2username";
            this.textBox_dp2username.Size = new System.Drawing.Size(224, 28);
            this.textBox_dp2username.TabIndex = 4;
            // 
            // textBox_dp2serverUrl
            // 
            this.textBox_dp2serverUrl.Location = new System.Drawing.Point(134, 32);
            this.textBox_dp2serverUrl.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dp2serverUrl.Name = "textBox_dp2serverUrl";
            this.textBox_dp2serverUrl.Size = new System.Drawing.Size(343, 28);
            this.textBox_dp2serverUrl.TabIndex = 3;
            this.textBox_dp2serverUrl.TextChanged += new System.EventHandler(this.textBox_dp2serverUrl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "密  码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器地址：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 521);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_login.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_login;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_verify;
        private System.Windows.Forms.TextBox textBox_dp2password;
        private System.Windows.Forms.TextBox textBox_dp2username;
        private System.Windows.Forms.TextBox textBox_dp2serverUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

