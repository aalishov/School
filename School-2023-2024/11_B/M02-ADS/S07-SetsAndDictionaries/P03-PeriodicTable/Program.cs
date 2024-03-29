public class Program
{
    public static void Main()
    {
        SortedSet<string> uniqueElements = new SortedSet<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] compounds = Console.ReadLine().Split(' '); //O H , K Mn, Mg K O
            foreach (string compound in compounds)
            {
                uniqueElements.Add(compound);
            }
        }

        Console.WriteLine(string.Join(" ", uniqueElements));
    }
}
