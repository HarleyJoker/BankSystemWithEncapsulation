using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystemwithEncapsulation.Models
{
    public class BankAccount
    {
        private decimal balance;
        private readonly string accountHolder;
        private  readonly string accountNumber;

        public BankAccount(string accountHolder, string accountNumber, decimal initialBalance)
        {
            this.accountHolder = accountHolder;
            this.accountNumber = accountNumber;
            balance = initialBalance > 0 ? initialBalance : 0;
        }


        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} has been deposited.");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"{amount} has been withdrawn.");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
                return false;
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Current Balance: {balance}");
        }
    }
}
