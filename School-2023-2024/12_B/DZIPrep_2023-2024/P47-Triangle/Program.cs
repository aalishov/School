public class Program
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());
        //List<int> elements = new List<int>() {n};
        //for (int i = n - 1; i >= 0; i--)
        //{
        //    Console.WriteLine($"{string.Join(" ", elements)}");
        //    elements.Insert(0, i);
        //}
        int n = int.Parse(Console.ReadLine());
        string[] elements = new string[n];
        for (int i = 0; i < n - 1; i++)
        {
            elements[i] = " ";
        }
        elements[n-1]=n.ToString();
        for (int i = n - 1; i > 0; i--)
        {
            Console.WriteLine($"{string.Join(" ", elements)}");
            elements[i-1] = $"{i - 1}";
        }
    }
}
