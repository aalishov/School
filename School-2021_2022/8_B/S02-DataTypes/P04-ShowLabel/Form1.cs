﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_ShowLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            MessageBox.Show("Show label");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            MessageBox.Show("Hide label");
        }
    }
}
