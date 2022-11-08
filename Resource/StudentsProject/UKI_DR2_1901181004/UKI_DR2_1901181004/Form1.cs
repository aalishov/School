using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKI_DR2_1901181004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи U";
            label2.Text = "Въведи R";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи R";
            label2.Text = "Въведи I";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Въведи U";
            label2.Text = "Въведи I";
        }
    }
}
