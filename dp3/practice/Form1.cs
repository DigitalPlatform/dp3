﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Cancel1_Click(object sender, EventArgs e)
        {
            Form_cancel1 dlg = new Form_cancel1();
            dlg.ShowDialog(this);
        }

        private void button_cancel2_Click(object sender, EventArgs e)
        {
            Form_cancel2 dlg = new Form_cancel2();
            dlg.ShowDialog(this);
        }

        private void button_cancel3_Click(object sender, EventArgs e)
        {
            Form_cancel3 dlg = new Form_cancel3();
            dlg.ShowDialog(this);
        }
    }
}
