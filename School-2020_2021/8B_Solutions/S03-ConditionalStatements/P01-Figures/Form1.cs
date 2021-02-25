using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_Figures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBoxPerimeter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonTriangle.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonSquare.Checked)
            {
                double a = double.Parse(textBoxA.Text);
                double area = a * a;
                double perimeter = a * 4;
                if (checkBoxArea.Checked && checkBoxPerimeter.Checked)
                {
                    MessageBox.Show($"Square area: {area:f2}\nSquare perimeter: {perimeter:f2}");
                }
                else if (checkBoxArea.Checked)
                {
                    MessageBox.Show($"Square area: {area:f2}");
                }
                else if (checkBoxPerimeter.Checked)
                {
                    MessageBox.Show($"Square perimeter: {perimeter:f2}");
                }
            }
            else if (radioButtonRectangle.Checked)
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double area = a * b;
                double perimeter = 2 * a + 2 * b;
                if (checkBoxArea.Checked && checkBoxPerimeter.Checked)
                {
                    MessageBox.Show($"Rectangle area: {area:f2}\nRectangle perimeter: {perimeter:f2}");
                }
                else if (checkBoxArea.Checked)
                {
                    MessageBox.Show($"Rectangle area: {area:f2}");
                }
                else if (checkBoxPerimeter.Checked)
                {
                    MessageBox.Show($"Rectangle perimeter: {perimeter:f2}");
                }
            }
            else if (radioButtonTriangle.Checked)
            {
                double a = double.Parse(textBoxA.Text);
                double b = double.Parse(textBoxB.Text);
                double c = double.Parse(textBoxC.Text);

                double perimeter = a + b + c;
                double semiPerimeter = perimeter / 2;
                double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

                if (checkBoxArea.Checked && checkBoxPerimeter.Checked)
                {
                    MessageBox.Show($"Triangle area: {area:f2}\nTriangle perimeter: {perimeter:f2}");
                }
                else if (checkBoxArea.Checked)
                {
                    MessageBox.Show($"Triangle area: {area:f2}");
                }
                else if (checkBoxPerimeter.Checked)
                {
                    MessageBox.Show($"Triangle perimeter: {perimeter:f2}");
                }
            }
        }

        private void radioButtonSquare_CheckedChanged(object sender, EventArgs e)
        {
            textBoxB.Visible = false;
            label2.Visible = false;

            textBoxC.Visible = false;
            label3.Visible = false;
        }

        private void radioButtonRectangle_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBoxB.Visible = true;

            textBoxC.Visible = false;
            label3.Visible = false;
        }

        private void radioButtonTriangle_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            textBoxB.Visible = true;

            textBoxC.Visible = true;
            label3.Visible = true;
        }
    }
}
