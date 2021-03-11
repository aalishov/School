using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_FormMinValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int min = int.MaxValue;
        private void button1_Click(object sender, EventArgs e)
        {
            min = int.MaxValue;
            listBox1.Items.Clear();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int num = random.Next(-1500, 1500);

                if (num<min)
                {
                    min = num;
                }
                listBox1.Items.Add(num);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = min.ToString();
        }
   
    }
}
