namespace P02_Polygon
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

            Pen blackPen = new Pen(Color.Black, 2);
            Point p1 = new Point(150, 50);
            Point p2 = new Point(0, 200);
            Point p3 = new Point(300, 200);

            Point[] points = { p1, p2, p3 };

            g.DrawPolygon(blackPen, points);

        }
    }
}
