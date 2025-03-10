public class Program
{

    public static void Main()
    {
		try
		{
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            foreach (var kvp in dic)
            {
                Console.WriteLine($"число: {kvp.Key}, брой: {kvp.Value}");
            }
        }
		catch (Exception ex)
		{
            Console.WriteLine(ex.Message);
		}
    }
}

