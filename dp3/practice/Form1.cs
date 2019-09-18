using DigitalPlatform.RestClient;
using System;
using System.Collections;
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


        private void button_channel_get_Click(object sender, EventArgs e)
        {

        }

        Hashtable _table = new Hashtable();

        private void button_getChannel_Click(object sender, EventArgs e)
        {
            string url = this.Channel_textBox_url.Text.Trim();
            string userName = this.Channel_textBox_userName.Text.Trim();
            if (url == "" || userName == "")
            {
                MessageBox.Show(this, "url 和 userName不能为空");
                return;
            }

            RestChannel channel = this._channelPool.GetChannel(url, userName);

            this.ViewChannel();
        }
        void ViewChannel()
        {
            this.Channel_listView_channels.Items.Clear();
            _table.Clear();

            foreach (ChannelWrapper wrapper in this._channelPool)
            {
                ListViewItem item = new ListViewItem(wrapper.Channel.Url);
                item.SubItems.Add(wrapper.Channel.UserName);
                item.SubItems.Add(wrapper.InUsing.ToString());


                this.Channel_listView_channels.Items.Add(item);


                _table[item] = wrapper.Channel;
            }
        }

        private void button_returnChannel_Click(object sender, EventArgs e)
        {
            if (this.Channel_listView_channels.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "尚未选择要return的行");
                return;
            }

            ListViewItem item = this.Channel_listView_channels.SelectedItems[0];

            this._channelPool.ReturnChannel((RestChannel)this._table[item]);

            this.ViewChannel();
        }

        private void button_clearChannel_Click(object sender, EventArgs e)
        {
            this._channelPool.Clear();
            this.ViewChannel();
        }


        private void button_viewChannel_Click(object sender, EventArgs e)
        {
            this.ViewChannel();
        }

        #endregion


        private void button_getVersion_Click(object sender, EventArgs e)
        {
            string url = this.Login_textBox_url.Text.Trim();
            RestChannel channel = this._channelPool.GetChannel(url, "");
            try
            {
                string version = "";
                string error = "";
                long lRet = channel.GetVersion(out version, out error);
                if (lRet == -1)
                {
                    this.Login_textBox_result.Text = "获取版本出错：" + error;
                    return;
                }

                this.Login_textBox_result.Text =version;
            }
            finally
            {
                this._channelPool.ReturnChannel(channel);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string url = this.Login_textBox_url.Text.Trim();
            RestChannel channel = this._channelPool.GetChannel(url, "");
            try
            {
                string userName = this.Login_textBox_userName.Text.Trim();
                string password = this.Login_textBox_password.Text.Trim();
                if (userName == "" || password == "")
                {
                    MessageBox.Show(this, "用户名或密码不能为空");
                    return;
                }

                string parameters = "type=worker,client=resttest|0.01";
                LoginResponse response = channel.Login(userName, password, parameters);


                this.Login_textBox_result.Text = "Result:" + response.LoginResult.ErrorCode + response.LoginResult.ErrorInfo
                + "\r\n Rights:" + response.strRights
                + "\r\n UserName:" + response.strOutputUserName;
                        }
            finally
            {
                this._channelPool.ReturnChannel(channel);
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            string url = this.Login_textBox_url.Text.Trim();
            RestChannel channel = this._channelPool.GetChannel(url, "");
            try
            {
               LogoutResponse response = channel.Logout();// (userName, password, parameters);


                this.Login_textBox_result.Text = "Result:" + response.LogoutResult.ErrorCode + response.LogoutResult.ErrorInfo;
            }
            finally
            {
                this._channelPool.ReturnChannel(channel);
            }
        }




    }
}
