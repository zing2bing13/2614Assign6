using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from class Transaction.  Represents a Withdrawal Transaction.
    public class WithdrawalTransaction : Transaction
    {
        private BankAccount account;

        public WithdrawalTransaction(BankAccount account, decimal amount)
            : base(amount)
        {
            this.account = account;
        }

        // Returns a string containing details of the withdrawal transaction.
        public override string Details
        {
            get
            {
                return string.Format("{0}\t Account: {1}\r\n\t Amount: {2:C}\r\n\r\n", base.Summary, account.AccountNumber, base.Amount);
            }
        }

        // Returns a string containing the type of the transaction.
        public override string TransactionType
        {
            get
            {
                return "Withdrawal";
            }
        }

        // Checks to see if the account is active and that the amount entered is greater then 0.
        // Checks to see the account has sufficient funds and then completes the transaction.
        public override void DoTransaction()
        {
            if (account.Active)
            {
                if (base.Amount <= 0M)
                {
                    throw new InvalidTransactionAmtException();
                }

                if (account.HasSufficientFunds(base.Amount))
                {
                    this.Status = TransactionStatus.Complete;
                    account.Debit(base.Amount);
                }

                else
                {
                    throw new NoSufficientFundsException(account, base.Amount);
                }
            }

            else
            {
                throw new AccountInactiveException(account);
            }
        }

        // Not implemented for assignment.
        public override void Process()
        {
        }
    }
}
