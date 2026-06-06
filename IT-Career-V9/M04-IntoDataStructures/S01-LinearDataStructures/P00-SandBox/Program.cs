namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> A = new List<int>() { 2, 3, 7, 6, 8, 9 };
            //List<int> B = new List<int>() { 3, 4, 1 };

            //List<int> union = new List<int>();
            //List<int> intersection = new List<int>();

            //union = B.Union(A).ToList();
            //Console.WriteLine(string.Join(", ", union));
            //intersection = B.Intersect(A).ToList();
            //Console.WriteLine(string.Join(", ", intersection));

            Book b = new Book("C# in Depth");
        }

        public class Book
        {
            private string name;

            public Book(string name)
            {
                Name = name;
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
    }
}
