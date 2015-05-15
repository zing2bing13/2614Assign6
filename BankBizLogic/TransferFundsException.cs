using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from class Exception.  Represents an Transfer Funds Exception and 
    // accepts a string as the error message.
    public class TransferFundsException : Exception
    {
        public TransferFundsException(string message)
            : base(message)
        {

        }
    }
}
