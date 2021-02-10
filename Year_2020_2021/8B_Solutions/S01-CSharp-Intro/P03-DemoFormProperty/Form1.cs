using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_DemoFormProperty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Text = "Show";
            button3.Text = "Hide";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Text: "+textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            //Left
            label3.Text = "<";
            label3.Left -= 10; //label3.Left=label3.Left-10;
            button4.ForeColor = Color.Red;
            button5.ForeColor = Color.Red;
            button6.ForeColor = Color.Blue;
            button7.ForeColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Right
            label3.Text = ">";
            label3.Left += 10; //label3.Left=label3.Left+10;
            button4.ForeColor = Color.Red;
            button5.ForeColor = Color.Red;
            button6.ForeColor = Color.Red;
            button7.ForeColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Top
            label3.Text = "^";
            label3.Top -= 10;
            button4.ForeColor = Color.Blue;
            button5.ForeColor = Color.Red;
            button6.ForeColor = Color.Red;
            button7.ForeColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Bottom
            label3.Text = "v";
            label3.Top += 10;

            button4.ForeColor = Color.Red;
            button5.ForeColor = Color.Blue;
            button6.ForeColor = Color.Red;
            button7.ForeColor = Color.Red;
        }
    }
}
