using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRL2_1901181004
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
            Random r = new Random();
            Graphics g = e.Graphics;
            g.Clear(Color.AliceBlue);
            Pen pen = new Pen(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)), r.Next(2, 8));
            g.DrawRectangle(pen, new Rectangle(10, 10, 500, 250));
            g.DrawEllipse(pen, 10, 10, 500, 250);

            for (int i = 20; i <=260; i+=20)
            {
                Pen ePen=new Pen(Color.FromArgb(r.Next(0,255), r.Next(0, 255), r.Next(0, 255)),r.Next(2,8));
                g.DrawEllipse(ePen, 10+i, 10+i/2, 500-i*2, 250-i);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
