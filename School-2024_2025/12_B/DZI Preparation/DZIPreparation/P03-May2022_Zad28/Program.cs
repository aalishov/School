public class Program
{
    public static void Main()
    {
        string path = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());

        List<int> list = GetNumbers(path);
        RemoveItems(list, k);
        list = SortItems(list);
        Console.WriteLine(string.Join(", ", list));
    }

    public static List<int> GetNumbers(string path)
    {
        return File.ReadLines(path).Select(int.Parse).ToList();
    }
    public static List<int> SortItems(List<int> items)
    {
        return items.OrderBy(x => GetNumberSum(x)).ToList();
    }

    public static void RemoveItems(List<int> items, int k)
    {
        items.RemoveAll(i => GetNumberSum(i) % k == 0);
    }

    public static int GetNumberSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number = number / 10;
        }
        return sum;
    }
}