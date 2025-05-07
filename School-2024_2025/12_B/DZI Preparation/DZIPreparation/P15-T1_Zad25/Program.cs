public class Program
{
    public static void Main()
    {
        try
        {
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                throw new ArgumentException("Something went wrong!");
            }
            int[] digits = num.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            foreach (int digit in digits)
            {
                if (num % digit != 0)
                {
                    Console.WriteLine("No");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Yes");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
}