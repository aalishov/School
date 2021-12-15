using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "Е-мейлът на Иво Колев е kolev@kolev.com";
            string s1 = "kolev";
            string s2 = "KOLEV";
            int d1 = s.IndexOf(s1);
            int d2 = s.LastIndexOf(s1);
            int d3 = s.LastIndexOf(s2);
            label1.Text = d1.ToString();
            label2.Text = d2.ToString();
            label3.Text = d3.ToString();
        }
    }
}
