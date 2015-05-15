using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from the transaction class and represents a deposit transaction.
    public class DepositTransaction : Transaction
    {
        private const int DELAY = 30;
        private BankAccount account;

        public DepositTransaction(BankAccount account, decimal amount)
            : base(amount)
        {
            this.account = account;
        }

        // Returns a string with details of the transaction.
        public override string Details
        {
            get
            {
                return string.Format("{0}\t Account: {1}\r\n\t Amount: {2:C}\r\n\r\n", base.Summary, account.AccountNumber, base.Amount);
            }
        }

        // Returns a string with the type of transaction.
        public override string TransactionType
        {
            get
            {
                return "Deposit";
            }
        }

        // Performs the steps required to do the transaction.
        // Checks to see if an account is active and if the amount entered is
        // greater then 0.00.  Status of the transaction is already set
        // to pending by the base class Transaction.
        public override void DoTransaction()
        {
            if (account.Active)
            {
                if (base.Amount <= 0M)
                {
                    throw new InvalidTransactionAmtException();
                }
            }
            else
            {
                throw new AccountInactiveException(account);
            }
        }

        // Checks to see if 30 seconds have passed since the transaction was first
        // made.  If so, the bank account is credited with the amount deposited.
        public override void Process()
        {
            TimeSpan timeDifference = DateTime.Now - base.Date;

            if (timeDifference.Seconds >= DELAY)
            {
                account.Credit(base.Amount);
                base.Status = TransactionStatus.Complete;
            }
        }
    }
}
