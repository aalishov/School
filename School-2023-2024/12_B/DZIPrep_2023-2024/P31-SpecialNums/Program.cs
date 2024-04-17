public class Program
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());
        for (int i = startNum; i <= endNum; i++)
        {
            if (IsSpecial(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool IsSpecial(int n)
    {
        char[] digits = n.ToString().ToCharArray();
        for (int i = 0; i < digits.Length - 1; i++)
        {
            int current = digits[i];
            int next = digits[i + 1];
            if (Math.Abs(current - next) != 1)
            {
                return false;
            }
        }
        return true;
    }
}