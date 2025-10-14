
public class Program
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split(",");
        Dictionary<int, double> accounts = new Dictionary<int, double>();
        foreach (var item in input)
        {
            
            string[] accountInfo= item.Split("-");
            int id = int.Parse(accountInfo[0]);
            double balance = double.Parse(accountInfo[1]);
            accounts.Add(id, balance);
            if (accounts.ContainsKey(id))
            {

            }
            
        }
    }
}

