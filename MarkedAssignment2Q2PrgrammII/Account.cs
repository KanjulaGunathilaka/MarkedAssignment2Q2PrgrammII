using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkedAssignment2Q2PrgrammII
{
    public class Account
    {
        private double balance;

        public Account(double initialBalance = 0)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. Current balance: {balance:C}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. Current balance: {balance:C}");
        }

        public double InquireBalance()
        {
            return balance;
        }

        public void ComputeInterest(double rate)
        {
            double interest = balance * rate / 100;
            balance += interest;
            Console.WriteLine($"Interest added: {interest:C}. Current balance: {balance:C}");
        }
    }
}
