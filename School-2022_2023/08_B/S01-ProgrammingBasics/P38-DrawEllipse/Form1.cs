using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P38_DrawEllipse
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

            g.Clear(Color.Yellow);

            Pen p = new Pen(Color.Black, 3);
            Brush b = new SolidBrush(Color.Red);

            g.DrawEllipse(p, 50, 50, 300, 100);
            g.DrawRectangle(p, 50, 50, 300, 100);
            g.FillRectangle(b, 50, 50, 300, 100);

            Rectangle r = new Rectangle(50, 200, 200, 200);
            g.DrawEllipse(p, r);
            g.FillEllipse(b, r);
        }
    }
}
