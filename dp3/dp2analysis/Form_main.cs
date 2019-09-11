using DigitalPlatform.LibraryRestClient;
using dp2analysis.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp2analysis
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void dp2服务器配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting dlg = new Form_Setting();
            dlg.ShowDialog(this);
        }

        private void button_borrowreturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dp2analysisService.Instance.dp2ServerUrl) == true)
            {
                MessageBox.Show(this, "尚未配置服务器地址");
                return;
            }

            this._stop = false;

            string text = this.textBox2.Text.Trim();

            text = text.Replace("\r\n", "\n");
            string[] lines=text.Split(new char[] { '\n' });

            foreach (string line in lines)
            {
                int nindex=line.IndexOf("/");
                if (nindex == -1)
                {
                    MessageBox.Show(this, "输入格式不合法");
                    return;
                }
                string patronBarcode = line.Substring(0, nindex).Trim();
                if (patronBarcode == "")
                {
                    MessageBox.Show(this, "输入格式不合法");
                    return;
                }

                string itemBarcode = line.Substring(nindex+1).Trim();
                if (itemBarcode == "")
                {
                    MessageBox.Show(this, "输入格式不合法");
                    return;
                }
            }

            foreach (string line in lines)
            {
                int nindex = line.IndexOf("/");
                string patronBarcode = line.Substring(0, nindex).Trim();
                string itemBarcode = line.Substring(nindex + 1).Trim();
                Task.Factory.StartNew(() =>
                {
                    TestBorrowAndReturn("", patronBarcode, itemBarcode);
                });
            }

            //TestBorrowAndReturn("", "R0000001", "0000001");


            //Task.Factory.StartNew(() =>
            //{
            //    TestBorrowAndReturn("", "R0000001", "0000001");
            //});

            //Task.Factory.StartNew(() =>
            //{
            //    TestBorrowAndReturn("", "R0000002", "0000002");
            //});
        }

        void ShowInfo(string text)
        {
            this.Invoke((Action)(() =>
                ShowInfo1(text)
                ));
            //this.textBox1.Text = this.textBox1.Text + text + "\r\n";
        }

        void ShowInfo1(string text)
        {           
            this.textBox1.Text = this.textBox1.Text + text + "\r\n";
            this.textBox1.ScrollToCaret();
        }

        void EnableControls(bool bEnable)
        {
            this.button_borrowreturn.Enabled = bEnable;
            if (bEnable == false)
                this.button_stop.Enabled = true;
            else
                this.button_stop.Enabled = false;
        }

        bool _stop = false;


        // parameters:
        //      strStyle    风格
        void TestBorrowAndReturn(string strStyle,
            string strReaderBarcode,
            string strItemBarcode)
        {
            string strError = "";
            int nRet = 0;

            LibraryChannel channel = dp2analysisService.Instance.GetChannel();
            //TimeSpan old_timeout = channel.Timeout;
            // channel.Timeout = TimeSpan.FromMinutes(10);

            //Progress.Style = StopStyle.EnableHalfStop;
            //Progress.OnStop += new StopEventHandler(this.DoStop);
            //Progress.Initial("正在进行测试 ...");
            //Progress.BeginLoop();

            this.Invoke((Action)(() =>
                EnableControls(false)
                ));
            try
            {
                int nCount = 0;
                ShowInfo("开始进行密集借书还书测试");
//                Program.MainForm.OperHistory.AppendHtml("<div class='debug begin'>" + HttpUtility.HtmlEncode(DateTime.Now.ToLongTimeString())
//+ " 开始进行密集借书还书测试</div>");

                for (; ; )
                {
                    Application.DoEvents();
                    if (_stop == true)
                        break;

                    //if (stop?.State != 0)
                    //    break;

                    long lRet = 0;
                    string strReaderXml = "";

                    // 如果测试用的书目库以前就存在，要先删除。删除前最好警告一下
                   // Progress.SetMessage("正在借 ...");
                    {
                        lRet = channel.Borrow(
                            //stop,
                            false,
                            strReaderBarcode,
                            strItemBarcode,
                            //"", // strConfirmItemRecPath,
                            //false,
                            //null,   // saBorrowedItemBarcode,
                            //"", // strStyle,
                            //"", // strItemFormatList,
                            //out string[] item_records,
                            //"", // strReaderFormatList,
                            //out string[] reader_records,
                            //"", // strBiblioFormatList,
                            //out string[] biblio_records,
                            //out string[] aDupPath,
                            out string strOutputReaderBarcode,
                            out strReaderXml,
                            out BorrowInfo borrow_info,
                            out strError);
                    }
                    if (lRet == -1)
                    {
                       // if (channel.ErrorCode != DigitalPlatform.LibraryClient.localhost.ErrorCode.NotFound)
                            //goto ERROR1;

                        ShowInfo( $"读者 {strReaderBarcode} 借书 {strItemBarcode} 失败: {strError}");
                        //DisplayError($"读者 {strReaderBarcode} 借书 {strItemBarcode} 失败: {strError}");
                    }
                    else
                    {
                        ShowInfo($"读者 {strReaderBarcode} 借书 {strItemBarcode} 成功");
                        //DisplayOK($"读者 {strReaderBarcode} 借书 {strItemBarcode} 成功");
                    }


                    //{
                    //    nRet = TestChangeReaderRecord(channel,
                    //        strReaderBarcode,
                    //        out strError);
                    //    if (nRet == -1)
                    //        ShowInfo($"读者 {strReaderBarcode} 记录修改失败: {strError}");
                    //    else
                    //        ShowInfo($"读者 {strReaderBarcode} 记录修改成功");

                    //}

                    //Progress.SetMessage("正在还 ...");
                    {
                        //lRet = channel.Return(
                        //    "return",
                        //    strReaderBarcode,
                        //    strItemBarcode,
                        //    null,   // strConfirmItemRecPath,
                        //    false,
                        //    "", // strStyle,
                        //    "", // strItemFormatList,
                        //    out string[] item_records,
                        //    "", // strReaderFormatList,
                        //    out string[] reader_records,
                        //    "", // strBiblioFormatList,
                        //    out string[] biblio_records,
                        //    out string[] aDupPath,
                        //    out string strOutputReaderBarcode,
                        //    out ReturnInfo return_info,
                        //    out strError);

                        lRet = channel.Return("return",
                            strReaderBarcode,
                            strItemBarcode,
                            out string strOutputReaderBarcode,
                            out strReaderXml,
                            out ReturnInfo returnInfo,
                            out strError);
                    }

                    if (lRet == -1)
                        ShowInfo($"读者 {strReaderBarcode} 还书 {strItemBarcode} 失败: {strError}");
                    else
                        ShowInfo($"读者 {strReaderBarcode} 还书 {strItemBarcode} 成功");


                    nCount++;
                }
                //Program.MainForm.OperHistory.AppendHtml("<div class='debug end'>" + HttpUtility.HtmlEncode(DateTime.Now.ToLongTimeString())
//‘’+ " 结束密集借书还书测试</div>");
                ShowInfo("结束密集借书还书测试，共执行"+nCount.ToString()+"次");

                return;
            }
            catch (Exception ex)
            {
                strError = "TestBorrowAndReturn() Exception: " + ex.Message;//ExceptionUtil.GetExceptionText(ex);
                goto ERROR1;
            }
            finally
            {
                //Progress.EndLoop();
                //Progress.OnStop -= new StopEventHandler(this.DoStop);
                //Progress.Initial("");
                //Progress.HideProgress();

                this.Invoke((Action)(() =>
                    EnableControls(true)
                    ));

                //channel.Timeout = old_timeout;
                //this.ReturnChannel(channel);

                dp2analysisService.Instance.ReturnChannel(channel);
            }

            ERROR1:
            this.Invoke((Action)(() => MessageBox.Show(this, strError)));
            ShowInfo(strError);
           // this.ShowMessage(strError, "red", true);
        }



        int TestChangeReaderRecord(LibraryChannel channel,
    string strReaderBarcode,
    out string strError)
        {
            strError = "";

            /*
            long lRet = channel.GetReaderInfo(//stop,
                strReaderBarcode,
                "xml",
                out string[] results,
                out string strRecPath,
                out byte[] timestamp,
                out strError);
            if (lRet == -1)
                return -1;
            if (lRet == 0)
                return -1;

            string strXml = results[0];

            XmlDocument dom = new XmlDocument();
            dom.LoadXml(strXml);

            string comment = DomUtil.GetElementText(dom.DocumentElement, "comment");
            if (comment == null)
                comment = "";
            if (comment.Length > 200 * 1024)
            {
                comment = "";
                DisplayError($"comment 已经清除");
            }

            DomUtil.SetElementText(dom.DocumentElement, "comment", comment + new string('c', 1000));

            string strNewXml = dom.DocumentElement.OuterXml;

            lRet = channel.SetReaderInfo(stop,
    "change",
    strRecPath,
    strNewXml,
    strXml,
    timestamp,
    out string strExistingXml,
    out string strSavedXml,
    out string strSavedRecPath,
    out byte[] new_timestamp,
    out ErrorCodeValue kernel_errorcode,
    out strError);
            if (lRet == -1)
                return -1;
                */
            return 0;
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

            // 设上dp2analysisService实例上
            dp2analysisService.Instance.dp2ServerUrl = Properties.Settings.Default.dp2ServerUrl;
            dp2analysisService.Instance.dp2Username = Properties.Settings.Default.dp2Username;
            dp2analysisService.Instance.dp2Password = Properties.Settings.Default.dp2Password;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            _stop = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}
