public class Program
{
    public static void Main()
    {
        List<string> input = Console.ReadLine().Split(" ").ToList();
        double sum = 0;
        foreach (var item in input)
        {
            char firstLetter = item[0];
            double number = double.Parse(item.Substring(1, item.Length - 2));
            double result = number;
            char lastLetter = item[item.Length - 1];
            if (char.IsUpper(firstLetter))
            {
                double letterPosition = (int)firstLetter - 64;
                result /= letterPosition;
            }
            else
            {
                double letterPosition = (int)firstLetter - 96;
                result *= letterPosition;
            }
            if (char.IsUpper(lastLetter))
            {
                double letterPosition = (int)lastLetter - 64;
                result -= letterPosition;
            }
            else
            {
                double letterPosition = (int)lastLetter - 96;
                result += letterPosition;
            }
            sum += result;
        }
        Console.WriteLine($"{sum:f2}");
    }
    public static int GetPosition(char letter)
    {
        int num = 1;
        for (char i = 'a'; i <= 'z'; i++)
        {
            if (i ==letter)
            {
                return num;
            }
            num++;
        }
        num = 1;
        for (char i = 'A'; i <= 'Z'; i++)
        {
            if (i == letter)
            {
                return num;
            }
            num++;
        }
        return -1;
    }
}