namespace P06_BorderControl
{
    public class Program
    {
        private static List<ICitizen> citizens = new List<ICitizen>();
        public static void Main()
        {
            CreateCitizens();

            PrintFakeId();
        }

        private static void PrintFakeId()
        {
            string fakeId = Console.ReadLine();

            foreach (var citizen in citizens)
            {
                if (citizen.Id.EndsWith(fakeId))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }

        private static void CreateCitizens()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];

                ICitizen citizen = null;
                if (input.Length == 3)
                {
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    citizen = new Person(id, name, age);
                }
                else if (input.Length == 2)
                {
                    string id = input[1];
                    citizen = new Robot(id, name);
                }
                else { break; }
                citizens.Add(citizen);
            }
        }
    }
}