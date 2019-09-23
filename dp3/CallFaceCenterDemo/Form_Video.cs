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

namespace CallFaceCenterDemo
{
    public partial class Form_Video : Form
    {
        // 人脸中心 .NET Remoting URL
        static string facecenter_url = "ipc://FaceChannel/FaceServer";
        public Form_Video()
        {
            InitializeComponent();
        }

        private void button_startVideo_Click(object sender, EventArgs e)
        {
            BeginDisplayVideo();
        }

        private void button_stopVideo_Click(object sender, EventArgs e)
        {
            CancelDisplayVideo();
        }


        CancellationTokenSource _cancel = new CancellationTokenSource();

        Task _taskDisplayVideo = null;
        void BeginDisplayVideo()
        {
            CancelDisplayVideo();

            _cancel = new CancellationTokenSource();
            _taskDisplayVideo = Task.Run(() => {
                var result = FaceManager.DisplayVideo(facecenter_url, _cancel.Token,this.pictureBox1);
                if (_cancel != null && _cancel.IsCancellationRequested == false)
                    ShowMessageBox(result.ToString());
            });
        }



        void CancelDisplayVideo()
        {
            if (_cancel != null)
            {
                _cancel.Cancel();
                _cancel.Dispose();
                _cancel = null;
            }
        }

        // 显示结果
        void ShowMessageBox(string text)
        {
            //因为不一定是被界面线程调用，所以用invoke
            this.Invoke((Action)(() =>
            {
                MessageBox.Show(this, text);
            }));
        }

        private void Form_Video_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelDisplayVideo();
        }
    }
}
