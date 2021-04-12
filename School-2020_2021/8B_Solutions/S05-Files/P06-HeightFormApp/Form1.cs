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

namespace P06_HeightFormApp
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

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S05-Files\P06-HeightFormApp\students.txt";

            int maxNum = 0, maxHeight = 0;
            string line = "";

            using (StreamReader r = new StreamReader(path, Encoding.UTF8))
            {
                while ((line = r.ReadLine()) != null)
                {
                    //1,175
                    string[] info = line.Split(',');
                    int num = int.Parse(info[0]);
                    int height = int.Parse(info[1]);

                    if (height > maxHeight)
                    {
                        maxHeight = height;
                        maxNum = num;
                    }
                }
            }

            label1.Text = $"Най-високият ученик от класа е с номер {maxNum}{Environment.NewLine}и е висок {maxHeight} см.";
        }
    }
}
