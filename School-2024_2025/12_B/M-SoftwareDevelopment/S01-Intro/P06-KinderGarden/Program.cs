public class Program
{
    public static void Main()
    {
        string path = "../../../data.txt";

        string[] fileContent = File.ReadAllLines(path);

        KinderGarden kinderGarden = new KinderGarden();

        foreach (string line in fileContent)
        {
            try
            {
                string[] info = line.Split(" ");

                string cmd = info[0];

                if (cmd == "enrollment")
                {
                    string firstName = info[1];
                    string lastName = info[2];
                    string id = info[3];
                    int age = int.Parse(info[4]);
                    string parentName = info[5];
                    string parentGSM = info[6];

                    Kid kid = new Kid(firstName, lastName, id, age, parentName, parentGSM);
                    Console.WriteLine(kinderGarden.EnrollKid(kid));
                }
                else if (cmd == "information")
                {
                    string group = info[1];
                    Console.WriteLine(kinderGarden.GroupInfo(group));
                }
                else if (cmd == "unsubscribe")
                {
                    string id = info[1];
                    Console.WriteLine(kinderGarden.ReleaseKid(id));
                }
                else if (cmd=="END")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"{cmd} - invalid command.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine("Have a nice day!");
    }
}

