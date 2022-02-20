using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P22_CircleArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = double.Parse(textBox1.Text);
            double s = Math.PI * r * r;
            label2.Text = $"S = {Math.Round(s,4)}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
