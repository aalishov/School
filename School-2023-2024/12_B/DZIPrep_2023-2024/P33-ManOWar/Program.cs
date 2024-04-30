public class Program
{
    static void Main()
    {
        List<int> ship = Console.ReadLine().Split(">").Select(int.Parse).ToList();
        List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
        int healthCapacity = int.Parse(Console.ReadLine());

        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];
            switch (cmd)
            {
                case "Fire":
                    int index = int.Parse(input[1]);
                    int damage = int.Parse(input[2]);
                    if (index < 0 || index >= warShip.Count)
                    {
                        continue;
                    }
                    warShip[index] -= damage;
                    if (warShip[index] <= 0)
                    {
                        Console.WriteLine("You won! The enemy ship has sunken.");
                        Environment.Exit(0);
                    }
                    break;
                case "Defend":
                    int startindex = int.Parse(input[1]);
                    int endindex = int.Parse(input[2]);
                    damage = int.Parse(input[3]);
                    if (startindex < 0 || endindex >= ship.Count || startindex > endindex)
                    {
                        continue;
                    }
                    for (int i = startindex; i <= endindex; i++)
                    {
                        ship[i] -= damage;
                        if (ship[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            Environment.Exit(0);
                        }
                    }
                    break;
                case "Repair":
                    index = int.Parse(input[1]);
                    int health = int.Parse(input[2]);
                    if (index>0 && index<ship.Count)
                    {
                        if (ship[index] + health < healthCapacity)
                        {
                            ship[index] += health;
                        }
                        else
                        {
                            ship[index] = healthCapacity;
                        }
                    }
                    break;
                case "Status":
                    List<int> needRepair = ship.Where(x => x <= healthCapacity * 0.2).ToList();
                    Console.WriteLine($"{needRepair.Count} sections need repair.");
                    break;
                case "Retire":
                    Console.WriteLine($"Pirate ship status: {ship.Sum()}");
                    Console.WriteLine($"Warship status: {warShip.Sum()}");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}