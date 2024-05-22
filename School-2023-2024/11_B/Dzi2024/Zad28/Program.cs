public class Program
{
    private static KinderGarden garden = new KinderGarden();
    public static void Main()
    {
        string path = "data.txt";

        string[] input = File.ReadAllLines(path);

        foreach (string line in input)
        {
            try {
                string[] info = line.Split(" ");
                string cmd = info[0];
                string result = string.Empty;
                switch (cmd)
                {
                    case "enrollment":
                        result = garden.EnrollKid(new Kid(info[1], info[2], info[3], int.Parse(info[4]), info[5], info[6]));
                        break;
                    case "information":
                        result = garden.GroupInfo(info[1]);
                        break;
                    case "unsubscribe":
                        result = garden.ReleaseKid(info[1]);
                        break;
                    case "END":
                        Console.WriteLine("Have a nice day!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"{cmd} - invalid command.");
                        break;

                }
                Console.WriteLine(result);
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
