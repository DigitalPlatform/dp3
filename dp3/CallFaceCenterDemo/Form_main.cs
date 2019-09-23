using DigitalPlatform.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;// 人脸识别任务对象


namespace CallFaceCenterDemo
{
    public partial class Form_main : Form
    {
        // 人脸中心 .NET Remoting URL
        static string facecenter_url = "ipc://FaceChannel/FaceServer";

        Task _recognitionTask = null;

        // 用于停止图像显示
        CancellationTokenSource _cancel = new CancellationTokenSource();

        // 显示对象任务
        Task _taskDisplayVideo = null; 

        public Form_main()
        {
            InitializeComponent();
        }

        private void button_faceRecognition2_Click(object sender, EventArgs e)
        {
            // 用单独任务进行人脸识别，这样可以不阻塞界面线程
            _recognitionTask = Task.Run(() =>
            {
                BeginDisplayVideo();
                try
                {
                    var result = FaceManager.Recognition(facecenter_url, "");

                    string text = "";
                    if (String.IsNullOrEmpty(result.ErrorCode) == true 
                        && string.IsNullOrEmpty(result.Patron)==false)
                    {
                        text = "识别成功！读者证条码号为" + result.Patron;
                    }
                    else
                    {
                        text = "出错:" + result.ErrorInfo;
                    }
                    ShowMessage(text);
                    
                }
                finally
                {
                    _recognitionTask = null;

                    CancelDisplayVideo();
                }
            });
        }

        // 开始显示图像
        void BeginDisplayVideo()
        {
            CancelDisplayVideo();

            _cancel = new CancellationTokenSource();
            _taskDisplayVideo = Task.Run(() => {
                var result = FaceManager.DisplayVideo(facecenter_url, _cancel.Token,this.pictureBox1);
                if (_cancel != null && _cancel.IsCancellationRequested == false)
                {
                    ShowMessageBox(result.ToString());
                }
            });
        }

        // 结束显示图像
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
        void ShowMessage(string text)
        {
            //因为不一定是被界面线程调用，所以用invoke
            this.Invoke((Action)(() =>
            {
                this.textBox_result.Text = text;
            }));
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

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 记得取消没有完成的人脸识别任务
            if (_recognitionTask != null)
            {
                FaceManager.CancelRecognition(facecenter_url);
            }

            CancelDisplayVideo();
        }

        private void 人脸识别接口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_recognition dlg = new Form_recognition();
            dlg.ShowDialog(this);
        }

        private void 显示图像ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Video dlg = new Form_Video();
            dlg.ShowDialog(this);
        }

        private void 识别弹出图像窗口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_recognition_videodlg dlg = new Form_recognition_videodlg();
            dlg.ShowDialog(this);
        }
    }
}
