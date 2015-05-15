using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankBizLogic
{
    // Wrapper class for a collection of Transactions.
    public class TransactionCollection : List<Transaction>
    {
        // Checks if any transactions are pending and calls their process method.
        public void ProcessPendingTransactions()
        {
            foreach (Transaction transaction in this)
            {
                if (transaction.Status == TransactionStatus.Pending) //// good
                {
                    transaction.Process();
                }
            }
        }
    }
}
