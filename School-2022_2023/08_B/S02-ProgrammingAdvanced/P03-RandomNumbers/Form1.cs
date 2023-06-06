using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_RandomNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = int.Parse(textBox1.Text);
            int min = int.Parse(textBox3.Text);
            int max=int.Parse(textBox4.Text);
            string fileName = textBox2.Text + ".txt";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                Random random = new Random();

                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine(random.Next(min,max));
                }
            }
            MessageBox.Show("Job done!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
