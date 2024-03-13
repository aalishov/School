namespace P01_QueueOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).Take(n).ToArray();
            Queue<int> q = new Queue<int>(nums);
            for (int i = 0; i < s; i++)
            {
                q.Dequeue();
            }
            
            if (q.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (q.Count==0)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = int.MaxValue;
                for (int i = 0; i < q.Count; i++)
                {
                    if (min > q.Dequeue())
                    {
                        min = q.Dequeue();
                    }
                }
                Console.WriteLine(min);
            }
        }
    }
}
