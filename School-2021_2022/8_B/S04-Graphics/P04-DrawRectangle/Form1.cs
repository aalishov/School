using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_DrawRectangle
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
            g.Clear(Color.AliceBlue);

            Pen pen = new Pen(Color.IndianRed, 2);
            Point a = new Point(50, 50);
            Size size = new Size(400, 200);
            Rectangle r = new Rectangle(a, size);

            g.DrawRectangle(pen, r);
            g.DrawRectangle(pen, 100, 100, 50, 100);
        }
    }
}
