using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_FirstFormApp
{
    //Shitf + F7 - режим Design
    //F7 - режим Code
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            sum.Text = string.Empty;
            this.Text = "Demo Application - Run";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello world!";
            sum.Text = "Hello world from label sum!";
            int a = 12;
            int b = 13;
            label2.Text = $"{a} + {b} = {a + b}";
            label2.Visible = true;
            button2.Visible = true;
            textBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.YellowGreen;
            button3.BackColor = Color.DarkSeaGreen;
        }
    }
}
