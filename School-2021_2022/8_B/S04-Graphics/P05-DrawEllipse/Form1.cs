using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_DrawEllipse
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
            g.Clear(Color.FromArgb(0, 255, 255));
            Pen pen = new Pen(Color.Red, 2);
            Pen pen2 = new Pen(Color.Black, 2);
            Rectangle rectangle = new Rectangle(new Point(50, 50), new Size(200, 500));
            g.DrawRectangle(pen, rectangle);
            g.DrawEllipse(pen2, rectangle);
        }
    }
}
