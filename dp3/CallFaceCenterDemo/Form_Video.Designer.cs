namespace CallFaceCenterDemo
{
    partial class Form_Video
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_stopVideo = new System.Windows.Forms.Button();
            this.button_startVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button_stopVideo
            // 
            this.button_stopVideo.Location = new System.Drawing.Point(493, 82);
            this.button_stopVideo.Name = "button_stopVideo";
            this.button_stopVideo.Size = new System.Drawing.Size(144, 48);
            this.button_stopVideo.TabIndex = 9;
            this.button_stopVideo.Text = "关闭视频";
            this.button_stopVideo.UseVisualStyleBackColor = true;
            this.button_stopVideo.Click += new System.EventHandler(this.button_stopVideo_Click);
            // 
            // button_startVideo
            // 
            this.button_startVideo.Location = new System.Drawing.Point(493, 12);
            this.button_startVideo.Name = "button_startVideo";
            this.button_startVideo.Size = new System.Drawing.Size(144, 48);
            this.button_startVideo.TabIndex = 8;
            this.button_startVideo.Text = "开启视频";
            this.button_startVideo.UseVisualStyleBackColor = true;
            this.button_startVideo.Click += new System.EventHandler(this.button_startVideo_Click);
            // 
            // Form_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 418);
            this.Controls.Add(this.button_stopVideo);
            this.Controls.Add(this.button_startVideo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form_Video";
            this.Text = "Form_Video";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Video_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_stopVideo;
        private System.Windows.Forms.Button button_startVideo;
    }
}