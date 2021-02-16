using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation01
{
    class BankAccount
    {
        private double balance = 0;

        public void Deposit(double deposit)
        {
            balance += deposit;
        }
        public void Withdraw(double withdrawal)
        {
            balance -= withdrawal;
        }
        public double GetBalance()
        {
            return balance;
        }

    }
}
