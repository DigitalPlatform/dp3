using DigitalPlatform.RestClient;
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

        #region 通用练习题

        private void button_Cancel1_Click(object sender, EventArgs e)
        {
            Form_cancel1 dlg = new Form_cancel1();
            dlg.ShowDialog(this);
        }

        private void button_cancel2_Click(object sender, EventArgs e)
        {
            Form_cancel2 dlg = new Form_cancel2();
            dlg.ShowDialog(this);
        }

        private void button_cancel3_Click(object sender, EventArgs e)
        {
            Form_cancel3 dlg = new Form_cancel3();
            dlg.ShowDialog(this);
        }

        private void button_cancel4_Click(object sender, EventArgs e)
        {
            Form_cancel4 dlg = new Form_cancel4();
            dlg.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 dlg = new Form5();
            dlg.ShowDialog(this);
        }

        #endregion

        #region 通道测试

        // 通道池
        RestChannelPool _channelPool = new RestChannelPool();

        private void button_channel_create_Click(object sender, EventArgs e)
        {
            string url = this.textBox_channel_url.Text.Trim();
            string userName = this.textBox_channel_userName.Text.Trim();
            if (url == "" || userName == "")
            {
                MessageBox.Show(this, "url 和 userName不能为空");
                return;
            }
            this._channelPool.GetChannel(url, userName);
            this.ViewChannel();
        }

        void ViewChannel()
        {
            this.listView_channel.Items.Clear();

            foreach (ChannelWrapper wrapper in this._channelPool)
            {
                ListViewItem item = new ListViewItem(wrapper.Channel.Url);
                item.SubItems.Add(wrapper.Channel.UserName);
                this.listView_channel.Items.Add(item);
            }
        }

        #endregion

    }
}
