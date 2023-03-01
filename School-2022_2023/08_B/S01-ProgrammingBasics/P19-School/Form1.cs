using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P19_School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int count = 0;
            if (radioButton1.Checked)
            {
                if (checkBox1.Checked)
                {
                    count += int.Parse(textBox1.Text);
                }
                if (checkBox2.Checked)
                {
                    count += int.Parse(textBox2.Text);
                }
                if (checkBox3.Checked)
                {
                    count += int.Parse(textBox3.Text);
                }
            }
            else if (radioButton2.Checked)
            {
                if (checkBox1.Checked)
                {
                    count += int.Parse(textBox4.Text);
                }
                if (checkBox2.Checked)
                {
                    count += int.Parse(textBox5.Text);
                }
                if (checkBox3.Checked)
                {
                    count += int.Parse(textBox6.Text);
                }
            }
            else
            {
                if (checkBox1.Checked)
                {
                    count += int.Parse(textBox1.Text) + int.Parse(textBox4.Text);
                }
                if (checkBox2.Checked)
                {
                    count += int.Parse(textBox2.Text) + int.Parse(textBox4.Text);
                }
                if (checkBox3.Checked)
                {
                    count += int.Parse(textBox3.Text) + int.Parse(textBox6.Text); ;
                }
            }
            label1.Text = count.ToString();
        }
    }
}
