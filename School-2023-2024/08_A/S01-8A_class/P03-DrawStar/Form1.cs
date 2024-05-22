namespace P03_DrawStar
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
            Pen p = new Pen(Color.Black, 2);
            int cx = 150;
            int cy = 100;
            

            for (int j = 1; j < 5; j++)
            {
                Point[] point = new Point[5];
                cx *= j;
                cy *= j;

                for (int i = 0; i < 5; i++)
                {
                    double angle = (i * 0.8 - 0.5) * Math.PI;
                    point[i] = new Point((int)(cx * (0.25 + 0.24 * Math.Cos(angle))), (int)(cy * (0.5 + 0.48 * Math.Sin(angle))));
                }

                g.DrawPolygon(p, point);
            }
        }
    }
}
