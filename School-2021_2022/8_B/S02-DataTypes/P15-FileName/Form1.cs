using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P15_FileName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Въведи пътя до файла: ";
            label2.Text = "";
            button1.Text = "Изведи името на файла";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            int startIndex = path.LastIndexOf("\\");
            string fileName = path.Substring(startIndex+1);
            label2.Text = $"Името на файла е: {fileName}";
        }
    }
}
