using System;
using System.Collections.Generic;
using System.Text;


public class BankAccount
{
    private int id;
    private decimal balance;

    public BankAccount(int id, decimal balance)
    {
        this.Id = id;
        this.Balance = balance;
    }

    public int Id
    {
        get { return id; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Invalid id!");
            }
            id = value;
        }
    }


    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Balance must be positive!");
            }
            balance = value;
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount<=0)
        {
            throw new ArgumentException("Deposit amount must be positive!");
        }
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdraw amount must be positive!");
        }
        if (amount>this.Balance)
        {
            throw new InvalidOperationException("Insuficient balance!");
        }
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account id: {this.Id}, balance: {this.Balance} ";
    }

}


