using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_BankAccount
{
    public class BankAccount
    {
        private string accountNumber;
        private string ownerName;
        private decimal accountBalance;

        
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;
            }
        }
        public string OwnerName
        {
            get { return ownerName; }
            set
            {
                ownerName = value;
            }
        }
        public decimal AccountBalance
        {
            get { return accountBalance; }
            set
            {
                accountBalance = value;
            }
        }
        public void MakeDeposit(decimal amount)
        {
           AccountBalance += amount;
            Console.WriteLine($"Account balance: {AccountBalance}");
        }
        public void MakeWithdrawal(decimal amount)
        {
            if (AccountBalance > amount)
            {
                AccountBalance -= amount;
                Console.WriteLine($"Withdrawn funds: {amount}. Funds available on the account: {AccountBalance}");
            }
            else
            {
                Console.WriteLine($"Non-Sufficient Funds");
            }
        }
    }
}
