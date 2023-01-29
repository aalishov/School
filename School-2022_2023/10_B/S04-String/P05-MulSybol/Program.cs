public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');

        string first = input[0];
        string second = input[1];

        int result = 0;
        int min = Math.Min(first.Length, second.Length);

        for (int i = 0; i < min; i++)
        {
            int product = first[i] * second[i];
            result += product;
        }

        if (first.Length > min)
        {
            for (int i = min; i < first.Length; i++)
            {
                result += first[i];
            }
        }
        else if (second.Length > min)
        {
            for (int i = min; i < second.Length; i++)
            {
                result += second[i];
            }
        }

        Console.WriteLine(result);
    }
}
