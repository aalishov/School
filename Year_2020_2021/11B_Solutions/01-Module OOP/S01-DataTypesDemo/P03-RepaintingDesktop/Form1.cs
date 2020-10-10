using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_RepaintingDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal nylonPrice = 1.50m;
            const decimal pricePaint = 14.50m;
            const decimal paintThinnerPrice = 5m;

            int nylon = int.Parse(textBox1.Text);
            int paint = int.Parse(textBox2.Text);
            int paintThinner = int.Parse(textBox3.Text);
            int hours = int.Parse(textBox4.Text);

            nylon += 2;

            decimal nylonExpenses = nylon * nylonPrice;

            double nPaint = paint * 1.1;

            decimal paintExpenses = (decimal)nPaint * pricePaint;
            decimal tinnerExpenses = paintThinner * paintThinnerPrice;

            decimal totalExpenses = nylonExpenses + paintExpenses + tinnerExpenses + 0.40m;

            decimal workerExpenses = totalExpenses * 0.3m * hours;

            totalExpenses += workerExpenses;

            label6.Text = $"{totalExpenses:f2}";
        }
    }
}
