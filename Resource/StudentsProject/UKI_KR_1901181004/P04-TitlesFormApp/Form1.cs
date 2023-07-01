using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_TitlesFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox1.Text);
            if (age < 16)
            {
                if (radioButton1.Checked) { label3.Text="Master"; }
                else if (radioButton2.Checked) { label3.Text = "Miss"; }
            }
            else
            {
                if (radioButton1.Checked) { label3.Text = "Mr."; }
                else if (radioButton2.Checked) { label3.Text = "Ms."; }
            }
        }
    }
}
