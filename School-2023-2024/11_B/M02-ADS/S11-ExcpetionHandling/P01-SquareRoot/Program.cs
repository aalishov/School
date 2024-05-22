using System.Data;

namespace P01_SquareRoot
{
    public class Program
    {
        public static void Main(string[] args)
        {
			try
			{
				int num=int.Parse(Console.ReadLine());
				if (num <= 0) 
				{
					throw new ArithmeticException("Invalid number!");
				}
                Console.WriteLine(Math.Sqrt(num));
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);

            }
			finally 
			{
                Console.WriteLine("Good bye!");
            }
        }
    }
}
