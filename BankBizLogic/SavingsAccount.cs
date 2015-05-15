using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from class BankAccount.  Represents a Savings Account object.
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal amount)
            : base(amount)
        {
        }

        // Checks to see if the account has sufficient funds.
        public override bool HasSufficientFunds(decimal amount)
        {
            return base.Balance >= amount;
        }

        // Overrides the default ToString method.
        public override string ToString()
        {
            return "Savings " + base.AccountNumber.ToString();
        }
    }
}
