public class Program
{
    public static void Main()
    {
        Run();
    }

    private static void Run()
    {
        try
        {
            Rally rally = CreateRally();

            while (true)
            {
                Console.WriteLine("[a]dd [v]iew [d]elete [q]uit");
                string cmd = Console.ReadLine();
                if (cmd == "q")
                {
                    break;
                }
                else if (cmd == "a")
                {
                    CreatePilot(rally);
                }
                else if (cmd == "v")
                {
                    Console.WriteLine(rally.ToString());
                }
                else if (cmd == "d")
                {
                    DeletePilot(rally);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong");
        }
    }

    private static Rally CreateRally()
    {
        string rallyName = Console.ReadLine();
        int rallyYear = int.Parse(Console.ReadLine());
        Rally rally = new Rally(rallyName, rallyYear);
        return rally;
    }

    private static void DeletePilot(Rally rally)
    {
        Console.Write("Delete pilot (name): ");
        string name = Console.ReadLine();
        if (rally.RemovePilot(name))
        {
            Console.WriteLine("Removed succesfully!");
        }
        else
        {
            Console.WriteLine("Pilot not found");
        }
    }

    private static void CreatePilot(Rally rally)
    {
        Console.Write("Pilot name: ");
        string name = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Category (A|B|C): ");
        string category = Console.ReadLine();
        Console.Write("Car model: ");
        string brand = Console.ReadLine();
        Console.Write("Car power (hp): ");
        int hp = int.Parse(Console.ReadLine());
        Car car = new Car(brand, hp);
        Pilot pilot = new Pilot(name, age, car, category);

        rally.AddPilot(pilot);
    }
}

