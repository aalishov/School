public class Program
{
    public static void Main()
    {
        House house = new House(4);
        List<Person> people = new List<Person>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");
            if (input[0] == "END") { break; }
            string name = input[0];
            int age = int.Parse(input[1]);
            string town = input[2];
            people.Add(new Person(name, age, town));
            house.Add(new Person(name, age, town));
        }

        int personIndex = int.Parse(Console.ReadLine()) - 1;

        Person person = people[personIndex];

        int countOfMatches = 0;

        foreach (Person person2 in people) {
            if (person.CompareTo(person2)==0)
            {
                countOfMatches++;
            }
        }

        if (countOfMatches>1)
        {
            Console.WriteLine($"{countOfMatches} {people.Count-countOfMatches} {people.Count}");
        }
        else
        {
            Console.WriteLine("No matches");
        }

        foreach (var p in house)
        {
            Console.WriteLine(p.Name);
        }
    }

}
