using System;

namespace P01_AddNUnit
{
    public class Program
    {
        public static void Main()
        {
            BankAccount account = new BankAccount(100);

            account.Deposit(100);
            account.Withdraw(-50);

            Console.WriteLine(account.Amount);
        }
    }
}
