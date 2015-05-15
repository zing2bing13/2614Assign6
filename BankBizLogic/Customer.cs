using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Represents a customer object with bank accounts and transaction history.
    public class Customer
    {
        private BankAccountCollection accounts;
        private TransactionCollection transactionHistory;

        public Customer(BankAccountCollection accounts)
        {
            this.accounts = accounts;
            transactionHistory = new TransactionCollection();
        }

        // Gets the collection of accounts the customer has.
        public BankAccountCollection Accounts
        {
            get { return accounts; }
        }

        // Gets the transaction history of the customer.
        public TransactionCollection TransactionHistory
        {
            get { return transactionHistory; }
        }
    }
}
