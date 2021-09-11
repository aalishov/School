using System;
using System.Collections.Generic;
using System.Text;

namespace P06_IFigure
{
    public class Rectangle : IDrawable
    {
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(DrawLine(this.Width, '*', '*'));
            for (int i = 1; i < this.Height-1; i++)
            {
                sb.AppendLine(DrawLine(this.Width, '*', ' '));
            }
            sb.AppendLine(DrawLine(this.Width, '*', '*'));
            return sb.ToString().TrimEnd();
        }

        private string DrawLine(double width, char end, char mid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(end);
            for (int i = 1; i < width-1; i++)
            {
                sb.Append(mid);
            }
            sb.AppendLine(end.ToString());
            return sb.ToString().TrimEnd();
        }
    }
}
