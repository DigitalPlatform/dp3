using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DigitalPlatform.RestClient;

namespace dp2RestDemo
{
    public partial class Form1 : Form
    {

        // 通道池
        RestChannelPool _channelPool = new RestChannelPool();


        public Form1()
        {
            InitializeComponent();
        }

        private void button_channel_create_Click(object sender, EventArgs e)
        {
            string url = this.textBox_channel_url.Text.Trim();
            string userName = this.textBox_channel_userName.Text.Trim();
            if (url == "" || userName == "")
            {
                MessageBox.Show(this, "url 和 userName不能为空");
                return;
            }
            this._channelPool.GetChannel(url,userName);
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

        private void button_channel_return_Click(object sender, EventArgs e)
        {

        }

        private void button_channel_clear_Click(object sender, EventArgs e)
        {

        }

        private void listView_channel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_channel_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_channel_url_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
