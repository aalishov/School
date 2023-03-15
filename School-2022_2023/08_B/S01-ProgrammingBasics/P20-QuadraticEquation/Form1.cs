using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P20_QuadraticEquation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "ax\xB2+bx\xB2+c=0";
            label2.Text = "x\x2081=";
            label3.Text = "x\x2082=";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double d = b * b - 4 * a * c;
            if (d >= 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2*a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                label7.Text = x1.ToString();
                label8.Text = x2.ToString();
            }
            else
            {
                label7.Text = "No real roots!";
                label8.Text = "No real roots!";
            }
        }
    }
}
