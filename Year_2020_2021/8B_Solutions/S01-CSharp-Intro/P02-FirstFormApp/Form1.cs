using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_FirstFormApp
{
    //Shitf + F7 - режим Design
    //F7 - режим Code
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "-";
            label2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello world!";
            label2.Text = "Hello world from label 2!";
        }
    }
}
