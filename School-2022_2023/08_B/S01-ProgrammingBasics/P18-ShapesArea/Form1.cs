using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P18_ShapesArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox2.Enabled = false;
            }
            else
            {
                textBox2.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = double.Parse(textBox1.Text);
                if (checkBox1.Checked)
                {
                    label5.Text = (a * a).ToString();
                }
                else
                {
                    label5.Text = "-";
                }
                if (checkBox2.Checked)
                {
                    label6.Text = (4 * a).ToString();
                }
                else
                {
                    label6.Text = "-";
                }
            }
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                if (checkBox1.Checked)
                {
                    label5.Text = (a * b).ToString();
                }
                else
                {
                    label5.Text = "-";
                }
                if (checkBox2.Checked)
                {
                    label6.Text = (2 * a + 2 * b).ToString();
                }
                else
                {
                    label6.Text = "-";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
