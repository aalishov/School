

public class Program
{
    public static void Main()
    {
        Dictionary<string, SortedSet<string>> companies = new Dictionary<string, SortedSet<string>>();
        while (true)
        {
            string[] info = Console.ReadLine().Split(" -> ").ToArray();
            if (info[0] == "End")
            {
                break;
            }
            string nameCompany = info[0];
            string nameEmployee = info[1];
            if (companies.ContainsKey(nameCompany))
            {
                companies[nameCompany].Add(nameEmployee);
            }
            else
            {
                companies.Add(nameCompany, new SortedSet<string>() { nameEmployee });
            }
        }
        foreach (var company in companies)
        {
            Console.WriteLine($"{company.Key}");
            foreach (var employeeName in company.Value)
            {
                Console.WriteLine($"-- {employeeName}");
            }
        }
    }

}


