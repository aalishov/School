using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08_House
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
            g.Clear(Color.Wheat);


            //Grass
            Brush greenBrush = new SolidBrush(Color.Green);
            Rectangle grass = new Rectangle(0, 400, 1000, 200);
            g.FillRectangle(greenBrush, grass);

            for (int i = 0; i < 70; i++)
            {
                Random r = new Random();
                Brush randBrush = new SolidBrush(Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)));
                Rectangle dot = new Rectangle(r.Next(10, 990), r.Next(410, 590), 10, 10);
                g.FillEllipse(randBrush, dot);
            }
            //Sun
            Brush sunBrush = new SolidBrush(Color.Yellow);
            Rectangle sunRect = new Rectangle(20, 10, 80, 80);
            g.FillEllipse(sunBrush, sunRect);
        }
    }
}
