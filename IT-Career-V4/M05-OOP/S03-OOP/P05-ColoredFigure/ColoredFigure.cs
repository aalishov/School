using System;

namespace P05_ColoredFigure
{
    public abstract class ColoredFigure
    {
        protected ColoredFigure(string color, double size)
        {
            this.Color = color;
            this.Size = size;
        }

        public string Color { get; set; }

        public double Size { get; set; }

        public string Show()
        {
            return $"Color: {this.Color}{Environment.NewLine}Size: {this.Size:f2}";
        }

        public abstract double GetArea();

        public abstract string GetName();
    }
}
