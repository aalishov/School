using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_RandomListMinElement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int min = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox1.Items.Clear();
            min = int.MaxValue;
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(1, 100);
                listBox1.Items.Add(number);
                if (number<min)
                {
                    min = number;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = min.ToString();
        }
    }
}
