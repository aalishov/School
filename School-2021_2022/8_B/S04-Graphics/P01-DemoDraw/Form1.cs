using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_DemoDraw
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
            //Създаване на чертожно поле
            Graphics g = e.Graphics;
            //Задаване цвят на чертожното поле
            g.Clear(Color.White);

            //Създаваме писалка
            Pen blackPen = new Pen(Color.Black, 20);
            Pen bluePen = new Pen(Color.Blue, 1);
            //Създаваме точки
            Point a = new Point(0, 0);
            Point b = new Point(200, 200);
            //Изчертаваме линия
            g.DrawLine(blackPen, a, b);
        }
    }
}
