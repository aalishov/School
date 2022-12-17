using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_Toto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetRandom().ToString();
            textBox2.Text = GetRandom().ToString();
            textBox3.Text = GetRandom().ToString();
            textBox4.Text = GetRandom().ToString();
            textBox5.Text = GetRandom().ToString();
            textBox6.Text = GetRandom().ToString();
        }

        private int GetRandom()
        {
            Random random = new Random();
            return random.Next() % 49 + 1;
        }
    }
}
