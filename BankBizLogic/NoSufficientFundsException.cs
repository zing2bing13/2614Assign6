using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from the Exception class.  Represents a No Sufficient Funds exception.
    public class NoSufficientFundsException : Exception
    {
        private BankAccount account;
        private decimal withdrawalAmount;

        public NoSufficientFundsException(BankAccount account, decimal amount)
            : base("There are insufficient funds for this transaction.")
        {
            this.account = account;
            withdrawalAmount = amount;
        }

        // Returns the account
        public BankAccount Account
        {
            get
            {
                return account;
            }
        }

        // Returns the amount to be withdrawn.
        public decimal WithdrawalAmount
        {
            get
            {
                return withdrawalAmount;
            }
        }
    }
}
