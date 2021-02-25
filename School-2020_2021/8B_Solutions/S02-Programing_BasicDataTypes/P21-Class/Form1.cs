using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P21_Class
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            int girls8A = int.Parse(textBox1.Text);
            int boys8A = int.Parse(textBox2.Text);
            int girls8B = int.Parse(textBox3.Text);
            int boys8B = int.Parse(textBox4.Text);
            int girls8V = int.Parse(textBox5.Text);
            int boys8V = int.Parse(textBox6.Text);
            int sum = 0;

            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    sum += girls8A;
                }
                if (checkBox2.Checked)
                {
                    sum += girls8B;
                }
                if (checkBox3.Checked)
                {
                    sum += girls8V;
                }
            }
            else if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    sum += boys8A;
                }
                if (checkBox2.Checked)
                {
                    sum += boys8B;
                }
                if (checkBox3.Checked)
                {
                    sum += boys8V;
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    sum += boys8A;
                    sum += girls8A;
                }
                if (checkBox2.Checked)
                {
                    sum += boys8B;
                    sum += girls8B;
                }
                if (checkBox3.Checked)
                {
                    sum += boys8V;
                    sum += girls8V;
                }
            }
            label4.Text = sum.ToString();
        }
    }
}
