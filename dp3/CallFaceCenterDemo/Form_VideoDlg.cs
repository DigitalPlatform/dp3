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
    public partial class Form_VideoDlg : Form
    {
        // 人脸中心 .NET Remoting URL
        static string facecenter_url = "ipc://FaceChannel/FaceServer";

        // 人脸识别任务对象
        Task _recognitionTask = null;

        // 用于停止图像显示
        CancellationTokenSource _cancel = new CancellationTokenSource();

        // 显示对象任务
        Task _taskDisplayVideo = null;

        public Form_VideoDlg()
        {
            InitializeComponent();
        }





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
            // 记得取消没有完成的人脸识别任务
            if (_recognitionTask != null)
            {
                FaceManager.CancelRecognition(facecenter_url);
            }
            CancelDisplayVideo();
        }

        public string PatfromBacode = "";

        private void Form_VideoDlg_Load(object sender, EventArgs e)
        {
            // 用单独任务进行人脸识别，这样可以不阻塞界面线程
            _recognitionTask = Task.Run(() =>
            {
                BeginDisplayVideo();
                try
                {
                    var result = FaceManager.Recognition(facecenter_url, "");

                    if (String.IsNullOrEmpty(result.ErrorCode) == true
                        && string.IsNullOrEmpty(result.Patron) == false)
                    {
                        this.PatfromBacode = result.Patron;

                        this.Invoke((Action)(() =>
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }));
                    }
                    else
                    {
                        ShowMessageBox(result.ToString());
                    }
                }
                finally
                {
                    _recognitionTask = null;

                    CancelDisplayVideo();
                }
            });
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
