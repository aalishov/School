using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06_CarPriceFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double price = double.Parse(textBox1.Text);
            if (radioButton2.Checked)
            {
                price *= 0.9;
            }
            else if (radioButton3.Checked)
            {
                price *= 1.15;
            }

            if (checkBox1.Checked)
            {
                price += 800;
            }
            if (checkBox2.Checked)
            {
                price += 600;
            }
            if (checkBox3.Checked)
            {
                price += 400;
            }
            if (checkBox4.Checked)
            {
                price += 300;
            }
            label3.Text = $"Final price: {price:f2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
