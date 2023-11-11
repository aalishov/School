namespace P09_MultiplyEvensByOdds
{
    public class Program
    {
        public static void Main()
        {
            int num=int.Parse(Console.ReadLine());
            int result=  GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(num), GetSumOfOddDigits(num));
            Console.WriteLine(result);
        }

        public static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int result = num % 10;

                if (result % 2 == 0)
                {
                    sum += result;
                }
                num /= 10;
            }
            return sum;
        }
        public static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int result = num % 10;

                if (result % 2 != 0)
                {
                    sum += result;
                }
                num /= 10;
            }
            return sum;
        }

        public static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            return even * odd;
        }
    }
}