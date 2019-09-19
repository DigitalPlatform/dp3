using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceCenterDemo
{
    public partial class VideoWindow : Form
    {
        public VideoWindow()
        {
            InitializeComponent();
        }

        public void SetPhoto(Stream stream)
        {
            if (stream == null)
            {
                //this.photo.Source = null;
                this.pictureBox1.Image = null;
                return;
            }

           this.pictureBox1.Image= Image.FromStream(stream);

            //var imageSource = new BitmapImage();
            //imageSource.BeginInit();
            //imageSource.StreamSource = stream;
            //imageSource.EndInit();
            //this.photo.Source = imageSource;
        }
    }
}
