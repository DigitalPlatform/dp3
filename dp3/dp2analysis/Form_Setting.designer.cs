namespace dp2analysis
{
    partial class Form_Setting
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_verify = new System.Windows.Forms.Button();
            this.textBox_dp2password = new System.Windows.Forms.TextBox();
            this.textBox_dp2username = new System.Windows.Forms.TextBox();
            this.textBox_dp2serverUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox4.Location = new System.Drawing.Point(9, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(671, 209);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "图书馆应用服务器配置";
            // 
            // button_verify
            // 
            this.button_verify.Location = new System.Drawing.Point(134, 154);
            this.button_verify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_verify.Name = "button_verify";
            this.button_verify.Size = new System.Drawing.Size(101, 34);
            this.button_verify.TabIndex = 6;
            this.button_verify.Text = "检测";
            this.button_verify.UseVisualStyleBackColor = true;
            this.button_verify.Click += new System.EventHandler(this.button_verify_Click);
            // 
            // textBox_dp2password
            // 
            this.textBox_dp2password.Location = new System.Drawing.Point(134, 112);
            this.textBox_dp2password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_dp2password.Name = "textBox_dp2password";
            this.textBox_dp2password.PasswordChar = '*';
            this.textBox_dp2password.Size = new System.Drawing.Size(224, 28);
            this.textBox_dp2password.TabIndex = 5;
            // 
            // textBox_dp2username
            // 
            this.textBox_dp2username.Location = new System.Drawing.Point(134, 72);
            this.textBox_dp2username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_dp2username.Name = "textBox_dp2username";
            this.textBox_dp2username.Size = new System.Drawing.Size(224, 28);
            this.textBox_dp2username.TabIndex = 4;
            // 
            // textBox_dp2serverUrl
            // 
            this.textBox_dp2serverUrl.Location = new System.Drawing.Point(134, 32);
            this.textBox_dp2serverUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_dp2serverUrl.Name = "textBox_dp2serverUrl";
            this.textBox_dp2serverUrl.Size = new System.Drawing.Size(343, 28);
            this.textBox_dp2serverUrl.TabIndex = 3;
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
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_cancel.Location = new System.Drawing.Point(362, 239);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(124, 40);
            this.button_cancel.TabIndex = 24;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_ok.Location = new System.Drawing.Point(229, 239);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(124, 40);
            this.button_ok.TabIndex = 23;
            this.button_ok.Text = "确定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
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
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 308);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.groupBox4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Setting";
            this.Text = "dp2服务器参数配置";
            this.Load += new System.EventHandler(this.Form_CreateTestEnv_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_dp2password;
        private System.Windows.Forms.TextBox textBox_dp2username;
        private System.Windows.Forms.TextBox textBox_dp2serverUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_verify;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label4;
    }
}