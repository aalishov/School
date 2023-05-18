using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P00_IsEven
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            MessageBox.Show(IsEvenOrOdd(num));
        }

        public static string IsEvenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                return $"Number {num} is even!";
            }
            else
            {
                return $"Number {num} is odd!";
            }
        }
    }
}
