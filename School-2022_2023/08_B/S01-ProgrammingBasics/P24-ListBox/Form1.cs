using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P24_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int min = int.MaxValue;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox1.Items.Clear();
            min = int.MaxValue;
            textBox1.Text=string.Empty; 
            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(0, 100);
                listBox1.Items.Add(num);
                if (num < min)
                {
                    min = num;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text=min.ToString();
        }
    }
}
