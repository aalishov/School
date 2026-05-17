public class Program
{
    public static void Main()
    {
        ArrayList<int> list = new ArrayList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        ArrayList<char> symbols = new ArrayList<char>();
        Console.WriteLine($"Count: {list.Count}");
        

        List<int> nums = new List<int> { 1, 2, 3 };


        foreach (var n in list)
        {
            Console.WriteLine(n);
        }
       
    }
}

