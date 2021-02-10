using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_v2_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int points = int.Parse(textBox1.Text);

            if (points >= 80)
            {
                label2.Text="Отличен";
            }
            else if (points >= 60 && points < 80)
            {
                label2.Text = "Много добър";
            }
            else if (points >= 40 && points < 60)
            {
                label2.Text = "Добър";
            }
            else if (points >= 20 && points < 40)
            {
                label2.Text = "Среден";
            }
            else
            {
                label2.Text = "Слаб";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
