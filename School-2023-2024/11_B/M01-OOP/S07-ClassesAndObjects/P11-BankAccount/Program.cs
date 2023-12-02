
using P11_BankAccount;

public class Program
{
    public static void Main()
    {

        BankAccount account = CreateBankAccount();

        while (true)
        {
            Console.Write("Enter command: ");
            string[] input = Console.ReadLine().Split(" ");
            string cmd = input[0];

            switch (cmd)
            {
                case "Deposit":
                    account.MakeDeposit(decimal.Parse(input[1]));
                    break;
                case "Withdrawal":
                    account.MakeWithdrawal(decimal.Parse(input[1]));
                    break;
                case "End":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command!");
                    break;
            }
        }
    }

    private static BankAccount CreateBankAccount()
    {
        Console.Write("Enter owner info: ");
        string[] ownerInfo = Console.ReadLine().Split(" ");

        string number = ownerInfo[0];
        string name = $"{ownerInfo[1]} {ownerInfo[2]}";
        decimal balance = decimal.Parse(ownerInfo[3]);

        BankAccount account = new BankAccount()
        {
            AccountNumber = number,
            OwnerName = name,
            AccountBalance = balance
        };

        return account;
    }
}
