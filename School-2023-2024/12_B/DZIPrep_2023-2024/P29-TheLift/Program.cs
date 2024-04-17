public class Program
{
    public static void Main(string[] args)
    {
        int peopleWaiting = int.Parse(Console.ReadLine());
        List<int> lift = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

        for (int i = 0; i < lift.Count; i++)
        {
            int freeSpace = 4 - lift[i];


            if (freeSpace <= peopleWaiting)
            {
                lift[i] += freeSpace;
                peopleWaiting -= freeSpace;
            }
            else
            {
                lift[i] += peopleWaiting;
                peopleWaiting = 0;
            }
        }
        if (lift.Any(x => x != 4))
        {
            Console.WriteLine($"The lift has empty spots!");
            Console.WriteLine(string.Join(" ", lift));
        }
        else if (peopleWaiting > 0)
        {
            Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            Console.WriteLine(string.Join(" ", lift));
        }
        else
        {
            Console.WriteLine(string.Join(" ", lift));
        }
    }
}

