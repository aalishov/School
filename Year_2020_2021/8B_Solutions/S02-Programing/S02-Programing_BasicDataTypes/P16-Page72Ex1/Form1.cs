using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P16_Page72Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int a = 0, c = 12;
            int b = 10, d = 5;
            a = c % d;
            b = b/a;
            label1.Text = a.ToString();
            label2.Text = b.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
