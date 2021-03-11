using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_Arrays380FormsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            if (number != 0)
            {
                listBox1.Items.Add(number);
            }
            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                int[] numbers = new int[listBox1.Items.Count];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = (int)listBox1.Items[i];
                }
                label1.Text += $"\n{numbers.Where(x => x % 2 == 1).Sum()}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox2.Text);
            listBox2.Items.Add(number);
            textBox2.Text = string.Empty;
            if (listBox2.Items.Count == 8)
            {
                textBox2.Enabled = false;
                button2.Enabled = false;
                int product = 1;
                for (int i = 0; i < 8; i++)
                {
                    product *= (int)listBox2.Items[i];
                }
                label2.Text += $"\n{Math.Pow((double)product, (double)1.0 / 8.0):f5}";
            }
        }

        private int Sss(int k)
        {
            Random random = new Random();

            int[] randomNumbers = new int[k];

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(-1000, 1000);
            }

            int product = 1;

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                bool addToProduct = randomNumbers[i] >= 10 && randomNumbers[i] <= 99 && randomNumbers[i] % 10 == 5;
                if (addToProduct)
                {
                    product *= randomNumbers[i];
                }
            }

            return product;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);
            int b = int.Parse(textBox4.Text);
            int c = int.Parse(textBox5.Text);
            int result = Sss(Math.Abs(a - b)) * Sss(b + c);
            label6.Text = $"result: {result}";
        }

    }
}
