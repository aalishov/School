using P06_MoneyTransactions;

public class Program
{
    public static void Main()
    {
        List<BankAccount> bankAccounts = new List<BankAccount>();
        string[] accInfo = Console.ReadLine().Split(",");
        foreach (var acc in accInfo)
        {
            string[] info = acc.Split("-");
            int num = int.Parse(info[0]);
            double balance = double.Parse(info[1]);
            BankAccount bankAccount = new BankAccount(num, balance);
            bankAccounts.Add(bankAccount);
        }
        while (true)
        {
            try
            {
                string[] cmd = Console.ReadLine().Split(" ");
                if (cmd[0] == "Deposit")
                {
                    int bankNum = int.Parse(cmd[1]);
                    double amount = double.Parse(cmd[2]);
                    double result = bankAccounts.FirstOrDefault(x => x.Number == bankNum).Deposit(amount);
                    Console.WriteLine($"Account {bankNum} has new balance: {result}");
                }
                else if (cmd[0] == "Withdraw")
                {
                    int bankNum = int.Parse(cmd[1]);
                    double amount = double.Parse(cmd[2]);
                    double result = bankAccounts.FirstOrDefault(x => x.Number == bankNum).Withdraw(amount);
                    Console.WriteLine($"Account {bankNum} has new balance: {result}");
                }
                else if (cmd[0] == "End")
                {
                    Environment.Exit(0);
                }
                else
                {
                    throw new InvalidOperationException("Invalid command!");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Invalid account!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Enter another command");
            }
        }
    }
}