public class Program
{
    public static void Main()
    {
        SortedDictionary<string, HashSet<string>> companies = new SortedDictionary<string, HashSet<string>>();

        while (true)
        {
            string[] input = Console.ReadLine().Split("->");
            if (input[0] == "End")
            {
                break;
            }

            string company = input[0];
            string employee = input[1];

            if (companies.ContainsKey(company))
            {
                companies[company].Add(employee);
            }
            else
            {
                companies.Add(company, new HashSet<string>() { employee });
            }
        }

        foreach (var company in companies)
        {
            Console.WriteLine(company.Key);
            foreach (var employee in company.Value)
            {
                Console.WriteLine($"-- {employee}");
            }
        }
    }
}