using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CancellationTokenSource _cancelTokenSource = new CancellationTokenSource();

        private void button_start_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                dothing(this._cancelTokenSource.Token);
            });
        }

        // 做事
        void dothing(CancellationToken token)
        {
            // 设置按置状态
            this.Invoke((Action)(() =>
                EnableControls(false)
                ));
            try
            {
                int i = 0;
                for (; ; )
                {
                    if (token.IsCancellationRequested)
                        break;

                    i++;

                    // 界面显示信息
                    this.Invoke((Action)(() =>
                            this.textBox_info.Text += this.textBox_info.Text + i.ToString() + "\r\n"
                            ));
                }
            }
            finally
            {
                // 设置按置状态
                this.Invoke((Action)(() =>
                    EnableControls(false)
                    ));
            }
        }

        // 设置控件是否可用
        void EnableControls(bool bEnable)
        {
            this.button_start.Enabled = bEnable;
            this.button_stop.Enabled = !(bEnable);

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            // 停止
            this._cancelTokenSource.Cancel();
        }


    }
}
