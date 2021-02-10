using System;
using System.Collections.Generic;
using System.Text;

namespace P01_PersonWithBankAccounts
{
    public class BankAccount
    {
        public BankAccount(int id, decimal balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        public int Id { get; set; }

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount<0)
            {
                throw new ArgumentException("Deposit amount must be positive!");
            }
            this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Withdraw amount must be positive!");
            }
            if (this.Balance<amount)
            {
                throw new ArgumentException("Insufficient amount!");
            }
            this.Balance -= amount;
        }
    }
}
