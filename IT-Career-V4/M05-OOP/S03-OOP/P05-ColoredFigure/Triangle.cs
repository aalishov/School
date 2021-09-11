namespace P05_ColoredFigure
{
    using System;
    public class Triangle : ColoredFigure
    {
        public Triangle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return (Math.Pow(this.Size, 2) * Math.Sqrt(3)) / 4;
        }

        public override string GetName()
        {
            return this.GetType().Name+":";
        }
    }
}
