using DigitalPlatform.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallFaceCenterDemo
{
    public partial class Form1 : Form
    {
        // 人脸中心 .NET Remoting URL
        static string facecenter_url = "ipc://FaceChannel/FaceServer";

        // 人脸识别任务对象
        Task _recognitionTask = null;

        public Form1()
        {
            InitializeComponent();
        }

        // 人脸识别，调facecenter窗口
        private void button_faceRecognition1_Click(object sender, EventArgs e)
        {
            // 用单独任务进行人脸识别，这样可以不阻塞界面线程
            _recognitionTask = Task.Run(() =>
            {
            var result = FaceManager.Recognition(facecenter_url, "");//  "ui");
                try
                {
                    ShowMessageBox(result.ToString());
                }
                finally
                {
                    _recognitionTask = null;
                }
            });
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


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
