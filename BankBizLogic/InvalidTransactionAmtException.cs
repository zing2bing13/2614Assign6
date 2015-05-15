using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from Exception class.  Represents an Invalid transaction amount exception.
    public class InvalidTransactionAmtException : Exception
    {
        public InvalidTransactionAmtException()
            : base("Invalid transaction amount.  Amount must be greater than $0.00")
        {

        }
    }
}
