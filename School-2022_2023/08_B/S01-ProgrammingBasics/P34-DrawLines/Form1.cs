using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P34_DrawLines
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

            Pen blackPen = new Pen(Color.Black, 3);
            Pen redPen = new Pen(Color.Red, 7);
            Pen bluePen = new Pen(Color.Blue, 7);

            g.DrawLine(blackPen, 10, 10, 250, 250);
            g.DrawLine(redPen, 10, 30, 250, 270);
            g.DrawLine(blackPen, 10, 50, 250, 50);
            g.DrawLine(bluePen, 100, 10, 550, 10);
            g.DrawLine(redPen, 20, 10, 70, 600);

            Random rnd = new Random();
            
            for (int i = 0; i < 30; i++)
            {
                int red=rnd.Next(0,255);
                int green=rnd.Next(0,255);
                int blue=rnd.Next(0,255);
                Pen randomPen = new Pen(Color.FromArgb(red,green,blue),20);
                g.DrawLine(randomPen, 20, 20*i, 600, 20*i);
            }
        }
    }
}
