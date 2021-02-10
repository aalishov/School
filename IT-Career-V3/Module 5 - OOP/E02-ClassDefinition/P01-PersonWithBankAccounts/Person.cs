using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_PersonWithBankAccounts
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            Count++;
            AgeSum += age;
            this.accounts = new List<BankAccount>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid name length!");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }
        public static int Count { get;private set; }
        private static int AgeSum { get;  set; }
        public static string AverageAge { get=>$"Persons average age: {(decimal)AgeSum/Count}";  }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { this.accounts = value; }
        }

        public string IntroduceYourself()
        {
            return $"Здравейте! Аз съм {this.Name} и съм на {this.Age} години!";
        }

        public string GetBalance()
        {
            return $"{this.Name}'s balance: {this.accounts.Sum(x => x.Balance)}";
        }
        public void Grow()
        {
            this.Age++;
        }

    }
}
