using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_FillShapes
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

            Pen blackPen = new Pen(Color.Black, 2);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush blueBrush = new SolidBrush(Color.Blue);

            Rectangle rect = new Rectangle(10, 10, 300, 150);

            //g.DrawRectangle(blackPen, rect);
            g.FillRectangle(redBrush, rect);
            g.FillEllipse(blueBrush, rect);
        }
    }
}
