using System;
using System.Collections.Generic;
using System.Text;

namespace P08_ExInterfaceFigures
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

        public string Print()
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
