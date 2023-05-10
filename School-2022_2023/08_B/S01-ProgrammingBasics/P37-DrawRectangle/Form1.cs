using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P37_DrawRectangle
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

            g.Clear(Color.White);

            Pen p = new Pen(Color.Black, 5);
            Pen p1 = new Pen(Color.Red, 3);

            g.DrawRectangle(p, 50, 50, 250, 100);

            g.DrawRectangle(p, 300, 150, 150, 300);

            Rectangle r = new Rectangle(50, 200, 50, 50);

            g.DrawRectangle(p1, r);
        }
    }
}
