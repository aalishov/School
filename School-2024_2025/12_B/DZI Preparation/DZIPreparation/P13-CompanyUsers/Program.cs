public class Program
{
    public static void Main()
    {
        SortedDictionary<string, SortedSet<string>> companies = new SortedDictionary<string, SortedSet<string>>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(" -> ");

            if (input[0] == "End") { break; }

            string companyName = input[0];
            string employeeName = input[1];

            if (companies.ContainsKey(companyName))
            {
                companies[companyName].Add(employeeName);
            }
            else
            {
                companies.Add(companyName, new SortedSet<string>() { employeeName });
            }
        }

        foreach (var company in companies)
        {
            Console.WriteLine($"{company.Key}");
            foreach (var employee in company.Value)
            {
                Console.WriteLine($"-- {employee}");
            }
        }
    }
}