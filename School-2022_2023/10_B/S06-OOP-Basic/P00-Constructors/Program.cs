using System;


public class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1, "John", 1000);
        BankAccount account2 = new BankAccount(2,"Jane");

        Console.WriteLine(account);
        account.Deposit(50);
        Console.WriteLine(account);
    }
}

