namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sign(5);
            Sign(-5);
            Sign(0);
        }
        public static void Sign(int n)
        {
            if(n > 0)
            {
                Console.WriteLine($"The number {n} is positive");
            }
            else if(n < 0)
            {
                Console.WriteLine($"The number {n} is negative");
            }
            else
            {
                Console.WriteLine($"The number {n} is zero");
            }
        }
    }
}