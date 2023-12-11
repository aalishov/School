namespace P00_DemoAbstraction
{
    public class Program
    {
        public static void Main()
        {
            //List<IPrintable> shapes= new List<IPrintable>();
            //shapes.Add(new Square(5));
            //shapes.Add(new Square(7));
            //shapes.Add(new Rectangle(5,10));
            //shapes.Add(new Rectangle(7, 10));

            //foreach (var s in shapes)
            //{
            //    Console.WriteLine(s.Print());
            //}

            //int[] nums1 = new int[] { 11, 11, 11, 25, 32, 44 };
            //List<int> nums2= new List<int>() { 11, 11, 11, 25, 32, 44 };
            //HashSet<int> nums3= new HashSet<int>() { 11,11 ,11,25, 32, 44 };
            //Stack<int> nums4 = new Stack<int>(nums1) ;
            //Queue<int> nums5 = new Queue<int>(nums1);
            //Console.WriteLine(Sum(nums1));
            //Console.WriteLine(Sum(nums2));
            //Console.WriteLine(Sum(nums3));
            //Console.WriteLine(Sum(nums4));
            //Console.WriteLine(Sum(nums5));

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square2("black",3));
            shapes.Add(new Square2("black", 10));
            shapes.Add(new Rectangle2("red", 20,9));
            shapes.Add(new Rectangle2("green", 20, 9));

            foreach (var s in shapes)
            {
                Console.WriteLine(s);
            }
        }

        public static int Sum(IEnumerable<int> nums)
        {
            int sum = 0;
            foreach (var item in nums)
            {
                sum += item;
            }
            return sum;
        }

    }
}