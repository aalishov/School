using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_6_From_49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = $"{GetRandomNumber()}";
            label2.Text = $"{GetRandomNumber()}";
            label3.Text = $"{GetRandomNumber()}";
            label4.Text = $"{GetRandomNumber()}";
            label5.Text = $"{GetRandomNumber()}";
            label6.Text = $"{GetRandomNumber()}";
        }

        Random random = new Random();
        private int GetRandomNumber()
        {
            int randomNumber = random.Next() % 49 + 1;
            return randomNumber;
        }
    }
}
