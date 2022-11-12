using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06_DrawArc
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

            Pen pen = new Pen(Color.Red, 2);
            Pen pen2 = new Pen(Color.Black, 2);
            Pen pen3 = new Pen(Color.Black, 2);

            Rectangle r = new Rectangle(50, 50, 300, 300);


            g.DrawRectangle(pen, r);
            g.DrawArc(pen, r, 0, 60);
            
        }
    }
}
