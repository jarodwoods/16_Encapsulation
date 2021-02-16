using System;

namespace Encapsulation01
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            myAccount.Deposit(1111.11);
            myAccount.Withdraw(11.11);
            Console.WriteLine(myAccount.GetBalance());
        }
    }
}
