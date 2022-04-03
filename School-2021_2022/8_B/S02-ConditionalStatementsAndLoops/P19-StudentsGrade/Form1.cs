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

namespace P19_StudentsGrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Alishov\Desktop\School\School-2021_2022\8_B\S02-ConditionalStatementsAndLoops\P19-StudentsGrade\students.txt";
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line = string.Empty;
                while ((line = reader.ReadLine())!= null)
                {
                    if (line == "2") { count2++; }
                    else if (line == "3") { count3++; }
                    else if (line == "4") { count4++; }
                    else if (line == "5") { count5++; }
                    else if (line == "6") { count6++; }
                }
            }
            labelTwo.Text = count2.ToString();
            labelThree.Text = count3.ToString();
        }
    }
}
