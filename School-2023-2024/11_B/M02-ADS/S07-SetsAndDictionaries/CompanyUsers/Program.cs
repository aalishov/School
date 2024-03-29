namespace CompanyUsers
{
    public class Program
    {
        static void Main()
        {
            SortedDictionary<string, HashSet<string>> companies = new SortedDictionary<string, HashSet<string>>();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split("->").ToArray();
                if (cmd[0] == "End")
                {
                    break;
                }
                if (!companies.ContainsKey(cmd[0]))
                {
                    companies.Add(cmd[0], new HashSet<string>() { cmd[1] });
                }
                else
                {
                    companies[cmd[0]].Add(cmd[1]);
                }
            }
            foreach (var company in companies) 
            {
                Console.WriteLine(company.Key);
                foreach (var item in company.Value)
                {
                    Console.WriteLine($"--{item} ");
                }
            }
        }
    }
}
