public class Program
{
    private static Dictionary<int, int> numCounter = new Dictionary<int, int>();
    public static void Main()
    {        
        CountNumbers(ReadNumber("Enter elements count: "));

        PrintOutput();
    }

    private static void PrintOutput()
    {
        foreach (var item in numCounter)
        {
            Console.WriteLine($"number: {item.Key}, count:{item.Value}");
        }
    }
    private static void CountNumbers(int count)
    {
        for (int i = 0; i < count; i++)
        {
            int number = ReadNumber();
            if (numCounter.ContainsKey(number)) {  numCounter[number]++; }
            else {   numCounter.Add(number, 1);  }
        }
    }
    public static int ReadNumber(string message = "Enter number: ")
    {
        while (true)
        {
            try
            {
                Console.Write(message);
                int number = int.Parse(Console.ReadLine());
                if (number > 0)
                {
                    return number;
                }
                throw new Exception("Number is zero or negative!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\tError! {ex.Message}");
                Console.WriteLine("\tPlease enter positive number!");
            }
        }
    }
}
