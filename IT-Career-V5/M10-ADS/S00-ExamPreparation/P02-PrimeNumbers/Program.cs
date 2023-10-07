namespace P02_PrimeNumbers
{
    public class Program
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int primeCount = 0;
            int num = 2;
            while (count != primeCount)
            {
                if (IsPrime(num))
                {
                    primeCount++;
                    Console.WriteLine(num);
                }
                num++;
            }
        }
        public static bool IsPrime(int num)
        {
            if (num <= 1) { return false; }
            if (num == 2) { return true; }
            if (num % 2 == 0) { return false; }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}