using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_DemoEnabled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.Text = "Activate";
            button2.Text = "Deactivate";
            button3.Text = "Copy";
            button4.Text = "Clear";
            label1.Text = "Enter text: ";
            label2.Text = "You entered: ";
            label3.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "-";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
