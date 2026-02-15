public class Program
{
    public static void Main()
    {
        
        List<int> list = new List<int>(5);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(3);
        list.Add(3);
        list.Add(3);
        list.Remove(3);
        list.Insert(0, 10);
        list.Insert(list.Count/2, 20);

       //List<double> grades = Console.ReadLine().Split(" ").Select(double.Parse).ToList();

        Console.WriteLine($"Length: {list.Count}");
        Console.WriteLine($"Capacity: {list.Capacity}");
        Console.WriteLine(string.Join(", ",list));

        List<int> first= Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        List<int> second = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        List<int> result = first.Concat(second).OrderBy(x=>x).ToList();
        Console.WriteLine(string.Join(", ",result));
    }
}

