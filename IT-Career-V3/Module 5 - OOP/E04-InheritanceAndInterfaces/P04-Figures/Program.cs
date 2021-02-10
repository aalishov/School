namespace P04_Figures
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            IDrawable rectangle = new Rectangle() { Height = 5, Widht = 8 };
            IDrawable circle = new Circle() { Radius = 8 };

            List<IDrawable> figures = new List<IDrawable>();
            figures.Add(rectangle);
            figures.Add(circle);

            foreach (var figure in figures)
            {
                figure.Draw();
                Console.WriteLine(new string('-',40));
            }
        }
    }
}
