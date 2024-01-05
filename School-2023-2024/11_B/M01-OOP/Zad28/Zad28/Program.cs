namespace Zad28
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter rally name: ");
            string name = Console.ReadLine();
            Console.Write("Enter rally year: ");
            int year = int.Parse(Console.ReadLine());

            Rally r = new Rally(name, year);

            while (true)
            {
                Console.WriteLine("[a]dd [v]iew [q]uit");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "a":
                        Console.Write("Pilot name: ");
                        string pilotName=Console.ReadLine(); 
                        Console.Write("Age: ");
                        int age = int.Parse(Console.ReadLine());
                        Console.Write("Category (A|B|C): ");
                        string category = Console.ReadLine();
                        Console.Write("Car model: ");
                        string model = Console.ReadLine();
                        Console.Write("Car power (hp): ");
                        int hp = int.Parse(Console.ReadLine());
                        r.AddPilot(new Pilot(pilotName, age, new Car(model, hp), category));
                        break;
                    case "v": Console.WriteLine(r); break;
                    case "q": Environment.Exit(0); break;
                }
            }
        }
    }
}