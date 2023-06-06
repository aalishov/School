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

namespace P04_Polygon
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
        protected override void OnPaint(PaintEventArgs e)
        {
            string path = "C:\\Users\\aalis\\Desktop\\Repo\\School\\School-2022_2023\\08_B\\S02-ProgrammingAdvanced\\P04-Polygon\\points.txt";

            Graphics g = e.Graphics;

            using (StreamReader r = new StreamReader(path))
            {
                while (r.Peek() != -1)
                {
                    int[] pointInfo = r.ReadLine().Split(" ").Select(int.Parse).ToArray();
                    Point point = new Point(pointInfo[0], pointInfo[1]);
                }
            }
        }
    }
}
