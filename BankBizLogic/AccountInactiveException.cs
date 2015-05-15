using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    public class AccountInactiveException : Exception
    {
        BankAccount account;

        public AccountInactiveException(BankAccount account)
            : base("Account is not active.  Cannot use this account.")
        {
            this.account = account;
        }

        // Retrives the account not active.
        public BankAccount Account
        {
            get
            {
                return account;
            }
        }

    }
}
