using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Threading;

namespace FaceCenterDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CancellationTokenSource _cancelRefresh = new CancellationTokenSource();


        bool _stopVideo = false;
        Patron _patron = new Patron();

        private void Form1_Load(object sender, EventArgs e)
        {
            FaceManager.Base.Name = "人脸中心";
            FaceManager.Url = "ipc://FaceChannel/FaceServer";// "ipc://FaceChannel/FaceServer";//App.FaceUrl;
           // FaceManager.SetError += FaceManager_SetError;
           // FaceManager.Start(_cancelRefresh.Token);
        }

        private void FaceManager_SetError(object sender, SetErrorEventArgs e)
        {
            //SetError("face", e.Error);
            Invoke(new Action(() =>
            {
                this.label1.Text = e.Error;
            
            }));
        }

        private async void button_recognition_Click(object sender, EventArgs e)
        {
            RecognitionFaceResult result = null;

            VideoWindow videoRecognition = null;
             Invoke(new Action(() =>
            {
                videoRecognition = new VideoWindow
                {
                    Text = "识别人脸 ...",
                    //Owner = Application.Current.MainWindow,
                    StartPosition = FormStartPosition.CenterScreen,
                    //WindowStartupLocation = WindowStartupLocation.CenterOwner
                };
                videoRecognition.Closed += VideoRecognition_Closed;
                videoRecognition.Show();
            }));

            _stopVideo = false;
            //var task = Task.Run(() =>
            //{
                DisplayVideo(videoRecognition);
            //});

            /*
            try
            {
                result = await RecognitionFace("");
                if (result.Value == -1)
                {
                    if (result.ErrorCode != "cancelled")
                        SetGlobalError("face", result.ErrorInfo);

                    DisplayError(ref videoRecognition, result.ErrorInfo);
                    return;
                }

                SetGlobalError("face", null);
            }
            finally
            {
                if (videoRecognition != null)
                    Invoke(new Action(() =>
                    {
                        videoRecognition.Close();
                    }));
            }
             */
            //GetMessageResult message = new GetMessageResult
            //{
            //    Value = 1,
            //    Message = result.Patron,
            //};
            //SetPatronInfo(message);
            //SetQuality("");
            //await FillPatronDetail();
           
        }

        async Task<RecognitionFaceResult> RecognitionFace(string style)
        {
            EnableControls(false);
            try
            {
                return await Task.Run<RecognitionFaceResult>(() =>
                {
                    // 2019/9/6 增加
                    var result = FaceManager.GetState("camera");
                    if (result.Value == -1)
                        return new RecognitionFaceResult
                        {
                            Value = -1,
                            ErrorInfo = result.ErrorInfo,
                            ErrorCode = result.ErrorCode
                        };
                    return FaceManager.RecognitionFace("");
                });
            }
            finally
            {
                EnableControls(true);
            }
        }

        void DisplayVideo(VideoWindow window)
        {
            //while (_stopVideo == false)
            //{
                var result = FaceManager.GetImage("");
                if (result.ImageData == null)
                {
                    Thread.Sleep(500);
                return;
                }
                MemoryStream stream = new MemoryStream(result.ImageData);
                try
                {
                    //Invoke(new Action(() =>
                    //{
                        window.SetPhoto(stream);
                    //}));
                    //stream = null;
                }
                finally
                {
                    if (stream != null)
                        stream.Close();
                }
            //}
        }

        private void VideoRecognition_Closed(object sender, EventArgs e)
        {
            FaceManager.CancelRecognitionFace();
            _stopVideo = true;
            //RemoveLayer();
        }

        // 从指纹阅读器获取消息(第一阶段)
        void SetPatronInfo(GetMessageResult result)
        {


            if (result.Value == -1)
            {
                //SetPatronError("fingerprint", $"指纹中心出错: {result.ErrorInfo}, 错误码: {result.ErrorCode}");
                //if (_patron.IsFingerprintSource)
                //    PatronClear();    // 只有当面板上的读者信息来源是指纹仪时，才清除面板上的读者信息
                //return;
            }
            else
            {
                // 清除以前残留的报错信息
                //SetPatronError("fingerprint", "");
            }

            if (result.Message == null)
                return;

            //PatronClear();
            //_patron.IsFingerprintSource = true;
            //_patron.PII = result.Message;

        }

        // 填充读者信息的其他字段(第二阶段)
        async Task<NormalResult> FillPatronDetail(bool force = false)
        {



            //// 已经填充过了
            //if (_patron.PatronName != null
            //    && force == false)
            //    return new NormalResult();

            //string pii = _patron.PII;
            //if (string.IsNullOrEmpty(pii))
            //    pii = _patron.UID;

            //if (string.IsNullOrEmpty(pii))
            //    return new NormalResult();

            //// TODO: 改造为 await
            //// return.Value:
            ////      -1  出错
            ////      0   读者记录没有找到
            ////      1   成功
            //GetReaderInfoResult result = await
            //    Task<GetReaderInfoResult>.Run(() =>
            //    {
            //        return GetReaderInfo(pii);
            //    });

            //if (result.Value != 1)
            //{
            //    string error = $"读者 '{pii}': {result.ErrorInfo}";
            //    SetPatronError("getreaderinfo", error);
            //    return new NormalResult { Value = -1, ErrorInfo = error };
            //}

            //SetPatronError("getreaderinfo", "");

            //if (force)
            //    _patron.PhotoPath = "";
            //// string old_photopath = _patron.PhotoPath;
            //Application.Current.Dispatcher.Invoke(new Action(() =>
            //{
            //    _patron.SetPatronXml(result.RecPath, result.ReaderXml, result.Timestamp);
            //    this.patronControl.SetBorrowed(result.ReaderXml);
            //}));

            return new NormalResult();
        }

        void EnableControls(bool enable)
        { }

        // 设置全局区域错误字符串
        void SetGlobalError(string type, string error)
        {
            this.label1.Text = error;
            //App.CurrentApp.SetError(type, error);
        }

        void DisplayError(ref VideoWindow videoRegister,
    string message,
    string color = "red")
        {
            /*
            MemoryDialog(videoRegister);
            var temp = videoRegister;
            Invoke(new Action(() =>
            {
                temp.MessageText = message;
                temp.BackColor = color;
                temp.okButton.Content = "返回";
                temp = null;
            }));
            videoRegister = null;
            */


            Invoke(new Action(() =>
            {
                MessageBox.Show(this, message);
            }));
        }


    }


}
