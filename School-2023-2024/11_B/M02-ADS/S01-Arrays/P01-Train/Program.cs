public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] wagons = new int[n];
        int sum = 0;
        for  (int i = 0;i < wagons.Length; i++)
        {
            int people = int.Parse(Console.ReadLine());
            wagons[i] = people;
            sum += wagons[i];
        }
        Console.WriteLine(string.Join(" ", wagons));
        Console.WriteLine(sum);
    }
}
