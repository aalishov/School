using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08_FileName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //d:/Izkustva/klas_8/Urok_01/Image1.jpg
            int slashIndex = textBox1.Text.LastIndexOf("/");
            int length = textBox1.Text.Length;
            int charCount = length - slashIndex - 1;
            string fileName = textBox1.Text.Substring(slashIndex + 1, charCount);
            label1.Text = fileName;
        }
    }
}
