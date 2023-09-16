using System.Data;

public class Program
{
    public static void Main()
    {
        IDrawable s1 = new Rectangle() { Width = 5, Height = 5 };
        IDrawable s2 = new Rectangle() { Height = 3, Width = 6 };
        IDrawable s3 = new Circle() { Radius = 3 };
        IDrawable s4 = new Circle() { Radius = 5 };

        List<IDrawable> s = new List<IDrawable>() { s1, s2, s3, s4 };

        foreach (var shape in s)
        {
            shape.Draw();
        }
    }
}
