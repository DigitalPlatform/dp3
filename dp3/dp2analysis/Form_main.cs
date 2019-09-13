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

        private void button_borrowreturn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dp2analysisService.Instance.dp2ServerUrl) == true)
            {
                MessageBox.Show(this, "尚未配置服务器地址");
                return;
            }

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
                    TestBorrowAndReturn(this._cancel.Token,
                        "", patronBarcode, itemBarcode);
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

            LibraryChannel channel = dp2analysisService.Instance.GetChannel();
            this.Invoke((Action)(() =>
                EnableControls(false)
                ));
            try
            {
                int nCount = 0;
                ShowInfo("开始进行密集借书还书测试");

                while (token.IsCancellationRequested == false)
                {

                    //if (stop?.State != 0)
                    //    break;

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
                        ShowInfo($"读者 {strReaderBarcode} 借书 {strItemBarcode} 失败: {strError}");
                    }
                    else
                    {
                        ShowInfo($"读者 {strReaderBarcode} 借书 {strItemBarcode} 成功");
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
                        ShowInfo($"读者 {strReaderBarcode} 还书 {strItemBarcode} 失败: {strError}");
                    else
                        ShowInfo($"读者 {strReaderBarcode} 还书 {strItemBarcode} 成功");


                    nCount++;
                }

                ShowInfo("结束密集借书还书测试，共执行" + nCount.ToString() + "次");
            }
            catch (Exception ex)
            {
                strError = "TestBorrowAndReturn() Exception: " + ex.Message;//ExceptionUtil.GetExceptionText(ex);
                goto ERROR1;
            }
            finally
            {
                this.Invoke((Action)(() =>
                    EnableControls(true)
                    ));

                //channel.Timeout = old_timeout;
                //this.ReturnChannel(channel);

                dp2analysisService.Instance.ReturnChannel(channel);
            }


            ERROR1:
            ShowInfo(strError);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
        }
    }
}
