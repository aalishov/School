using System;


public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount(5, 50m);

        Console.WriteLine(account);

        Person person = new Person("Ivan", 20);
        Person person1 = new Person("Ivan", 5);
        Console.WriteLine(person);
    }
}

