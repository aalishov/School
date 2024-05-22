using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_MoneyTransactions
{
    public class BankAccount
    {
        public BankAccount(int number, double balance)
        {
            Number = number;
            Balance = balance;
        }
        public int Number { get; set; }
        public double Balance { get; set; }
        public double Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount can't be negative!");
            }
            return Balance += amount;
        }
        public double Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount can't be negative!");
            }
            if (Balance < amount)
            {
                throw new InvalidOperationException("Insufficient balance!");
            }
            return Balance -= amount;
        }
    }
}
