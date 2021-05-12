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

namespace Ex_3_p_130
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
            string path = @"D:\GIT\School\School-2020_2021\Blagova\Class8-2020_2021\Ex_3_p_130\points.txt";

            int pointsCount = 0;
            using (StreamReader reader= new StreamReader(path))
            {
                while (!(reader.ReadLine()==null))
                {
                    pointsCount++;
                }
            }

            Point[] points = new Point[pointsCount];

            using (StreamReader reader = new StreamReader(path))
            {
                for (int i = 0; i < pointsCount; i++)
                {
                    string[] info = reader.ReadLine().Split(' ');
                    int x = int.Parse(info[0]);
                    int y = int.Parse(info[1]);
                    points[i] = new Point(x, y);
                }
            }

            Graphics g = e.Graphics;
            g.Clear(Color.CadetBlue);

            Pen pen = new Pen(Color.Red, 3);
            Brush brush = new SolidBrush(Color.Yellow);

            g.DrawPolygon(pen, points);
            g.FillPolygon(brush,points);
        }
    }
}
