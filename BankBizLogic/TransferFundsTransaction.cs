using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Inherits from class Transaction.  Represents a Transfer Funds Transaction.
    public class TransferFundsTransaction : Transaction
    {
        private BankAccount fromAccount;
        private BankAccount toAccount;

        public TransferFundsTransaction(BankAccount fromAcct, BankAccount toAcct, decimal amount)
            : base(amount)
        {
            fromAccount = fromAcct;
            toAccount = toAcct;
        }

        // Returns the details of the transaction.
        public override string Details
        {
            get
            {
                return string.Format("{0}\t From account {1}\r\n\t To account {2}\r\n\t Amount: {3:C}\r\n\r\n", 
                    base.Summary, fromAccount.AccountNumber, toAccount.AccountNumber, base.Amount);
            }
        }

        // Returns the type of transaction.
        public override string TransactionType
        {
            get
            {
                return "Transfer Funds";
            }
        }

        // Performs the steps necessary for transferring funds from one account to another.
        public override void DoTransaction()
        {
            if (fromAccount.Active)
            {
                if (toAccount.Active)
                {
                    if (fromAccount == toAccount)
                    {
                        throw new TransferFundsException("From account and To account cannot be the same.");
                    }
                    else
                    {
                        if (base.Amount <= 0M)
                        {
                            throw new InvalidTransactionAmtException();
                        }

                        if (fromAccount.HasSufficientFunds(base.Amount))
                        {
                            this.Status = TransactionStatus.Complete;
                            fromAccount.Debit(base.Amount);
                            toAccount.Credit(base.Amount);
                        }
                        else
                        {
                            throw new NoSufficientFundsException(fromAccount, base.Amount);
                        }
                    }
                }
                else
                {
                    throw new AccountInactiveException(toAccount);
                }
            }
            else
            {
                throw new AccountInactiveException(fromAccount);
            }
        }

        // Not implemented for assignment.
        public override void Process()
        {
        }
    }
}
