﻿namespace practice
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
            this.SuspendLayout();
            // 
            // button_Cancel1
            // 
            this.button_Cancel1.Location = new System.Drawing.Point(12, 44);
            this.button_Cancel1.Name = "button_Cancel1";
            this.button_Cancel1.Size = new System.Drawing.Size(372, 36);
            this.button_Cancel1.TabIndex = 1;
            this.button_Cancel1.Text = "1个CancellationToken停止1个线程";
            this.button_Cancel1.UseVisualStyleBackColor = true;
            this.button_Cancel1.Click += new System.EventHandler(this.button_Cancel1_Click);
            // 
            // button_cancel2
            // 
            this.button_cancel2.Location = new System.Drawing.Point(12, 105);
            this.button_cancel2.Name = "button_cancel2";
            this.button_cancel2.Size = new System.Drawing.Size(372, 50);
            this.button_cancel2.TabIndex = 2;
            this.button_cancel2.Text = "多个CancellationToken停止1个线程";
            this.button_cancel2.UseVisualStyleBackColor = true;
            this.button_cancel2.Click += new System.EventHandler(this.button_cancel2_Click);
            // 
            // button_cancel3
            // 
            this.button_cancel3.Location = new System.Drawing.Point(12, 178);
            this.button_cancel3.Name = "button_cancel3";
            this.button_cancel3.Size = new System.Drawing.Size(372, 42);
            this.button_cancel3.TabIndex = 3;
            this.button_cancel3.Text = "等待两个线程";
            this.button_cancel3.UseVisualStyleBackColor = true;
            this.button_cancel3.Click += new System.EventHandler(this.button_cancel3_Click);
            // 
            // button_cancel4
            // 
            this.button_cancel4.Location = new System.Drawing.Point(12, 241);
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
            this.button5.Location = new System.Drawing.Point(12, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(372, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = "回调函数 与 事件";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 486);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_cancel4);
            this.Controls.Add(this.button_cancel3);
            this.Controls.Add(this.button_cancel2);
            this.Controls.Add(this.button_Cancel1);
            this.Name = "Form1";
            this.Text = "练习窗";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Cancel1;
        private System.Windows.Forms.Button button_cancel2;
        private System.Windows.Forms.Button button_cancel3;
        private System.Windows.Forms.Button button_cancel4;
        private System.Windows.Forms.Button button5;
    }
}

