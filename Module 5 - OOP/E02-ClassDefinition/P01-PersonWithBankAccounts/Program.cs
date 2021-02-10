namespace P01_PersonWithBankAccounts
{
    using System;
    public class Program
    {
        public static void Main()
        {
            //Person person = new Person("Pesho",12);
            //Person person1 = new Person("Pesho 1", 20);
            //Person person2 = new Person("Pesho 2", 21);
            //person.Grow();
            //Console.WriteLine(Person.Count);
            //Console.WriteLine(Person.AverageAge);

            //BankAccount account = new BankAccount(1, 50);
            //BankAccount account1 = new BankAccount(2, 100);

            //person.Accounts.Add(account);
            //person.Accounts.Add(account1);

            //Console.WriteLine(person.IntroduceYourself());
            //Console.WriteLine(person.GetBalance());
            //Console.WriteLine(person1.IntroduceYourself());
            //Console.WriteLine(person1.GetBalance());


            Person p1 = new Person("Ani", 16);
            Person p2 = new Person("Dani", 40);
            Person p3 = new Person("Pesho", 46);

            Family f = new Family();
            f.Members.Add(p2);
            f.Members.Add(p1);
            f.Members.Add(p3);

            Console.WriteLine(f.PrintFamilyAsc());
        }
    }
}
