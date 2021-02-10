using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = string.Empty;
            label4.Text = string.Empty;
        }


        //Сумиране
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text,out _) && int.TryParse(textBox2.Text,out _))
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int sum = num1 + num2;
                label2.Text = "+";
                label1.Text = $"{sum}";
                label4.Text = $"{num1} {label2.Text} {num2} {label3.Text} {sum}";
            }
            else
            {
                label4.Text = $"{textBox1.Text}{textBox2.Text}";
            }
        }

        //Изваждане
        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out _) && int.TryParse(textBox2.Text, out _))
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = num1 - num2;
                label2.Text = "-";
                label1.Text = $"{result}";
                label4.Text = $"{num1} {label2.Text} {num2} {label3.Text} {result}";
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 * num2;
            label2.Text = "*";
            label1.Text = $"{result}";
            label4.Text = $"{num1} {label2.Text} {num2} {label3.Text} {result}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 / num2;
            label2.Text = "/";
            label1.Text = $"{result}";
            label4.Text = $"{num1} {label2.Text} {num2} {label3.Text} {result}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result = num1 % num2;
            label2.Text = "%";
            label1.Text = $"{result}";
            label4.Text = $"{num1} {label2.Text} {num2} {label3.Text} {result}";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int result1 = num1 / num2;
            int result2 = num1 % num2;
            label2.Text = "/->%";
            label1.Text = $"{result1} -> {result2}";
            label4.Text = $"{num1} / {num2} {label3.Text} {result1} -> ост. {result2}";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            label2.Text = string.Empty;
            label1.Text = string.Empty;
            label4.Text = string.Empty;
        }
    }
}
