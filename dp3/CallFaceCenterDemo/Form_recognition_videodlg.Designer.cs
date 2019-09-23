namespace CallFaceCenterDemo
{
    partial class Form_recognition_videodlg
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
            this.button_faceRecognition1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_faceRecognition1
            // 
            this.button_faceRecognition1.Location = new System.Drawing.Point(111, 53);
            this.button_faceRecognition1.Name = "button_faceRecognition1";
            this.button_faceRecognition1.Size = new System.Drawing.Size(370, 45);
            this.button_faceRecognition1.TabIndex = 1;
            this.button_faceRecognition1.Text = "人脸识别(弹出视频窗口)";
            this.button_faceRecognition1.UseVisualStyleBackColor = true;
            this.button_faceRecognition1.Click += new System.EventHandler(this.button_faceRecognition1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 28);
            this.textBox1.TabIndex = 2;
            // 
            // Form_recognition_videodlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_faceRecognition1);
            this.Name = "Form_recognition_videodlg";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_recognition_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_faceRecognition1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

