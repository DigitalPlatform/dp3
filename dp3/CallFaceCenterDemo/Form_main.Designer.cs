namespace CallFaceCenterDemo
{
    partial class Form_main
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
            this.button_faceRecognition2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人脸识别接口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.识别弹出图像窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_faceRecognition2
            // 
            this.button_faceRecognition2.Location = new System.Drawing.Point(155, 27);
            this.button_faceRecognition2.Name = "button_faceRecognition2";
            this.button_faceRecognition2.Size = new System.Drawing.Size(406, 43);
            this.button_faceRecognition2.TabIndex = 5;
            this.button_faceRecognition2.Text = "开始人脸识别";
            this.button_faceRecognition2.UseVisualStyleBackColor = true;
            this.button_faceRecognition2.Click += new System.EventHandler(this.button_faceRecognition2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(30, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_result
            // 
            this.textBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox_result.Location = new System.Drawing.Point(30, 480);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_result.Size = new System.Drawing.Size(681, 70);
            this.textBox_result.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(747, 32);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人脸识别接口ToolStripMenuItem,
            this.显示图像ToolStripMenuItem,
            this.识别弹出图像窗口ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 人脸识别接口ToolStripMenuItem
            // 
            this.人脸识别接口ToolStripMenuItem.Name = "人脸识别接口ToolStripMenuItem";
            this.人脸识别接口ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.人脸识别接口ToolStripMenuItem.Text = "人脸识别接口";
            this.人脸识别接口ToolStripMenuItem.Click += new System.EventHandler(this.人脸识别接口ToolStripMenuItem_Click);
            // 
            // 显示图像ToolStripMenuItem
            // 
            this.显示图像ToolStripMenuItem.Name = "显示图像ToolStripMenuItem";
            this.显示图像ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.显示图像ToolStripMenuItem.Text = "显示图像";
            this.显示图像ToolStripMenuItem.Click += new System.EventHandler(this.显示图像ToolStripMenuItem_Click);
            // 
            // 识别弹出图像窗口ToolStripMenuItem
            // 
            this.识别弹出图像窗口ToolStripMenuItem.Name = "识别弹出图像窗口ToolStripMenuItem";
            this.识别弹出图像窗口ToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.识别弹出图像窗口ToolStripMenuItem.Text = "识别弹出图像窗口";
            this.识别弹出图像窗口ToolStripMenuItem.Click += new System.EventHandler(this.识别弹出图像窗口ToolStripMenuItem_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 558);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_faceRecognition2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_main";
            this.Text = "Form_main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_faceRecognition2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人脸识别接口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示图像ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 识别弹出图像窗口ToolStripMenuItem;
    }
}