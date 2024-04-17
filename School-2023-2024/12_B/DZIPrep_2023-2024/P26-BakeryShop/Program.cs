namespace P16_BakeryShop
{

    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> foods = new Dictionary<string, int>();
            string[] cmd = Console.ReadLine().Split(" ").ToArray();
            int sum = 0;
            while (cmd[0] != "Complete")
            {
                if (cmd[0] == "Receive")
                {
                    if (int.Parse(cmd[1])<=0)
                    {
                        continue;
                    }
                    if (!foods.ContainsKey(cmd[0]))
                    {
                        foods.Add(cmd[2], int.Parse(cmd[1]));
                    }
                    else
                    {

                        foods[cmd[2]] += int.Parse(cmd[1]);
                    }
                }
                else if (cmd[0] == "Sell")
                {
                    if (!foods.ContainsKey(cmd[2]))
                    {
                        Console.WriteLine($"You do not have any {cmd[2]}.");
                    }
                    else 
                    {
                        if (foods[cmd[2]] < int.Parse(cmd[1]))
                        {
                            
                            Console.WriteLine($"There aren't enough {cmd[2]}. You sold the last {foods[cmd[2]]} of them.");
                            sum += foods[cmd[2]];
                            foods.Remove(cmd[2]);
                        }
                        else
                        {
                            foods[cmd[2]] -= int.Parse(cmd[1]);
                            Console.WriteLine($"You sold {cmd[1]} {cmd[2]}.");
                            sum += int.Parse(cmd[1]);
                            if (foods[cmd[2]] == 0)
                            {
                                foods.Remove(cmd[2]);
                            }
                        }
                    }
                }
                cmd = Console.ReadLine().Split(" ").ToArray();
            }
            foreach (var food in foods)
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }
            Console.WriteLine($"All sold: {sum} goods");
        }
    }
}
