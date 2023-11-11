namespace P04_EvenPowersOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            Console.WriteLine(a);
               
            for (int i = 1; i <= n; i+=1)
            {
                a *= 2;
                if (i % 2 ==0)
                {
                    Console.WriteLine(a);
                } 
            }
        }
    }
}