public class Program
{
    public static void Main()
    {
        string[] products = Console.ReadLine().Split(" ").ToArray();
        long[] qiantity = Console.ReadLine().Split(" ").Select(long.Parse).ToArray();
        double[] price = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

        while (true)
        {
            string product = Console.ReadLine();
            if (product == "done") { break; }

            int index = -1;

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] == product)
                {
                    index = i; break;
                }
            }
            Console.WriteLine($"{products[index]} costs: {price[index]:f2}; Available quantity: {qiantity[index]}");
        }
    }
}

