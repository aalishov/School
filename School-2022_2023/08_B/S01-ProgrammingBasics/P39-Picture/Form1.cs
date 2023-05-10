using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P39_Picture
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


            Brush b = new SolidBrush(Color.Red);
            Point[] points= new Point[] { new Point(100,450), new Point(400, 450),new Point(250,300)};
            g.FillPolygon(b, points);

            // Grass
            Rectangle rectG = new Rectangle(0, 700, 1000, 300);
            Brush bG = new SolidBrush(Color.Green);
            g.FillRectangle(bG, rectG);

            // Dots
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                int x = r.Next(0, 1000);
                int y = r.Next(700, 1000);
                Rectangle dots = new Rectangle(x, y, 20, 20);
                Brush bDots = new SolidBrush(Color.FromArgb(r.Next(0,255),r.Next(0,255),r.Next(0,255)));

                g.FillEllipse(bDots, dots);
            }
        }
    }
}
