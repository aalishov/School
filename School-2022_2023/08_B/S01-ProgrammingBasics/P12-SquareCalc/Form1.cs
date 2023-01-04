using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_SquareCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side =double.Parse(textBox1.Text);
            double p = 4 * side;
            double s = side * side;
            MessageBox.Show($"Лице: {s:f2}\n\rОбиколка:{p:f2}");
        }
    }
}
