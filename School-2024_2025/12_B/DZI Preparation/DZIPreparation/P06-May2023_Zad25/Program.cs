using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        try
        {
            int num = int.Parse(Console.ReadLine());

            int[] digits = GetNumDigits2(num);

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

    public static int[] GetNumDigits(int num)
    {
        return Math.Abs(num).ToString()
            .ToCharArray()
            .Select(c => int.Parse(c.ToString()))
            .ToArray();
    }
    public static int[] GetNumDigits2(int num)
    {
        List<int> digits = new List<int>();

        while (num != 0)
        {
            digits.Add(num % 10);
            num = num / 10;
        }
        return digits.ToArray();
    }
}