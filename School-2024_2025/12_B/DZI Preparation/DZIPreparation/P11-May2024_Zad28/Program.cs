public class Program
{

    static void Main()
    {
        try
        {
            KinderGarden garden = new KinderGarden();

            string[] lines = File.ReadAllLines("data.txt");

            foreach (string line in lines)
            {
                try
                {
                    string[] cmd = line.Split(" ");

                    if (cmd[0] == "enrollment")
                    {
                        Kid kid = new Kid(cmd[1], cmd[2], cmd[3], int.Parse(cmd[4]), cmd[4], cmd[5]);
                        Console.WriteLine(garden.EnrollKid(kid));
                    }
                    else if (cmd[0] == "unsubscribe")
                    {
                        Console.WriteLine(garden.ReleaseKid(cmd[1]));
                    }
                    else if (cmd[0] == "information")
                    {
                        Console.WriteLine(garden.GroupInfo(cmd[1] + " group"));
                    }
                    else if (cmd[0] == "END")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{cmd[0]} - invalid command.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(new string('*',20));
            garden.Info();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Have a nice day!");
        }


    }
}
