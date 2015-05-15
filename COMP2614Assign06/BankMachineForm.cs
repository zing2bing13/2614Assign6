//                                               Possible  Actual
// Assignment Six Criteria                           Mark    Mark
// --------------------------------------------------------------
// Form Design                                        12       12
// Follows GUI design principles taught 
//  in the course (dialogs, controls, etc.)
//  does not have to be exactly same as sample (8)
// Has the same forms as the sample and each form
//  performs the same operations (4)
// --------------------------------------------------------------
//
//  Yes, all looks good
//
//
// Business Layer                                      12      12 
// Contained in a separate class library DLL (1)
// Design is appropriate (similar to or based on 
//  class diagram in handout – inheritance is used 
//  for Account and Transaction classes). (10)
// Never performs UI (for instance, a message box) (1)
// -------------------------------------------------------------- 
//  
//  Yes
//
//
// UI Layer                                             6       6
// Uses business classes for business rule validation
//  and handles exceptions.
// Implements non-business validation (empty fields,
//  non-numeric input)
// Error Provider implementation
// Inter-form communication follows best practices
// --------------------------------------------------------------
//
//  Yes
//
//
// Program Functionality                               15      15
// Program has one customer with three accounts
//  not all Savings, not all Line of Credit (1)
// Deposits – creates D. transaction in Pending 
//  state for 30 seconds, then credits account (4)
// Withdrawals – creates W. transaction Complete
//  state and debits account (2)
// Transfer funds – creates TF transaction and
//  modifies the two accounts correctly (3)
// Balance Inquiries – displays correct balance
//  for any account (2)
// Transaction History – shows all transactions
//  either in summary or detail view (3)
// --------------------------------------------------------------
//
//  All functions as required
//
//
// Coding style: follows coding standards for course;   3       3
//  commented; easy to read
// --------------------------------------------------------------
//
//  Yes
//
// --------------------------------------------------------------
// Total:                                              48      48
//
//
//


/******************************************************************
 * Name:  Stephen Vanderende
 * Title:  Assignment 6
 * Date:  11/11/2012
 * Class:  COMP 2614
 *****************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMP2614Assign06.UI;
using BankBizLogic;

namespace COMP2614Assign06
{
    public partial class BankMachineForm : Form
    {
        private Customer customer;

        public BankMachineForm()
        {
            InitializeComponent();
            BankAccountCollection accounts = new BankAccountCollection();
            accounts.Add(new SavingsAccount(0M));
            accounts.Add(new SavingsAccount(0M));
            accounts.Add(new LineOfCreditAccount(0M, 10000M));

            customer = new Customer(accounts);
        }

        // Deposit money into an account.
        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            DepositDialog dlg = new DepositDialog(customer);
            dlg.ShowDialog();
            dlg.Dispose();
        }

        // Withdraw money from an account.
        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawDialog dlg = new WithdrawDialog(customer);
            dlg.ShowDialog();
            dlg.Dispose();
        }

        // Show the Account Balances.
        private void buttonAccountBalance_Click(object sender, EventArgs e)
        {
            AccountBalanceDialog dlg = new AccountBalanceDialog(customer.Accounts);
            dlg.ShowDialog();
            dlg.Dispose();
        }

        // Transfer funds from one account to another.
        private void buttonTransferFunds_Click(object sender, EventArgs e)
        {
            TransferFundsDialog dlg = new TransferFundsDialog(customer);
            dlg.ShowDialog();
            dlg.Dispose();
        }

        // Show the customer's transaction history.
        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            TransactionHistoryDialog dlg = new TransactionHistoryDialog(customer.TransactionHistory);
            dlg.ShowDialog();
            dlg.Dispose();
        }

        // Timer ticks every 5 seconds and calls the process pending transactions method
        // from the Transaction History class.
        private void timerTransactions_Tick(object sender, EventArgs e)
        {
            customer.TransactionHistory.ProcessPendingTransactions();
        }
    }
}
