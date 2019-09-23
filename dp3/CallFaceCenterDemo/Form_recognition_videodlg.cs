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
    public partial class Form_recognition_videodlg : Form
    {


        public Form_recognition_videodlg()
        {
            InitializeComponent();
        }

        // 人脸识别，调facecenter窗口
        private void button_faceRecognition1_Click(object sender, EventArgs e)
        {
            Form_VideoDlg dlg = new Form_VideoDlg();
            dlg.ShowDialog(this);

            if (dlg.DialogResult == DialogResult.OK)
            {
                this.textBox1.Text = "识别成功，证条码为："+dlg.PatfromBacode;
            }
        }





        private void Form_recognition_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }


}
