using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkedAssignment2Q2PrgrammII
{
    public class Bank
    {
        private Account checking;
        private Account savings;

        public Bank(double checkingInitialBalance = 0, double savingsInitialBalance = 0)
        {
            checking = new Account(checkingInitialBalance);
            savings = new Account(savingsInitialBalance);
        }

        public void Deposit(double amount, string account)
        {
            if (account.ToLower() == "checking")
            {
                checking.Deposit(amount);
            }
            else if (account.ToLower() == "savings")
            {
                savings.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Invalid account type.");
            }
        }

        public void Withdraw(double amount, string account)
        {
            if (account.ToLower() == "checking")
            {
                checking.Withdraw(amount);
            }
            else if (account.ToLower() == "savings")
            {
                savings.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Invalid account type.");
            }
        }

        public void Transfer(double amount, string fromAccount, string toAccount)
        {
            if (fromAccount.ToLower() == "checking" && toAccount.ToLower() == "savings")
            {
                double withdrawnAmount = checking.InquireBalance() < amount ? checking.InquireBalance() : amount;
                checking.Withdraw(withdrawnAmount);
                savings.Deposit(withdrawnAmount);
            }
            else if (fromAccount.ToLower() == "savings" && toAccount.ToLower() == "checking")
            {
                double withdrawnAmount = savings.InquireBalance() < amount ? savings.InquireBalance() : amount;
                savings.Withdraw(withdrawnAmount);
                checking.Deposit(withdrawnAmount);
            }
            else
            {
                Console.WriteLine("Invalid account types for transfer.");
            }
        }

        public void PrintBalances()
        {
            Console.WriteLine("Checking account balance: " + checking.InquireBalance());
            Console.WriteLine("Savings account balance: " + savings.InquireBalance());
        }
    }
}
