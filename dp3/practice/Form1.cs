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
        // 通道池
        RestChannelPool _channelPool = new RestChannelPool();

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


        private void button_getVersion_Click(object sender, EventArgs e)
        {
            string url = this.Server_textBox_url.Text.Trim();
            RestChannel channel = this._channelPool.GetChannel(url, "");
            try
            {
                string version = "";
                string error = "";
                long lRet = channel.GetVersion(out version, out error);
                if (lRet == -1)
                {
                    this.textBox_result.Text = "获取版本出错：" + error;
                    return;
                }
                this.textBox_result.Text =version;
            }
            finally
            {
                this._channelPool.ReturnChannel(channel);
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string url = this.Server_textBox_url.Text.Trim();
            RestChannel channel = this._channelPool.GetChannel(url, "");
            try
            {
                string userName = this.Server_textBox_userName.Text.Trim();
                string password = this.Server_textBox_password.Text.Trim();
                if (userName == "")
                {
                    MessageBox.Show(this, "用户名不能为空");
                    return;
                }

                string parameters = "type=worker,client=resttest|0.01";
                LoginResponse response = channel.Login(userName, password, parameters);


                this.textBox_result.Text = "Result:" + response.LoginResult.ErrorCode + response.LoginResult.ErrorInfo
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
            string url = this.Server_textBox_url.Text.Trim();
            RestChannel channel = this._channelPool.GetChannel(url, "");
            try
            {
               LogoutResponse response = channel.Logout();// (userName, password, parameters);


                this.textBox_result.Text = "Result:" + response.LogoutResult.ErrorCode + response.LogoutResult.ErrorInfo;
            }
            finally
            {
                this._channelPool.ReturnChannel(channel);
            }
        }



    }
}
