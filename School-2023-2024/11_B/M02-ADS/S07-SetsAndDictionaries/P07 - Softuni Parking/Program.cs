namespace P07___Softuni_Parking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> registrations = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {   
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "register" )
                {
                    if (!registrations.ContainsKey(input[1]))
                    {
                        registrations.Add(input[1], input[2]);
                        Console.WriteLine($"{input[1]} registered {input[2]} succesfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {input[2]}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (registrations.ContainsKey(input[1]))
                    {
                        registrations.Remove(input[1]);
                        Console.WriteLine($"{input[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                }
            }
            foreach (var item in registrations)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
