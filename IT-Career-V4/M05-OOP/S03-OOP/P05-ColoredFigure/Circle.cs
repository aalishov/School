namespace P05_ColoredFigure
{
    using System;
    public class Circle : ColoredFigure
    {
        public Circle(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(this.Size, 2);
        }

        public override string GetName()
        {
            return this.GetType().Name + ":";
        }
    }
}
