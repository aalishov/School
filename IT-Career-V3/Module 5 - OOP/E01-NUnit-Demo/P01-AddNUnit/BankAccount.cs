
using System;

namespace P01_AddNUnit
{
    public class BankAccount
    {
        private decimal amount;

        public BankAccount(decimal initialBalance)
        {
            this.Amount = initialBalance;
        }
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Value must be positive!");
                }
                this.amount = value;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Value must be positive!");
            }
            this.Amount += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount<0)
            {
                throw new ArgumentException("Value must be positive!");
            }
            this.Amount -= amount;
        }
    }
}