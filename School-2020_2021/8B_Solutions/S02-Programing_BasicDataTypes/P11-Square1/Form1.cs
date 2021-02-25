using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_Square1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int side = int.Parse(textBox1.Text);
            int p = 4 * side;
            int s = side * side;
            label3.Text = p.ToString();
            label4.Text = s.ToString();
        }
    }
}
