using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P36_Squares
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
            Pen pen = new Pen(Color.Red, 2);

            int n = 30, m = 30;
            //изчертаване на първия триъгълник
            int side = 500;
            int x1 = 100, y1 = side; ;
            int x2 = x1 + side, y2 = y1;
            int x3 = x2, y3 = y2 - side;
            int x4 = x1, y4 = y1 - side;
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x4, y4);
            g.DrawLine(pen, x4, y4, x1, y1);

            x1 = 100 + side / 2; y1 = side; ;
            x2 = x1 + side; y2 = y1;
            x3 = x2; y3 = y2 - side;
            x4 = x1; y4 = y1 - side;
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x2, y2, x3, y3);
            g.DrawLine(pen, x3, y3, x4, y4);
            g.DrawLine(pen, x4, y4, x1, y1);

            //изчертаване на вписаните триъгълници
          
        }
    }
}
