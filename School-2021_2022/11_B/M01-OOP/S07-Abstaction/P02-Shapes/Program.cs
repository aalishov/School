using System.Collections.Generic;

namespace P02_Shapes
{
    public class Program
    {
        public static void Main()
        {
            Circle c = new Circle() { Radius = 3 };
            IDrawable r = new Rectangle() { Width = 8, Height = 5 };
            List<IDrawable> shapes = new List<IDrawable>();
            shapes.Add(c);
            shapes.Add(r);

            foreach (var e in shapes)
            {
                e.Draw();
            }
        }
    }
}