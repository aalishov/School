using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    private string accountNumber;
    private string ownerName;
    private decimal accountBalance;

    public string AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }
    
    public string OwnerName
    {
        get { return ownerName; }
        set { ownerName = value; }
    }

    public decimal AccountBalance
    {
        get { return accountBalance; }
        set { accountBalance = value; }
    }

    public void MakeDeposit(decimal deposit)
    {
        AccountBalance += deposit;
        Console.WriteLine($"Account balance: {AccountBalance}");
    }
    public void MakeWithdraw(decimal withdraw)
    {
        if (AccountBalance >= withdraw)
        {
            AccountBalance -= withdraw;
            Console.WriteLine($"Withdrawn funds: {withdraw}. Funds available on the account: {AccountBalance}");
        }
        else
        {
            Console.WriteLine("Non-Sufficient Funds");
        }
    }
}
