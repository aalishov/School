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

namespace P04_Grades
{
    public partial class Form1 : Form
    {
        private int countTwo = 0;
        private int countThree = 0;
        private int countFour = 0;
        private int countFive = 0;
        private int countSix = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int totalCount = countTwo + countThree + countFour + countFive + countSix;
            if (totalCount == 0)
            {
                MessageBox.Show("Няма оценки!");
            }
            else
            {
                double average = (countTwo * 2.0 + countThree * 3.0 + countFour * 4.0 + countFive * 5.0 + countSix * 6.0) / (totalCount);
                labelAverage.Text = $"{average:f2}";
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S05-Files\P04-Grades\students.txt";
            
            countTwo = 0;
            countThree = 0;
            countFour = 0;
            countFive = 0;
            countSix = 0;

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null) { break; }

                    if (line == "2") { countTwo++; }
                    else if (line == "3") { countThree++; }
                    else if (line == "4") { countFour++; }
                    else if (line == "5") { countFive++; }
                    else if (line == "6") { countSix++; }
                }
                reader.Close();
            }

            labelTwo.Text = countTwo.ToString();
            labelThree.Text = countThree.ToString();
            labelFour.Text = countFour.ToString();
            labelFive.Text = countFive.ToString();
            labelSix.Text = countSix.ToString();
        }
    }
}
