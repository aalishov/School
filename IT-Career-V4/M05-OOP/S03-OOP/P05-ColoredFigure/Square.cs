namespace P05_ColoredFigure
{
    using System;
    public class Square : ColoredFigure
    {
        public Square(string color, double size) : base(color, size)
        {
        }

        public override double GetArea()
        {
            return Math.Pow(this.Size, 2);
        }

        public override string GetName()
        {
            return this.GetType().Name + ":";
        }
    }
}
