using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_SeriesCalculatorWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Име на филм: ";
            label2.Text = "Брой сезони: ";
            label3.Text = "Брой епизоди: ";
            label4.Text = "Продължителност: ";
            label5.Text = "-";
            button1.Text = "Изчисли";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string name = textBox1.Text;          
            int numOfSeason = int.Parse(textBox2.Text);           
            int numOfEpisodes = int.Parse(textBox3.Text);          
            double time = double.Parse(textBox4.Text);

            double adTimePerEpisode = 0.2 * time;

            time += adTimePerEpisode;

            double specialEpisodeTime = 10 * numOfSeason;

            double totalTime = time * numOfEpisodes * numOfSeason + specialEpisodeTime;

            label5.Text=$"Total time needed to watch the {name} series is {Math.Floor(totalTime)} minutes.";
        }
    }
}
