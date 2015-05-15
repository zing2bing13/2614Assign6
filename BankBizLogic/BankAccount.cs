using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Represents a bank account object.
    public abstract class  BankAccount
    {
        private static int accountNumberHolder = 1001;
        private int accountNumber;
        private bool active;
        private decimal balance;

        public BankAccount(decimal amount)
        {
            accountNumber = accountNumberHolder;
            active = true;
            balance = amount;
            accountNumberHolder++;
        }

        // Gets the account number.
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        // Returns account active status.
        public bool Active
        {
            get { return active; }
        }

        // Gets the account balance.
        public decimal Balance
        {
            get { return balance; }
        }

        // Credits the account balance.
        public void Credit(decimal amount)
        {
            balance += amount;
        }

        // Debits the account balance.
        public void Debit(decimal amount)
        {
            balance -= amount;
        }

        // Checks whether the account has sufficient funds.
        public abstract bool HasSufficientFunds(decimal amount);
    }
}
