using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForm
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="1")
            {
                label1.Text = "One";
            }
            else if (textBox1.Text == "2")
            {
                label1.Text = "Two";
            }
            else
            {
                label1.Text = "Error";
            }
            
        }
    }
}
