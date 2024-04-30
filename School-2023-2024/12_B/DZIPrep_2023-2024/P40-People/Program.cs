namespace P40_People
{
    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Human> people = new List<Human>();
           

            for (int i = 0; i < n; i++)
            {
                Console.Write("First name: ");
                string firstName = Console.ReadLine();
                Console.Write("Last name: ");
                string lastName = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write($"Your choice[s - student] , [w - worker]:");
                string cmd = Console.ReadLine();
                if (cmd == "w")
                {
                    Console.Write("Wage: ");
                    double wage = double.Parse(Console.ReadLine());
                    Console.Write("Hours worked: ");
                    int hoursWorked = int.Parse(Console.ReadLine());
                    people.Add(new Worker(firstName, lastName, age, wage, hoursWorked));
                }
                else
                {
                    Console.Write("Grade: ");
                    double grade = double.Parse(Console.ReadLine());
                    people.Add(new Student(firstName,lastName,age,grade));
                }

            }
            for (int i = people.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(people[i]);
            }
        }
    }
}
