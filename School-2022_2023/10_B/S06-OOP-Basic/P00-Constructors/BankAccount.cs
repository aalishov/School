using System;
using System.Collections.Generic;
using System.Text;


public class BankAccount
{
    //Fields
    private double balance;
    private string owner;


    // Constructors
    public BankAccount(int id, string owner)
    {
        Id = id;
        Owner = owner;
        Balance = 0;
    }
    public BankAccount(int id, string owner, double balance) : this(id, owner)
    {
        Balance = balance;
    }


    //Properties
    public int Id { get; private set; }

    public string Owner
    {
        get { return owner; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
            {
                throw new ArgumentException("Invalid owner!");
            }
            owner = value;
        }
    }

    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid balance!");
            }
            balance = value;
        }
    }

    //Methods
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    public override string ToString()
    {
        return $"{Owner} : {Balance:f2}";
    }
}

