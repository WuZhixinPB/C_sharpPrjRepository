﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SerialPortUpperComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://www.baidu.com");
            Process.Start("explorer", "https://www.taobao.com");
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            
        }
    }
}
