namespace P01_DemoBank
{
    using System;
    public class BankAccount
    {
        public int Id { get; set; }

        public decimal Balance { get; set; }

        public BankAccount(int id, decimal balance)
        {
            this.Id = id;
            this.Balance = balance;
        }

        public void Deposit(decimal amount)
        {            
            if (amount<=0)
            {
                throw new ArgumentException("Invalid amount!");
            }
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Invalid amount!");
            }
            if (amount>this.Balance)
            {
                throw new InvalidOperationException("Insuficient balance!");
            }
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Id: {this.Id} => balance: {this.Balance:f3}";
        }
    }
}
