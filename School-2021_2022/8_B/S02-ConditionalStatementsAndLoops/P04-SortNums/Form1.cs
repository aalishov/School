namespace P04_SortNums
{
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBoxA.Text);
            double b = double.Parse(textBoxB.Text);
            double c = double.Parse(textBoxC.Text);
            if (radioButtonAsc.Checked)
            {
                if (b > a && c > b)
                {
                    labelResult.Text = $"{a} {b} {c}";
                }
                else if (c>a && b>c )
                {
                    labelResult.Text = $"{a} {c} {b}";
                }
                else if (a > b && c>a)
                {
                    labelResult.Text = $"{b} {a} {c}";
                }
                else if (c > b && a > c)
                {
                    labelResult.Text = $"{b} {c} {a}";
                }
                else if (a > c && b > a)
                {
                    labelResult.Text = $"{c} {a} {b}";
                }
                else
                {
                    labelResult.Text = $"{c} {b} {a}";
                }
            }
            else if (radioButtonDesc.Checked)
            {
                if (b < a && c < b)
                {
                    labelResult.Text = $"{a} {b} {c}";
                }
                else if (c < a && b < c)
                {
                    labelResult.Text = $"{a} {c} {b}";
                }
                else if (a < b && c < a)
                {
                    labelResult.Text = $"{b} {a} {c}";
                }
                else if (c < b && a < c)
                {
                    labelResult.Text = $"{b} {c} {a}";
                }
                else if (a < c && b < a)
                {
                    labelResult.Text = $"{c} {a} {b}";
                }
                else
                {
                    labelResult.Text = $"{c} {b} {a}";
                }
            }
            else
            {
                MessageBox.Show("Select ASC or DESC!");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
