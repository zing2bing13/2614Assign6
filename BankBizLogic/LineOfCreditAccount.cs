using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from class BankAccount.  Represents a Line of credit account object.
    public class LineOfCreditAccount : BankAccount
    {
        private decimal creditLimit;

        public LineOfCreditAccount(decimal openAmount, decimal creditAmount)
            : base(openAmount)
        {
            creditLimit = creditAmount;
        }

        // Returns the credit limit of the account.
        public decimal CreditLimit
        {
            get { return creditLimit; }
        }

        // Checks to see if the account has sufficient funds, including
        // the credit limit.
        public override bool HasSufficientFunds(decimal amount)
        {
            return base.Balance + creditLimit >= amount;
        }

        // Override the default ToString method.
        public override string ToString()
        {
            return "Line of credit " + base.AccountNumber.ToString();
        }
    }
}
