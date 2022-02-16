using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_ShapesArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Shape Area Calculator";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double area = 0;
            string shape = string.Empty;
            if (rbTriangle.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                double ha = double.Parse(tbSecondInput.Text);
                area = a * ha / 2;
                shape = rbTriangle.Text;
            }
            else if (rbSquare.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                area = a * a;
                shape = rbSquare.Text;
            }
            else if (rbRectangle.Checked)
            {
                double a = double.Parse(tbFirstInput.Text);
                double b = double.Parse(tbSecondInput.Text);
                area = a * b;
                shape = rbRectangle.Text;
            }

            labelResult.Text = $"{shape} area: {area:f3}";
        }

        private void rbSquare_CheckedChanged(object sender, EventArgs e)
        {
            ShowHide(false);
        }

        private void rbTriangle_CheckedChanged(object sender, EventArgs e)
        {
            ShowHide(true);
            labelSecondInput.Text = "ha=";
        }

        private void rbRectangle_CheckedChanged(object sender, EventArgs e)
        {
            ShowHide(true);
            labelSecondInput.Text = "  b=";
        }
        private void ShowHide(bool isVisible)
        {
            labelSecondInput.Visible = isVisible;
            tbSecondInput.Visible = isVisible;
        }
    }
}
