public class Program
{
    public static void Main()
    {
        int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Stack<int> box = new Stack<int>(line);
        int rackCapacity = int.Parse(Console.ReadLine());

        int rackCount = 1;
        int currentRackCapacity = rackCapacity;

        while (box.Count > 0)
        {
            int cloth = box.Peek();
            if (currentRackCapacity >= cloth)
            {
                currentRackCapacity -= cloth;
                box.Pop();
            }
            else
            {
                currentRackCapacity = rackCapacity;
                rackCount++;
            }
        }
        Console.WriteLine(rackCount);
    }
}