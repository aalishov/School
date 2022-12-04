using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_Digits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                label1.ForeColor=Color.Red;
                label1.Text = "Нула";
            }
            else if (textBox1.Text=="1") 
            {
                label1.ForeColor = Color.Aqua;
                label1.Text = "Едно";
            }
            else if (textBox1.Text == "2")
            {
                label1.ForeColor = Color.OrangeRed;
                label1.Text = "Две";
            }
            else if (textBox1.Text == "3")
            {
                label1.ForeColor = Color.Blue;
                label1.Text = "Три";
            }
            else if (textBox1.Text == "4")
            {
                label1.Text = "Четири";
            }
            else if (textBox1.Text == "5")
            {
                label1.Text = "Пет";
            }
            else if (textBox1.Text == "6")
            {
                label1.Text = "Шест";
            }
            else if (textBox1.Text == "7")
            {
                label1.Text = "Седем";
            }
            else if (textBox1.Text == "8")
            {
                label1.Text = "Осем";
            }
            else if (textBox1.Text == "9")
            {
                label1.Text = "Девет";
            }
            else
            {
                label1.Text = "Не знам!";
            }
        }
    }
}
