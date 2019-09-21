using DigitalPlatform.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Ipc;
using System.Text;
using System.Threading.Tasks;

namespace CallFaceCenterDemo
{
    public class FaceManager
    {


        // 人脸识别 API
        public static RecognitionFaceResult Recognition(string url, string style)
        {
            // 先创建与facecente连接的通道
            FaceChannel channel = StartFaceChannel(url,
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
        public static FaceChannel StartFaceChannel(string strUrl,
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
        public static void EndFaceChannel(FaceChannel channel)
        {
            if (channel != null && channel.Channel != null)
            {
                ChannelServices.UnregisterChannel(channel.Channel);
                channel.Channel = null;
            }
        }

        // 取消人脸识别任务 API
        public static NormalResult CancelRecognition(string url)
        {
            FaceChannel channel = StartFaceChannel(
                url,
                out string strError);
            if (channel == null)
                return new NormalResult
                {
                    Value = -1,
                    ErrorInfo = strError
                };

            try
            {
                return channel.Object.CancelRecognitionFace();
            }
            catch (Exception ex)
            {
                strError = $"针对 {url} 的 CancelRecognitionFace() 操作失败: { ex.Message}";
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
    }

    public class FaceChannel
    {
        public IpcClientChannel Channel { get; set; }
        public IBioRecognition Object { get; set; }
    }
}
