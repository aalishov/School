namespace P04_EvenTimes
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map[num] = 1;
                }
            }
            foreach (var item in map)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
