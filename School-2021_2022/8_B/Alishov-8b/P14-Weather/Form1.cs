using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P14_Weather
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Въведи ден: ";
            label2.Text = "Въведи температура: ";
            label3.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string day = textBox1.Text;
            string temp = textBox2.Text;
            string result = $"Температурата днес ({day}) е {temp} градуса";
            label3.Text = result;
        }


    }
}
