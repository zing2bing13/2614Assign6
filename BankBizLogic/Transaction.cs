using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Enumeration of valid Transaction Status.
    public enum TransactionStatus
    {
        Pending,
        Complete
    }

    // Represents the base class for all transaction objects.
    public abstract class Transaction
    {
        private decimal amount;
        private DateTime date;
        private TransactionStatus status;

        public Transaction(decimal amount)
        {
            this.amount = amount;
            date = DateTime.Now;
            status = TransactionStatus.Pending;
        }

        // Returns the amount of the transaction.
        public decimal Amount
        {
            get { return amount; }
        }

        // Returns the date the transaction was made.
        public DateTime Date
        {
            get { return date; }
        }

        // Gets and sets the status of the transaction.
        public TransactionStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        // Returns a string of transaction as a summary.
        public string Summary
        {
            get
            {
                if (status == TransactionStatus.Pending)
                {
                    return string.Format("{0:yyyy-MM-dd} {1} (Pending) \r\n", date, TransactionType);
                }
                else
                {
                    return string.Format("{0:yyyy-MM-dd} {1} \r\n", date, TransactionType);
                }
            }
        }

        // Returns a string of the transaction with details.
        public abstract string Details{ get; }

        // Returns a string of the type of transaction.
        public abstract string TransactionType{ get; }

        // Does the actual transaction.
        public abstract void DoTransaction();

        // Processes the transaction if it is pending.
        public abstract void Process();
    }
}
