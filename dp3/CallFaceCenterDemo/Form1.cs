﻿using DigitalPlatform.Interfaces;
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
                var result = Recognition(facecenter_url, "ui");
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


        // 人脸识别 API
        RecognitionFaceResult Recognition(string url, string style)
        {
            // 先创建与facecente连接的通道
            FaceChannel channel = StartFaceChannel( url,
                out string strError);
            if (channel == null)
            {
                return new RecognitionFaceResult
                {
                    Value = -1,
                    ErrorInfo = strError
                };
            }

            try
            {
                // 调facecenter的识别接口
                return channel.Object.RecognitionFace(style);
            }
            catch (Exception ex)
            {
                strError = $"针对 {url} 的 RecongitionFace() 操作失败: { ex.Message}";
                return new RecognitionFaceResult
                {
                    Value = -1,
                    ErrorInfo = strError
                };
            }
            finally
            {
                EndFaceChannel(channel);
            }
        }


        // strUrl:人脸中心url
        public FaceChannel StartFaceChannel(string strUrl,
            out string strError)
        {
            strError = "";

            FaceChannel result = new FaceChannel();
            result.Channel = new IpcClientChannel(Guid.NewGuid().ToString(), // 随机的名字，令多个 Channel 对象可以并存 
                    new BinaryClientFormatterSinkProvider());


            ChannelServices.RegisterChannel(result.Channel, true);
            bool bDone = false;
            try
            {
                result.Object = (IBioRecognition)Activator.GetObject(typeof(IBioRecognition),
                    strUrl);
                if (result.Object == null)
                {
                    strError = "无法连接到服务器 " + strUrl;
                    return null;
                }
                bDone = true;
                return result;
            }
            finally
            {
                if (bDone == false)
                    EndFaceChannel(result);
            }
        }

        // 结束通道连接
        public void EndFaceChannel(FaceChannel channel)
        {
            if (channel != null && channel.Channel != null)
            {
                ChannelServices.UnregisterChannel(channel.Channel);
                channel.Channel = null;
            }
        }
    }

    public class FaceChannel
    {
        public IpcClientChannel Channel { get; set; }
        public IBioRecognition Object { get; set; }
    }
}
