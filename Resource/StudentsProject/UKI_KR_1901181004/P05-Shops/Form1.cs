using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_Shops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled= false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            radioButton1.Checked=true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0.0;
            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    price += int.Parse(textBox1.Text) * 0.5;
                }
                if (checkBox2.Checked)
                {
                    price += int.Parse(textBox2.Text) * 0.7;
                }
                if (checkBox3.Checked)
                {
                    price += int.Parse(textBox3.Text) * 1.45;
                }
            }
            else if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    price += int.Parse(textBox1.Text) * 0.4;
                }
                if (checkBox2.Checked)
                {
                    price += int.Parse(textBox2.Text) * 0.7;
                }
                if (checkBox3.Checked)
                {
                    price += int.Parse(textBox3.Text) * 1.30;
                }
            }
            label2.Text = $"Final price: {price:f2}";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
