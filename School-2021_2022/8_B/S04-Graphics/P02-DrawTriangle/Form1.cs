using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_DrawTriangle
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
            g.Clear(Color.Black);
            Pen pen = new Pen(Color.Pink,3);

            Point a = new Point(50, 100);
            Point b = new Point(100, 200);
            Point c = new Point(200, 180);

            for (int i = 0; i < 500; i+=50)
            {
               
                g.DrawLine(pen, a,b);
                g.DrawLine(pen, b, c);
                g.DrawLine(pen, c, a);
            }
        }
    }
}
