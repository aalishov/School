using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Маргарита")
            {
                pictureBox1.Load("https://placeralplato.com/files/2015/06/pizza-Margarita-640x480.jpg?width=1200&enable=upscale");
            }
            else if (comboBox1.Text=="Капричоза")
            {
                pictureBox1.Load("https://boliarky.com/media/18/1690.jpg");
            }
            else if (comboBox1.Text=="4 сезона")
            {
                pictureBox1.Load("https://2.bp.blogspot.com/-rBc3WRAp3N0/WcpjubEj3yI/AAAAAAAHb-M/dWalGxaT2BQmERBwgKRm2HxIdrBirQJHQCLcBGAs/s640/14-pizza-png-image.png");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*',10));
            sb.AppendLine($"Пица:{comboBox1.Text}");
            sb.AppendLine();
            if (radioButton1.Checked)
            {
                sb.AppendLine("Размер: малка");
            }
            else if (radioButton3.Checked)
            {
                sb.AppendLine("Размер: голяма");
            }
            else if (radioButton2.Checked)
            {
                sb.AppendLine("Размер: семейна");
            }
            if (radioButton4.Checked)
            {
                sb.AppendLine("Начин на плащане: брой");
            }
            else if(radioButton5.Checked)
            {
                sb.AppendLine("Начин на плащане: онлайн");
            }
            sb.AppendLine("Екстри: ");
            if (checkBox1.Checked)
            {
                sb.AppendLine("кетчуп");
            }
            if (checkBox2.Checked)
            {
                sb.AppendLine("майонеза");
            }
            if (checkBox3.Checked)
            {
                sb.AppendLine("горчица");
            }
            if (checkBox4.Checked)
            {
                sb.AppendLine("чеснов сос");
            }
            if (checkBox5.Checked)
            {
                sb.AppendLine("соев сос");
            }
            if (checkBox6.Checked)
            {
                sb.AppendLine("чили");
            }
            sb.AppendLine(new string('*', 10));
            File.AppendAllText("orders.txt", sb.ToString().TrimEnd());
            MessageBox.Show("Поръчката е успешна!");
        }
    }
}
