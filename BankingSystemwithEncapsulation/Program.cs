using BankingSystemwithEncapsulation.Models;
using System;

namespace BankingSystemWithEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //new BankAccount instance
            BankAccount myAccount = new BankAccount("John Doe", "1234567890", 500.00m);

            myAccount.DisplayAccountInfo();

            Console.WriteLine();

            // Deposit money into the account
            myAccount.Deposit(150.00m);
            Console.WriteLine($"Balance after deposit: {myAccount.GetBalance()}");

            Console.WriteLine(); 

            // Try withdrawing money from the account
            bool success = myAccount.Withdraw(200.00m);
            if (success)
            {
                Console.WriteLine($"Balance after withdrawal: {myAccount.GetBalance()}");
            }

            Console.WriteLine(); 

            // Try withdrawing more money than the account holds
            success = myAccount.Withdraw(1000.00m);
            if (!success)
            {
                Console.WriteLine($"Balance after failed withdrawal: {myAccount.GetBalance()}");
            }

            // Final account information
            myAccount.DisplayAccountInfo();
        }
    }
}