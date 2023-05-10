using System;
using System.Collections.Generic;

public class Program
{
    private static Dictionary<int, decimal> accounts = new Dictionary<int, decimal>();

    public static void Main()
    {
        CreateAccounts();

        while (true)
        {
            try
            {
                string[] input = Console.ReadLine().Split(' ');

                string cmd = input[0].ToLower();

                switch (cmd)
                {
                    case "end":
                        //PrintOutput();
                        Environment.Exit(0);
                        break;
                    case "deposit":
                        Deposit();
                        break;
                    case "withdraw":
                        Withdraw();
                        break;
                    default:
                        throw new InvalidOperationException("Invalid command!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        Console.WriteLine();
    }

    public static void Withdraw(int id, decimal amount)
    {
       
    }
    public static void Deposit()
    {
        throw new NotImplementedException("Deposit not implemented!");
    }
    private static void CreateAccounts()
    {
        string[] accountsInfo = Console.ReadLine().Split(',');

        foreach (string account in accountsInfo)
        {
            string[] accountInfo = account.Split("-");
            int id = int.Parse(accountInfo[0]);
            decimal balance = decimal.Parse(accountInfo[1]);

            if (!accounts.ContainsKey(id))
            {
                //accounts[id] = balance;
                accounts.Add(id, balance);
            }
        }
    }
}

