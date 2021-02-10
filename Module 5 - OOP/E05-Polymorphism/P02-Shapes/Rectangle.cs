using System;
using System.Collections.Generic;
using System.Text;

namespace P02_Shapes
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public override string CalculateArea()
        {
            return $"Rectangle area: {Width * Height}";
        }

        public override string CalculatePerimeter()
        {
            return $"Rectangle perimeter: {Width*2 + Height*2}";
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder(base.Draw());
            for (int i = 0; i < this.Height; i++)
            {
                sb.AppendLine($"{new string('*', this.Width)}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
