using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkedAssignment2Q2PrgrammII
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000, 2000);

            // Test deposit
            bank.Deposit(500, "checking");
            bank.Deposit(700, "savings");

            // Test withdraw
            bank.Withdraw(300, "checking");
            bank.Withdraw(1000, "savings");

            // Test transfer
            bank.Transfer(400, "checking", "savings");
            bank.Transfer(800, "savings", "checking");

            // Test print balances
            bank.PrintBalances();
        }
    }
}
