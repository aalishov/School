using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_AdvancedCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Enter a:";
            label2.Text = "Enter b:";
            label3.Text = "-";
            button1.Text = "+";
            button2.Text = "-";
            button3.Text = "*";
            button4.Text = "/";
            button5.Text = "%";
            button6.Text = "Pow(a,b)";
            button7.Text = "Round(a,b)";
            button8.Text = "Floor(a)";
            button9.Text = "Ceiling(a)";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = $"Round({a},{b})={Math.Round(a,b)}";
        }
    }
}
