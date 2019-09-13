namespace dp2analysis
{
    partial class Form_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dp2服务器配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_borrowreturn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(682, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dp2服务器配置ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "帮助";
            // 
            // dp2服务器配置ToolStripMenuItem
            // 
            this.dp2服务器配置ToolStripMenuItem.Name = "dp2服务器配置ToolStripMenuItem";
            this.dp2服务器配置ToolStripMenuItem.Size = new System.Drawing.Size(217, 30);
            this.dp2服务器配置ToolStripMenuItem.Text = "dp2服务器配置";
            this.dp2服务器配置ToolStripMenuItem.Click += new System.EventHandler(this.dp2服务器配置ToolStripMenuItem_Click);
            // 
            // button_borrowreturn
            // 
            this.button_borrowreturn.Location = new System.Drawing.Point(408, 87);
            this.button_borrowreturn.Name = "button_borrowreturn";
            this.button_borrowreturn.Size = new System.Drawing.Size(131, 44);
            this.button_borrowreturn.TabIndex = 1;
            this.button_borrowreturn.Text = "连续借书还书";
            this.button_borrowreturn.UseVisualStyleBackColor = true;
            this.button_borrowreturn.Click += new System.EventHandler(this.button_borrowreturn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 201);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(647, 300);
            this.textBox1.TabIndex = 2;
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(408, 137);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(131, 40);
            this.button_stop.TabIndex = 3;
            this.button_stop.Text = "停止";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 90);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(376, 87);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "R0000001/0000001\r\nR0000002/0000002";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "输入连续借还的证条码号与册条码号\r\n(格式：证条码号/册条码号,每组一行）";
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_borrowreturn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dp2服务器配置ToolStripMenuItem;
        private System.Windows.Forms.Button button_borrowreturn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}

