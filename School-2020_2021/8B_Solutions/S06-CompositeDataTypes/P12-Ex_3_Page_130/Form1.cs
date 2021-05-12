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

namespace P12_Ex_3_Page_130
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
            string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S06-CompositeDataTypes\P12-Ex_3_Page_130\points.txt";

            Graphics g = e.Graphics;
            g.Clear(Color.BurlyWood);

            int pointCounter = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine()!=null)
                {
                    pointCounter++;
                }
            }

            Point[] points = new Point[pointCounter];

            using (StreamReader reader= new StreamReader(path))
            {
                for (int i = 0; i < points.Length; i++)
                {
                    int[] coordinates = reader.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
                    int x = coordinates[0];
                    int y = coordinates[1];

                    points[i] = new Point(x,y);
                }
            }

            Pen pen = new Pen(Color.White, 3);
            Brush brush = new SolidBrush(Color.Green);

            g.DrawPolygon(pen, points);
            g.FillPolygon(brush, points);
        }
    }
}
