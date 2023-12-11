namespace P01_Shape
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var Radius = int.Parse(Console.ReadLine());
            IDrawable Circle = new Circle(Radius);

            var Width = int.Parse(Console.ReadLine());
            var Height = int.Parse(Console.ReadLine());
            IDrawable Rectangle = new Rectangle(Width,Height);

            Circle.Draw();
            Rectangle.Draw();
        }
    }
}