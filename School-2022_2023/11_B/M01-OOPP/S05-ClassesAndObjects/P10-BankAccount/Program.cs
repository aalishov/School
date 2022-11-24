using System;

public class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        BankAccount ba1 = new BankAccount()
        {
            AccountBalance = decimal.Parse(input[3]),
            OwnerName = input[1] + " " + input[2],
            AccountNumber = input[0],
        };
        while (true)
        {
            input = Console.ReadLine().Split(' ');
            switch (input[0])
            {
                case "End":
                    Environment.Exit(0);
                    break;
                case "Deposit":
                    ba1.MakeDeposit(decimal.Parse(input[1]));
                    break;
                case "Withdrawal":
                    ba1.MakeWithdraw(decimal.Parse(input[1]));
                    break;
                default:
                //    Console.WriteLine("Invalid command");
                    break;
            }
        }
    }
}
