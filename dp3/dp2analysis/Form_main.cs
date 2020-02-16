using DigitalPlatform.LibraryRestClient;
using dp2analysis.service;
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

namespace dp2analysis
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        // 用于终止线程
        CancellationTokenSource _cancel = new CancellationTokenSource();

        private void dp2服务器配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting dlg = new Form_Setting();
            dlg.ShowDialog(this);
        }

        private async void button_borrowreturn_Click(object sender, EventArgs e)
        {

            this.textBox1.Text = "";
            this._cancel.Dispose();
            this._cancel = new CancellationTokenSource();

            if (string.IsNullOrEmpty(dp2analysisService.Instance.dp2ServerUrl) == true)
            {
                MessageBox.Show(this, "尚未配置服务器地址");
                return;
            }

            string text = this.textBox2.Text.Trim();

            text = text.Replace("\r\n", "\n");
            string[] lines = text.Split(new char[] { '\n' });

            foreach (string line in lines)
            {
                int nindex = line.IndexOf("/");
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

                string itemBarcode = line.Substring(nindex + 1).Trim();
                if (itemBarcode == "")
                {
                    MessageBox.Show(this, "输入格式不合法");
                    return;
                }
            }

            await Task.Run(() =>
            {
                this.Invoke((Action)(() =>
                    EnableControls(false)
                    ));
                try
                {
                    List<Task> tasks = new List<Task>();

                    foreach (string line in lines)
                    {
                        int nindex = line.IndexOf("/");
                        string patronBarcode = line.Substring(0, nindex).Trim();
                        string itemBarcode = line.Substring(nindex + 1).Trim();

                        Task t = Task.Run(() =>
                          {
                              TestBorrowAndReturn(this._cancel.Token,
                                                      "", patronBarcode, itemBarcode);
                          });

                        tasks.Add(t);

                    }

                    Task.WaitAll(tasks.ToArray());
                }
                finally
                {
                    this.Invoke((Action)(() =>
                        EnableControls(true)
                        ));
                }
            });
        }

        void ShowInfo(string text)
        {
            this.Invoke((Action)(() =>
            {
                this.textBox1.Text = this.textBox1.Text + text + "\r\n";
                this.textBox1.ScrollToCaret();
            }
                ));
        }

        // 设置按钮状态
        void EnableControls(bool bEnable)
        {
            this.button_borrowreturn.Enabled = bEnable;
            this.button_stop.Enabled = !(bEnable);
        }



        // parameters:
        //      strStyle    风格
        void TestBorrowAndReturn(CancellationToken token,
            string strStyle,
            string strReaderBarcode,
            string strItemBarcode)
        {
            string strError = "";
            int nRet = 0;
            int nCount = 0;

            RestChannel channel = dp2analysisService.Instance.GetChannel();
            try
            {
                while (token.IsCancellationRequested == false)
                {
                    Thread.Sleep(50);

                    // 数量达到100时，清空一下信息区域
                    if (nCount % 50 == 0)
                    {
                        this.Invoke((Action)(() =>
                          this.textBox1.Text = ""
                        ));
                    }

                    long lRet = 0;
                    string strOutputReaderBarcode = "";
                    string strReaderXml = "";

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
                        out strOutputReaderBarcode,
                        out strReaderXml,
                        out BorrowInfo borrow_info,
                        out strError);

                    if (lRet == -1)
                    {
                        ShowInfo($"读者 {strReaderBarcode} 借书 {strItemBarcode} 失败: {strError}" + nCount.ToString());
                    }
                    else
                    {
                        ShowInfo($"读者 {strReaderBarcode} 借书 {strItemBarcode} 成功" +nCount.ToString());
                    }

                    // 还书
                    lRet = channel.Return("return",
                        strReaderBarcode,
                        strItemBarcode,
                        out strOutputReaderBarcode,
                        out strReaderXml,
                        out ReturnInfo returnInfo,
                        out strError);

                    if (lRet == -1)
                        ShowInfo($"读者 {strReaderBarcode} 还书 {strItemBarcode} 失败: {strError}" + nCount.ToString());
                    else
                        ShowInfo($"读者 {strReaderBarcode} 还书 {strItemBarcode} 成功" + nCount.ToString());


                    nCount++;
                }
            }
            catch (Exception ex)
            {
                ShowInfo("TestBorrowAndReturn() Exception: " + ex.Message);//ExceptionUtil.GetExceptionText(ex);              
            }
            finally
            {
                ShowInfo(strReaderBarcode + "结束密集借书还书，共执行" + nCount.ToString() + "次");

                dp2analysisService.Instance.ReturnChannel(channel);
            }

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
            this._cancel.Cancel();
        }

        private void Form_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._cancel.Cancel();
            this._cancel.Dispose();
        }
    }
}
