using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_DrawRandomPolygon
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
            Graphics g = e.Graphics;
            g.Clear(Color.Chartreuse);

            Pen pen = new Pen(Color.Red, 3);
            Brush brush = new SolidBrush(Color.Yellow);

            Random random = new Random();

            Point[] points = new Point[5];

            for (int i = 0; i < points.Length; i++)
            {
                int x = random.Next(0, 1000);
                int y = random.Next(0, 1000);
                points[i] = new Point(x,y);
            }

            g.DrawPolygon(pen, points);
            g.FillPolygon(brush, points);
        }
    }
}
