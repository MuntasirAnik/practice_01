using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_01
{
    class Transaction
    {
        public string accountNumber;
        public string customerName;
        private double balance;
        public bool Deposit(double amount)
        {
            balance = balance + amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            balance = balance - amount;

            return true;
        }

        public string GetInfo()
        {
            var message = customerName + ", your account number: " + accountNumber + " and its balance: " + balance;
            return message;
        }
    }
}
