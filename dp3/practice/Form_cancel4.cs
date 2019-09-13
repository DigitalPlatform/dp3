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
    public partial class Form_cancel4 : Form
    {
        public Form_cancel4()
        {
            InitializeComponent();
        }

        // 名字以用途命名即可。TokenSource 这种类型名称可以不出现在名字中
        CancellationTokenSource _cancel = new CancellationTokenSource();


        private async void button_start_Click(object sender, EventArgs e)
        {
            // 每次开头都重新 new 一个。这样避免受到上次遗留的 _cancel 对象的状态影响
            this._cancel.Dispose();
            this._cancel = new CancellationTokenSource();
            this.textBox_info.Text = "";


            // 第三种写法
            // 用 Task.Run() 调用一个平凡函数
            List<Item> items = await Task.Run(() =>
            {

                // 设置按钮状态
                this.Invoke((Action)(() =>
                    EnableControls(false)
                    ));
                try
                {
                    return RunTwo();
                }
                finally
                {
                    // 设置按钮状态
                    this.Invoke((Action)(() =>
                        EnableControls(true)
                        ));
                }

            });

            string info = "";
            foreach (Item item in items)
            {
                info += "线程"+items.IndexOf(item)+":count=["+item.count.ToString()+"],text=["+item.text+"]"+"\r\n";
            }
            this.Invoke((Action)(() =>
            {
                MessageBox.Show(this, info);
            }));


        }


        // 平凡的函数，要根据调主的意愿才能决定到底运行在什么线程
        List<Item> RunTwo()
        {
            Task<Item> t1 = Task.Run(() =>
            {
                return doSomething(this._cancel.Token, "*");
            });

            Task<Item> t2 = Task.Run(() =>
            {
                return doSomething(this._cancel.Token, "-");
            });

            Task.WaitAll(new Task[] { t1, t2 });

            List<Item> items = new List<Item>();
            items.Add(t1.Result);
            items.Add(t2.Result);

            return items;
        }

        // 做事，返回一个对象
        Item doSomething(CancellationToken token, string preprefix)
        {
            int i = 0;
            while (token.IsCancellationRequested == false)
            {
                // 没有这个语句，界面会冻结
                Thread.Sleep(100);

                /*
                // 中断也可以用
                token.ThrowIfCancellationRequested();
                */

                i++;

                // 界面显示信息
                this.Invoke((Action)(() =>
                {
                    this.textBox_info.Text = this.textBox_info.Text + preprefix + i.ToString() + "\r\n";

                    // 没起作用
                    // this.textBox_info.ScrollToCaret();
                }));
            }

            Item item = new Item
            {
                text = "合计"+i.ToString(),
                count = i
            };

            return item;
        }





        // 设置控件是否可用
        void EnableControls(bool bEnable)
        {
            this.button_start.Enabled = bEnable;
            this.button_stop1.Enabled = !(bEnable);
        }


        private void Form_cancel1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 窗口关闭前让循环退出
            this._cancel.Cancel();
            this._cancel.Dispose();
        }

        // 停止1按钮触发
        private void button_stop1_Click(object sender, EventArgs e)
        {
            // 停止
            this._cancel.Cancel();
        }
    }

    class Item
    {
        public string text { get; set; }
        public int count { get; set; }
    }
}
