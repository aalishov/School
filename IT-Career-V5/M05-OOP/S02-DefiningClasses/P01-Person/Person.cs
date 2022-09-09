using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Person
{
    private string name;
    private readonly List<BankAccount> bankAccounts = new List<BankAccount>();

    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }
    public int Age { get; set; }
    public IReadOnlyCollection<BankAccount> BankAccounts
    {
        get { return this.bankAccounts.AsReadOnly(); }
    }
    public void AddBankAccount(BankAccount account)
    {
        this.bankAccounts.Add(account);
    }
    public string GetBalance()
    {
        return $"Name: {this.Name}, balance: {this.bankAccounts.Sum(x => x.Balance):c2}";
    }
    public string IntroduceYourself()
    {
        return string.Format("Здравейте! Аз съм {0} и съм на {1} години.", this.Name, this.Age);
    }
}

