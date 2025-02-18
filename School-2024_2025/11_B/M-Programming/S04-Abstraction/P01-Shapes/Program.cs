namespace P01_Shapes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int radius = int.Parse(Console.ReadLine());
            //IDrawable circle = new Circle(radius);

            //int width = int.Parse(Console.ReadLine());
            //int height = int.Parse(Console.ReadLine());
            //IDrawable rectangle = new Rectangle(height, width);

            //circle.Draw();
            //rectangle.Draw();

            int[] nums = { 1, 2, 3, 4, 5, };
            List<int> list = new List<int>{8,12,2,1,211};

            Console.WriteLine(Sum(nums));
            Console.WriteLine(Sum(list));
        }

        public static int Sum(IEnumerable<int> arr)
        {
            int sum = 0;
            foreach (int i in arr) { sum += i; }
            return sum;
        }
        

    }
}
