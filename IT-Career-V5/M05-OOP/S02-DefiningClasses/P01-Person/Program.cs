using System;

public class Program
{
    public static void Main()
    {
        BankAccount account1 = new BankAccount() { Id = 1, Balance = 20 };
        BankAccount account2 = new BankAccount() { Id = 2, Balance = 80 };
        BankAccount account3 = new BankAccount() { Id = 3, Balance = 900 };


        Person person = new Person() { Name = "Ivan", Age = 12 };
        person.AddBankAccount(account1);
        person.AddBankAccount(account2);
        person.AddBankAccount(account3);
        Console.WriteLine(person.GetBalance());
    }
}

