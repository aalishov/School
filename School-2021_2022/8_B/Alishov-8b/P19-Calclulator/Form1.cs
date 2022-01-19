using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P19_Calclulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter number 1";
            label2.Text = "Enter number 2";
            button1.Text = "Calculate";
            label3.Text = string.Empty;
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(textBox1.Text);
            double num2 = double.Parse(textBox2.Text);
            double sum = num1 + num2;
            double sub = num1 - num2;
            label3.Text = $"{num1} + {num2} = {sum:f2}";
            label4.Text = $"{num1} - {num2} = {sub:f2}";
        }


    }
}
