public class Program
{
    static void Main()
    {
        List<int> nums = new List<int>();
        int start = 1;
        while (nums.Count < 10)
        {
            try
            {              
              start = ReadNumber(start, 100);
              nums.Add(start);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine(string.Join(", ", nums));
    }
    static int ReadNumber(int start, int end)
    {
        int n = int.Parse(Console.ReadLine());

        if (n <= start || n >= end)
        {
            throw new ArgumentException($"Your number is not in range ({start} - {end})");

        }
        return n;
    }
}

