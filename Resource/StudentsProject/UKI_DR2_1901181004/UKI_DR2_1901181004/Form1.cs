using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKI_DR2_1901181004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            button1.Text = "Пресметни I";
            label1.Text = "Въведи U";
            label2.Text = "Въведи R";
            label4.Text = "V";
            label5.Text = "Ω";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            button1.Text = "Пресметни U";
            label1.Text = "Въведи R";
            label2.Text = "Въведи I";
            label4.Text = "Ω";
            label5.Text = "A";
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            button1.Text = "Пресметни R";
            label1.Text = "Въведи U";
            label2.Text = "Въведи I";
            label4.Text = "V";
            label5.Text = "A";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double v1 = double.Parse(textBox1.Text);
                double v2 = double.Parse(textBox2.Text);

                if (radioButton1.Checked)
                {
                    label3.Text = $"Силата на тока (I) е: {(v1 / v2):f2}A";
                }
                else if (radioButton2.Checked)
                {
                    label3.Text = $"Напрежението (U) е: {(v1 * v2):f2}V";
                }
                else
                {
                    label3.Text = $"Съпротивлението (R) е: {(v1 / v2):f2}Ω";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Въведи валидни стойности!");
                button2_Click(sender, e);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
