namespace P03_Figures
{
    using System.Text;
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get; set; }

        public double Width { get; set; }

        public override double CalculateArea()
        {
            return this.Width*this.Height;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 2 + this.Height * 2;
        }

        public override string Draw()
        {

            StringBuilder sb = new StringBuilder();
            DrawLine(sb, this.Width, '*', '*');
            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(sb, this.Width, '*', ' ');
            }
            DrawLine(sb, this.Width, '*', '*');

            return sb.ToString().TrimEnd();
        }

        private void DrawLine(StringBuilder sb, double width, char end, char mid)
        {
            sb.Append(end);
            for (int i = 1; i < width - 1; ++i)
            {
                sb.Append(mid);
            }
            sb.AppendLine(end.ToString());
        }
    }
}
