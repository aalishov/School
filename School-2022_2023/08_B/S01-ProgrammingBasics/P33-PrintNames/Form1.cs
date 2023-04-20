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

namespace P33_PrintNames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\08_B\\S01-ProgrammingBasics\\P33-PrintNames\\input.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    richTextBox1.AppendText(line);
                    richTextBox1.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
