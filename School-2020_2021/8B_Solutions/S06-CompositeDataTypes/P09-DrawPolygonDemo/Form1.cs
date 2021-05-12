using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09_DrawPolygonDemo
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
            g.Clear(Color.BlanchedAlmond);

            Pen p = new Pen(Color.Red, 3);
            Brush b = new SolidBrush(Color.Yellow);

            Point[] points = new Point[]
            {
                new Point(10, 10),
                new Point(300, 5),
                new Point(25, 300),
                new Point(800, 25),
                 new Point(450, 450),
                 new Point(450, 450),
                new Point(800, 900),
                new Point(269, 345)
             };

            g.DrawPolygon(p, points);
            g.FillPolygon(b, points);
        }
    }
}
