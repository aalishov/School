public class Program
{
    public static void Main()
    {
        string name=Console.ReadLine();
        int year=int.Parse(Console.ReadLine());
        Rally rally= new Rally(name, year);

        while (true)
        {
            Console.WriteLine("[a]dd [v]iew [q]uit");
            string cmd= Console.ReadLine();
            switch (cmd)
            {
                case "a":
                    Console.Write("Pilot name: ");
                    string pilotName=Console.ReadLine();
                    Console.Write("Age: ");
                    int pilotAge = int.Parse(Console.ReadLine());
                    Console.Write("Category (A|B|C): ");
                    string category = Console.ReadLine();
                    Console.Write("Car model: ");
                    string brand = Console.ReadLine();
                    Console.Write("Car power (hp): ");
                    int hp = int.Parse(Console.ReadLine());
                    rally.Add(new Pilot(pilotName,pilotAge,new Car(brand,hp),category));
                    break;
                case "v":
                    Console.WriteLine(rally.ToString());
                    break;
                case "q":
                    Environment.Exit(0);
                    break;
            }
        }

    }
}