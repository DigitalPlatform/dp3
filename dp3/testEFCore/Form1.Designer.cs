namespace testEFCore
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
            this.button_getCat = new System.Windows.Forms.Button();
            this.button_addCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_getCat
            // 
            this.button_getCat.Location = new System.Drawing.Point(238, 52);
            this.button_getCat.Name = "button_getCat";
            this.button_getCat.Size = new System.Drawing.Size(159, 55);
            this.button_getCat.TabIndex = 3;
            this.button_getCat.Text = "GetCat";
            this.button_getCat.UseVisualStyleBackColor = true;
            this.button_getCat.Click += new System.EventHandler(this.button_getCat_Click);
            // 
            // button_addCat
            // 
            this.button_addCat.Location = new System.Drawing.Point(61, 53);
            this.button_addCat.Name = "button_addCat";
            this.button_addCat.Size = new System.Drawing.Size(138, 52);
            this.button_addCat.TabIndex = 2;
            this.button_addCat.Text = "AddCat";
            this.button_addCat.UseVisualStyleBackColor = true;
            this.button_addCat.Click += new System.EventHandler(this.button_addCat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_getCat);
            this.Controls.Add(this.button_addCat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_getCat;
        private System.Windows.Forms.Button button_addCat;
    }
}

